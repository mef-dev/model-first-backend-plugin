using System;
using System.Collections.Generic;
using System.Linq;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
using UCP.Common.Plugin.Services;
using Bss.Entities.Extensions;
using System.Diagnostics;

namespace Bss.Entities
{
    [DocIgnore]
    public class ViewCaller<TGetWebReq,
        TGetCallReq,
        TGetCallResp,
        TGetWebResp,
        TProcSet,
        TWebSet> : IViewCaller
            where TGetWebReq : BaseEntity
            where TGetCallReq : class, ICallProcedureModel<TGetCallReq>
            where TGetCallResp : class
            where TGetWebResp : class, IModifiedTag
            where TProcSet : class
            where TWebSet : BaseEntity, IPropertyIndexer
    {
        public virtual IPagedList<IModifiedTag, BaseEntity> Get(Filter filter, 
            string viewName, 
            IApiContext context)
        {
            TGetWebReq getWebModel = null;

            //���� ������ �� ������
            //�������� ���� �������� �� TGetWebReq
            if (!string.IsNullOrEmpty(filter.filter))
            {
                try
                {
                    getWebModel = ConvertService.Convert<TGetWebReq>(filter.filter);
                }
                catch (Exception e)
                {
                    throw new CommonPlatformException($"Error while parse  filter", e);
                }
            }

            //����������� �� ���. ������ ������ �� Filter
            //��� ������� ����� �� Filter
            getWebModel = (getWebModel != null) ?
                MappingService.MapperWN.Map<Filter, TGetWebReq>(filter, getWebModel) :
                MappingService.Mapper.Map<TGetWebReq>(filter);

            getWebModel?.Clean();

            BasePlugin.CorrectWebModelBase(getWebModel, context);

            TGetCallReq argModel = MappingService.Map<TGetCallReq>(getWebModel);

            //CorrectCallGetProcModel(ref argModel);

            TGetCallResp argModelRes = null;
            IList<TWebSet> resultSet = null;

            using (var db = new DB(context))
            {
                resultSet = db.Procedures.CallRequestResponseQuery<TGetCallReq, TGetCallResp, TWebSet>(argModel, out argModelRes, (o) =>
                {
                    if (o == null)
                        return o;
                    //dynamic -> TProcSet
                    TProcSet procRes = MappingService.Map<TProcSet>(o);
                    //TProcSet -> TWebSet
                    var res = MappingService.MapWN<TWebSet>(procRes);
                    return (TWebSet)res.Clean();
                }).ToList();
            }

            TGetWebResp result = MappingService.MapWN<TGetWebResp>(argModelRes);
            (result as BaseEntity)?.Clean();
            long? total = null;
            try
            {
                var first = resultSet.FirstOrDefault();
                if (first != null)
                {
                    total = (long?)first.SafeGet<int>("Total");
                }
            }
            catch(Exception exc)
            {
                Debug.WriteLine($"Error while try to get total : {exc}");
            }

            if (!total.HasValue)
                total = resultSet?.Count();

            /*
            if (!total.HasValue)
                total = 0;
            */

            return new PagedList<IModifiedTag, BaseEntity>(resultSet.AsQueryable(), filter.PageIndex, filter.PageSize)
            {
                Result = result as IModifiedTag,
                TotalCount = total.GetValueOrDefault()
            };
        }
    }
}
