using System;
using System.Composition;
using System.Linq;
using System.Reflection;
using FluentSiren.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Schema;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Models.Config;
using UCP.Common.Plugin.Services;
using Microsoft.Extensions.Logging;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
     [DocIgnore]
     public class EntityPlugin<TReq,
        TSetReq, 
        TSetResp, 
        TResp, 
        TGetWebReq, 
        TGetCallReq,
        TGetCallResp,
        TGetWebResp,
        TProcSet,
        TWebSet> : BasePlugin, IBackendPlugin,
            ITypedPageListOperation<TGetWebResp,TWebSet>,
            ITypedBackendPlugin<TReq>
            where TReq : BaseEntity
            where TSetReq : class, ICallProcedureModel<TSetReq>
            where TSetResp :class, ICallProcedureModel<TSetResp>
            where TResp : BaseEntity
            where TGetWebReq : BaseEntity
            where TGetCallReq : class, ICallProcedureModel<TGetCallReq>
            where TGetCallResp : class
            where TGetWebResp :class, IModifiedTag
            where TProcSet : class
            where TWebSet : BaseEntity
    {
        #region [Fields]
        public const string EntityNameAttribute = "EntityName";
        protected Lazy<Type> _selfType = null;
        //protected static int defaultPostTimeout = 180;
        //protected static int defaultPutTimeout = 180;
        protected IApiContext _apiContext = null;
        protected PluginExportMetadata exportMetadata = null;
        protected string packageName = string.Empty;
        protected string entityName { get; set; } = null;
        #endregion

        public EntityPlugin():base()
        {
            packageName = this.GetType().Assembly.GetName().Name;
            this._selfType = new Lazy<Type>(() => this.GetType());

            ReadExportAttributes();

            if (string.IsNullOrEmpty(this.entityName))
            {
                throw new ArgumentNullException($"{this.GetType().Name} :: Empty mandatory plugin attribute : Entity");
            }
        }

        public virtual void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public virtual IPagedList<IModifiedTag, BaseEntity> Get(Filter filter, string view = null)
        {
            CheckApiContext();
            ReadConfig(GetCfgName());
            CheckRuntimeState();

            string targetView = string.IsNullOrEmpty(view) ? "default" : view.ToLower();

            if (EntityService.BindersDictionary.TryGetValue(this.entityName.ToLower(), out EntityBindContainer ebc))
            {
                if (ebc.GetViewBindContainers.TryGetValue(targetView, out CallGetProcedureBindContainer cgpbc))
                {
                    var viewCaller = ModelFactory.CreateViewCaller(cgpbc);
                    if (viewCaller != null)
                    {
                        return viewCaller.Get(filter, targetView, this._apiContext);
                    }
                    else
                        throw new CommonPlatformException($"View caller for entity {this.entityName} with view '{targetView}' is null");
                }
                else
                    throw new CommonPlatformException($"Can not find view '{targetView}' for entity '{this.entityName}'");
            }
            else
                throw new CommonPlatformException($"Can not find entity metada for entity {this.entityName}");
        }

        public virtual IPagedList<TGetWebResp, TWebSet> GetTyped(Filter filter)
        {
            CheckApiContext();
            //CheckForGetFeatures();
            IPagedList<IModifiedTag,BaseEntity> pl = this.Get(filter);

            return new PagedList<TGetWebResp, TWebSet>()
            {
                Lang = pl.Lang,
                PageIndex = pl.PageIndex,
                PageSize = pl.PageSize,
                TotalCount = pl.TotalCount,
                TotalPages = pl.TotalPages,
                Data = pl.Data.Cast<TWebSet>().ToList(),
                Result = pl.Result as TGetWebResp
            };
        }

        public virtual JSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public virtual Entity HateousSchema(BaseEntity baseEntity)
        {
            throw new NotImplementedException();
        }

        public virtual BaseEntity Post(string lang,
            BaseEntity entity,
            string parent = null)
        {
            CheckApiContext();
            LogPostInformation(lang, entity, parent);

            TReq tr = ResolveEntityModel<TReq>(entity);

            return Post(lang, tr, parent);
        }

        public virtual BaseEntity Put(string id, string lang, BaseEntity entity)
        {
            CheckApiContext();
            ReadConfig(GetCfgName());
            CheckRuntimeState();

            TReq tr = ResolveEntityModel<TReq>(entity);
            /*
             * ������������� �� 27.07.19
             * ������������ ������ null �� ����
             */
            CorrectWebModel(tr, null, null);


            if (!string.IsNullOrEmpty(lang))
                tr.Lang = lang;

            tr.Id = id;

            TSetReq argModel = MappingService.Map<TSetReq>(tr);
            //CorrectCallSetProcModel(ref argModel);
            TSetResp argModelRes = null;

            using (var db = new DB(ConnectionStrings.WriteOrDefaultConnection()))
            {
                db.PreSqlCommand = this.PreSqlCommand;
                db.SqlExecParameters = this.SqlExecParameters;
                argModelRes = db.Procedures.CallRequestResponse<TSetReq, TSetResp>(argModel, DefaultPutTimeout);
            }

            TResp result = MappingService.MapWN<TResp>(argModelRes);
            result.Clean();
            return result;
        }

        public virtual void SetApiContext(IApiContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context")
                {
                    Source = $"{this.entityName} plugin"
                };

            if (!ApiContextManager.Instance.ValidateContext(context, this))
                throw new CommonPlatformException("�ontext failed validation")
                {
                    Source = $"{this.entityName} plugin"
                };

            this._apiContext = context;
        }

        public virtual void SetServiceConfigurations(PluginConfig pluginConfig)
        {
            // stub
        }

        protected override void ReadConfig(string cfgFileName)
        {
            this._apiContext?.Log?.LogInformation($"|{this.GetHashCode()}|Start read config {cfgFileName}");
            try
            {
                IConfigurationRoot cfgRoot = ApiContextHelper.GetConfiguration(_apiContext, this);
                if (cfgRoot != null)
                {
                    base.ReadConfig(cfgRoot);
                    return;
                }

                if (string.IsNullOrEmpty(cfgFileName))
                {
                    cfgRoot = _apiContext.DataBag.Configuration as IConfigurationRoot;
                    if (cfgRoot != null)
                        base.ReadConfig(cfgRoot);
                }
                else
                    base.ReadConfig(cfgFileName);
            }
            catch (Exception e)
            {
                this._apiContext?.Log?.LogInformation(e, $"|{this.GetHashCode()}|Error while read {cfgFileName}");
            }
            finally
            {
                this._apiContext?.Log?.LogInformation($"|{this.GetHashCode()}|Finish read config {cfgFileName}");
            }
        }

        protected virtual void CorrectWebModel(TReq webModel, string entityName, string parent)
        {
            CorrectWebModelBase(webModel,this._apiContext, entityName, parent);
        }

        protected virtual void CorrectWebModel(TGetWebReq webModel, string entityName, string parent)
        {
            CorrectWebModelBase(webModel, this._apiContext, entityName, parent);
        }

        protected T ResolveEntityModel<T>(BaseEntity baseEntity) where T:BaseEntity
        {
            if (baseEntity == null)
                throw new CommonPlatformException($"Invalid model: null");

            T result = baseEntity as T;

            if (result == null)
                throw new CommonPlatformException($"Invalid model.'{baseEntity.GetType().Name}' not a type or descendant type of '{typeof(TReq).Name}'")
                {
                    
                };

            return result;
        }

        public virtual BaseEntity PostEntityAction(string lang, BaseEntity entity, string action, string parent = null)
        {
            LogPostActionInformation(lang, entity, action, parent);
            if (false == exportMetadata?.Actions?.Contains(action, StringComparer.InvariantCultureIgnoreCase))
            {
                throw new CommonPlatformException($"Actions list does not contain definitions for the action '{action}'");
            }

            if (EntityService.BindersDictionary.TryGetValue(this.entityName.ToLower(), out EntityBindContainer ebc))
            {
                if (ebc.ActionBindContainers.TryGetValue(action.ToLower(), out CallProcedureBindContainer cpbc))
                {
                    var actionCaller = ModelFactory.CreateActionCaller(cpbc);
                    if (actionCaller != null)
                    {
                        CheckApiContext();
                        ReadConfig(GetCfgName());
                        CheckRuntimeState();
                        if (!string.IsNullOrEmpty(lang))
                            entity.Lang = lang;
                        
                        BasePlugin.CorrectWebModelBase(entity, this._apiContext, this.entityName, parent);
                        entity.Clean();

                        return actionCaller.PostEntityAction(ConnectionStrings.WriteOrDefaultConnection(),
                                    entity,
                                    DefaultPostTimeout,
                                    this._apiContext.Log);
                    }
                    else
                        throw new CommonPlatformException($"Action caller for entity {this.entityName} with action '{action}' is null");
                }
                else
                    throw new CommonPlatformException($"Can not find action metada for entity {this.entityName} with action '{action}'");
            }
            else
                throw new CommonPlatformException($"Can not find entity metada for entity {this.entityName}");
        }

        protected void CheckRuntimeState()
        {
            if (this.RuntimeState != RuntimeState.Run)
                throw new ServiceUnavailableException($"{_selfType.Value.Name}({entityName}/{exportMetadata?.EntityName}):: Service unavailable")
                {
                    ReasonCode = (int)ReasonCodes.PreventiveStop,
                    EstimatedDownTime = this.IdleTime,
                    ReasonDescription = this.RuntimeStateDescription
                };
        }

        protected string GetCfgName()
        {
            if (string.IsNullOrEmpty(_apiContext?.AssemblyLocation))
                return null;
            return System.IO.Path.Combine(_apiContext?.AssemblyLocation, $"{this.GetType().Assembly.GetName().Name}.settings.json");
        }

        protected void CheckApiContext()
        {
            if (this._apiContext == null)
                throw new ArgumentNullException("Api context")
                {
                    Source = $"{this.entityName} plugin"
                };
        }

        [Obsolete]
        protected TOut PostEntityActionGen<TIn, TInCall, TOutCall, TOut>(string lang, BaseEntity entity, string action, string parent = null) where TIn:BaseEntity, IPropertyIndexer, new()
            where TOut:BaseEntity
            where TInCall: class, ICallProcedureModel<TInCall>
            where TOutCall: class, ICallProcedureModel<TOutCall>
        {
            TIn rra = entity as TIn ??
                new TIn()
                {
                    Id = entity?.Id,
                    ParentId = entity?.ParentId,
                    Format = entity?.Format,
                    Lang = entity?.Lang,
                    Name = entity?.Name,
                };

            if (!string.IsNullOrEmpty(lang))
                rra.Lang = lang;

            if (string.IsNullOrEmpty((string)rra["EntityName"]))
            {
                rra["EntityName"] = this.entityName;
            }

            BasePlugin.CorrectWebModelBase(rra, this._apiContext, this.entityName, parent);
            //CorrectWebModelBase(rra);

            rra.Clean();

            var binder = new CallSetModelCaller<TIn,
                TInCall,
                TOutCall,
                TOut>();


            TOut result = binder.CallSetViaWebModel(ConnectionStrings.WriteOrDefaultConnection(),
                rra,
                DefaultPostTimeout);

            return result; // new VoidResponse();

        }

        public PluginConfig GetServiceConfiguration()
        {
            throw new NotImplementedException();
        }

        public void SetServiceConfiguration(PluginConfig config)
        {
            throw new NotImplementedException();
        }

        protected void ReadExportAttributes()
        {
            var expAttrib = this.GetType().GetCustomAttribute<ExportAttribute>();
            var custAttribs = this.GetType().GetCustomAttributes<ExportMetadataAttribute>();

            var entityNameAttrib = custAttribs.FirstOrDefault(ema => EntityNameAttribute.Equals(ema.Name, StringComparison.InvariantCultureIgnoreCase));

            entityName = (entityNameAttrib?.Value as string) ?? expAttrib?.ContractName;

            var mdAttributes = this._selfType.Value
                .GetCustomAttributes<ExportMetadataAttribute>()
                .ToArray();

            if (mdAttributes != null)
            {
                exportMetadata = new PluginExportMetadata();

                foreach (ExportMetadataAttribute ema in mdAttributes)
                {
                    if (string.Equals(ema.Name, nameof(PluginExportMetadata.Actions), StringComparison.InvariantCultureIgnoreCase))
                        exportMetadata.Actions = (string[])ema.Value;
                    else
                    if (string.Equals(ema.Name, nameof(PluginExportMetadata.Description), StringComparison.InvariantCultureIgnoreCase))
                        exportMetadata.Description = (string)ema.Value;
                    else
                    if (string.Equals(ema.Name, nameof(PluginExportMetadata.EntityName), StringComparison.InvariantCultureIgnoreCase))
                        exportMetadata.EntityName = (string)ema.Value;
                }
            }
        }

        public BaseEntity Post(string lang, TReq entity, string parent = null)
        {
            CheckApiContext();
            LogPostInformation(lang, entity, parent);

            TReq tr = entity;

            if (!EntitiesSubordinates.ValidRelation(parent?.ToLower(), this.entityName.ToLower()))
            {
                throw new CommonPlatformException($"Invalid relation : {parent}/{this.entityName}")
                {
                    StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest
                };
            }
            //throw new Exception($"Invalid relation : {parent}/{this.entityName}");

            ReadConfig(GetCfgName());
            CheckRuntimeState();

            /*
             * ������������� �� 27.07.19
             * ������������ ������ null �� ����
             */
            CorrectWebModel(tr, null, parent);

            if (!string.IsNullOrEmpty(lang))
                tr.Lang = lang;
            _apiContext?.Log.LogInformation($"Start mapping {tr.GetType().Name} -> {typeof(TSetReq).Name}");
            TSetReq argModel = MappingService.Map<TSetReq>(tr);
            _apiContext?.Log.LogInformation($"Stop mapping {tr.GetType().Name} -> {typeof(TSetReq).Name}");
            InspectDirectMapping(tr, argModel);
            //CorrectCallSetProcModel(ref argModel);
            TSetResp argModelRes = null;

            using (var db = new DB(ConnectionStrings.WriteOrDefaultConnection(), this._apiContext?.Log))
            {
                db.PreSqlCommand = this.PreSqlCommand;
                db.SqlExecParameters = this.SqlExecParameters;
                try
                {
                    _apiContext.Log.LogInformation($"Start call {argModel.StoredProcedureName()} ...");
                    argModelRes = db.Procedures.CallRequestResponse<TSetReq, TSetResp>(argModel, DefaultPostTimeout);
                }
                finally
                {
                    _apiContext.Log.LogInformation($"Call of {argModel.StoredProcedureName()} finished");
                }
            }

            TResp result = MappingService.MapWN<TResp>(argModelRes);

            result?.Clean();

            return result;
        }

        public BaseEntity Put(string id, string lang, TReq entity)
        {
            throw new NotImplementedException();
        }

        public BaseEntity PostEntityAction(string lang, TReq entity, string action, string parent = null)
        {
            throw new NotImplementedException();
        }
        /*
        public IPagedList<IModifiedTag, BaseEntity> Get(Filter filter)
        {
            throw new NotImplementedException();
        }
        */
        #region [Logs]
        internal virtual void LogPostInformation(string lang,
            BaseEntity entity,
            string parent = null)
        {
            this._apiContext?.Log?.LogInformation($"({this.GetHashCode()}){_selfType.Value.Name}({entityName}/{exportMetadata?.EntityName})::Post: Start with parent/id '{parent}'/'{entity?.Id}'");
        }

        internal virtual void LogPostActionInformation(string lang,
            BaseEntity entity,
            string action,
            string parent = null)
        {
            this._apiContext?.Log?.LogInformation($"({this.GetHashCode()}){_selfType.Value.Name}({entityName}/{exportMetadata?.EntityName})::Post: Start with parent/action/id/ '{parent}'/'{action}'/'{entity?.Id}'");
        }

        internal virtual void InspectDirectMapping(TReq webModel, TSetReq callModel)
        {

        }
        #endregion
    }
}
