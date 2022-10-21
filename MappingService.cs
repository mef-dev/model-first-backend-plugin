
////////////////////////////////////////////////////////
// Прокси класс Маппинга WEB-Моделей и вызова процедур
// Сгенерирован из файла C:\Users\keiqsa\Projects\model-first-backend-plugin\models.xml
// Время генерации 10/21/2022 12:54:29 PM
////////////////////////////////////////////////////////

using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UCP.Common.Plugin;
using AutoMapper;
using AutoMapper.Configuration;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
	[DocIgnore]
	public static partial class MappingService
	{
        #region [Private]
        private static Lazy<MapperConfigurationExpression> mapperConfigurationExpressionHolder = new Lazy<MapperConfigurationExpression>(() =>
            GetMapperConfigurationExpression());
        private static Lazy<MapperConfigurationExpression> mapperConfigurationExpressionWNHolder = new Lazy<MapperConfigurationExpression>(() =>
            GetMapperConfigurationWNExpression());
        private static Lazy<MapperConfigurationExpression> mapperConfigurationExpressionDefaultHolder = new Lazy<MapperConfigurationExpression>(() =>
            GetMapperConfigurationDefaultExpression());
        private static Lazy<MapperConfiguration> mapperConfigurationHolder = new Lazy<MapperConfiguration>(() =>
            GetMapperConfiguration(0));
        private static Lazy<MapperConfiguration> mapperConfigurationWNHolder = new Lazy<MapperConfiguration>(() =>
            GetMapperConfiguration(1));
        private static Lazy<MapperConfiguration> mapperConfigurationDefaultHolder = new Lazy<MapperConfiguration>(() =>
            GetMapperConfiguration(2));

        private static Lazy<IMapper> mapperHolder = new Lazy<IMapper>(() =>
            mapperConfigurationHolder.Value.CreateMapper());
        private static Lazy<IMapper> mapperWNHolder = new Lazy<IMapper>(() =>
            mapperConfigurationWNHolder.Value.CreateMapper());
        private static Lazy<IMapper> mapperDefaultHolder = new Lazy<IMapper>(() =>
            mapperConfigurationDefaultHolder.Value.CreateMapper());
			/*
		private static Lazy<Natec.Entities.InsComparer> insComparer = 
			new Lazy<Natec.Entities.InsComparer>();
			*/
        #endregion

        #region [Properties]
		public static IMapper MapperDefault
		{
			get
			{
				return mapperDefaultHolder.Value;
			}
		}

		public static IMapper Mapper
		{
			get
			{
				return mapperHolder.Value;
			}
		}

        public static IMapper MapperWN
        {
            get
            {
                return mapperWNHolder.Value;
            }
        }

		public static MapperConfiguration Configuration
		{
			get
			{
				return mapperConfigurationHolder.Value;
			}
		}

        public static MapperConfiguration ConfigurationWN
        {
            get
            {
                return mapperConfigurationWNHolder.Value;
            }
        }

        public static MapperConfiguration ConfigurationDefault
        {
            get
            {
                return mapperConfigurationDefaultHolder.Value;
            }
        }

		public static MapperConfigurationExpression ConfigurationExpression
        {
            get
            {
                return mapperConfigurationExpressionHolder.Value;
            }
        }

        public static MapperConfigurationExpression ConfigurationWNExpression
        {
            get
            {
                return mapperConfigurationExpressionWNHolder.Value;
            }
        }

        public static MapperConfigurationExpression ConfigurationDefaultExpression
        {
            get
            {
                return mapperConfigurationExpressionDefaultHolder.Value;
            }
        }
        #endregion

        #region [Public]
		public static T Map<T>(object wm) where T:class
		{
			try
			{
				return Mapper.Map<T>(wm);
				//return (cfgType == 0)?Mapper.Map<T>(wm):MapperWN.Map<T>(wm);
			}
			catch(Exception e)
			{
				throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
			}
		}

		public static T MapWN<T>(object wm) where T:class
		{
			try
			{
				return MapperWN.Map<T>(wm);
			}
			catch(Exception e)
			{
				throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
			}
		}

		public static T MapDefault<T>(object wm) where T:class
		{
			try
			{
				return MapperDefault.Map<T>(wm);
			}
			catch(Exception e)
			{
				throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
			}
		}

        public static TOut Map<T, TOut>(T wm, TOut existsInstance) where T : class
        {
            try
            {
                return Mapper.Map<T, TOut>(wm, existsInstance);
            }
            catch (Exception e)
            {
                throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
            }
        }

        public static TOut MapWN<T, TOut>(T wm, TOut existsInstance) where T : class
        {
            try
            {
                return MapperWN.Map<T, TOut>(wm, existsInstance);
            }
            catch (Exception e)
            {
                throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
            }
        }

        public static TOut MapDefault<T, TOut>(T wm, TOut existsInstance) where T : class
        {
            try
            {
                return MapperDefault.Map<T, TOut>(wm, existsInstance);
            }
            catch (Exception e)
            {
                throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
            }
        }

        public static void ResetConfiguration(int cfgType)
        {
			/*
            mapperConfigurationHolder = new Lazy<MapperConfiguration>(() =>
                GetMapperConfiguration(cfgType));
				*/
        }

		public static MapperConfiguration GetMapperConfiguration(int cfgType)
		{
            MapperConfiguration result = null;
            if (cfgType == 0)
            {
                result = new MapperConfiguration(ConfigurationExpression);
            }
            else if (cfgType == 1)
            {
                result = new MapperConfiguration(ConfigurationWNExpression);
            }
			else
			{
				result = new MapperConfiguration(ConfigurationDefaultExpression);
			}

            result.CompileMappings();
			return result;
		}
        #endregion

		///////////////////////////////////////////////////////////////////////////
		/// Простая "дефолтная конфигруация"
		///////////////////////////////////////////////////////////////////////////
		public static MapperConfigurationExpression GetMapperConfigurationDefaultExpression()
		{
			throw new NotImplementedException();
		}

		////////////////////////////////////////////////////////////////
		// Конфигурация, где перезаписываются финальные значения вне зависимости от 
		// того, нул или не нул в модели - источнике
		////////////////////////////////////////////////////////////////
		public static MapperConfigurationExpression GetMapperConfigurationExpression()
		{
			MapperConfigurationExpression cfg = new MapperConfigurationExpression();
            #region [Accounts]
            #region [Accounts_Request_GET]->[GET_p_ucp_get_Accounts_Request]
			//********************** DIRECT:    WebModel[Accounts_Request_GET] -> CallModel[GET_p_ucp_get_Accounts_Request] *************************************
			cfg.CreateMap<Accounts_Request_GET, GET_p_ucp_get_Accounts_Request>()
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Acnt_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Acat_ID, opt => opt.MapFrom(src => src.CategoryID))
                .ForMember(dest => dest.Rgsc_ID, opt => opt.MapFrom(src => src.RegistrCatID))
                .ForMember(dest => dest.Accl_ID, opt => opt.MapFrom(src => src.ClassID))
                .ForMember(dest => dest.Actp_ID, opt => opt.MapFrom(src => src.TypeID))
                .ForMember(dest => dest.Aptp_ID, opt => opt.MapFrom(src => src.PayTypeID))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.CacheControlDate))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
                .ForMember(dest => dest.Dls_ID, opt => opt.MapFrom(src => src.Dls_ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
;
#endregion
            #region [GET_p_ucp_get_Accounts_Response->Accounts_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_Accounts_Response] -> WebModel Response(Accounts_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Accounts_Response, Accounts_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.CacheControlDate, opt => opt.MapFrom(src => src.IfModifiedSinceDate));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Accounts_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageIndex, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_Accounts_Response_OUTPUT] -> WebModel Response Output(Accounts_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_Accounts_Response_OUTPUT] -> WebModel Response Output(Accounts_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Accounts_Response_OUTPUT, Accounts_Response_GET_OUTPUT>()
                .ForMember(dest => dest.CurrencyCode, opt => opt.MapFrom(src => src.Currency))
                .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.CategoryID, opt => opt.MapFrom(src => src.acat_ID))
                .ForMember(dest => dest.RegistrCatID, opt => opt.MapFrom(src => src.rgsc_ID))
                .ForMember(dest => dest.ClassID, opt => opt.MapFrom(src => src.accl_ID))
                .ForMember(dest => dest.TypeID, opt => opt.MapFrom(src => src.actp_ID))
                .ForMember(dest => dest.PayTypeID, opt => opt.MapFrom(src => src.aptp_ID))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.acatd_Name))
                .ForMember(dest => dest.RegistrCatName, opt => opt.MapFrom(src => src.rgscd_Name))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.accld_Name))
                .ForMember(dest => dest.TypeName, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.PayTypeName, opt => opt.MapFrom(src => src.aptpd_Name))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.TotalCount, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.AccountID, opt => opt.MapFrom(src => src.Acnt_ID))
                .ForMember(dest => dest.abc_Amount, opt => opt.MapFrom(src => src.abc_Amount))
                .ForMember(dest => dest.abc_DateCharge, opt => opt.MapFrom(src => src.abc_DateCharge))
                .ForMember(dest => dest.acnt_CreateDate, opt => opt.MapFrom(src => src.acnt_CreateDate))
                .ForMember(dest => dest.acnt_ExternalID, opt => opt.MapFrom(src => src.acnt_ExternalID))
                .ForMember(dest => dest.acnt_ModifiedFrom, opt => opt.MapFrom(src => src.acnt_ModifiedFrom))
                .ForMember(dest => dest.acnt_Remark, opt => opt.MapFrom(src => src.acnt_Remark))
                .ForMember(dest => dest.adlsb_Code, opt => opt.MapFrom(src => src.adlsb_Code))
                .ForMember(dest => dest.dls_ID, opt => opt.MapFrom(src => src.dls_ID))
                .ForMember(dest => dest.dlsd_Name, opt => opt.MapFrom(src => src.dlsd_Name))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.TaxProfileEnable, opt => opt.MapFrom(src => src.TaxProfileEnable));
#endregion
            #region [Accounts_Request_SET]->[SET_p_ucp_set_Accounts_Request]
			//********************** DIRECT:    WebModel[Accounts_Request_SET] -> CallModel[SET_p_ucp_set_Accounts_Request] *************************************
			cfg.CreateMap<Accounts_Request_SET, SET_p_ucp_set_Accounts_Request>()
                .ForMember(dest => dest.Adlsb_Code, opt => opt.MapFrom(src => src.DeliverZone))
                .ForMember(dest => dest.Dls_ID, opt => opt.MapFrom(src => src.DeliveryID))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.CurrencyCode))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Acat_ID, opt => opt.MapFrom(src => src.CategoryID))
                .ForMember(dest => dest.Accl_ID, opt => opt.MapFrom(src => src.ClassID))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.Aptp_ID, opt => opt.MapFrom(src => src.PayTypeID))
                .ForMember(dest => dest.Rgsc_ID, opt => opt.MapFrom(src => src.RegistrCatID))
                .ForMember(dest => dest.Actp_ID, opt => opt.MapFrom(src => src.TypeID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.acnt_isAnonymous, opt => opt.MapFrom(src => src.IsAnonymous))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Acnt_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
;
#endregion
            #region  [SET_p_ucp_set_Accounts_Response->Accounts_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_Accounts_Response] -> WebModel[Accounts_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_Accounts_Response, Accounts_Response_SET>()
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Acnt_Number))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Acnt_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Accounts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Accounts_Request, GET_p_ucp_get_Accounts_Response>();
            cfg.CreateMap<SET_p_ucp_set_Accounts_Request, SET_p_ucp_set_Accounts_Response>();
            #endregion
            #region [Accounts_CustomerAccounts_Request_GET]->[GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request]
			//********************** DIRECT:    WebModel[Accounts_CustomerAccounts_Request_GET] -> CallModel[GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request] *************************************
			cfg.CreateMap<Accounts_CustomerAccounts_Request_GET, GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request>()
                .ForMember(dest => dest.isExternalSearch, opt => opt.MapFrom(src => src.isExternalSearch))
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.actp_ID, opt => opt.MapFrom(src => src.actp_ID))
                .ForMember(dest => dest.bll_Number, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageNumber))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System));
;
#endregion
            #region [GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response->Accounts_CustomerAccounts_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response] -> WebModel Response(Accounts_CustomerAccounts_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response, Accounts_CustomerAccounts_Response_GET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Accounts_CustomerAccounts_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response_OUTPUT] -> WebModel Response Output(Accounts_CustomerAccounts_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response_OUTPUT] -> WebModel Response Output(Accounts_CustomerAccounts_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response_OUTPUT, Accounts_CustomerAccounts_Response_GET_OUTPUT>()
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.actpd_Name, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
                .ForMember(dest => dest.extCount, opt => opt.MapFrom(src => src.extCount))
                .ForMember(dest => dest.isClosed, opt => opt.MapFrom(src => src.isClosed))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.IsSyncEnable, opt => opt.MapFrom(src => src.IsSyncEnable))
                .ForMember(dest => dest.msisdn, opt => opt.MapFrom(src => src.msisdn))
                .ForMember(dest => dest.ParentID, opt => opt.MapFrom(src => src.ParentID));
#endregion
            #region (Accounts/CustomerAccounts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request, GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response>();
            #endregion
            #endregion
            #region [AccountTaxes]
            #region [AccountTaxes_Request_SET]->[SET_p_ucp_set_AccountTaxes_Request]
			//********************** DIRECT:    WebModel[AccountTaxes_Request_SET] -> CallModel[SET_p_ucp_set_AccountTaxes_Request] *************************************
			cfg.CreateMap<AccountTaxes_Request_SET, SET_p_ucp_set_AccountTaxes_Request>()
                .ForMember(dest => dest.Enable, opt => opt.MapFrom(src => src.Enable))
                .ForMember(dest => dest.Txs_ID, opt => opt.MapFrom(src => src.TaxesID))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Acnt_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Actxb_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
;
#endregion
            #region  [SET_p_ucp_set_AccountTaxes_Response->AccountTaxes_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_AccountTaxes_Response] -> WebModel[AccountTaxes_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_AccountTaxes_Response, AccountTaxes_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Actxb_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (AccountTaxes)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_AccountTaxes_Request, SET_p_ucp_set_AccountTaxes_Response>();
            #endregion
            #endregion
            #region [Addresses]
            #region [Addresses_Request_SET]->[SET_p_ucp_set_TreeNodeAddresses_Request]
			//********************** DIRECT:    WebModel[Addresses_Request_SET] -> CallModel[SET_p_ucp_set_TreeNodeAddresses_Request] *************************************
			cfg.CreateMap<Addresses_Request_SET, SET_p_ucp_set_TreeNodeAddresses_Request>()
                .ForMember(dest => dest.Str_ID, opt => opt.MapFrom(src => src.StreetID))
                .ForMember(dest => dest.Zip_Name, opt => opt.MapFrom(src => src.ZipName))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.House_ID, opt => opt.MapFrom(src => src.HouseID))
                .ForMember(dest => dest.Appartment, opt => opt.MapFrom(src => src.Appartment))
                .ForMember(dest => dest.Cit_Name, opt => opt.MapFrom(src => src.CityName))
                .ForMember(dest => dest.ContEMail, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.ContFax, opt => opt.MapFrom(src => src.Fax))
                .ForMember(dest => dest.ContPhone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Corpus_Name, opt => opt.MapFrom(src => src.Corpus))
                .ForMember(dest => dest.Cou_Name, opt => opt.MapFrom(src => src.CountryName))
                .ForMember(dest => dest.Dstr_Name, opt => opt.MapFrom(src => src.DistictName))
                .ForMember(dest => dest.House_Name, opt => opt.MapFrom(src => src.HouseName))
                .ForMember(dest => dest.Prov_Name, opt => opt.MapFrom(src => src.ProvinceName))
                .ForMember(dest => dest.Str_Name, opt => opt.MapFrom(src => src.StreetName))
                .ForMember(dest => dest.TextConst, opt => opt.MapFrom(src => src.TextConst))
                .ForMember(dest => dest.Zip_ID, opt => opt.MapFrom(src => src.ZipID))
                .ForMember(dest => dest.Cit_ID, opt => opt.MapFrom(src => src.CityID))
                .ForMember(dest => dest.Prov_ID, opt => opt.MapFrom(src => src.ProvinceID))
                .ForMember(dest => dest.Dstr_ID, opt => opt.MapFrom(src => src.DistrictID))
                .ForMember(dest => dest.Cou_ID, opt => opt.MapFrom(src => src.CountyID))
                .ForMember(dest => dest.Adrt_ID, opt => opt.MapFrom(src => src.AddressTypeID))
                .ForMember(dest => dest.Cttp_ID, opt => opt.MapFrom(src => src.CityTypeID))
                .ForMember(dest => dest.Strt_ID, opt => opt.MapFrom(src => src.StreetTypeID))
                .ForMember(dest => dest.Adf_ID, opt => opt.MapFrom(src => src.AddressFormat))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Aadb_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
;
#endregion
            #region  [SET_p_ucp_set_TreeNodeAddresses_Response->Addresses_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_TreeNodeAddresses_Response] -> WebModel[Addresses_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_TreeNodeAddresses_Response, Addresses_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Aadb_ID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID));
#endregion
            #region (Addresses)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_TreeNodeAddresses_Request, SET_p_ucp_set_TreeNodeAddresses_Response>();
            #endregion
            #region [Addresses_Sync_Request_ACTION]->[ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request]
			//********************** DIRECT:    WebModel[Addresses_Sync_Request_ACTION] -> CallModel[ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request] *************************************
			cfg.CreateMap<Addresses_Sync_Request_ACTION, ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request>()
                .ForMember(dest => dest.DateEndSync, opt => opt.MapFrom(src => src.DateEndSync))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.wev_User, opt => opt.MapFrom(src => src.wev_User));
;
#endregion
            #region  [ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response->Addresses_Sync_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response] -> WebModel[Addresses_Sync_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response, Addresses_Sync_Response_ACTION>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Addresses/Sync)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request, ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response>();
            #endregion
            #endregion
            #region [Adjustments]
            #region [Adjustments_Request_SET]->[SET_p_ucp_set_AccountAdjustments_Request]
			//********************** DIRECT:    WebModel[Adjustments_Request_SET] -> CallModel[SET_p_ucp_set_AccountAdjustments_Request] *************************************
			cfg.CreateMap<Adjustments_Request_SET, SET_p_ucp_set_AccountAdjustments_Request>()
                .ForMember(dest => dest.Aadj_Abn_ID, opt => opt.MapFrom(src => src.TransferTo))
                .ForMember(dest => dest.Aadj_Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.Aadj_Annul, opt => opt.MapFrom(src => src.Annul))
                .ForMember(dest => dest.Aadj_bll_ID, opt => opt.MapFrom(src => src.BillID))
                .ForMember(dest => dest.Aadj_Date, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.Aadj_DocDate, opt => opt.MapFrom(src => src.DocDate))
                .ForMember(dest => dest.Aadj_DocNum, opt => opt.MapFrom(src => src.DocNum))
                .ForMember(dest => dest.Aadj_Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Aar_ID, opt => opt.MapFrom(src => src.ReasonID))
                .ForMember(dest => dest.Aat_ID, opt => opt.MapFrom(src => src.TypeID))
                .ForMember(dest => dest.Cpay_ID, opt => opt.MapFrom(src => src.PaymentID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Aadj_Aar_ID, opt => opt.MapFrom(src => src.TransferReasonID))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Sech_ID, opt => opt.MapFrom(src => src.ChargeID))
                .ForMember(dest => dest.Srg_ID, opt => opt.MapFrom(src => src.DetailID))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Aadj_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.aadj_ExternalID, opt => opt.MapFrom(src => src.aadj_ExternalID))
                .ForMember(dest => dest.dnm_id, opt => opt.MapFrom(src => src.dnm_id))
                .ForMember(dest => dest.dsc_id, opt => opt.MapFrom(src => src.dsc_id))
                .ForMember(dest => dest.dsv_id, opt => opt.MapFrom(src => src.dsv_id))
                .ForMember(dest => dest.Ext_ID, opt => opt.MapFrom(src => src.ExtentionID))
                .ForMember(dest => dest.NeedCheckPermission, opt => opt.MapFrom(src => src.NeedCheckPermission))
                .ForMember(dest => dest.NumberATS, opt => opt.MapFrom(src => src.NumberATS))
                .ForMember(dest => dest.pkt_id, opt => opt.MapFrom(src => src.pkt_ID))
                .ForMember(dest => dest.rpr_id, opt => opt.MapFrom(src => src.rpr_id))
                .ForMember(dest => dest.Srv_ID, opt => opt.MapFrom(src => src.ServiceID))
                .ForMember(dest => dest.ss_id, opt => opt.MapFrom(src => src.ss_id))
                .ForMember(dest => dest.Subscriber_ID, opt => opt.MapFrom(src => src.Subscriber_ID));
;
#endregion
            #region  [SET_p_ucp_set_AccountAdjustments_Response->Adjustments_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_AccountAdjustments_Response] -> WebModel[Adjustments_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_AccountAdjustments_Response, Adjustments_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Aadj_ID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Adjustments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_AccountAdjustments_Request, SET_p_ucp_set_AccountAdjustments_Response>();
            #endregion
            #endregion
            #region [Agreements]
            #region [Agreements_Request_SET]->[SET_p_ucp_set_SubscriberAgreements_Request]
			//********************** DIRECT:    WebModel[Agreements_Request_SET] -> CallModel[SET_p_ucp_set_SubscriberAgreements_Request] *************************************
			cfg.CreateMap<Agreements_Request_SET, SET_p_ucp_set_SubscriberAgreements_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.TasksJsonData, opt => opt.MapFrom(src => src.TasksJsonData))
                .ForMember(dest => dest.IsCheckBallance, opt => opt.MapFrom(src => src.IsCheckBallance))
                .ForMember(dest => dest.TemplateIDs, opt => opt.MapFrom(src => src.TemplateIDs))
                .ForMember(dest => dest.Rpr_ID, opt => opt.MapFrom(src => src.RepresentationID))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.Grt_ID, opt => opt.MapFrom(src => src.PlanGroupID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Agr_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Activate, opt => opt.MapFrom(src => src.Activate))
                .ForMember(dest => dest.Agr_ID_Old, opt => opt.MapFrom(src => src.Agr_ID_Old))
                .ForMember(dest => dest.Cancel, opt => opt.MapFrom(src => src.Cancel))
                .ForMember(dest => dest.Grt_ID_New, opt => opt.MapFrom(src => src.Grt_ID_New))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.Rtb_IDs, opt => opt.MapFrom(src => src.Rtb_IDs))
                .ForMember(dest => dest.Services, opt => opt.MapFrom(src => src.Services))
                .ForMember(dest => dest.TariffBegin, opt => opt.MapFrom(src => src.TariffBegin));
;
#endregion
            #region  [SET_p_ucp_set_SubscriberAgreements_Response->Agreements_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_SubscriberAgreements_Response] -> WebModel[Agreements_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_SubscriberAgreements_Response, Agreements_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Agr_ID))
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Agreements)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_SubscriberAgreements_Request, SET_p_ucp_set_SubscriberAgreements_Response>();
            #endregion
            #region [Agreements_ChangeTariffs_Request_ACTION]->[ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request]
			//********************** DIRECT:    WebModel[Agreements_ChangeTariffs_Request_ACTION] -> CallModel[ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request] *************************************
			cfg.CreateMap<Agreements_ChangeTariffs_Request_ACTION, ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request>()
                .ForMember(dest => dest.Activate, opt => opt.MapFrom(src => src.Activate))
                .ForMember(dest => dest.Cancel, opt => opt.MapFrom(src => src.Cancel))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IsCheckBallance, opt => opt.MapFrom(src => src.IsCheckBallance))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Agr_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Grt_ID, opt => opt.MapFrom(src => src.PlanGroupID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.TariffBegin, opt => opt.MapFrom(src => src.TariffBegin))
                .ForMember(dest => dest.TasksJsonData, opt => opt.MapFrom(src => src.TasksJsonData));
;
#endregion
            #region  [ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response->Agreements_ChangeTariffs_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response] -> WebModel[Agreements_ChangeTariffs_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response, Agreements_ChangeTariffs_Response_ACTION>()
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Agr_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Agreements/ChangeTariffs)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request, ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response>();
            #endregion
            #endregion
            #region [Associations]
            #region [Associations_Request_GET]->[GET_p_ucp_get_Associations_Request]
			//********************** DIRECT:    WebModel[Associations_Request_GET] -> CallModel[GET_p_ucp_get_Associations_Request] *************************************
			cfg.CreateMap<Associations_Request_GET, GET_p_ucp_get_Associations_Request>()
                .ForMember(dest => dest.mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.Ntw_ID, opt => opt.MapFrom(src => src.Ntw_ID))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageNumber))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.Rgsc_ID, opt => opt.MapFrom(src => src.Rgsc_ID))
                .ForMember(dest => dest.ShowBalances, opt => opt.MapFrom(src => src.ShowBalances))
                .ForMember(dest => dest.ShowEntities, opt => opt.MapFrom(src => src.ShowEntities))
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection))
                .ForMember(dest => dest.Srv_ID, opt => opt.MapFrom(src => src.Srv_ID))
                .ForMember(dest => dest.Srv_Name, opt => opt.MapFrom(src => src.Srv_Name))
                .ForMember(dest => dest.Sst_ID, opt => opt.MapFrom(src => src.Sst_ID))
                .ForMember(dest => dest.tnst_Code, opt => opt.MapFrom(src => src.tnst_Code))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.LastModifiedDate, opt => opt.MapFrom(src => src.LastModifiedDate))
                .ForMember(dest => dest.Cntr_Name, opt => opt.MapFrom(src => src.Cntr_Name))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.abn_ID_Boss, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.Acat_ID, opt => opt.MapFrom(src => src.Acat_ID))
                .ForMember(dest => dest.Accl_ID, opt => opt.MapFrom(src => src.Accl_ID))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Acnt_Number))
                .ForMember(dest => dest.Actp_ID, opt => opt.MapFrom(src => src.Actp_ID))
                .ForMember(dest => dest.Adlsb_Code, opt => opt.MapFrom(src => src.Adlsb_Code))
                .ForMember(dest => dest.Aptp_ID, opt => opt.MapFrom(src => src.Aptp_ID))
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.Bac_Number, opt => opt.MapFrom(src => src.Bac_Number))
                .ForMember(dest => dest.bll_Number, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.BossLastName, opt => opt.MapFrom(src => src.BossLastName))
                .ForMember(dest => dest.com_ID, opt => opt.MapFrom(src => src.com_ID))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.Dls_ID, opt => opt.MapFrom(src => src.Dls_ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.CacheControlDate))
                .ForMember(dest => dest.jsonFieldsName, opt => opt.MapFrom(src => src.jsonFieldsName))
                .ForMember(dest => dest.jsonFilter, opt => opt.MapFrom(src => src.jsonFilter))
                .ForMember(dest => dest.jsonFilterContain, opt => opt.MapFrom(src => src.jsonFilterContain))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Lng_ID, opt => opt.MapFrom(src => src.Lng_ID));
;
#endregion
            #region [GET_p_ucp_get_Associations_Response->Associations_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_Associations_Response] -> WebModel Response(Associations_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Associations_Response, Associations_Response_GET>()
                .ForMember(dest => dest.CacheControlDate, opt => opt.MapFrom(src => src.IfModifiedSinceDate))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Associations_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_Associations_Response_OUTPUT] -> WebModel Response Output(Associations_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_Associations_Response_OUTPUT] -> WebModel Response Output(Associations_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Associations_Response_OUTPUT, Associations_Response_GET_OUTPUT>()
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.ext_ID_count, opt => opt.MapFrom(src => src.ext_ID_count))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.acnt_ID_count, opt => opt.MapFrom(src => src.acnt_ID_count))
                .ForMember(dest => dest.acnt_IsPersonal, opt => opt.MapFrom(src => src.acnt_IsPersonal))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.actp_ID, opt => opt.MapFrom(src => src.actp_ID))
                .ForMember(dest => dest.actpd_Name, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
                .ForMember(dest => dest.aut_ID_count, opt => opt.MapFrom(src => src.aut_ID_count))
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.aut_NumberAts, opt => opt.MapFrom(src => src.aut_NumberAts))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
                .ForMember(dest => dest.cntr_ID_count, opt => opt.MapFrom(src => src.cntr_ID_count))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
                .ForMember(dest => dest.com_Id, opt => opt.MapFrom(src => src.com_Id))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
                .ForMember(dest => dest.isEditAllow, opt => opt.MapFrom(src => src.isEditAllow))
                .ForMember(dest => dest.isEditWorkPlace, opt => opt.MapFrom(src => src.isEditWorkPlace))
                .ForMember(dest => dest.lng_ID, opt => opt.MapFrom(src => src.lng_ID))
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
                .ForMember(dest => dest.Location_ID, opt => opt.MapFrom(src => src.Location_ID))
                .ForMember(dest => dest.ntw_ID, opt => opt.MapFrom(src => src.ntw_ID))
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.rptURL, opt => opt.MapFrom(src => src.rptURL))
                .ForMember(dest => dest.SubsCount, opt => opt.MapFrom(src => src.SubsCount))
                .ForMember(dest => dest.tnst_ExternalID, opt => opt.MapFrom(src => src.tnst_ExternalID))
                .ForMember(dest => dest.tnst_ID, opt => opt.MapFrom(src => src.tnst_ID))
                .ForMember(dest => dest.tnt_AccountMandatory, opt => opt.MapFrom(src => src.tnt_AccountMandatory))
                .ForMember(dest => dest.tnt_ID, opt => opt.MapFrom(src => src.tnt_ID))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.abn_Balance, opt => opt.MapFrom(src => src.abn_Balance))
                .ForMember(dest => dest.abn_CreateDate, opt => opt.MapFrom(src => src.abn_CreateDate))
                .ForMember(dest => dest.abn_Date, opt => opt.MapFrom(src => src.abn_Date))
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
                .ForMember(dest => dest.abn_Guid, opt => opt.MapFrom(src => src.abn_Guid))
                .ForMember(dest => dest.abn_HasNotEmptyPrepaid, opt => opt.MapFrom(src => src.abn_HasNotEmptyPrepaid))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.ParentID, opt => opt.MapFrom(src => src.abn_ID_Boss))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_IsGuest, opt => opt.MapFrom(src => src.abn_IsGuest))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
                .ForMember(dest => dest.abn_ModifiedDate, opt => opt.MapFrom(src => src.abn_ModifiedDate))
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
                .ForMember(dest => dest.abn_NestedSets_Left, opt => opt.MapFrom(src => src.abn_NestedSets_Left))
                .ForMember(dest => dest.abn_NestedSets_Right, opt => opt.MapFrom(src => src.abn_NestedSets_Right))
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
                .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => opt.MapFrom(src => src.abn_ShowPhoneDirectory))
                .ForMember(dest => dest.dep_id_boss, opt => opt.MapFrom(src => src.dep_id_boss))
                .ForMember(dest => dest.dep_Name_boss, opt => opt.MapFrom(src => src.dep_Name_boss))
                .ForMember(dest => dest.isRefusalChangeName, opt => opt.MapFrom(src => src.isRefusalChangeName))
                .ForMember(dest => dest.max_ModDate, opt => opt.MapFrom(src => src.max_ModDate))
                .ForMember(dest => dest.vrr_ID, opt => opt.MapFrom(src => src.vrr_ID));
#endregion
            #region [Associations_Request_SET]->[SET_p_ucp_set_Associations_Request]
			//********************** DIRECT:    WebModel[Associations_Request_SET] -> CallModel[SET_p_ucp_set_Associations_Request] *************************************
			cfg.CreateMap<Associations_Request_SET, SET_p_ucp_set_Associations_Request>()
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.Customer_SearchName))
                .ForMember(dest => dest.Abn_Date, opt => opt.MapFrom(src => src.CustomerDate))
                .ForMember(dest => dest.Lng_ID, opt => opt.MapFrom(src => src.CustomerLanguageId))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Abn_IsCreatedWithTariffication, opt => opt.MapFrom(src => src.IsCreatedWithTariffication))
                .ForMember(dest => dest.Abn_Employe_Export_ID, opt => opt.MapFrom(src => src.Export_ID))
                .ForMember(dest => dest.Grp_ID, opt => opt.MapFrom(src => src.GroupID))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.UpdateAbonentTree, opt => opt.MapFrom(src => src.isUpdateNodeTree))
                .ForMember(dest => dest.Abn_PositionCode, opt => opt.MapFrom(src => src.PositionCode))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.Dep_ID, opt => opt.MapFrom(src => src.SegmentID))
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.Abn_Employee_ID, opt => opt.MapFrom(src => src.SyncId))
                .ForMember(dest => dest.Abn_ShowPhoneDirectory, opt => opt.MapFrom(src => src.TechnicalTag))
                .ForMember(dest => dest.Location_ID, opt => opt.MapFrom(src => src.LocationID))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Sag_Code, opt => opt.MapFrom(src => src.AgentCode))
                .ForMember(dest => dest.Sag_ID, opt => opt.MapFrom(src => src.AgentID))
                .ForMember(dest => dest.Pos_Code, opt => opt.MapFrom(src => src.SalesPointCode))
                .ForMember(dest => dest.Pos_ID, opt => opt.MapFrom(src => src.SalesPointID))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Abn_ID_Boss, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Abn_Guid, opt => opt.MapFrom(src => src.Abn_Guid))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System));
;
#endregion
            #region  [SET_p_ucp_set_Associations_Response->Associations_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_Associations_Response] -> WebModel[Associations_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_Associations_Response, Associations_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Abn_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Associations)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Associations_Request, GET_p_ucp_get_Associations_Response>();
            cfg.CreateMap<SET_p_ucp_set_Associations_Request, SET_p_ucp_set_Associations_Response>();
            #endregion
            #region [Associations_Activate_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request]
			//********************** DIRECT:    WebModel[Associations_Activate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request] *************************************
			cfg.CreateMap<Associations_Activate_Request_ACTION, ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request>()
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCode))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response->Associations_Activate_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response] -> WebModel[Associations_Activate_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response, Associations_Activate_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Associations/Activate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request, ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response>();
            #endregion
            #region [Associations_ChangeName_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request]
			//********************** DIRECT:    WebModel[Associations_ChangeName_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request] *************************************
			cfg.CreateMap<Associations_ChangeName_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Abn_FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.SearchName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.toClean, opt => opt.MapFrom(src => src.ToClean));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response->Associations_ChangeName_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response] -> WebModel[Associations_ChangeName_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response, Associations_ChangeName_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Associations/ChangeName)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request, ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response>();
            #endregion
            #region [Associations_ChangeParent_Request_ACTION]->[ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request]
			//********************** DIRECT:    WebModel[Associations_ChangeParent_Request_ACTION] -> CallModel[ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request] *************************************
			cfg.CreateMap<Associations_ChangeParent_Request_ACTION, ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request>()
                .ForMember(dest => dest.ConfAccepted, opt => opt.MapFrom(src => src.ConfAccepted))
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Parent_ID, opt => opt.MapFrom(src => src.ParentNode))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_target_new, opt => opt.MapFrom(src => src.TargetStatusID));
;
#endregion
            #region  [ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response->Associations_ChangeParent_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response] -> WebModel[Associations_ChangeParent_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response, Associations_ChangeParent_Response_ACTION>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage));
#endregion
            #region (Associations/ChangeParent)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request, ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response>();
            #endregion
            #region [Associations_ChangeStatus_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request]
			//********************** DIRECT:    WebModel[Associations_ChangeStatus_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request] *************************************
			cfg.CreateMap<Associations_ChangeStatus_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfirmationMessage))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.ConfAccepted, opt => opt.MapFrom(src => src.UserAcceptance));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response->Associations_ChangeStatus_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response] -> WebModel[Associations_ChangeStatus_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response, Associations_ChangeStatus_Response_ACTION>()
                .ForMember(dest => dest.ConfirmationMessage, opt => opt.MapFrom(src => src.ConfMessage))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Associations/ChangeStatus)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request, ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response>();
            #endregion
            #region [Associations_Deactivate_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request]
			//********************** DIRECT:    WebModel[Associations_Deactivate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request] *************************************
			cfg.CreateMap<Associations_Deactivate_Request_ACTION, ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_Code_crnt, opt => opt.MapFrom(src => src.StatusCode))
                .ForMember(dest => dest.Tnst_Code_trgt, opt => opt.MapFrom(src => src.TargetStatusCode));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response->Associations_Deactivate_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response] -> WebModel[Associations_Deactivate_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response, Associations_Deactivate_Response_ACTION>()
                .ForMember(dest => dest.AffectedCount, opt => opt.MapFrom(src => src.AffectedCount))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.WorkEventID, opt => opt.MapFrom(src => src.Wev_ID));
#endregion
            #region (Associations/Deactivate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request, ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response>();
            #endregion
            #region [Associations_Details_Request_GET]->[GET_p_ucp_get_AssociationByID_Associations_Details_Request]
			//********************** DIRECT:    WebModel[Associations_Details_Request_GET] -> CallModel[GET_p_ucp_get_AssociationByID_Associations_Details_Request] *************************************
			cfg.CreateMap<Associations_Details_Request_GET, GET_p_ucp_get_AssociationByID_Associations_Details_Request>()
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.CacheControlDate));
;
#endregion
            #region [GET_p_ucp_get_AssociationByID_Associations_Details_Response->Associations_Details_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_AssociationByID_Associations_Details_Response] -> WebModel Response(Associations_Details_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_AssociationByID_Associations_Details_Response, Associations_Details_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.CacheControlDate, opt => opt.MapFrom(src => src.IfModifiedSinceDate));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Associations_Details_Request_GET>()
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_AssociationByID_Associations_Details_Response_OUTPUT] -> WebModel Response Output(Associations_Details_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_AssociationByID_Associations_Details_Response_OUTPUT] -> WebModel Response Output(Associations_Details_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_AssociationByID_Associations_Details_Response_OUTPUT, Associations_Details_Response_GET_OUTPUT>()
                .ForMember(dest => dest.debt_Amount, opt => opt.MapFrom(src => src.debt_Amount))
                .ForMember(dest => dest.debt_Date, opt => opt.MapFrom(src => src.debt_Date))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.ext_ID_count, opt => opt.MapFrom(src => src.ext_ID_count))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
                .ForMember(dest => dest.isActivated, opt => opt.MapFrom(src => src.isActivated))
                .ForMember(dest => dest.isEditAllow, opt => opt.MapFrom(src => src.isEditAllow))
                .ForMember(dest => dest.isEditWorkPlace, opt => opt.MapFrom(src => src.isEditWorkPlace))
                .ForMember(dest => dest.lng_ID, opt => opt.MapFrom(src => src.lng_ID))
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
                .ForMember(dest => dest.Location_ID, opt => opt.MapFrom(src => src.Location_ID))
                .ForMember(dest => dest.ntw_ID, opt => opt.MapFrom(src => src.ntw_ID))
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.SubsCount, opt => opt.MapFrom(src => src.SubsCount))
                .ForMember(dest => dest.tnh_LastFM, opt => opt.MapFrom(src => src.tnh_LastFM))
                .ForMember(dest => dest.tnst_ExternalID, opt => opt.MapFrom(src => src.tnst_ExternalID))
                .ForMember(dest => dest.tnst_ID, opt => opt.MapFrom(src => src.tnst_ID))
                .ForMember(dest => dest.tnt_AccountMandatory, opt => opt.MapFrom(src => src.tnt_AccountMandatory))
                .ForMember(dest => dest.tnt_ID, opt => opt.MapFrom(src => src.tnt_ID))
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
                .ForMember(dest => dest.abc_Balance_Personal, opt => opt.MapFrom(src => src.abc_Balance_Personal))
                .ForMember(dest => dest.abc_Date, opt => opt.MapFrom(src => src.abc_Date))
                .ForMember(dest => dest.abc_Date_Personal, opt => opt.MapFrom(src => src.abc_Date_Personal))
                .ForMember(dest => dest.abn_Balance, opt => opt.MapFrom(src => src.abn_Balance))
                .ForMember(dest => dest.abn_CreateDate, opt => opt.MapFrom(src => src.abn_CreateDate))
                .ForMember(dest => dest.abn_Date, opt => opt.MapFrom(src => src.abn_Date))
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_Guid, opt => opt.MapFrom(src => src.abn_Guid))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.abn_ID_Boss, opt => opt.MapFrom(src => src.abn_ID_Boss))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_IsGuest, opt => opt.MapFrom(src => src.abn_IsGuest))
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
                .ForMember(dest => dest.abn_ModifiedDate, opt => opt.MapFrom(src => src.abn_ModifiedDate))
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
                .ForMember(dest => dest.abn_NestedSets_Left, opt => opt.MapFrom(src => src.abn_NestedSets_Left))
                .ForMember(dest => dest.abn_NestedSets_Right, opt => opt.MapFrom(src => src.abn_NestedSets_Right))
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
                .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => opt.MapFrom(src => src.abn_ShowPhoneDirectory))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.abn_WorkPlace_Personal, opt => opt.MapFrom(src => src.abn_WorkPlace_Personal))
                .ForMember(dest => dest.abn_XmlData, opt => opt.MapFrom(src => src.abn_XmlData))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.acnt_ID_count, opt => opt.MapFrom(src => src.acnt_ID_count))
                .ForMember(dest => dest.acnt_IsPersonal, opt => opt.MapFrom(src => src.acnt_IsPersonal))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.Actpd_Name, opt => opt.MapFrom(src => src.Actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abb_Balance, opt => opt.MapFrom(src => src.abb_Balance))
                .ForMember(dest => dest.abb_Balance_Personal, opt => opt.MapFrom(src => src.abb_Balance_Personal))
                .ForMember(dest => dest.abb_ModifiedDate, opt => opt.MapFrom(src => src.abb_ModifiedDate))
                .ForMember(dest => dest.abb_ModifiedDate_Personal, opt => opt.MapFrom(src => src.abb_ModifiedDate_Personal))
                .ForMember(dest => dest.abc_Balance, opt => opt.MapFrom(src => src.abc_Balance))
                .ForMember(dest => dest.atnsb_DateEnd, opt => opt.MapFrom(src => src.atnsb_DateEnd))
                .ForMember(dest => dest.atnsb_DateStart, opt => opt.MapFrom(src => src.atnsb_DateStart))
                .ForMember(dest => dest.aut_ID_count, opt => opt.MapFrom(src => src.aut_ID_count))
                .ForMember(dest => dest.Boss_Tnt_Type, opt => opt.MapFrom(src => src.Boss_Tnt_Type))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
                .ForMember(dest => dest.com_Id, opt => opt.MapFrom(src => src.com_Id))
                .ForMember(dest => dest.isRefusalChangeName, opt => opt.MapFrom(src => src.isRefusalChangeName));
#endregion
            #region (Associations/Details)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_AssociationByID_Associations_Details_Request, GET_p_ucp_get_AssociationByID_Associations_Details_Response>();
            #endregion
            #region [Associations_SetLabels_Request_ACTION]->[ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request]
			//********************** DIRECT:    WebModel[Associations_SetLabels_Request_ACTION] -> CallModel[ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request] *************************************
			cfg.CreateMap<Associations_SetLabels_Request_ACTION, ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.LinkedServer, opt => opt.MapFrom(src => src.LinkedServer))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.SourceQuery, opt => opt.MapFrom(src => src.SourceQuery));
;
#endregion
            #region  [ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response->Associations_SetLabels_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response] -> WebModel[Associations_SetLabels_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response, Associations_SetLabels_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Associations/SetLabels)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request, ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response>();
            #endregion
            #endregion
            #region [AuthCodes]
            #region [AuthCodes_Request_SET]->[SET_p_ucp_set_TreeNodeAuthCodes_Request]
			//********************** DIRECT:    WebModel[AuthCodes_Request_SET] -> CallModel[SET_p_ucp_set_TreeNodeAuthCodes_Request] *************************************
			cfg.CreateMap<AuthCodes_Request_SET, SET_p_ucp_set_TreeNodeAuthCodes_Request>()
                .ForMember(dest => dest.aab_DHCPOption82, opt => opt.MapFrom(src => src.DHCPOption82))
                .ForMember(dest => dest.aab_IdentificationInfo, opt => opt.MapFrom(src => src.IdentificationInfo))
                .ForMember(dest => dest.aab_MACAddress, opt => opt.MapFrom(src => src.MACAddress))
                .ForMember(dest => dest.aab_SessionId, opt => opt.MapFrom(src => src.SessionId))
                .ForMember(dest => dest.Acnt_ID, opt => opt.MapFrom(src => src.AccountID))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.AccountNumber))
                .ForMember(dest => dest.aut_ID, opt => opt.MapFrom(src => src.AuthCodeID))
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCodeName))
                .ForMember(dest => dest.aut_XmlData, opt => opt.MapFrom(src => src.XmlData))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModifiedFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.NumberAts, opt => opt.MapFrom(src => src.NumberAts))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.XmlDataFormat, opt => opt.MapFrom(src => src.XmlDataFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.ipAddress, opt => opt.MapFrom(src => src.IpAddress))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.aab_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.ModifiedDate));
;
#endregion
            #region  [SET_p_ucp_set_TreeNodeAuthCodes_Response->AuthCodes_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_TreeNodeAuthCodes_Response] -> WebModel[AuthCodes_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_TreeNodeAuthCodes_Response, AuthCodes_Response_SET>()
                .ForMember(dest => dest.AuthCodeID, opt => opt.MapFrom(src => src.aut_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.aab_ID));
#endregion
            #region (AuthCodes)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_TreeNodeAuthCodes_Request, SET_p_ucp_set_TreeNodeAuthCodes_Response>();
            #endregion
            #endregion
            #region [BankAccounts]
            #region [BankAccounts_Request_GET]->[GET_p_ucp_get_BankAccounts_Request]
			//********************** DIRECT:    WebModel[BankAccounts_Request_GET] -> CallModel[GET_p_ucp_get_BankAccounts_Request] *************************************
			cfg.CreateMap<BankAccounts_Request_GET, GET_p_ucp_get_BankAccounts_Request>()
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.Abn_ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageNumber))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize));
;
#endregion
            #region [GET_p_ucp_get_BankAccounts_Response->BankAccounts_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_BankAccounts_Response] -> WebModel Response(BankAccounts_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_BankAccounts_Response, BankAccounts_Response_GET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, BankAccounts_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
					//Id
					.ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.Id));
#endregion
            #region [GET_p_ucp_get_BankAccounts_Response_OUTPUT] -> WebModel Response Output(BankAccounts_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_BankAccounts_Response_OUTPUT] -> WebModel Response Output(BankAccounts_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_BankAccounts_Response_OUTPUT, BankAccounts_Response_GET_OUTPUT>()
                .ForMember(dest => dest.AccNumber, opt => opt.MapFrom(src => src.AccNumber))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.bac_ID))
                .ForMember(dest => dest.BankCode, opt => opt.MapFrom(src => src.BankCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.IBAN, opt => opt.MapFrom(src => src.IBAN))
                .ForMember(dest => dest.loc_ID, opt => opt.MapFrom(src => src.loc_ID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.OneString, opt => opt.MapFrom(src => src.OneString))
                .ForMember(dest => dest.bnk_ID, opt => opt.MapFrom(src => src.bnk_ID))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total));
#endregion
            #region (BankAccounts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_BankAccounts_Request, GET_p_ucp_get_BankAccounts_Response>();
            #endregion
            #endregion
            #region [BankDetails]
            #region [BankDetails_Request_SET]->[SET_p_ucp_set_BankDetails_Request]
			//********************** DIRECT:    WebModel[BankDetails_Request_SET] -> CallModel[SET_p_ucp_set_BankDetails_Request] *************************************
			cfg.CreateMap<BankDetails_Request_SET, SET_p_ucp_set_BankDetails_Request>()
                .ForMember(dest => dest.Esys_ID, opt => opt.MapFrom(src => src.Esys_ID))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
                .ForMember(dest => dest.Bac_IBANCode, opt => opt.MapFrom(src => src.IBANCode))
                .ForMember(dest => dest.Bnk_CloseDate, opt => opt.MapFrom(src => src.BankCloseDate))
                .ForMember(dest => dest.Bnk_JsonData, opt => opt.MapFrom(src => src.BankJsonData))
                .ForMember(dest => dest.Bnk_ID, opt => opt.MapFrom(src => src.BankID))
                .ForMember(dest => dest.Bac_ID, opt => opt.MapFrom(src => src.BankAccountID))
                .ForMember(dest => dest.Cit_ID, opt => opt.MapFrom(src => src.CityID))
                .ForMember(dest => dest.Loc_ID, opt => opt.MapFrom(src => src.LocationID))
                .ForMember(dest => dest.Cou_ID, opt => opt.MapFrom(src => src.CountryID))
                .ForMember(dest => dest.Bnk_Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.Bnkd_Name, opt => opt.MapFrom(src => src.BankName))
                .ForMember(dest => dest.Bnk_BankCode, opt => opt.MapFrom(src => src.BankCode))
                .ForMember(dest => dest.Bac_Number, opt => opt.MapFrom(src => src.BankAccountNumber))
                .ForMember(dest => dest.Bnk_CloseBy, opt => opt.MapFrom(src => src.BankCloseBy))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Adab_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
;
#endregion
            #region  [SET_p_ucp_set_BankDetails_Response->BankDetails_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_BankDetails_Response] -> WebModel[BankDetails_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_BankDetails_Response, BankDetails_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Adab_ID))
                .ForMember(dest => dest.BankAccountID, opt => opt.MapFrom(src => src.Bac_ID))
                .ForMember(dest => dest.BankID, opt => opt.MapFrom(src => src.Bnk_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID));
#endregion
            #region (BankDetails)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_BankDetails_Request, SET_p_ucp_set_BankDetails_Response>();
            #endregion
            #endregion
            #region [BankStatements]
            #region [BankStatements_Request_GET]->[GET_p_ucp_get_BatchPayDocRecords_Request]
			//********************** DIRECT:    WebModel[BankStatements_Request_GET] -> CallModel[GET_p_ucp_get_BatchPayDocRecords_Request] *************************************
			cfg.CreateMap<BankStatements_Request_GET, GET_p_ucp_get_BatchPayDocRecords_Request>()
                .ForMember(dest => dest.Bank_Account_NUM, opt => opt.MapFrom(src => src.BankAccountNumberTo))
                .ForMember(dest => dest.Bank_MFO, opt => opt.MapFrom(src => src.BankCodeTo))
                .ForMember(dest => dest.Batch_ID, opt => opt.MapFrom(src => src.BatchID))
                .ForMember(dest => dest.Date_doc, opt => opt.MapFrom(src => src.PayDate))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
;
#endregion
            #region [GET_p_ucp_get_BatchPayDocRecords_Response->BankStatements_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_BatchPayDocRecords_Response] -> WebModel Response(BankStatements_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_BatchPayDocRecords_Response, BankStatements_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, BankStatements_Request_GET>()
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_BatchPayDocRecords_Response_OUTPUT] -> WebModel Response Output(BankStatements_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_BatchPayDocRecords_Response_OUTPUT] -> WebModel Response Output(BankStatements_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_BatchPayDocRecords_Response_OUTPUT, BankStatements_Response_GET_OUTPUT>()
                .ForMember(dest => dest.BankAccountNumberFrom, opt => opt.MapFrom(src => src.accountfrom))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.amount))
                .ForMember(dest => dest.BankAccountExternalID, opt => opt.MapFrom(src => src.bank_account_ID))
                .ForMember(dest => dest.BankAccountNumberTo, opt => opt.MapFrom(src => src.bank_account_num))
                .ForMember(dest => dest.pre_ExternalID, opt => opt.MapFrom(src => src.bank_st_ID))
                .ForMember(dest => dest.PaymentOrder, opt => opt.MapFrom(src => src.bank_trx_number))
                .ForMember(dest => dest.BankInternalCodeTo, opt => opt.MapFrom(src => src.bankcode))
                .ForMember(dest => dest.BatchID, opt => opt.MapFrom(src => src.batch_id))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.creation_date))
                .ForMember(dest => dest.PayDate, opt => opt.MapFrom(src => src.date_doc))
                .ForMember(dest => dest.cpd_ExportID, opt => opt.MapFrom(src => src.doc_ID))
                .ForMember(dest => dest.pre_NumReestr, opt => opt.MapFrom(src => src.list_num))
                .ForMember(dest => dest.BankCodeTo, opt => opt.MapFrom(src => src.mfo))
                .ForMember(dest => dest.BankCodeFrom, opt => opt.MapFrom(src => src.mfofrom))
                .ForMember(dest => dest.BankNameFrom, opt => opt.MapFrom(src => src.namefrom))
                .ForMember(dest => dest.BusinessUIDFrom, opt => opt.MapFrom(src => src.okpofrom))
                .ForMember(dest => dest.TenantID, opt => opt.MapFrom(src => src.org_ID))
                .ForMember(dest => dest.RequestNumber, opt => opt.MapFrom(src => src.req_num))
                .ForMember(dest => dest.PayDocStatusId, opt => opt.MapFrom(src => src.status))
                .ForMember(dest => dest.TransactionCode, opt => opt.MapFrom(src => src.trx_code))
                .ForMember(dest => dest.TransactionText, opt => opt.MapFrom(src => src.trx_text))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.bill_acc));
#endregion
            #region [BankStatements_Request_SET]->[SET_p_ucp_set_BatchPayDocRecords_Request]
			//********************** DIRECT:    WebModel[BankStatements_Request_SET] -> CallModel[SET_p_ucp_set_BatchPayDocRecords_Request] *************************************
			cfg.CreateMap<BankStatements_Request_SET, SET_p_ucp_set_BatchPayDocRecords_Request>()
                .ForMember(dest => dest.Bank_Account_NUM, opt => opt.MapFrom(src => src.BankAccountNumberTo))
                .ForMember(dest => dest.Bank_MFO, opt => opt.MapFrom(src => src.BankCodeTo))
                .ForMember(dest => dest.Batch_Count, opt => opt.MapFrom(src => src.RowCount))
                .ForMember(dest => dest.Batch_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Bil_Account, opt => opt.MapFrom(src => src.IsBillingAccount))
                .ForMember(dest => dest.Date_doc, opt => opt.MapFrom(src => src.PayDate))
                .ForMember(dest => dest.Doc_ID, opt => opt.MapFrom(src => src.cpd_ExportID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Org_ID, opt => opt.MapFrom(src => src.TenantID))
                .ForMember(dest => dest.Remitted, opt => opt.MapFrom(src => src.IsPostponed))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.PayDocStatusCode))
                .ForMember(dest => dest.User_ID, opt => opt.MapFrom(src => src.UserID))
                .ForMember(dest => dest.Bac_ID, opt => opt.MapFrom(src => src.ParentID));
;
#endregion
            #region  [SET_p_ucp_set_BatchPayDocRecords_Response->BankStatements_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_BatchPayDocRecords_Response] -> WebModel[BankStatements_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_BatchPayDocRecords_Response, BankStatements_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Batch_ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result));
#endregion
            #region (BankStatements)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_BatchPayDocRecords_Request, GET_p_ucp_get_BatchPayDocRecords_Response>();
            cfg.CreateMap<SET_p_ucp_set_BatchPayDocRecords_Request, SET_p_ucp_set_BatchPayDocRecords_Response>();
            #endregion
            #region [BankStatements_ChangePaymentsStatus_Request_ACTION]->[ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request]
			//********************** DIRECT:    WebModel[BankStatements_ChangePaymentsStatus_Request_ACTION] -> CallModel[ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request] *************************************
			cfg.CreateMap<BankStatements_ChangePaymentsStatus_Request_ACTION, ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request>()
                .ForMember(dest => dest.Doc_ID, opt => opt.MapFrom(src => src.cpd_ExportID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Status_AU, opt => opt.MapFrom(src => src.PayDocStatusId))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result));
;
#endregion
            #region  [ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response->BankStatements_ChangePaymentsStatus_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response] -> WebModel[BankStatements_ChangePaymentsStatus_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response, BankStatements_ChangePaymentsStatus_Response_ACTION>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result));
#endregion
            #region (BankStatements/ChangePaymentsStatus)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request, ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response>();
            #endregion
            #region [BankStatements_CheckNoSavePayments_Request_ACTION]->[ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request]
			//********************** DIRECT:    WebModel[BankStatements_CheckNoSavePayments_Request_ACTION] -> CallModel[ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request] *************************************
			cfg.CreateMap<BankStatements_CheckNoSavePayments_Request_ACTION, ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request>()
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result))
                .ForMember(dest => dest.User_ID, opt => opt.MapFrom(src => src.UserID));
;
#endregion
            #region  [ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response->BankStatements_CheckNoSavePayments_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response] -> WebModel[BankStatements_CheckNoSavePayments_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response, BankStatements_CheckNoSavePayments_Response_ACTION>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result));
#endregion
            #region (BankStatements/CheckNoSavePayments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request, ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response>();
            #endregion
            #region [BankStatements_ClearBatch_Request_ACTION]->[ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request]
			//********************** DIRECT:    WebModel[BankStatements_ClearBatch_Request_ACTION] -> CallModel[ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request] *************************************
			cfg.CreateMap<BankStatements_ClearBatch_Request_ACTION, ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request>()
                .ForMember(dest => dest.Batch_ID, opt => opt.MapFrom(src => src.BatchID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result));
;
#endregion
            #region  [ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response->BankStatements_ClearBatch_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response] -> WebModel[BankStatements_ClearBatch_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response, BankStatements_ClearBatch_Response_ACTION>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result));
#endregion
            #region (BankStatements/ClearBatch)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request, ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response>();
            #endregion
            #endregion
            #region [BankStatementTransactions]
            #region [BankStatementTransactions_Request_GET]->[GET_p_ucp_get_BankStatements_Request]
			//********************** DIRECT:    WebModel[BankStatementTransactions_Request_GET] -> CallModel[GET_p_ucp_get_BankStatements_Request] *************************************
			cfg.CreateMap<BankStatementTransactions_Request_GET, GET_p_ucp_get_BankStatements_Request>()
                .ForMember(dest => dest.Bac_ID, opt => opt.MapFrom(src => src.BankAccountID))
                .ForMember(dest => dest.DateFrom, opt => opt.MapFrom(src => src.DateFrom))
                .ForMember(dest => dest.DateTo, opt => opt.MapFrom(src => src.DateTo))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.If_Modified_Since))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.Page))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection));
;
#endregion
            #region [GET_p_ucp_get_BankStatements_Response->BankStatementTransactions_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_BankStatements_Response] -> WebModel Response(BankStatementTransactions_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_BankStatements_Response, BankStatementTransactions_Response_GET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.If_Modified_Since, opt => opt.MapFrom(src => src.IfModifiedSinceDate))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, BankStatementTransactions_Request_GET>()
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_BankStatements_Response_OUTPUT] -> WebModel Response Output(BankStatementTransactions_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_BankStatements_Response_OUTPUT] -> WebModel Response Output(BankStatementTransactions_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_BankStatements_Response_OUTPUT, BankStatementTransactions_Response_GET_OUTPUT>()
                .ForMember(dest => dest.BankAccountNumberFrom, opt => opt.MapFrom(src => src.accountfrom))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.amount))
                .ForMember(dest => dest.BankAccountExternalID, opt => opt.MapFrom(src => src.bank_account_ID))
                .ForMember(dest => dest.BankAccountNumberTo, opt => opt.MapFrom(src => src.bank_account_num))
                .ForMember(dest => dest.pre_ExternalID, opt => opt.MapFrom(src => src.bank_st_ID))
                .ForMember(dest => dest.PaymentOrder, opt => opt.MapFrom(src => src.bank_trx_number))
                .ForMember(dest => dest.BankInternalCodeTo, opt => opt.MapFrom(src => src.bankcode))
                .ForMember(dest => dest.BatchID, opt => opt.MapFrom(src => src.batch_id))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.bill_acc))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.created_by))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.creation_date))
                .ForMember(dest => dest.crn_CodeISO, opt => opt.MapFrom(src => src.currency_code))
                .ForMember(dest => dest.PayDate, opt => opt.MapFrom(src => src.date_doc))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.doc_ID))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.last_update_date))
                .ForMember(dest => dest.ModifiedDBy, opt => opt.MapFrom(src => src.last_updated_by))
                .ForMember(dest => dest.pre_NumReestr, opt => opt.MapFrom(src => src.list_num))
                .ForMember(dest => dest.BankCodeTo, opt => opt.MapFrom(src => src.mfo))
                .ForMember(dest => dest.BankCodeFrom, opt => opt.MapFrom(src => src.mfofrom))
                .ForMember(dest => dest.BankNameFrom, opt => opt.MapFrom(src => src.namefrom))
                .ForMember(dest => dest.BusinessUIDFrom, opt => opt.MapFrom(src => src.okpofrom))
                .ForMember(dest => dest.TenantID, opt => opt.MapFrom(src => src.org_ID))
                .ForMember(dest => dest.RequestNumber, opt => opt.MapFrom(src => src.req_num))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.status))
                .ForMember(dest => dest.StatusCode, opt => opt.MapFrom(src => src.status_code))
                .ForMember(dest => dest.StatusName, opt => opt.MapFrom(src => src.statusName))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.TransactionCode, opt => opt.MapFrom(src => src.trx_code))
                .ForMember(dest => dest.TransactionText, opt => opt.MapFrom(src => src.trx_text))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.userName));
#endregion
            #region (BankStatementTransactions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_BankStatements_Request, GET_p_ucp_get_BankStatements_Response>();
            #endregion
            #endregion
            #region [BillingTasks]
            #region [BillingTasks_Request_SET]->[SET_sp_set_BillingTasks_Request]
			//********************** DIRECT:    WebModel[BillingTasks_Request_SET] -> CallModel[SET_sp_set_BillingTasks_Request] *************************************
			cfg.CreateMap<BillingTasks_Request_SET, SET_sp_set_BillingTasks_Request>()
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.abn_grp_ID, opt => opt.MapFrom(src => src.GroupID))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.opt_XmlData, opt => opt.MapFrom(src => src.Options))
                .ForMember(dest => dest.pkt_IDs, opt => opt.MapFrom(src => src.PacketsIDs))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.srv_ID, opt => opt.MapFrom(src => src.ServiceID))
                .ForMember(dest => dest.srv_ID_Accumulative, opt => opt.MapFrom(src => src.ServiceIDAccumulative))
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.ExitAfterFirstError, opt => opt.MapFrom(src => src.ExitAfterFirstError))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.cacheStatus, opt => opt.MapFrom(src => src.cacheStatus))
                .ForMember(dest => dest.Tsk_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.srs_ID_list, opt => opt.MapFrom(src => src.srs_ID_list))
                .ForMember(dest => dest.Tsst_Code, opt => opt.MapFrom(src => src.Tsst_Code));
;
#endregion
            #region  [SET_sp_set_BillingTasks_Response->BillingTasks_Response_SET]
			//********************** BACK:   CallModel(SET_sp_set_BillingTasks_Response] -> WebModel[BillingTasks_Response_SET] *************************************
			cfg.CreateMap<SET_sp_set_BillingTasks_Response, BillingTasks_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Tsk_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID));
#endregion
            #region (BillingTasks)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_sp_set_BillingTasks_Request, SET_sp_set_BillingTasks_Response>();
            #endregion
            #endregion
            #region [CallCredits]
            #region [CallCredits_Request_SET]->[SET_p_ucp_set_DiscountValue4Subscriber_Request]
			//********************** DIRECT:    WebModel[CallCredits_Request_SET] -> CallModel[SET_p_ucp_set_DiscountValue4Subscriber_Request] *************************************
			cfg.CreateMap<CallCredits_Request_SET, SET_p_ucp_set_DiscountValue4Subscriber_Request>()
                .ForMember(dest => dest.DiscountForm, opt => opt.MapFrom(src => src.DiscountForm))
                .ForMember(dest => dest.DiscountFormParam, opt => opt.MapFrom(src => src.DiscountFormParam))
                .ForMember(dest => dest.dsc_ID, opt => opt.MapFrom(src => src.DiscountID))
                .ForMember(dest => dest.dsvs_ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.dsvs_ModifiedFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.isAnnul, opt => opt.MapFrom(src => src.isAnnul))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.DateSet, opt => opt.MapFrom(src => src.DateSet))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.dab_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
;
#endregion
            #region  [SET_p_ucp_set_DiscountValue4Subscriber_Response->CallCredits_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_DiscountValue4Subscriber_Response] -> WebModel[CallCredits_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_DiscountValue4Subscriber_Response, CallCredits_Response_SET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.dab_ID));
#endregion
            #region (CallCredits)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_DiscountValue4Subscriber_Request, SET_p_ucp_set_DiscountValue4Subscriber_Response>();
            #endregion
            #endregion
            #region [CallUserGroups]
            #region [CallUserGroups_Request_SET]->[SET_p_ucp_set_CodeRegionGroups_Request]
			//********************** DIRECT:    WebModel[CallUserGroups_Request_SET] -> CallModel[SET_p_ucp_set_CodeRegionGroups_Request] *************************************
			cfg.CreateMap<CallUserGroups_Request_SET, SET_p_ucp_set_CodeRegionGroups_Request>()
                .ForMember(dest => dest.Crg_DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.Crg_DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.Crg_Order, opt => opt.MapFrom(src => src.Priority))
                .ForMember(dest => dest.Crg_Prefixes, opt => opt.MapFrom(src => src.Prefixes))
                .ForMember(dest => dest.Crg_RegionName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Crg_RegionNameEN, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.Crgo_Options, opt => opt.MapFrom(src => src.Options))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Crg_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Crg_Default, opt => opt.MapFrom(src => src.Crg_Default))
                .ForMember(dest => dest.Crg_IsUniqueCodes, opt => opt.MapFrom(src => src.Crg_IsUniqueCodes))
                .ForMember(dest => dest.Crgt_ID, opt => opt.MapFrom(src => src.Crgt_ID))
                .ForMember(dest => dest.RegionNameEN, opt => opt.MapFrom(src => src.RegionNameEN))
                .ForMember(dest => dest.RegionNameRU, opt => opt.MapFrom(src => src.RegionNameRU))
                .ForMember(dest => dest.RegionNameUK, opt => opt.MapFrom(src => src.RegionNameUK));
;
#endregion
            #region  [SET_p_ucp_set_CodeRegionGroups_Response->CallUserGroups_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_CodeRegionGroups_Response] -> WebModel[CallUserGroups_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_CodeRegionGroups_Response, CallUserGroups_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Crg_ID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (CallUserGroups)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_CodeRegionGroups_Request, SET_p_ucp_set_CodeRegionGroups_Response>();
            #endregion
            #endregion
            #region [Contracts]
            #region [Contracts_Request_SET]->[SET_p_ucp_set_Contracts_Request]
			//********************** DIRECT:    WebModel[Contracts_Request_SET] -> CallModel[SET_p_ucp_set_Contracts_Request] *************************************
			cfg.CreateMap<Contracts_Request_SET, SET_p_ucp_set_Contracts_Request>()
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
                .ForMember(dest => dest.aut_ID, opt => opt.MapFrom(src => src.AuthCodeID))
                .ForMember(dest => dest.cntc_ID, opt => opt.MapFrom(src => src.ClassID))
                .ForMember(dest => dest.cntg_ID, opt => opt.MapFrom(src => src.CategoryID))
                .ForMember(dest => dest.cntr_Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.cntr_DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.cntr_DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.cntr_ExternalID, opt => opt.MapFrom(src => src.ExternalID))
                .ForMember(dest => dest.cntr_JsonData, opt => opt.MapFrom(src => src.JsonData))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.cntr_Primary, opt => opt.MapFrom(src => src.Primary))
                .ForMember(dest => dest.cntr_Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.cnts_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.ext_ID, opt => opt.MapFrom(src => src.ExtentionID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.cntr_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
;
#endregion
            #region  [SET_p_ucp_set_Contracts_Response->Contracts_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_Contracts_Response] -> WebModel[Contracts_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_Contracts_Response, Contracts_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.cntr_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Contracts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_Contracts_Request, SET_p_ucp_set_Contracts_Response>();
            #endregion
            #endregion
            #region [CustomerPayments]
            #region [CustomerPayments_Request_GET]->[GET_p_ucp_get_CustomerPayments_Request]
			//********************** DIRECT:    WebModel[CustomerPayments_Request_GET] -> CallModel[GET_p_ucp_get_CustomerPayments_Request] *************************************
			cfg.CreateMap<CustomerPayments_Request_GET, GET_p_ucp_get_CustomerPayments_Request>()
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.CustomerID))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.AmountFrom, opt => opt.MapFrom(src => src.AmountFrom))
                .ForMember(dest => dest.AmountTo, opt => opt.MapFrom(src => src.AmountTo))
                .ForMember(dest => dest.Bac_ID, opt => opt.MapFrom(src => src.BankAccountID))
                .ForMember(dest => dest.Bnk_BankCode, opt => opt.MapFrom(src => src.BankCode))
                .ForMember(dest => dest.Cof_Remark, opt => opt.MapFrom(src => src.KassaRemark))
                .ForMember(dest => dest.Cpay_Annul, opt => opt.MapFrom(src => src.Annul))
                .ForMember(dest => dest.Cpay_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Cpay_Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Cpc_ID, opt => opt.MapFrom(src => src.PayClass))
                .ForMember(dest => dest.Cpd_ExternalID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Cpd_PayDocNumber, opt => opt.MapFrom(src => src.PayDocNumber))
                .ForMember(dest => dest.Cpif_ID, opt => opt.MapFrom(src => src.PayInterfaceID))
                .ForMember(dest => dest.Cpifd_Name, opt => opt.MapFrom(src => src.PayInterfaceName))
                .ForMember(dest => dest.DateFrom, opt => opt.MapFrom(src => src.DateFrom))
                .ForMember(dest => dest.DateTo, opt => opt.MapFrom(src => src.DateTo))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.CacheControlDate))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageNumber))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
                .ForMember(dest => dest.Pre_NumReestr, opt => opt.MapFrom(src => src.ReestrNumber))
                .ForMember(dest => dest.aar_ID, opt => opt.MapFrom(src => src.aar_ID))
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection))
                .ForMember(dest => dest.IsExternalSync, opt => opt.MapFrom(src => src.IsExternalSync));
;
#endregion
            #region [GET_p_ucp_get_CustomerPayments_Response->CustomerPayments_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_CustomerPayments_Response] -> WebModel Response(CustomerPayments_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerPayments_Response, CustomerPayments_Response_GET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.CacheControlDate, opt => opt.MapFrom(src => src.IfModifiedSinceDate))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, CustomerPayments_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_CustomerPayments_Response_OUTPUT] -> WebModel Response Output(CustomerPayments_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_CustomerPayments_Response_OUTPUT] -> WebModel Response Output(CustomerPayments_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerPayments_Response_OUTPUT, CustomerPayments_Response_GET_OUTPUT>()
                .ForMember(dest => dest.Moved, opt => opt.MapFrom(src => src.cpd_Moved))
                .ForMember(dest => dest.PayDocNumber, opt => opt.MapFrom(src => src.cpd_PayDocNumber))
                .ForMember(dest => dest.PayINN, opt => opt.MapFrom(src => src.cpd_PayINN))
                .ForMember(dest => dest.PayInterfaceID, opt => opt.MapFrom(src => src.cpif_ID))
                .ForMember(dest => dest.PayInterfaceName, opt => opt.MapFrom(src => src.cpifd_Name))
                .ForMember(dest => dest.currency_Name, opt => opt.MapFrom(src => src.currency_Name))
                .ForMember(dest => dest.customer_Name, opt => opt.MapFrom(src => src.customer_Name))
                .ForMember(dest => dest.IsPayDoc, opt => opt.MapFrom(src => src.IsPayDoc))
                .ForMember(dest => dest.ReestrDate, opt => opt.MapFrom(src => src.pre_DateReestr))
                .ForMember(dest => dest.ReestrNumber, opt => opt.MapFrom(src => src.pre_NumReestr))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.BankAccountNumber, opt => opt.MapFrom(src => src.bac_Number))
                .ForMember(dest => dest.BillDateCreate, opt => opt.MapFrom(src => src.bll_DateCreate))
                .ForMember(dest => dest.BillNumber, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.bnkd_Name))
                .ForMember(dest => dest.KassaRemark, opt => opt.MapFrom(src => src.cof_Remark))
                .ForMember(dest => dest.Account, opt => opt.MapFrom(src => src.cpay_Account))
                .ForMember(dest => dest.cpay_Amount, opt => opt.MapFrom(src => src.cpay_Amount))
                .ForMember(dest => dest.cpay_AmountTaxes, opt => opt.MapFrom(src => src.cpay_AmountTaxes))
                .ForMember(dest => dest.Annul, opt => opt.MapFrom(src => src.cpay_Annul))
                .ForMember(dest => dest.DatePay, opt => opt.MapFrom(src => src.cpay_DatePay))
                .ForMember(dest => dest.cpay_ExternalID, opt => opt.MapFrom(src => src.cpay_ExternalID))
                .ForMember(dest => dest.cpay_ID, opt => opt.MapFrom(src => src.cpay_ID))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.cpay_ModifiedBy))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.cpay_ModifiedDate))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.cpay_Remark))
                .ForMember(dest => dest.RemoveBy, opt => opt.MapFrom(src => src.cpay_RemoveBy))
                .ForMember(dest => dest.RemoveDate, opt => opt.MapFrom(src => src.cpay_RemoveDate))
                .ForMember(dest => dest.PayClassCode, opt => opt.MapFrom(src => src.cpc_Code))
                .ForMember(dest => dest.PayClass, opt => opt.MapFrom(src => src.cpc_ID))
                .ForMember(dest => dest.PayClassName, opt => opt.MapFrom(src => src.cpcd_Name))
                .ForMember(dest => dest.cpd_Amount, opt => opt.MapFrom(src => src.cpd_Amount))
                .ForMember(dest => dest.DealerId, opt => opt.MapFrom(src => src.cpd_DealerId))
                .ForMember(dest => dest.DesAccount, opt => opt.MapFrom(src => src.cpd_DesAccount))
                .ForMember(dest => dest.DesContract, opt => opt.MapFrom(src => src.cpd_DesContract))
                .ForMember(dest => dest.DesPhone, opt => opt.MapFrom(src => src.cpd_DesPhone))
                .ForMember(dest => dest.ParentID, opt => opt.MapFrom(src => src.cpd_ExternalID))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.cpay_ExternalError, opt => opt.MapFrom(src => src.cpay_ExternalError))
                .ForMember(dest => dest.cps_Code, opt => opt.MapFrom(src => src.cps_Code))
                .ForMember(dest => dest.cps_ID, opt => opt.MapFrom(src => src.cps_ID));
#endregion
            #region [CustomerPayments_Request_SET]->[SET_p_ucp_set_CustomerPayments_Request]
			//********************** DIRECT:    WebModel[CustomerPayments_Request_SET] -> CallModel[SET_p_ucp_set_CustomerPayments_Request] *************************************
			cfg.CreateMap<CustomerPayments_Request_SET, SET_p_ucp_set_CustomerPayments_Request>()
                .ForMember(dest => dest.Cpay_DatePay, opt => opt.MapFrom(src => src.DatePay))
                .ForMember(dest => dest.Cpc_ID, opt => opt.MapFrom(src => src.PayClass))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.AccountNumber))
                .ForMember(dest => dest.Cpay_Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.Сpay_Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Cpd_ExternalID, opt => opt.MapFrom(src => src.PayDocID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Redistribution, opt => opt.MapFrom(src => src.AllocateAmount))
                .ForMember(dest => dest.Pinv_ID, opt => opt.MapFrom(src => src.InvoiceID))
                .ForMember(dest => dest.Pinv_Number, opt => opt.MapFrom(src => src.InvoiceNumber))
                .ForMember(dest => dest.Cpay_Annul, opt => opt.MapFrom(src => src.Annul))
                .ForMember(dest => dest.Сpay_RemoveBy, opt => opt.MapFrom(src => src.RemoveBy))
                .ForMember(dest => dest.Сpay_RemoveFrom, opt => opt.MapFrom(src => src.RemoveFrom))
                .ForMember(dest => dest.Cpif_ID, opt => opt.MapFrom(src => src.PayInterfaceID))
                .ForMember(dest => dest.Dlr_ID, opt => opt.MapFrom(src => src.DealerID))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.Cpay_ExternalID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Cpay_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsDenyPayOff, opt => opt.MapFrom(src => src.IsDenyPayOff));
;
#endregion
            #region  [SET_p_ucp_set_CustomerPayments_Response->CustomerPayments_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_CustomerPayments_Response] -> WebModel[CustomerPayments_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_CustomerPayments_Response, CustomerPayments_Response_SET>()
                .ForMember(dest => dest.global_unique_id, opt => opt.MapFrom(src => src.Cpay_ExternalID))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Cpay_ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (CustomerPayments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerPayments_Request, GET_p_ucp_get_CustomerPayments_Response>();
            cfg.CreateMap<SET_p_ucp_set_CustomerPayments_Request, SET_p_ucp_set_CustomerPayments_Response>();
            #endregion
            #region [CustomerPayments_AllocatedPayments_Request_GET]->[GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request]
			//********************** DIRECT:    WebModel[CustomerPayments_AllocatedPayments_Request_GET] -> CallModel[GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request] *************************************
			cfg.CreateMap<CustomerPayments_AllocatedPayments_Request_GET, GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request>()
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.Redistribution, opt => opt.MapFrom(src => src.AllocateAmount))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.bll_Amount, opt => opt.MapFrom(src => src.bll_Amount))
                .ForMember(dest => dest.cpd_ExportID, opt => opt.MapFrom(src => src.cpd_ExportID))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.PromisedPayLogic, opt => opt.MapFrom(src => src.PromisedPayLogic));
;
#endregion
            #region [GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response->CustomerPayments_AllocatedPayments_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response] -> WebModel Response(CustomerPayments_AllocatedPayments_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response, CustomerPayments_AllocatedPayments_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, CustomerPayments_AllocatedPayments_Request_GET>()
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response_OUTPUT] -> WebModel Response Output(CustomerPayments_AllocatedPayments_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response_OUTPUT] -> WebModel Response Output(CustomerPayments_AllocatedPayments_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response_OUTPUT, CustomerPayments_AllocatedPayments_Response_GET_OUTPUT>()
                .ForMember(dest => dest.cpc_ID, opt => opt.MapFrom(src => src.cpc_ID))
                .ForMember(dest => dest.cpif_ID, opt => opt.MapFrom(src => src.cpif_ID))
                .ForMember(dest => dest.cpay_ID, opt => opt.MapFrom(src => src.cpay_ID))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.cpay_ExternalID, opt => opt.MapFrom(src => src.cpay_ExternalID))
                .ForMember(dest => dest.cpc_ExternalID, opt => opt.MapFrom(src => src.cpc_ExternalID))
                .ForMember(dest => dest.cpd_ExportedDate, opt => opt.MapFrom(src => src.cpd_ExportedDate))
                .ForMember(dest => dest.cpd_ExternalID, opt => opt.MapFrom(src => src.cpd_ExternalID))
                .ForMember(dest => dest.cpd_Moved, opt => opt.MapFrom(src => src.cpd_Moved))
                .ForMember(dest => dest.cpif_ExternalID, opt => opt.MapFrom(src => src.cpif_ExternalID))
                .ForMember(dest => dest.crn_CodeISO, opt => opt.MapFrom(src => src.crn_CodeISO))
                .ForMember(dest => dest.divided_Amount, opt => opt.MapFrom(src => src.divided_Amount))
                .ForMember(dest => dest.inv_One_String, opt => opt.MapFrom(src => src.inv_One_String))
                .ForMember(dest => dest.isBlocked, opt => opt.MapFrom(src => src.isBlocked))
                .ForMember(dest => dest.order_ID, opt => opt.MapFrom(src => src.order_ID))
                .ForMember(dest => dest.pinv_Amount, opt => opt.MapFrom(src => src.pinv_Amount))
                .ForMember(dest => dest.pinv_Date, opt => opt.MapFrom(src => src.pinv_Date))
                .ForMember(dest => dest.pinv_ID, opt => opt.MapFrom(src => src.pinv_ID))
                .ForMember(dest => dest.pinv_Number, opt => opt.MapFrom(src => src.pinv_Number))
                .ForMember(dest => dest.Retry, opt => opt.MapFrom(src => src.Retry))
                .ForMember(dest => dest.global_unique_id, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ParentID, opt => opt.MapFrom(src => src.ParentID));
#endregion
            #region (CustomerPayments/AllocatedPayments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request, GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response>();
            #endregion
            #endregion
            #region [Customers]
            #region [Customers_Request_GET]->[GET_p_ucp_get_Customers_Request]
			//********************** DIRECT:    WebModel[Customers_Request_GET] -> CallModel[GET_p_ucp_get_Customers_Request] *************************************
			cfg.CreateMap<Customers_Request_GET, GET_p_ucp_get_Customers_Request>()
                .ForMember(dest => dest.Dls_ID, opt => opt.MapFrom(src => src.Dls_ID))
                .ForMember(dest => dest.com_ID, opt => opt.MapFrom(src => src.com_ID))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.CacheControlDate))
                .ForMember(dest => dest.jsonFieldsName, opt => opt.MapFrom(src => src.jsonFieldsName))
                .ForMember(dest => dest.jsonFilter, opt => opt.MapFrom(src => src.jsonFilter))
                .ForMember(dest => dest.jsonFilterContain, opt => opt.MapFrom(src => src.jsonFilterContain))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Lng_ID, opt => opt.MapFrom(src => src.Lng_ID))
                .ForMember(dest => dest.mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.Ntw_ID, opt => opt.MapFrom(src => src.Ntw_ID))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageNumber))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.Rgsc_ID, opt => opt.MapFrom(src => src.Rgsc_ID))
                .ForMember(dest => dest.ShowBalances, opt => opt.MapFrom(src => src.ShowBalances))
                .ForMember(dest => dest.ShowEntities, opt => opt.MapFrom(src => src.ShowEntities))
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection))
                .ForMember(dest => dest.Srv_ID, opt => opt.MapFrom(src => src.Srv_ID))
                .ForMember(dest => dest.Srv_Name, opt => opt.MapFrom(src => src.Srv_Name))
                .ForMember(dest => dest.Sst_ID, opt => opt.MapFrom(src => src.Sst_ID))
                .ForMember(dest => dest.tnst_Code, opt => opt.MapFrom(src => src.tnst_Code))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.abn_ID_Boss, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.Acat_ID, opt => opt.MapFrom(src => src.Acat_ID))
                .ForMember(dest => dest.Accl_ID, opt => opt.MapFrom(src => src.Accl_ID))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Acnt_Number))
                .ForMember(dest => dest.Actp_ID, opt => opt.MapFrom(src => src.Actp_ID))
                .ForMember(dest => dest.Adlsb_Code, opt => opt.MapFrom(src => src.Adlsb_Code))
                .ForMember(dest => dest.Aptp_ID, opt => opt.MapFrom(src => src.Aptp_ID))
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.Bac_Number, opt => opt.MapFrom(src => src.Bac_Number))
                .ForMember(dest => dest.bll_Number, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.BossLastName, opt => opt.MapFrom(src => src.BossLastName))
                .ForMember(dest => dest.Cntr_Name, opt => opt.MapFrom(src => src.Cntr_Name))
                .ForMember(dest => dest.LastModifiedDate, opt => opt.MapFrom(src => src.LastModifiedDate));
;
#endregion
            #region [GET_p_ucp_get_Customers_Response->Customers_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_Customers_Response] -> WebModel Response(Customers_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Customers_Response, Customers_Response_GET>()
                .ForMember(dest => dest.CacheControlDate, opt => opt.MapFrom(src => src.IfModifiedSinceDate))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.LastModifiedDate, opt => opt.MapFrom(src => src.LastModifiedDate));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Customers_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_Customers_Response_OUTPUT] -> WebModel Response Output(Customers_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_Customers_Response_OUTPUT] -> WebModel Response Output(Customers_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Customers_Response_OUTPUT, Customers_Response_GET_OUTPUT>()
                .ForMember(dest => dest.tnt_AccountMandatory, opt => opt.MapFrom(src => src.tnt_AccountMandatory))
                .ForMember(dest => dest.tnt_ID, opt => opt.MapFrom(src => src.tnt_ID))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.ParentID, opt => opt.MapFrom(src => src.abn_ID_Boss))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_IsGuest, opt => opt.MapFrom(src => src.abn_IsGuest))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
                .ForMember(dest => dest.abn_ModifiedDate, opt => opt.MapFrom(src => src.abn_ModifiedDate))
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
                .ForMember(dest => dest.abn_NestedSets_Left, opt => opt.MapFrom(src => src.abn_NestedSets_Left))
                .ForMember(dest => dest.abn_NestedSets_Right, opt => opt.MapFrom(src => src.abn_NestedSets_Right))
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
                .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => opt.MapFrom(src => src.abn_ShowPhoneDirectory))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.acnt_ID_count, opt => opt.MapFrom(src => src.acnt_ID_count))
                .ForMember(dest => dest.acnt_IsPersonal, opt => opt.MapFrom(src => src.acnt_IsPersonal))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.actp_ID, opt => opt.MapFrom(src => src.actp_ID))
                .ForMember(dest => dest.actpd_Name, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
                .ForMember(dest => dest.aut_ID_count, opt => opt.MapFrom(src => src.aut_ID_count))
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.aut_NumberAts, opt => opt.MapFrom(src => src.aut_NumberAts))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
                .ForMember(dest => dest.cntr_ID_count, opt => opt.MapFrom(src => src.cntr_ID_count))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
                .ForMember(dest => dest.com_Id, opt => opt.MapFrom(src => src.com_Id))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.ext_ID_count, opt => opt.MapFrom(src => src.ext_ID_count))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
                .ForMember(dest => dest.isEditAllow, opt => opt.MapFrom(src => src.isEditAllow))
                .ForMember(dest => dest.isEditWorkPlace, opt => opt.MapFrom(src => src.isEditWorkPlace))
                .ForMember(dest => dest.lng_ID, opt => opt.MapFrom(src => src.lng_ID))
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
                .ForMember(dest => dest.Location_ID, opt => opt.MapFrom(src => src.Location_ID))
                .ForMember(dest => dest.ntw_ID, opt => opt.MapFrom(src => src.ntw_ID))
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.rptURL, opt => opt.MapFrom(src => src.rptURL))
                .ForMember(dest => dest.SubsCount, opt => opt.MapFrom(src => src.SubsCount))
                .ForMember(dest => dest.tnst_ExternalID, opt => opt.MapFrom(src => src.tnst_ExternalID))
                .ForMember(dest => dest.tnst_ID, opt => opt.MapFrom(src => src.tnst_ID))
                .ForMember(dest => dest.abn_Balance, opt => opt.MapFrom(src => src.abn_Balance))
                .ForMember(dest => dest.abn_CreateDate, opt => opt.MapFrom(src => src.abn_CreateDate))
                .ForMember(dest => dest.abn_Date, opt => opt.MapFrom(src => src.abn_Date))
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
                .ForMember(dest => dest.abn_Guid, opt => opt.MapFrom(src => src.abn_Guid))
                .ForMember(dest => dest.abn_HasNotEmptyPrepaid, opt => opt.MapFrom(src => src.abn_HasNotEmptyPrepaid))
                .ForMember(dest => dest.dep_id_boss, opt => opt.MapFrom(src => src.dep_id_boss))
                .ForMember(dest => dest.dep_Name_boss, opt => opt.MapFrom(src => src.dep_Name_boss))
                .ForMember(dest => dest.isRefusalChangeName, opt => opt.MapFrom(src => src.isRefusalChangeName))
                .ForMember(dest => dest.max_ModDate, opt => opt.MapFrom(src => src.max_ModDate))
                .ForMember(dest => dest.vrr_ID, opt => opt.MapFrom(src => src.vrr_ID));
#endregion
            #region [Customers_Request_SET]->[SET_p_ucp_set_Customers_Request]
			//********************** DIRECT:    WebModel[Customers_Request_SET] -> CallModel[SET_p_ucp_set_Customers_Request] *************************************
			cfg.CreateMap<Customers_Request_SET, SET_p_ucp_set_Customers_Request>()
                .ForMember(dest => dest.Lng_ID, opt => opt.MapFrom(src => src.CustomerLanguageId))
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.Dep_ID, opt => opt.MapFrom(src => src.SegmentID))
                .ForMember(dest => dest.Abn_FirstName, opt => opt.MapFrom(src => src.Customer_FirstName))
                .ForMember(dest => dest.Abn_PositionCode, opt => opt.MapFrom(src => src.PositionCode))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.CustomerLogin))
                .ForMember(dest => dest.Abn_MiddleName, opt => opt.MapFrom(src => src.Customer_MiddleName))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.CustomerPassword))
                .ForMember(dest => dest.Abn_IsCreatedWithTariffication, opt => opt.MapFrom(src => src.IsCreatedWithTariffication))
                .ForMember(dest => dest.Abn_ShowPhoneDirectory, opt => opt.MapFrom(src => src.TechnicalTag))
                .ForMember(dest => dest.Abn_Employe_Export_ID, opt => opt.MapFrom(src => src.Export_ID))
                .ForMember(dest => dest.Abn_Employee_ID, opt => opt.MapFrom(src => src.SyncId))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Abn_Date, opt => opt.MapFrom(src => src.CustomerDate))
                .ForMember(dest => dest.UpdateAbonentTree, opt => opt.MapFrom(src => src.isUpdateNodeTree))
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.Customer_SearchName))
                .ForMember(dest => dest.Grp_ID, opt => opt.MapFrom(src => src.GroupID))
                .ForMember(dest => dest.Location_ID, opt => opt.MapFrom(src => src.LocationID))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.DebugLevel, opt => opt.MapFrom(src => src.DebugLevel))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.Sag_Code, opt => opt.MapFrom(src => src.AgentCode))
                .ForMember(dest => dest.Sag_ID, opt => opt.MapFrom(src => src.AgentID))
                .ForMember(dest => dest.Pos_Code, opt => opt.MapFrom(src => src.SalesPointCode))
                .ForMember(dest => dest.Pos_ID, opt => opt.MapFrom(src => src.SalesPointID))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Ntw_ID, opt => opt.MapFrom(src => src.NetworkID))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.Abn_ID_Boss, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System));
;
#endregion
            #region  [SET_p_ucp_set_Customers_Response->Customers_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_Customers_Response] -> WebModel[Customers_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_Customers_Response, Customers_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Abn_ID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID));
#endregion
            #region (Customers)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Customers_Request, GET_p_ucp_get_Customers_Response>();
            cfg.CreateMap<SET_p_ucp_set_Customers_Request, SET_p_ucp_set_Customers_Response>();
            #endregion
            #region [Customers_Activate_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request]
			//********************** DIRECT:    WebModel[Customers_Activate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request] *************************************
			cfg.CreateMap<Customers_Activate_Request_ACTION, ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request>()
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCode))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response->Customers_Activate_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response] -> WebModel[Customers_Activate_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response, Customers_Activate_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Customers/Activate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request, ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response>();
            #endregion
            #region [Customers_CalcCharges_Request_ACTION]->[ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request]
			//********************** DIRECT:    WebModel[Customers_CalcCharges_Request_ACTION] -> CallModel[ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request] *************************************
			cfg.CreateMap<Customers_CalcCharges_Request_ACTION, ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request>()
                .ForMember(dest => dest.ChargeCode, opt => opt.MapFrom(src => src.ChargeCode))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EmulateMode, opt => opt.MapFrom(src => src.EmulateMode))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Ext_ID, opt => opt.MapFrom(src => src.ExtentionID))
                .ForMember(dest => dest.ID_GroupATS, opt => opt.MapFrom(src => src.ID_GroupATS))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IsReCharge, opt => opt.MapFrom(src => src.IsReCharge))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Srv_ID, opt => opt.MapFrom(src => src.ServiceID))
                .ForMember(dest => dest.Srs_SessionID, opt => opt.MapFrom(src => src.Srs_SessionID));
;
#endregion
            #region  [ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response->Customers_CalcCharges_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response] -> WebModel[Customers_CalcCharges_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response, Customers_CalcCharges_Response_ACTION>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.WorkEventID, opt => opt.MapFrom(src => src.Wev_ID));
#endregion
            #region (Customers/CalcCharges)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request, ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response>();
            #endregion
            #region [Customers_ChangeName_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request]
			//********************** DIRECT:    WebModel[Customers_ChangeName_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request] *************************************
			cfg.CreateMap<Customers_ChangeName_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Abn_FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.SearchName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.toClean, opt => opt.MapFrom(src => src.ToClean));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response->Customers_ChangeName_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response] -> WebModel[Customers_ChangeName_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response, Customers_ChangeName_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Customers/ChangeName)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request, ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response>();
            #endregion
            #region [Customers_ChangeParent_Request_ACTION]->[ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request]
			//********************** DIRECT:    WebModel[Customers_ChangeParent_Request_ACTION] -> CallModel[ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request] *************************************
			cfg.CreateMap<Customers_ChangeParent_Request_ACTION, ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request>()
                .ForMember(dest => dest.ConfAccepted, opt => opt.MapFrom(src => src.ConfAccepted))
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Parent_ID, opt => opt.MapFrom(src => src.ParentNode))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_target_new, opt => opt.MapFrom(src => src.TargetStatusID));
;
#endregion
            #region  [ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response->Customers_ChangeParent_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response] -> WebModel[Customers_ChangeParent_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response, Customers_ChangeParent_Response_ACTION>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage));
#endregion
            #region (Customers/ChangeParent)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request, ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response>();
            #endregion
            #region [Customers_ChangeStatus_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request]
			//********************** DIRECT:    WebModel[Customers_ChangeStatus_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request] *************************************
			cfg.CreateMap<Customers_ChangeStatus_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfirmationMessage))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.ConfAccepted, opt => opt.MapFrom(src => src.UserAcceptance));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response->Customers_ChangeStatus_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response] -> WebModel[Customers_ChangeStatus_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response, Customers_ChangeStatus_Response_ACTION>()
                .ForMember(dest => dest.ConfirmationMessage, opt => opt.MapFrom(src => src.ConfMessage))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Customers/ChangeStatus)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request, ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response>();
            #endregion
            #region [Customers_Copy_Request_ACTION]->[ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request]
			//********************** DIRECT:    WebModel[Customers_Copy_Request_ACTION] -> CallModel[ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request] *************************************
			cfg.CreateMap<Customers_Copy_Request_ACTION, ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request>()
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.AccountNumber))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Wev_ID, opt => opt.MapFrom(src => src.WorkEventID));
;
#endregion
            #region  [ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response->Customers_Copy_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response] -> WebModel[Customers_Copy_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response, Customers_Copy_Response_ACTION>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.WorkEventID, opt => opt.MapFrom(src => src.Wev_ID));
#endregion
            #region (Customers/Copy)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request, ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response>();
            #endregion
            #region [Customers_CustomerExtentions_Request_GET]->[GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request]
			//********************** DIRECT:    WebModel[Customers_CustomerExtentions_Request_GET] -> CallModel[GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request] *************************************
			cfg.CreateMap<Customers_CustomerExtentions_Request_GET, GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request>()
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageNumber))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize));
;
#endregion
            #region [GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response->Customers_CustomerExtentions_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response] -> WebModel Response(Customers_CustomerExtentions_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response, Customers_CustomerExtentions_Response_GET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Customers_CustomerExtentions_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response_OUTPUT] -> WebModel Response Output(Customers_CustomerExtentions_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response_OUTPUT] -> WebModel Response Output(Customers_CustomerExtentions_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response_OUTPUT, Customers_CustomerExtentions_Response_GET_OUTPUT>()
                .ForMember(dest => dest.ext_ID, opt => opt.MapFrom(src => src.ext_ID))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ParentID, opt => opt.MapFrom(src => src.ParentID));
#endregion
            #region (Customers/CustomerExtentions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request, GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response>();
            #endregion
            #region [Customers_Deactivate_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request]
			//********************** DIRECT:    WebModel[Customers_Deactivate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request] *************************************
			cfg.CreateMap<Customers_Deactivate_Request_ACTION, ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_Code_crnt, opt => opt.MapFrom(src => src.StatusCode))
                .ForMember(dest => dest.Tnst_Code_trgt, opt => opt.MapFrom(src => src.TargetStatusCode));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response->Customers_Deactivate_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response] -> WebModel[Customers_Deactivate_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response, Customers_Deactivate_Response_ACTION>()
                .ForMember(dest => dest.AffectedCount, opt => opt.MapFrom(src => src.AffectedCount))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.WorkEventID, opt => opt.MapFrom(src => src.Wev_ID));
#endregion
            #region (Customers/Deactivate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request, ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response>();
            #endregion
            #region [Customers_Details_Request_GET]->[GET_p_ucp_get_CustomerByID_Customers_Details_Request]
			//********************** DIRECT:    WebModel[Customers_Details_Request_GET] -> CallModel[GET_p_ucp_get_CustomerByID_Customers_Details_Request] *************************************
			cfg.CreateMap<Customers_Details_Request_GET, GET_p_ucp_get_CustomerByID_Customers_Details_Request>()
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.CacheControlDate));
;
#endregion
            #region [GET_p_ucp_get_CustomerByID_Customers_Details_Response->Customers_Details_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_CustomerByID_Customers_Details_Response] -> WebModel Response(Customers_Details_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerByID_Customers_Details_Response, Customers_Details_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.CacheControlDate, opt => opt.MapFrom(src => src.IfModifiedSinceDate));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Customers_Details_Request_GET>()
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_CustomerByID_Customers_Details_Response_OUTPUT] -> WebModel Response Output(Customers_Details_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_CustomerByID_Customers_Details_Response_OUTPUT] -> WebModel Response Output(Customers_Details_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerByID_Customers_Details_Response_OUTPUT, Customers_Details_Response_GET_OUTPUT>()
                .ForMember(dest => dest.abc_Date_Personal, opt => opt.MapFrom(src => src.abc_Date_Personal))
                .ForMember(dest => dest.abn_Balance, opt => opt.MapFrom(src => src.abn_Balance))
                .ForMember(dest => dest.abn_CreateDate, opt => opt.MapFrom(src => src.abn_CreateDate))
                .ForMember(dest => dest.abn_Date, opt => opt.MapFrom(src => src.abn_Date))
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
                .ForMember(dest => dest.abn_Guid, opt => opt.MapFrom(src => src.abn_Guid))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.abn_ID_Boss, opt => opt.MapFrom(src => src.abn_ID_Boss))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_IsGuest, opt => opt.MapFrom(src => src.abn_IsGuest))
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
                .ForMember(dest => dest.abn_ModifiedDate, opt => opt.MapFrom(src => src.abn_ModifiedDate))
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
                .ForMember(dest => dest.abn_NestedSets_Left, opt => opt.MapFrom(src => src.abn_NestedSets_Left))
                .ForMember(dest => dest.abn_NestedSets_Right, opt => opt.MapFrom(src => src.abn_NestedSets_Right))
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
                .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => opt.MapFrom(src => src.abn_ShowPhoneDirectory))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.abn_WorkPlace_Personal, opt => opt.MapFrom(src => src.abn_WorkPlace_Personal))
                .ForMember(dest => dest.abn_XmlData, opt => opt.MapFrom(src => src.abn_XmlData))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.acnt_ID_count, opt => opt.MapFrom(src => src.acnt_ID_count))
                .ForMember(dest => dest.acnt_IsPersonal, opt => opt.MapFrom(src => src.acnt_IsPersonal))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.Actpd_Name, opt => opt.MapFrom(src => src.Actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
                .ForMember(dest => dest.atnsb_DateEnd, opt => opt.MapFrom(src => src.atnsb_DateEnd))
                .ForMember(dest => dest.atnsb_DateStart, opt => opt.MapFrom(src => src.atnsb_DateStart))
                .ForMember(dest => dest.aut_ID_count, opt => opt.MapFrom(src => src.aut_ID_count))
                .ForMember(dest => dest.abb_Balance, opt => opt.MapFrom(src => src.abb_Balance))
                .ForMember(dest => dest.abb_Balance_Personal, opt => opt.MapFrom(src => src.abb_Balance_Personal))
                .ForMember(dest => dest.abb_ModifiedDate, opt => opt.MapFrom(src => src.abb_ModifiedDate))
                .ForMember(dest => dest.abb_ModifiedDate_Personal, opt => opt.MapFrom(src => src.abb_ModifiedDate_Personal))
                .ForMember(dest => dest.abc_Balance, opt => opt.MapFrom(src => src.abc_Balance))
                .ForMember(dest => dest.abc_Balance_Personal, opt => opt.MapFrom(src => src.abc_Balance_Personal))
                .ForMember(dest => dest.abc_Date, opt => opt.MapFrom(src => src.abc_Date))
                .ForMember(dest => dest.Boss_Tnt_Type, opt => opt.MapFrom(src => src.Boss_Tnt_Type))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
                .ForMember(dest => dest.com_Id, opt => opt.MapFrom(src => src.com_Id))
                .ForMember(dest => dest.debt_Amount, opt => opt.MapFrom(src => src.debt_Amount))
                .ForMember(dest => dest.debt_Date, opt => opt.MapFrom(src => src.debt_Date))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.ext_ID_count, opt => opt.MapFrom(src => src.ext_ID_count))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
                .ForMember(dest => dest.isActivated, opt => opt.MapFrom(src => src.isActivated))
                .ForMember(dest => dest.isEditAllow, opt => opt.MapFrom(src => src.isEditAllow))
                .ForMember(dest => dest.isEditWorkPlace, opt => opt.MapFrom(src => src.isEditWorkPlace))
                .ForMember(dest => dest.lng_ID, opt => opt.MapFrom(src => src.lng_ID))
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
                .ForMember(dest => dest.Location_ID, opt => opt.MapFrom(src => src.Location_ID))
                .ForMember(dest => dest.ntw_ID, opt => opt.MapFrom(src => src.ntw_ID))
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.SubsCount, opt => opt.MapFrom(src => src.SubsCount))
                .ForMember(dest => dest.tnh_LastFM, opt => opt.MapFrom(src => src.tnh_LastFM))
                .ForMember(dest => dest.tnt_AccountMandatory, opt => opt.MapFrom(src => src.tnt_AccountMandatory))
                .ForMember(dest => dest.tnt_ID, opt => opt.MapFrom(src => src.tnt_ID))
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.tnst_ID, opt => opt.MapFrom(src => src.tnst_ID))
                .ForMember(dest => dest.tnst_ExternalID, opt => opt.MapFrom(src => src.tnst_ExternalID))
                .ForMember(dest => dest.isRefusalChangeName, opt => opt.MapFrom(src => src.isRefusalChangeName));
#endregion
            #region (Customers/Details)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerByID_Customers_Details_Request, GET_p_ucp_get_CustomerByID_Customers_Details_Response>();
            #endregion
            #region [Customers_postponeInvoice_Request_ACTION]->[ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request]
			//********************** DIRECT:    WebModel[Customers_postponeInvoice_Request_ACTION] -> CallModel[ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request] *************************************
			cfg.CreateMap<Customers_postponeInvoice_Request_ACTION, ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request>()
                .ForMember(dest => dest.DateLimit, opt => opt.MapFrom(src => src.DateLimit))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark));
;
#endregion
            #region (Customers/postponeInvoice)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            #endregion
            #region [Customers_SetLabels_Request_ACTION]->[ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request]
			//********************** DIRECT:    WebModel[Customers_SetLabels_Request_ACTION] -> CallModel[ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request] *************************************
			cfg.CreateMap<Customers_SetLabels_Request_ACTION, ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.LinkedServer, opt => opt.MapFrom(src => src.LinkedServer))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.SourceQuery, opt => opt.MapFrom(src => src.SourceQuery));
;
#endregion
            #region  [ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response->Customers_SetLabels_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response] -> WebModel[Customers_SetLabels_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response, Customers_SetLabels_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Customers/SetLabels)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request, ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response>();
            #endregion
            #endregion
            #region [CustomerTypes]
            #region [CustomerTypes_Request_GET]->[GET_p_ucp_get_CustomerTypes_Request]
			//********************** DIRECT:    WebModel[CustomerTypes_Request_GET] -> CallModel[GET_p_ucp_get_CustomerTypes_Request] *************************************
			cfg.CreateMap<CustomerTypes_Request_GET, GET_p_ucp_get_CustomerTypes_Request>()
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
;
#endregion
            #region [GET_p_ucp_get_CustomerTypes_Response->CustomerTypes_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_CustomerTypes_Response] -> WebModel Response(CustomerTypes_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerTypes_Response, CustomerTypes_Response_GET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, CustomerTypes_Request_GET>()
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_CustomerTypes_Response_OUTPUT] -> WebModel Response Output(CustomerTypes_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_CustomerTypes_Response_OUTPUT] -> WebModel Response Output(CustomerTypes_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerTypes_Response_OUTPUT, CustomerTypes_Response_GET_OUTPUT>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.AccountTypeID))
                .ForMember(dest => dest.AccountTypeName, opt => opt.MapFrom(src => src.AccountTypeName))
                .ForMember(dest => dest.Idtype, opt => opt.MapFrom(src => src.Idtype));
#endregion
            #region (CustomerTypes)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerTypes_Request, GET_p_ucp_get_CustomerTypes_Response>();
            #endregion
            #endregion
            #region [Discounts]
            #region [Discounts_Request_SET]->[SET_p_ucp_set_DiscountAbonentBind_Request]
			//********************** DIRECT:    WebModel[Discounts_Request_SET] -> CallModel[SET_p_ucp_set_DiscountAbonentBind_Request] *************************************
			cfg.CreateMap<Discounts_Request_SET, SET_p_ucp_set_DiscountAbonentBind_Request>()
                .ForMember(dest => dest.DateSet, opt => opt.MapFrom(src => src.DateSet))
                .ForMember(dest => dest.dsc_ID, opt => opt.MapFrom(src => src.DiscountID))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.isAnnul, opt => opt.MapFrom(src => src.isAnnul))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.dab_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
;
#endregion
            #region  [SET_p_ucp_set_DiscountAbonentBind_Response->Discounts_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_DiscountAbonentBind_Response] -> WebModel[Discounts_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_DiscountAbonentBind_Response, Discounts_Response_SET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.dab_ID));
#endregion
            #region (Discounts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_DiscountAbonentBind_Request, SET_p_ucp_set_DiscountAbonentBind_Response>();
            #endregion
            #endregion
            #region [Environment]
            #region [Environment_Request_GET]->[GET_p_ucp_get_Variables_Request]
			//********************** DIRECT:    WebModel[Environment_Request_GET] -> CallModel[GET_p_ucp_get_Variables_Request] *************************************
			cfg.CreateMap<Environment_Request_GET, GET_p_ucp_get_Variables_Request>()
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.var_Name, opt => opt.MapFrom(src => src.var_Name))
                .ForMember(dest => dest.var_Group, opt => opt.MapFrom(src => src.var_Group));
;
#endregion
            #region [GET_p_ucp_get_Variables_Response->Environment_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_Variables_Response] -> WebModel Response(Environment_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Variables_Response, Environment_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Environment_Request_GET>()
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_Variables_Response_OUTPUT] -> WebModel Response Output(Environment_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_Variables_Response_OUTPUT] -> WebModel Response Output(Environment_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Variables_Response_OUTPUT, Environment_Response_GET_OUTPUT>()
                .ForMember(dest => dest.var_Description, opt => opt.MapFrom(src => src.var_Description))
                .ForMember(dest => dest.var_Error, opt => opt.MapFrom(src => src.var_Error))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.var_Name))
                .ForMember(dest => dest.var_Value, opt => opt.MapFrom(src => src.var_Value))
                .ForMember(dest => dest.var_ValueDatetime, opt => opt.MapFrom(src => src.var_ValueDatetime))
                .ForMember(dest => dest.var_ValueDecimal, opt => opt.MapFrom(src => src.var_ValueDecimal))
                .ForMember(dest => dest.var_ValueInt, opt => opt.MapFrom(src => src.var_ValueInt))
                .ForMember(dest => dest.ddat, opt => opt.MapFrom(src => src.ddat))
                .ForMember(dest => dest.ddec, opt => opt.MapFrom(src => src.ddec))
                .ForMember(dest => dest.dint, opt => opt.MapFrom(src => src.dint))
                .ForMember(dest => dest.dstr, opt => opt.MapFrom(src => src.dstr))
                .ForMember(dest => dest.var_Group, opt => opt.MapFrom(src => src.var_Group));
#endregion
            #region (Environment)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Variables_Request, GET_p_ucp_get_Variables_Response>();
            #endregion
            #endregion
            #region [Extentions]
            #region [Extentions_Request_SET]->[SET_p_ucp_set_SubscriberExtentions_Request]
			//********************** DIRECT:    WebModel[Extentions_Request_SET] -> CallModel[SET_p_ucp_set_SubscriberExtentions_Request] *************************************
			cfg.CreateMap<Extentions_Request_SET, SET_p_ucp_set_SubscriberExtentions_Request>()
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.ModifiedDateExst, opt => opt.MapFrom(src => src.StatusModifiedDate))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModifiedFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.XmlDataFormat, opt => opt.MapFrom(src => src.XmlDataFormat))
                .ForMember(dest => dest.Ext_ID, opt => opt.MapFrom(src => src.ExtentionID))
                .ForMember(dest => dest.Ext_ExternalID, opt => opt.MapFrom(src => src.ExternalID))
                .ForMember(dest => dest.Ext_XmlData, opt => opt.MapFrom(src => src.XmlData))
                .ForMember(dest => dest.Exct_ID, opt => opt.MapFrom(src => src.CategoryID))
                .ForMember(dest => dest.Excl_ID, opt => opt.MapFrom(src => src.ClassID))
                .ForMember(dest => dest.Exst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.Extp_ID, opt => opt.MapFrom(src => src.TypeID))
                .ForMember(dest => dest.Cpt_ID, opt => opt.MapFrom(src => src.ConnectionPointID))
                .ForMember(dest => dest.NumberAts, opt => opt.MapFrom(src => src.NumberAts))
                .ForMember(dest => dest.Ext_ExtNum, opt => opt.MapFrom(src => src.ExtentionNumber))
                .ForMember(dest => dest.Ext_IsCreatedWithTariffication, opt => opt.MapFrom(src => src.IsCreatedWithTariffication))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.DebugLevel, opt => opt.MapFrom(src => src.DebugLevel))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Eab_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ext_ShowPhoneDirectory, opt => opt.MapFrom(src => src.ext_ShowPhoneDirectory))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.ModifiedDate));
;
#endregion
            #region  [SET_p_ucp_set_SubscriberExtentions_Response->Extentions_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_SubscriberExtentions_Response] -> WebModel[Extentions_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_SubscriberExtentions_Response, Extentions_Response_SET>()
                .ForMember(dest => dest.ExtentionID, opt => opt.MapFrom(src => src.Ext_ID))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Eab_ID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID));
#endregion
            #region (Extentions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_SubscriberExtentions_Request, SET_p_ucp_set_SubscriberExtentions_Response>();
            #endregion
            #endregion
            #region [Gains]
            #region [Gains_Request_SET]->[SET_p_ucp_set_AccountCredits_Request]
			//********************** DIRECT:    WebModel[Gains_Request_SET] -> CallModel[SET_p_ucp_set_AccountCredits_Request] *************************************
			cfg.CreateMap<Gains_Request_SET, SET_p_ucp_set_AccountCredits_Request>()
                .ForMember(dest => dest.Accrr_Code, opt => opt.MapFrom(src => src.ReasonCode))
                .ForMember(dest => dest.Ctpro_Code, opt => opt.MapFrom(src => src.ProgrammCode))
                .ForMember(dest => dest.Accr_Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Crtp_Code, opt => opt.MapFrom(src => src.TypeCode))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Accr_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Accr_Break, opt => opt.MapFrom(src => src.Accr_Break))
                .ForMember(dest => dest.Accr_Warning, opt => opt.MapFrom(src => src.Accr_Warning));
;
#endregion
            #region  [SET_p_ucp_set_AccountCredits_Response->Gains_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_AccountCredits_Response] -> WebModel[Gains_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_AccountCredits_Response, Gains_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Accr_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Gains)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_AccountCredits_Request, SET_p_ucp_set_AccountCredits_Response>();
            #endregion
            #endregion
            #region [Memberships]
            #region [Memberships_Request_SET]->[SET_p_ucp_set_CodeRegions_Memberships_Request]
			//********************** DIRECT:    WebModel[Memberships_Request_SET] -> CallModel[SET_p_ucp_set_CodeRegions_Memberships_Request] *************************************
			cfg.CreateMap<Memberships_Request_SET, SET_p_ucp_set_CodeRegions_Memberships_Request>()
                .ForMember(dest => dest.IncludeNumbers, opt => opt.MapFrom(src => src.IncludeNumbers))
                .ForMember(dest => dest.Cds_FullCode, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Cds_IsRemoved, opt => opt.MapFrom(src => src.IsRemoved))
                .ForMember(dest => dest.Crg_ID, opt => opt.MapFrom(src => src.GroupID))
                .ForMember(dest => dest.Crgb_DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.Crgb_DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Crgb_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Cds_CityAddCode, opt => opt.MapFrom(src => src.Cds_CityAddCode))
                .ForMember(dest => dest.Cds_CityCode, opt => opt.MapFrom(src => src.Cds_CityCode))
                .ForMember(dest => dest.Cds_CountryCode, opt => opt.MapFrom(src => src.Cds_CountryCode))
                .ForMember(dest => dest.Cds_ID, opt => opt.MapFrom(src => src.Cds_ID))
                .ForMember(dest => dest.Cds_Name, opt => opt.MapFrom(src => src.Cds_Name))
                .ForMember(dest => dest.Crg_RegionNameEN, opt => opt.MapFrom(src => src.Crg_RegionNameEN));
;
#endregion
            #region  [SET_p_ucp_set_CodeRegions_Memberships_Response->Memberships_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_CodeRegions_Memberships_Response] -> WebModel[Memberships_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_CodeRegions_Memberships_Response, Memberships_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Crgb_ID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Cds_ID, opt => opt.MapFrom(src => src.Cds_ID));
#endregion
            #region (Memberships)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_CodeRegions_Memberships_Request, SET_p_ucp_set_CodeRegions_Memberships_Response>();
            #endregion
            #endregion
            #region [Networks]
            #region [Networks_Request_GET]->[GET_p_ucp_get_Networks_Request]
			//********************** DIRECT:    WebModel[Networks_Request_GET] -> CallModel[GET_p_ucp_get_Networks_Request] *************************************
			cfg.CreateMap<Networks_Request_GET, GET_p_ucp_get_Networks_Request>()
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Ntw_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Ntwd_Name, opt => opt.MapFrom(src => src.NetworkName))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize));
;
#endregion
            #region [GET_p_ucp_get_Networks_Response->Networks_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_Networks_Response] -> WebModel Response(Networks_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Networks_Response, Networks_Response_GET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Networks_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageIndex, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_Networks_Response_OUTPUT] -> WebModel Response Output(Networks_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_Networks_Response_OUTPUT] -> WebModel Response Output(Networks_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Networks_Response_OUTPUT, Networks_Response_GET_OUTPUT>()
                .ForMember(dest => dest.NameATS, opt => opt.MapFrom(src => src.NameATS))
                .ForMember(dest => dest.NetworkExternalID, opt => opt.MapFrom(src => src.ntw_ExternalID))
                .ForMember(dest => dest.NetworkID, opt => opt.MapFrom(src => src.ntw_ID))
                .ForMember(dest => dest.NetworkName, opt => opt.MapFrom(src => src.ntwd_Name))
                .ForMember(dest => dest.NumberATS, opt => opt.MapFrom(src => src.NumberATS));
#endregion
            #region (Networks)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Networks_Request, GET_p_ucp_get_Networks_Response>();
            #endregion
            #region [Networks_ClearLogins_Request_ACTION]->[ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request]
			//********************** DIRECT:    WebModel[Networks_ClearLogins_Request_ACTION] -> CallModel[ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request] *************************************
			cfg.CreateMap<Networks_ClearLogins_Request_ACTION, ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request>()
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ntw_id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModifiedFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.NewLoginSource, opt => opt.MapFrom(src => src.NewLoginSource))
                .ForMember(dest => dest.NewPassword, opt => opt.MapFrom(src => src.NewPassword))
                .ForMember(dest => dest.RegExpValue, opt => opt.MapFrom(src => src.RegExpValue))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark));
;
#endregion
            #region  [ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response->Networks_ClearLogins_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response] -> WebModel[Networks_ClearLogins_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response, Networks_ClearLogins_Response_ACTION>()
                .ForMember(dest => dest.AffectedCount, opt => opt.MapFrom(src => src.UpdatedAbnCount))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Networks/ClearLogins)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request, ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response>();
            #endregion
            #endregion
            #region [PaymentDocuments]
            #region [PaymentDocuments_Request_SET]->[SET_p_ucp_set_PayDocs_Request]
			//********************** DIRECT:    WebModel[PaymentDocuments_Request_SET] -> CallModel[SET_p_ucp_set_PayDocs_Request] *************************************
			cfg.CreateMap<PaymentDocuments_Request_SET, SET_p_ucp_set_PayDocs_Request>()
                .ForMember(dest => dest.Cpd_PayDate, opt => opt.MapFrom(src => src.PayDate))
                .ForMember(dest => dest.Pre_DateReestr, opt => opt.MapFrom(src => src.ReestrDate))
                .ForMember(dest => dest.Cpd_AnnulDate, opt => opt.MapFrom(src => src.AnnulDate))
                .ForMember(dest => dest.Cpd_ExportedDate, opt => opt.MapFrom(src => src.ExportedDate))
                .ForMember(dest => dest.Cpd_Moved, opt => opt.MapFrom(src => src.Moved))
                .ForMember(dest => dest.Cpd_Annul, opt => opt.MapFrom(src => src.Annul))
                .ForMember(dest => dest.Pre_ExternalID, opt => opt.MapFrom(src => src.ReestrID))
                .ForMember(dest => dest.Bnk_ID, opt => opt.MapFrom(src => src.BankID))
                .ForMember(dest => dest.Cof_ID, opt => opt.MapFrom(src => src.KassaID))
                .ForMember(dest => dest.Loc_ID, opt => opt.MapFrom(src => src.LocationID))
                .ForMember(dest => dest.Cpc_ID, opt => opt.MapFrom(src => src.PayClass))
                .ForMember(dest => dest.Pre_NumReestr, opt => opt.MapFrom(src => src.ReestrNumber))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.AccountNumber))
                .ForMember(dest => dest.Cpd_AnnulBy, opt => opt.MapFrom(src => src.AnnulBy))
                .ForMember(dest => dest.Cpif_ID, opt => opt.MapFrom(src => src.PayInterfaceID))
                .ForMember(dest => dest.Crn_CodeISO, opt => opt.MapFrom(src => src.CurrencyCode))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Cpd_Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.Cpd_PayEffDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Cpd_DesPhone, opt => opt.MapFrom(src => src.ExtentionNumber))
                .ForMember(dest => dest.Bac_ID, opt => opt.MapFrom(src => src.BankAccountID))
                .ForMember(dest => dest.Cpd_DealerId, opt => opt.MapFrom(src => src.DealerId))
                .ForMember(dest => dest.Cpd_PayDocNumber, opt => opt.MapFrom(src => src.PayDocNumber))
                .ForMember(dest => dest.Cpd_ExportID, opt => opt.MapFrom(src => src.ExportID))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.cacheStatus, opt => opt.MapFrom(src => src.cacheStatus))
                .ForMember(dest => dest.Cpd_ExternalID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
;
#endregion
            #region  [SET_p_ucp_set_PayDocs_Response->PaymentDocuments_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_PayDocs_Response] -> WebModel[PaymentDocuments_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_PayDocs_Response, PaymentDocuments_Response_SET>()
                .ForMember(dest => dest.global_unique_id, opt => opt.MapFrom(src => src.Cpd_ExternalID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID));
#endregion
            #region (PaymentDocuments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_PayDocs_Request, SET_p_ucp_set_PayDocs_Response>();
            #endregion
            #endregion
            #region [PaymentRegistry]
            #region [PaymentRegistry_Request_GET]->[GET_p_ucp_get_PayReestres_Request]
			//********************** DIRECT:    WebModel[PaymentRegistry_Request_GET] -> CallModel[GET_p_ucp_get_PayReestres_Request] *************************************
			cfg.CreateMap<PaymentRegistry_Request_GET, GET_p_ucp_get_PayReestres_Request>()
                .ForMember(dest => dest.bac_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.bnk_ID, opt => opt.MapFrom(src => src.bnk_ID))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.pre_ExternalID, opt => opt.MapFrom(src => src.pre_ExternalID));
;
#endregion
            #region [GET_p_ucp_get_PayReestres_Response->PaymentRegistry_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_PayReestres_Response] -> WebModel Response(PaymentRegistry_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_PayReestres_Response, PaymentRegistry_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, PaymentRegistry_Request_GET>()
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_PayReestres_Response_OUTPUT] -> WebModel Response Output(PaymentRegistry_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_PayReestres_Response_OUTPUT] -> WebModel Response Output(PaymentRegistry_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_PayReestres_Response_OUTPUT, PaymentRegistry_Response_GET_OUTPUT>()
                .ForMember(dest => dest.pre_ExternalID, opt => opt.MapFrom(src => src.pre_ExternalID))
                .ForMember(dest => dest.pre_DateReestr, opt => opt.MapFrom(src => src.pre_DateReestr))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.pre_ID))
                .ForMember(dest => dest.pre_NumReestr, opt => opt.MapFrom(src => src.pre_NumReestr))
                .ForMember(dest => dest.bac_ID, opt => opt.MapFrom(src => src.bac_ID))
                .ForMember(dest => dest.bnk_ID, opt => opt.MapFrom(src => src.bnk_ID));
#endregion
            #region [PaymentRegistry_Request_SET]->[SET_p_ucp_set_PayReestres_Request]
			//********************** DIRECT:    WebModel[PaymentRegistry_Request_SET] -> CallModel[SET_p_ucp_set_PayReestres_Request] *************************************
			cfg.CreateMap<PaymentRegistry_Request_SET, SET_p_ucp_set_PayReestres_Request>()
                .ForMember(dest => dest.bac_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.crn_CodeISO, opt => opt.MapFrom(src => src.crn_CodeISO))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.pre_DateReestr, opt => opt.MapFrom(src => src.pre_DateReestr))
                .ForMember(dest => dest.pre_ExternalID, opt => opt.MapFrom(src => src.pre_ExternalID))
                .ForMember(dest => dest.pre_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.pre_NumReestr, opt => opt.MapFrom(src => src.pre_NumReestr))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.bnk_ID, opt => opt.MapFrom(src => src.bnk_ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
;
#endregion
            #region  [SET_p_ucp_set_PayReestres_Response->PaymentRegistry_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_PayReestres_Response] -> WebModel[PaymentRegistry_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_PayReestres_Response, PaymentRegistry_Response_SET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.pre_ID))
                .ForMember(dest => dest.bnk_ID, opt => opt.MapFrom(src => src.bnk_ID));
#endregion
            #region (PaymentRegistry)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_PayReestres_Request, GET_p_ucp_get_PayReestres_Response>();
            cfg.CreateMap<SET_p_ucp_set_PayReestres_Request, SET_p_ucp_set_PayReestres_Response>();
            #endregion
            #endregion
            #region [PhoneNumbers]
            #region [PhoneNumbers_Request_SET]->[SET_p_ucp_set_CodeRegions_PhoneNumbers_Request]
			//********************** DIRECT:    WebModel[PhoneNumbers_Request_SET] -> CallModel[SET_p_ucp_set_CodeRegions_PhoneNumbers_Request] *************************************
			cfg.CreateMap<PhoneNumbers_Request_SET, SET_p_ucp_set_CodeRegions_PhoneNumbers_Request>()
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.Cds_FullCode, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Cds_IsRemoved, opt => opt.MapFrom(src => src.IsRemoved))
                .ForMember(dest => dest.Crgb_DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.Crgb_DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Crgb_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Crg_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Cds_CityAddCode, opt => opt.MapFrom(src => src.Cds_CityAddCode))
                .ForMember(dest => dest.Cds_CityCode, opt => opt.MapFrom(src => src.Cds_CityCode))
                .ForMember(dest => dest.Cds_CountryCode, opt => opt.MapFrom(src => src.Cds_CountryCode))
                .ForMember(dest => dest.Cds_ID, opt => opt.MapFrom(src => src.Cds_ID))
                .ForMember(dest => dest.Cds_Name, opt => opt.MapFrom(src => src.Cds_Name))
                .ForMember(dest => dest.Crg_RegionNameEN, opt => opt.MapFrom(src => src.Crg_RegionNameEN));
;
#endregion
            #region  [SET_p_ucp_set_CodeRegions_PhoneNumbers_Response->PhoneNumbers_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_CodeRegions_PhoneNumbers_Response] -> WebModel[PhoneNumbers_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_CodeRegions_PhoneNumbers_Response, PhoneNumbers_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Crgb_ID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Cds_ID, opt => opt.MapFrom(src => src.Cds_ID));
#endregion
            #region (PhoneNumbers)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_CodeRegions_PhoneNumbers_Request, SET_p_ucp_set_CodeRegions_PhoneNumbers_Response>();
            #endregion
            #endregion
            #region [PortabilityNumbers]
            #region [PortabilityNumbers_Request_SET]->[SET_p_ucp_set_CodeRegions_Request]
			//********************** DIRECT:    WebModel[PortabilityNumbers_Request_SET] -> CallModel[SET_p_ucp_set_CodeRegions_Request] *************************************
			cfg.CreateMap<PortabilityNumbers_Request_SET, SET_p_ucp_set_CodeRegions_Request>()
                .ForMember(dest => dest.Cds_FullCode, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Cds_IsRemoved, opt => opt.MapFrom(src => src.IsRemoved))
                .ForMember(dest => dest.Crgb_DateStart, opt => opt.MapFrom(src => src.PortedDate))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Crg_RegionNameEN, opt => opt.MapFrom(src => src.RecipientRC))
                .ForMember(dest => dest.Crgb_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.Abn_ID))
                .ForMember(dest => dest.Cds_CityAddCode, opt => opt.MapFrom(src => src.Cds_CityAddCode))
                .ForMember(dest => dest.Cds_CityCode, opt => opt.MapFrom(src => src.Cds_CityCode))
                .ForMember(dest => dest.Cds_CountryCode, opt => opt.MapFrom(src => src.Cds_CountryCode))
                .ForMember(dest => dest.Cds_ID, opt => opt.MapFrom(src => src.Cds_ID))
                .ForMember(dest => dest.Cds_Name, opt => opt.MapFrom(src => src.Cds_Name))
                .ForMember(dest => dest.Crg_ID, opt => opt.MapFrom(src => src.Crg_ID))
                .ForMember(dest => dest.Crgb_DateEnd, opt => opt.MapFrom(src => src.Crgb_DateEnd))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IncludeNumbers, opt => opt.MapFrom(src => src.IncludeNumbers));
;
#endregion
            #region  [SET_p_ucp_set_CodeRegions_Response->PortabilityNumbers_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_CodeRegions_Response] -> WebModel[PortabilityNumbers_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_CodeRegions_Response, PortabilityNumbers_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Crgb_ID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Cds_ID, opt => opt.MapFrom(src => src.Cds_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID));
#endregion
            #region (PortabilityNumbers)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_CodeRegions_Request, SET_p_ucp_set_CodeRegions_Response>();
            #endregion
            #endregion
            #region [Profiles]
            #region [Profiles_Request_SET]->[SET_p_ucp_set_Profiles_Request]
			//********************** DIRECT:    WebModel[Profiles_Request_SET] -> CallModel[SET_p_ucp_set_Profiles_Request] *************************************
			cfg.CreateMap<Profiles_Request_SET, SET_p_ucp_set_Profiles_Request>()
                .ForMember(dest => dest.JsonData, opt => opt.MapFrom(src => src.Attributes))
                .ForMember(dest => dest.vrr_ID, opt => opt.MapFrom(src => src.IdentityType))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.tnv_ID, opt => opt.MapFrom(src => src.TemplateID))
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.aatr_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom));
;
#endregion
            #region  [SET_p_ucp_set_Profiles_Response->Profiles_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_Profiles_Response] -> WebModel[Profiles_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_Profiles_Response, Profiles_Response_SET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.aatr_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID));
#endregion
            #region (Profiles)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_Profiles_Request, SET_p_ucp_set_Profiles_Response>();
            #endregion
            #endregion
            #region [RatingData]
            #region [RatingData_Request_SET]->[SET_p_ucp_set_ServiceReservations_Request]
			//********************** DIRECT:    WebModel[RatingData_Request_SET] -> CallModel[SET_p_ucp_set_ServiceReservations_Request] *************************************
			cfg.CreateMap<RatingData_Request_SET, SET_p_ucp_set_ServiceReservations_Request>()
                .ForMember(dest => dest.beginTimeStamp, opt => opt.MapFrom(src => src.beginTimeStamp))
                .ForMember(dest => dest.CheckBalanceMode, opt => opt.MapFrom(src => src.CheckBalanceMode))
                .ForMember(dest => dest.consumedUnit, opt => opt.MapFrom(src => src.consumedUnit))
                .ForMember(dest => dest.destinationIdData, opt => opt.MapFrom(src => src.destinationIdData))
                .ForMember(dest => dest.destinationIdType, opt => opt.MapFrom(src => src.destinationIdType))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.srsv_UniqueID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.invocationTimeStamp, opt => opt.MapFrom(src => src.invocationTimeStamp))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.nfConsumerIdentification, opt => opt.MapFrom(src => src.nfConsumerIdentification))
                .ForMember(dest => dest.oneTimeEvent, opt => opt.MapFrom(src => src.oneTimeEvent))
                .ForMember(dest => dest.oneTimeEventType, opt => opt.MapFrom(src => src.oneTimeEventType))
                .ForMember(dest => dest.ratingGroup, opt => opt.MapFrom(src => src.ratingGroup))
                .ForMember(dest => dest.requestedUnit, opt => opt.MapFrom(src => src.requestedUnit))
                .ForMember(dest => dest.requestSubType, opt => opt.MapFrom(src => src.requestSubType))
                .ForMember(dest => dest.serviceContextId, opt => opt.MapFrom(src => src.serviceContextId))
                .ForMember(dest => dest.serviceId, opt => opt.MapFrom(src => src.serviceId))
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
                .ForMember(dest => dest.srsv_ID, opt => opt.MapFrom(src => src.srsv_ID))
                .ForMember(dest => dest.srsv_LinkID, opt => opt.MapFrom(src => src.srsv_LinkID))
                .ForMember(dest => dest.srsv_Remark, opt => opt.MapFrom(src => src.srsv_Remark))
                .ForMember(dest => dest.subscriptionId, opt => opt.MapFrom(src => src.subscriptionId))
                .ForMember(dest => dest.invocationSequenceNumber, opt => opt.MapFrom(src => src.invocationSequenceNumber))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.location, opt => opt.MapFrom(src => src.location));
;
#endregion
            #region  [SET_p_ucp_set_ServiceReservations_Response->RatingData_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_ServiceReservations_Response] -> WebModel[RatingData_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_ServiceReservations_Response, RatingData_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.srsv_UniqueID))
                .ForMember(dest => dest.invocationTimeStamp, opt => opt.MapFrom(src => src.invocationTimeStamp))
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
                .ForMember(dest => dest.srsv_ID, opt => opt.MapFrom(src => src.srsv_ID))
                .ForMember(dest => dest.srsv_LinkID, opt => opt.MapFrom(src => src.srsv_LinkID))
                .ForMember(dest => dest.invocationSequenceNumber, opt => opt.MapFrom(src => src.invocationSequenceNumber))
                .ForMember(dest => dest.location, opt => opt.MapFrom(src => src.location));
#endregion
            #region (RatingData)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_ServiceReservations_Request, SET_p_ucp_set_ServiceReservations_Response>();
            #endregion
            #region [RatingData_Release_Request_ACTION]->[ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request]
			//********************** DIRECT:    WebModel[RatingData_Release_Request_ACTION] -> CallModel[ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request] *************************************
			cfg.CreateMap<RatingData_Release_Request_ACTION, ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request>()
                .ForMember(dest => dest.beginTimeStamp, opt => opt.MapFrom(src => src.beginTimeStamp))
                .ForMember(dest => dest.CheckBalanceMode, opt => opt.MapFrom(src => src.CheckBalanceMode))
                .ForMember(dest => dest.consumedUnit, opt => opt.MapFrom(src => src.consumedUnit))
                .ForMember(dest => dest.destinationIdData, opt => opt.MapFrom(src => src.destinationIdData))
                .ForMember(dest => dest.destinationIdType, opt => opt.MapFrom(src => src.destinationIdType))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.invocationSequenceNumber, opt => opt.MapFrom(src => src.invocationSequenceNumber))
                .ForMember(dest => dest.invocationTimeStamp, opt => opt.MapFrom(src => src.invocationTimeStamp))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.nfConsumerIdentification, opt => opt.MapFrom(src => src.nfConsumerIdentification))
                .ForMember(dest => dest.srsv_UniqueID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ratingGroup, opt => opt.MapFrom(src => src.ratingGroup))
                .ForMember(dest => dest.requestedUnit, opt => opt.MapFrom(src => src.requestedUnit))
                .ForMember(dest => dest.requestSubType, opt => opt.MapFrom(src => src.requestSubType))
                .ForMember(dest => dest.serviceContextId, opt => opt.MapFrom(src => src.serviceContextId))
                .ForMember(dest => dest.serviceId, opt => opt.MapFrom(src => src.serviceId))
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
                .ForMember(dest => dest.srsv_ID, opt => opt.MapFrom(src => src.srsv_ID))
                .ForMember(dest => dest.srsv_LinkID, opt => opt.MapFrom(src => src.srsv_LinkID))
                .ForMember(dest => dest.srsv_Remark, opt => opt.MapFrom(src => src.srsv_Remark))
                .ForMember(dest => dest.subscriptionId, opt => opt.MapFrom(src => src.subscriptionId));
;
#endregion
            #region  [ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response->RatingData_Release_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response] -> WebModel[RatingData_Release_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response, RatingData_Release_Response_ACTION>()
                .ForMember(dest => dest.invocationSequenceNumber, opt => opt.MapFrom(src => src.invocationSequenceNumber))
                .ForMember(dest => dest.invocationTimeStamp, opt => opt.MapFrom(src => src.invocationTimeStamp))
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
                .ForMember(dest => dest.srsv_ID, opt => opt.MapFrom(src => src.srsv_ID))
                .ForMember(dest => dest.srsv_LinkID, opt => opt.MapFrom(src => src.srsv_LinkID));
#endregion
            #region (RatingData/Release)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request, ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response>();
            #endregion
            #region [RatingData_Update_Request_ACTION]->[ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request]
			//********************** DIRECT:    WebModel[RatingData_Update_Request_ACTION] -> CallModel[ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request] *************************************
			cfg.CreateMap<RatingData_Update_Request_ACTION, ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request>()
                .ForMember(dest => dest.beginTimeStamp, opt => opt.MapFrom(src => src.beginTimeStamp))
                .ForMember(dest => dest.CheckBalanceMode, opt => opt.MapFrom(src => src.CheckBalanceMode))
                .ForMember(dest => dest.consumedUnit, opt => opt.MapFrom(src => src.consumedUnit))
                .ForMember(dest => dest.destinationIdData, opt => opt.MapFrom(src => src.destinationIdData))
                .ForMember(dest => dest.destinationIdType, opt => opt.MapFrom(src => src.destinationIdType))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.invocationSequenceNumber, opt => opt.MapFrom(src => src.invocationSequenceNumber))
                .ForMember(dest => dest.invocationTimeStamp, opt => opt.MapFrom(src => src.invocationTimeStamp))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.location, opt => opt.MapFrom(src => src.location))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.nfConsumerIdentification, opt => opt.MapFrom(src => src.nfConsumerIdentification))
                .ForMember(dest => dest.oneTimeEvent, opt => opt.MapFrom(src => src.oneTimeEvent))
                .ForMember(dest => dest.oneTimeEventType, opt => opt.MapFrom(src => src.oneTimeEventType))
                .ForMember(dest => dest.srsv_UniqueID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ratingGroup, opt => opt.MapFrom(src => src.ratingGroup))
                .ForMember(dest => dest.requestedUnit, opt => opt.MapFrom(src => src.requestedUnit))
                .ForMember(dest => dest.requestSubType, opt => opt.MapFrom(src => src.requestSubType))
                .ForMember(dest => dest.serviceContextId, opt => opt.MapFrom(src => src.serviceContextId))
                .ForMember(dest => dest.serviceId, opt => opt.MapFrom(src => src.serviceId))
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
                .ForMember(dest => dest.srsv_ID, opt => opt.MapFrom(src => src.srsv_ID))
                .ForMember(dest => dest.srsv_LinkID, opt => opt.MapFrom(src => src.srsv_LinkID))
                .ForMember(dest => dest.srsv_Remark, opt => opt.MapFrom(src => src.srsv_Remark))
                .ForMember(dest => dest.subscriptionId, opt => opt.MapFrom(src => src.subscriptionId));
;
#endregion
            #region  [ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response->RatingData_Update_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response] -> WebModel[RatingData_Update_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response, RatingData_Update_Response_ACTION>()
                .ForMember(dest => dest.invocationSequenceNumber, opt => opt.MapFrom(src => src.invocationSequenceNumber))
                .ForMember(dest => dest.invocationTimeStamp, opt => opt.MapFrom(src => src.invocationTimeStamp))
                .ForMember(dest => dest.location, opt => opt.MapFrom(src => src.location))
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
                .ForMember(dest => dest.srsv_ID, opt => opt.MapFrom(src => src.srsv_ID))
                .ForMember(dest => dest.srsv_LinkID, opt => opt.MapFrom(src => src.srsv_LinkID));
#endregion
            #region (RatingData/Update)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request, ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response>();
            #endregion
            #endregion
            #region [ServiceSubscriptions]
            #region [ServiceSubscriptions_Request_SET]->[SET_p_ucp_set_ServiceSubscriptions_Request]
			//********************** DIRECT:    WebModel[ServiceSubscriptions_Request_SET] -> CallModel[SET_p_ucp_set_ServiceSubscriptions_Request] *************************************
			cfg.CreateMap<ServiceSubscriptions_Request_SET, SET_p_ucp_set_ServiceSubscriptions_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.Srs_JsonData, opt => opt.MapFrom(src => src.TaskJsonData))
                .ForMember(dest => dest.Srs_DateDrop, opt => opt.MapFrom(src => src.DateDrop))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.Srs_PriceRatio, opt => opt.MapFrom(src => src.PriceRatio))
                .ForMember(dest => dest.Srs_Count, opt => opt.MapFrom(src => src.Count))
                .ForMember(dest => dest.Pkt_ID, opt => opt.MapFrom(src => src.PacketID))
                .ForMember(dest => dest.Tsk_ID, opt => opt.MapFrom(src => src.TaskID))
                .ForMember(dest => dest.Sst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.Srs_Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Srs_DateSet, opt => opt.MapFrom(src => src.DateSet))
                .ForMember(dest => dest.Srv_Code, opt => opt.MapFrom(src => src.ServiceCode))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Sst_IsStatusHistory, opt => opt.MapFrom(src => src.OverrideHistory))
                .ForMember(dest => dest.Rtb_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Srs_SessionID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Ext_ID, opt => opt.MapFrom(src => src.ExtentionID))
                .ForMember(dest => dest.ModDate, opt => opt.MapFrom(src => src.ModDate))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.ServiceMode, opt => opt.MapFrom(src => src.ServiceMode))
                .ForMember(dest => dest.TariffBegin, opt => opt.MapFrom(src => src.TariffBegin));
;
#endregion
            #region  [SET_p_ucp_set_ServiceSubscriptions_Response->ServiceSubscriptions_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_ServiceSubscriptions_Response] -> WebModel[ServiceSubscriptions_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_ServiceSubscriptions_Response, ServiceSubscriptions_Response_SET>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.TaskID, opt => opt.MapFrom(src => src.Tsk_ID))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Srs_SessionID));
#endregion
            #region (ServiceSubscriptions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_ServiceSubscriptions_Request, SET_p_ucp_set_ServiceSubscriptions_Response>();
            #endregion
            #endregion
            #region [Subscribers]
            #region [Subscribers_Request_GET]->[GET_p_ucp_get_Subscribers_Request]
			//********************** DIRECT:    WebModel[Subscribers_Request_GET] -> CallModel[GET_p_ucp_get_Subscribers_Request] *************************************
			cfg.CreateMap<Subscribers_Request_GET, GET_p_ucp_get_Subscribers_Request>()
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection))
                .ForMember(dest => dest.Srv_ID, opt => opt.MapFrom(src => src.Srv_ID))
                .ForMember(dest => dest.Srv_Name, opt => opt.MapFrom(src => src.Srv_Name))
                .ForMember(dest => dest.Sst_ID, opt => opt.MapFrom(src => src.Sst_ID))
                .ForMember(dest => dest.tnst_Code, opt => opt.MapFrom(src => src.tnst_Code))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.LastModifiedDate, opt => opt.MapFrom(src => src.LastModifiedDate))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
                .ForMember(dest => dest.abn_ID_Boss, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.Acat_ID, opt => opt.MapFrom(src => src.Acat_ID))
                .ForMember(dest => dest.Accl_ID, opt => opt.MapFrom(src => src.Accl_ID))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Acnt_Number))
                .ForMember(dest => dest.Actp_ID, opt => opt.MapFrom(src => src.Actp_ID))
                .ForMember(dest => dest.Adlsb_Code, opt => opt.MapFrom(src => src.Adlsb_Code))
                .ForMember(dest => dest.Aptp_ID, opt => opt.MapFrom(src => src.Aptp_ID))
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.Bac_Number, opt => opt.MapFrom(src => src.Bac_Number))
                .ForMember(dest => dest.bll_Number, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.BossLastName, opt => opt.MapFrom(src => src.BossLastName))
                .ForMember(dest => dest.Cntr_Name, opt => opt.MapFrom(src => src.Cntr_Name))
                .ForMember(dest => dest.com_ID, opt => opt.MapFrom(src => src.com_ID))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.Dls_ID, opt => opt.MapFrom(src => src.Dls_ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.CacheControlDate))
                .ForMember(dest => dest.jsonFieldsName, opt => opt.MapFrom(src => src.jsonFieldsName))
                .ForMember(dest => dest.jsonFilter, opt => opt.MapFrom(src => src.jsonFilter))
                .ForMember(dest => dest.jsonFilterContain, opt => opt.MapFrom(src => src.jsonFilterContain))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Lng_ID, opt => opt.MapFrom(src => src.Lng_ID))
                .ForMember(dest => dest.mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.Ntw_ID, opt => opt.MapFrom(src => src.Ntw_ID))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageNumber))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.Rgsc_ID, opt => opt.MapFrom(src => src.Rgsc_ID))
                .ForMember(dest => dest.ShowBalances, opt => opt.MapFrom(src => src.ShowBalances))
                .ForMember(dest => dest.ShowEntities, opt => opt.MapFrom(src => src.ShowEntities));
;
#endregion
            #region [GET_p_ucp_get_Subscribers_Response->Subscribers_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_Subscribers_Response] -> WebModel Response(Subscribers_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Subscribers_Response, Subscribers_Response_GET>()
                .ForMember(dest => dest.CacheControlDate, opt => opt.MapFrom(src => src.IfModifiedSinceDate))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Subscribers_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_Subscribers_Response_OUTPUT] -> WebModel Response Output(Subscribers_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_Subscribers_Response_OUTPUT] -> WebModel Response Output(Subscribers_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Subscribers_Response_OUTPUT, Subscribers_Response_GET_OUTPUT>()
                .ForMember(dest => dest.abn_HasNotEmptyPrepaid, opt => opt.MapFrom(src => src.abn_HasNotEmptyPrepaid))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Balance, opt => opt.MapFrom(src => src.abn_Balance))
                .ForMember(dest => dest.abn_CreateDate, opt => opt.MapFrom(src => src.abn_CreateDate))
                .ForMember(dest => dest.abn_Date, opt => opt.MapFrom(src => src.abn_Date))
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
                .ForMember(dest => dest.abn_Guid, opt => opt.MapFrom(src => src.abn_Guid))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.ParentID, opt => opt.MapFrom(src => src.abn_ID_Boss))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_IsGuest, opt => opt.MapFrom(src => src.abn_IsGuest))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
                .ForMember(dest => dest.abn_ModifiedDate, opt => opt.MapFrom(src => src.abn_ModifiedDate))
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
                .ForMember(dest => dest.abn_NestedSets_Left, opt => opt.MapFrom(src => src.abn_NestedSets_Left))
                .ForMember(dest => dest.abn_NestedSets_Right, opt => opt.MapFrom(src => src.abn_NestedSets_Right))
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
                .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => opt.MapFrom(src => src.abn_ShowPhoneDirectory))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.acnt_ID_count, opt => opt.MapFrom(src => src.acnt_ID_count))
                .ForMember(dest => dest.acnt_IsPersonal, opt => opt.MapFrom(src => src.acnt_IsPersonal))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.actp_ID, opt => opt.MapFrom(src => src.actp_ID))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.actpd_Name, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
                .ForMember(dest => dest.aut_ID_count, opt => opt.MapFrom(src => src.aut_ID_count))
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.aut_NumberAts, opt => opt.MapFrom(src => src.aut_NumberAts))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
                .ForMember(dest => dest.cntr_ID_count, opt => opt.MapFrom(src => src.cntr_ID_count))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
                .ForMember(dest => dest.com_Id, opt => opt.MapFrom(src => src.com_Id))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.ext_ID_count, opt => opt.MapFrom(src => src.ext_ID_count))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
                .ForMember(dest => dest.isEditAllow, opt => opt.MapFrom(src => src.isEditAllow))
                .ForMember(dest => dest.lng_ID, opt => opt.MapFrom(src => src.lng_ID))
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
                .ForMember(dest => dest.Location_ID, opt => opt.MapFrom(src => src.Location_ID))
                .ForMember(dest => dest.ntw_ID, opt => opt.MapFrom(src => src.ntw_ID))
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.rptURL, opt => opt.MapFrom(src => src.rptURL))
                .ForMember(dest => dest.SubsCount, opt => opt.MapFrom(src => src.SubsCount))
                .ForMember(dest => dest.tnst_ExternalID, opt => opt.MapFrom(src => src.tnst_ExternalID))
                .ForMember(dest => dest.tnst_ID, opt => opt.MapFrom(src => src.tnst_ID))
                .ForMember(dest => dest.tnt_AccountMandatory, opt => opt.MapFrom(src => src.tnt_AccountMandatory))
                .ForMember(dest => dest.tnt_ID, opt => opt.MapFrom(src => src.tnt_ID))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.isEditWorkPlace, opt => opt.MapFrom(src => src.isEditWorkPlace))
                .ForMember(dest => dest.dep_id_boss, opt => opt.MapFrom(src => src.dep_id_boss))
                .ForMember(dest => dest.dep_Name_boss, opt => opt.MapFrom(src => src.dep_Name_boss))
                .ForMember(dest => dest.isRefusalChangeName, opt => opt.MapFrom(src => src.isRefusalChangeName))
                .ForMember(dest => dest.max_ModDate, opt => opt.MapFrom(src => src.max_ModDate))
                .ForMember(dest => dest.vrr_ID, opt => opt.MapFrom(src => src.vrr_ID));
#endregion
            #region [Subscribers_Request_SET]->[SET_p_ucp_set_Subscribers_Request]
			//********************** DIRECT:    WebModel[Subscribers_Request_SET] -> CallModel[SET_p_ucp_set_Subscribers_Request] *************************************
			cfg.CreateMap<Subscribers_Request_SET, SET_p_ucp_set_Subscribers_Request>()
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.Ntw_ID, opt => opt.MapFrom(src => src.StandartID))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.AutoCreateContract, opt => opt.MapFrom(src => src.AutoCreateContract))
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.Customer_SearchName))
                .ForMember(dest => dest.Abn_Date, opt => opt.MapFrom(src => src.CustomerDate))
                .ForMember(dest => dest.DebugLevel, opt => opt.MapFrom(src => src.DebugLevel))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.Abn_Employe_Export_ID, opt => opt.MapFrom(src => src.Export_ID))
                .ForMember(dest => dest.Abn_PositionCode, opt => opt.MapFrom(src => src.PositionCode))
                .ForMember(dest => dest.Sag_Code, opt => opt.MapFrom(src => src.AgentCode))
                .ForMember(dest => dest.Sag_ID, opt => opt.MapFrom(src => src.AgentID))
                .ForMember(dest => dest.Pos_Code, opt => opt.MapFrom(src => src.SalesPointCode))
                .ForMember(dest => dest.Pos_ID, opt => opt.MapFrom(src => src.SalesPointID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Abn_IsCreatedWithTariffication, opt => opt.MapFrom(src => src.IsCreatedWithTariffication))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.Abn_Employee_ID, opt => opt.MapFrom(src => src.SyncId))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.SubscriberLogin))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.SubscriberPassword))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Abn_ID_Boss, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
;
#endregion
            #region  [SET_p_ucp_set_Subscribers_Response->Subscribers_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_Subscribers_Response] -> WebModel[Subscribers_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_Subscribers_Response, Subscribers_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Abn_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Subscribers)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Subscribers_Request, GET_p_ucp_get_Subscribers_Response>();
            cfg.CreateMap<SET_p_ucp_set_Subscribers_Request, SET_p_ucp_set_Subscribers_Response>();
            #endregion
            #region [Subscribers_Activate_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request]
			//********************** DIRECT:    WebModel[Subscribers_Activate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request] *************************************
			cfg.CreateMap<Subscribers_Activate_Request_ACTION, ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request>()
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCode))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response->Subscribers_Activate_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response] -> WebModel[Subscribers_Activate_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response, Subscribers_Activate_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Subscribers/Activate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request, ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response>();
            #endregion
            #region [Subscribers_CalcCharges_Request_ACTION]->[ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request]
			//********************** DIRECT:    WebModel[Subscribers_CalcCharges_Request_ACTION] -> CallModel[ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request] *************************************
			cfg.CreateMap<Subscribers_CalcCharges_Request_ACTION, ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request>()
                .ForMember(dest => dest.ChargeCode, opt => opt.MapFrom(src => src.ChargeCode))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EmulateMode, opt => opt.MapFrom(src => src.EmulateMode))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Ext_ID, opt => opt.MapFrom(src => src.ExtentionID))
                .ForMember(dest => dest.ID_GroupATS, opt => opt.MapFrom(src => src.ID_GroupATS))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IsReCharge, opt => opt.MapFrom(src => src.IsReCharge))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Srv_ID, opt => opt.MapFrom(src => src.ServiceID))
                .ForMember(dest => dest.Srs_SessionID, opt => opt.MapFrom(src => src.Srs_SessionID));
;
#endregion
            #region  [ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response->Subscribers_CalcCharges_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response] -> WebModel[Subscribers_CalcCharges_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response, Subscribers_CalcCharges_Response_ACTION>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.WorkEventID, opt => opt.MapFrom(src => src.Wev_ID));
#endregion
            #region (Subscribers/CalcCharges)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request, ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response>();
            #endregion
            #region [Subscribers_ChangeAccount_Request_ACTION]->[ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request]
			//********************** DIRECT:    WebModel[Subscribers_ChangeAccount_Request_ACTION] -> CallModel[ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request] *************************************
			cfg.CreateMap<Subscribers_ChangeAccount_Request_ACTION, ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request>()
                .ForMember(dest => dest.Acnt_ID_New, opt => opt.MapFrom(src => src.AccountID))
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCode))
                .ForMember(dest => dest.aut_NameAuthCodePrivate, opt => opt.MapFrom(src => src.AuthCodePrivate))
                .ForMember(dest => dest.ConfAccepted, opt => opt.MapFrom(src => src.ConfAccepted))
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.RunBilling, opt => opt.MapFrom(src => src.RunBilling))
                .ForMember(dest => dest.Tnst_target_old, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.SubscriberLogin))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.SubscriberPassword))
                .ForMember(dest => dest.Tnst_target_new, opt => opt.MapFrom(src => src.TargetStatusID));
;
#endregion
            #region  [ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response->Subscribers_ChangeAccount_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response] -> WebModel[Subscribers_ChangeAccount_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response, Subscribers_ChangeAccount_Response_ACTION>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage));
#endregion
            #region (Subscribers/ChangeAccount)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request, ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response>();
            #endregion
            #region [Subscribers_ChangeName_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request]
			//********************** DIRECT:    WebModel[Subscribers_ChangeName_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request] *************************************
			cfg.CreateMap<Subscribers_ChangeName_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Abn_FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.SearchName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.toClean, opt => opt.MapFrom(src => src.ToClean));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response->Subscribers_ChangeName_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response] -> WebModel[Subscribers_ChangeName_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response, Subscribers_ChangeName_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Subscribers/ChangeName)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request, ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response>();
            #endregion
            #region [Subscribers_ChangeStatus_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request]
			//********************** DIRECT:    WebModel[Subscribers_ChangeStatus_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request] *************************************
			cfg.CreateMap<Subscribers_ChangeStatus_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfirmationMessage))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.ConfAccepted, opt => opt.MapFrom(src => src.UserAcceptance));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response->Subscribers_ChangeStatus_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response] -> WebModel[Subscribers_ChangeStatus_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response, Subscribers_ChangeStatus_Response_ACTION>()
                .ForMember(dest => dest.ConfirmationMessage, opt => opt.MapFrom(src => src.ConfMessage))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Subscribers/ChangeStatus)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request, ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response>();
            #endregion
            #region [Subscribers_Deactivate_Request_ACTION]->[ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request]
			//********************** DIRECT:    WebModel[Subscribers_Deactivate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request] *************************************
			cfg.CreateMap<Subscribers_Deactivate_Request_ACTION, ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_Code_crnt, opt => opt.MapFrom(src => src.StatusCode))
                .ForMember(dest => dest.Tnst_Code_trgt, opt => opt.MapFrom(src => src.TargetStatusCode));
;
#endregion
            #region  [ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response->Subscribers_Deactivate_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response] -> WebModel[Subscribers_Deactivate_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response, Subscribers_Deactivate_Response_ACTION>()
                .ForMember(dest => dest.AffectedCount, opt => opt.MapFrom(src => src.AffectedCount))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.WorkEventID, opt => opt.MapFrom(src => src.Wev_ID));
#endregion
            #region (Subscribers/Deactivate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request, ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response>();
            #endregion
            #region [Subscribers_Details_Request_GET]->[GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request]
			//********************** DIRECT:    WebModel[Subscribers_Details_Request_GET] -> CallModel[GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request] *************************************
			cfg.CreateMap<Subscribers_Details_Request_GET, GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request>()
                .ForMember(dest => dest.IfModifiedSinceDate, opt => opt.MapFrom(src => src.CacheControlDate))
                .ForMember(dest => dest.abn_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
;
#endregion
            #region [GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response->Subscribers_Details_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response] -> WebModel Response(Subscribers_Details_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response, Subscribers_Details_Response_GET>()
                .ForMember(dest => dest.CacheControlDate, opt => opt.MapFrom(src => src.IfModifiedSinceDate))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Subscribers_Details_Request_GET>()
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response_OUTPUT] -> WebModel Response Output(Subscribers_Details_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response_OUTPUT] -> WebModel Response Output(Subscribers_Details_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response_OUTPUT, Subscribers_Details_Response_GET_OUTPUT>()
                .ForMember(dest => dest.abn_IsGuest, opt => opt.MapFrom(src => src.abn_IsGuest))
                .ForMember(dest => dest.abc_Date_Personal, opt => opt.MapFrom(src => src.abc_Date_Personal))
                .ForMember(dest => dest.abn_Balance, opt => opt.MapFrom(src => src.abn_Balance))
                .ForMember(dest => dest.abn_CreateDate, opt => opt.MapFrom(src => src.abn_CreateDate))
                .ForMember(dest => dest.abn_Date, opt => opt.MapFrom(src => src.abn_Date))
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
                .ForMember(dest => dest.abn_ExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
                .ForMember(dest => dest.abn_Guid, opt => opt.MapFrom(src => src.abn_Guid))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.abn_ID_Boss, opt => opt.MapFrom(src => src.abn_ID_Boss))
                .ForMember(dest => dest.abn_IsExistAD, opt => opt.MapFrom(src => src.abn_IsExistAD))
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
                .ForMember(dest => dest.abn_ModifiedDate, opt => opt.MapFrom(src => src.abn_ModifiedDate))
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
                .ForMember(dest => dest.abn_NestedSets_Left, opt => opt.MapFrom(src => src.abn_NestedSets_Left))
                .ForMember(dest => dest.abn_NestedSets_Right, opt => opt.MapFrom(src => src.abn_NestedSets_Right))
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
                .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => opt.MapFrom(src => src.abn_ShowPhoneDirectory))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.abn_WorkPlace_Personal, opt => opt.MapFrom(src => src.abn_WorkPlace_Personal))
                .ForMember(dest => dest.abn_XmlData, opt => opt.MapFrom(src => src.abn_XmlData))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
                .ForMember(dest => dest.acnt_ID, opt => opt.MapFrom(src => src.acnt_ID))
                .ForMember(dest => dest.acnt_ID_count, opt => opt.MapFrom(src => src.acnt_ID_count))
                .ForMember(dest => dest.acnt_IsPersonal, opt => opt.MapFrom(src => src.acnt_IsPersonal))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.Actpd_Name, opt => opt.MapFrom(src => src.Actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
                .ForMember(dest => dest.atnsb_DateEnd, opt => opt.MapFrom(src => src.atnsb_DateEnd))
                .ForMember(dest => dest.atnsb_DateStart, opt => opt.MapFrom(src => src.atnsb_DateStart))
                .ForMember(dest => dest.abb_Balance, opt => opt.MapFrom(src => src.abb_Balance))
                .ForMember(dest => dest.abb_Balance_Personal, opt => opt.MapFrom(src => src.abb_Balance_Personal))
                .ForMember(dest => dest.abb_ModifiedDate, opt => opt.MapFrom(src => src.abb_ModifiedDate))
                .ForMember(dest => dest.abb_ModifiedDate_Personal, opt => opt.MapFrom(src => src.abb_ModifiedDate_Personal))
                .ForMember(dest => dest.abc_Balance, opt => opt.MapFrom(src => src.abc_Balance))
                .ForMember(dest => dest.abc_Balance_Personal, opt => opt.MapFrom(src => src.abc_Balance_Personal))
                .ForMember(dest => dest.abc_Date, opt => opt.MapFrom(src => src.abc_Date))
                .ForMember(dest => dest.aut_ID_count, opt => opt.MapFrom(src => src.aut_ID_count))
                .ForMember(dest => dest.Boss_Tnt_Type, opt => opt.MapFrom(src => src.Boss_Tnt_Type))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
                .ForMember(dest => dest.com_Id, opt => opt.MapFrom(src => src.com_Id))
                .ForMember(dest => dest.debt_Amount, opt => opt.MapFrom(src => src.debt_Amount))
                .ForMember(dest => dest.debt_Date, opt => opt.MapFrom(src => src.debt_Date))
                .ForMember(dest => dest.dep_ID, opt => opt.MapFrom(src => src.dep_ID))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.ext_ID_count, opt => opt.MapFrom(src => src.ext_ID_count))
                .ForMember(dest => dest.grp_ID, opt => opt.MapFrom(src => src.grp_ID))
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
                .ForMember(dest => dest.isActivated, opt => opt.MapFrom(src => src.isActivated))
                .ForMember(dest => dest.isEditAllow, opt => opt.MapFrom(src => src.isEditAllow))
                .ForMember(dest => dest.isEditWorkPlace, opt => opt.MapFrom(src => src.isEditWorkPlace))
                .ForMember(dest => dest.lng_ID, opt => opt.MapFrom(src => src.lng_ID))
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
                .ForMember(dest => dest.Location_ID, opt => opt.MapFrom(src => src.Location_ID))
                .ForMember(dest => dest.ntw_ID, opt => opt.MapFrom(src => src.ntw_ID))
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
                .ForMember(dest => dest.ProfileType, opt => opt.MapFrom(src => src.ProfileType))
                .ForMember(dest => dest.SubsCount, opt => opt.MapFrom(src => src.SubsCount))
                .ForMember(dest => dest.tnh_LastFM, opt => opt.MapFrom(src => src.tnh_LastFM))
                .ForMember(dest => dest.tnst_ExternalID, opt => opt.MapFrom(src => src.tnst_ExternalID))
                .ForMember(dest => dest.tnst_ID, opt => opt.MapFrom(src => src.tnst_ID))
                .ForMember(dest => dest.tnt_AccountMandatory, opt => opt.MapFrom(src => src.tnt_AccountMandatory))
                .ForMember(dest => dest.tnt_ID, opt => opt.MapFrom(src => src.tnt_ID))
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
                .ForMember(dest => dest.trf_ID, opt => opt.MapFrom(src => src.trf_ID))
                .ForMember(dest => dest.isRefusalChangeName, opt => opt.MapFrom(src => src.isRefusalChangeName));
#endregion
            #region (Subscribers/Details)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request, GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response>();
            #endregion
            #region [Subscribers_Recharge_Request_ACTION]->[ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request]
			//********************** DIRECT:    WebModel[Subscribers_Recharge_Request_ACTION] -> CallModel[ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request] *************************************
			cfg.CreateMap<Subscribers_Recharge_Request_ACTION, ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.AMOUNT))
                .ForMember(dest => dest.ChargeCode, opt => opt.MapFrom(src => src.ChargeCode))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EmulateMode, opt => opt.MapFrom(src => src.EmulateMode))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Ext_ID, opt => opt.MapFrom(src => src.ExtentionID))
                .ForMember(dest => dest.ID_GroupATS, opt => opt.MapFrom(src => src.ID_GroupATS))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.IsOnline, opt => opt.MapFrom(src => src.IsOnline))
                .ForMember(dest => dest.IsReCharge, opt => opt.MapFrom(src => src.IsReCharge))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.NumberATS, opt => opt.MapFrom(src => src.NumberATS))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Srv_ID, opt => opt.MapFrom(src => src.ServiceID))
                .ForMember(dest => dest.Srs_SessionID, opt => opt.MapFrom(src => src.Srs_SessionID))
                .ForMember(dest => dest.Wev_CurrrentState, opt => opt.MapFrom(src => src.Wev_CurrrentState))
                .ForMember(dest => dest.Wev_ID, opt => opt.MapFrom(src => src.WorkEventID));
;
#endregion
            #region  [ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response->Subscribers_Recharge_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response] -> WebModel[Subscribers_Recharge_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response, Subscribers_Recharge_Response_ACTION>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.WorkEventID, opt => opt.MapFrom(src => src.Wev_ID));
#endregion
            #region (Subscribers/Recharge)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request, ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response>();
            #endregion
            #region [Subscribers_SetLabels_Request_ACTION]->[ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request]
			//********************** DIRECT:    WebModel[Subscribers_SetLabels_Request_ACTION] -> CallModel[ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request] *************************************
			cfg.CreateMap<Subscribers_SetLabels_Request_ACTION, ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.LinkedServer, opt => opt.MapFrom(src => src.LinkedServer))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.SourceQuery, opt => opt.MapFrom(src => src.SourceQuery));
;
#endregion
            #region  [ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response->Subscribers_SetLabels_Response_ACTION]
			//********************** BACK:   CallModel(ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response] -> WebModel[Subscribers_SetLabels_Response_ACTION] *************************************
			cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response, Subscribers_SetLabels_Response_ACTION>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Subscribers/SetLabels)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request, ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response>();
            #endregion
            #endregion
            #region [Tasks]
            #region [Tasks_Request_SET]->[SET_p_ucp_set_ServiceTask_Request]
			//********************** DIRECT:    WebModel[Tasks_Request_SET] -> CallModel[SET_p_ucp_set_ServiceTask_Request] *************************************
			cfg.CreateMap<Tasks_Request_SET, SET_p_ucp_set_ServiceTask_Request>()
                .ForMember(dest => dest.Tsk_DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.Tsk_PeriodBegin, opt => opt.MapFrom(src => src.PeriodBegin))
                .ForMember(dest => dest.Tsk_PeriodEnd, opt => opt.MapFrom(src => src.PeriodEnd))
                .ForMember(dest => dest.ID_GroupATS, opt => opt.MapFrom(src => src.DeviceGroupID))
                .ForMember(dest => dest.Lig_ID, opt => opt.MapFrom(src => src.ListGroupID))
                .ForMember(dest => dest.Tsk_JsonData, opt => opt.MapFrom(src => src.JsonData))
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
                .ForMember(dest => dest.Tsst_ID, opt => opt.MapFrom(src => src.StatusID))
                .ForMember(dest => dest.Tsk_StateMessage, opt => opt.MapFrom(src => src.Message))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.cacheStatus, opt => opt.MapFrom(src => src.cacheStatus))
                .ForMember(dest => dest.Tsk_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.HostName, opt => opt.MapFrom(src => src.HostName))
                .ForMember(dest => dest.Tsk_IsReady, opt => opt.MapFrom(src => src.Tsk_IsReady));
;
#endregion
            #region  [SET_p_ucp_set_ServiceTask_Response->Tasks_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_ServiceTask_Response] -> WebModel[Tasks_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_ServiceTask_Response, Tasks_Response_SET>()
                .ForMember(dest => dest.PeriodBegin, opt => opt.MapFrom(src => src.Tsk_PeriodBegin))
                .ForMember(dest => dest.PeriodEnd, opt => opt.MapFrom(src => src.Tsk_PeriodEnd))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Tsk_ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region (Tasks)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_ServiceTask_Request, SET_p_ucp_set_ServiceTask_Response>();
            #endregion
            #endregion
            #region [TemplateSubscriptions]
            #region [TemplateSubscriptions_Request_GET]->[GET_p_ucp_get_TemplateSubscriptions_Request]
			//********************** DIRECT:    WebModel[TemplateSubscriptions_Request_GET] -> CallModel[GET_p_ucp_get_TemplateSubscriptions_Request] *************************************
			cfg.CreateMap<TemplateSubscriptions_Request_GET, GET_p_ucp_get_TemplateSubscriptions_Request>()
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.TreeNodeID))
                .ForMember(dest => dest.Agr_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Ext_ID, opt => opt.MapFrom(src => src.ExtentionID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageNumber))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
                .ForMember(dest => dest.ShowBasicTP, opt => opt.MapFrom(src => src.ShowBasicTP))
                .ForMember(dest => dest.TariffName, opt => opt.MapFrom(src => src.TariffName));
;
#endregion
            #region [GET_p_ucp_get_TemplateSubscriptions_Response->TemplateSubscriptions_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_TemplateSubscriptions_Response] -> WebModel Response(TemplateSubscriptions_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_TemplateSubscriptions_Response, TemplateSubscriptions_Response_GET>()
;
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, TemplateSubscriptions_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_TemplateSubscriptions_Response_OUTPUT] -> WebModel Response Output(TemplateSubscriptions_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_TemplateSubscriptions_Response_OUTPUT] -> WebModel Response Output(TemplateSubscriptions_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_TemplateSubscriptions_Response_OUTPUT, TemplateSubscriptions_Response_GET_OUTPUT>()
                .ForMember(dest => dest.SubscriberID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.AgreementID, opt => opt.MapFrom(src => src.agr_ID))
                .ForMember(dest => dest.ExtentionID, opt => opt.MapFrom(src => src.ext_ID))
                .ForMember(dest => dest.TarifPlanName, opt => opt.MapFrom(src => src.grt_Name))
                .ForMember(dest => dest.PolicyID, opt => opt.MapFrom(src => src.ptp_ID))
                .ForMember(dest => dest.PolicyName, opt => opt.MapFrom(src => src.ptp_UserGroupName))
                .ForMember(dest => dest.RepresentationID, opt => opt.MapFrom(src => src.rpr_ID))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.rtb_DateDrop))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.rtb_DateSet))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.rtb_ID))
                .ForMember(dest => dest.TariffDescription, opt => opt.MapFrom(src => src.TariffDescription))
                .ForMember(dest => dest.TariffName, opt => opt.MapFrom(src => src.TariffName))
                .ForMember(dest => dest.PriceRatio, opt => opt.MapFrom(src => src.tgb_PriceRatio))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.PacketExternalID, opt => opt.MapFrom(src => src.tp_ExternalID))
                .ForMember(dest => dest.PacketParentID, opt => opt.MapFrom(src => src.tp_ID_Boss))
                .ForMember(dest => dest.grt_ExternalId, opt => opt.MapFrom(src => src.grt_ExternalId))
                .ForMember(dest => dest.grt_ID, opt => opt.MapFrom(src => src.grt_ID))
                .ForMember(dest => dest.IdTariffPlan, opt => opt.MapFrom(src => src.IdTariffPlan))
                .ForMember(dest => dest.tpgnd_Name, opt => opt.MapFrom(src => src.tpgnd_Name));
#endregion
            #region [TemplateSubscriptions_Request_SET]->[SET_p_ucp_set_AgreementTemplates_Request]
			//********************** DIRECT:    WebModel[TemplateSubscriptions_Request_SET] -> CallModel[SET_p_ucp_set_AgreementTemplates_Request] *************************************
			cfg.CreateMap<TemplateSubscriptions_Request_SET, SET_p_ucp_set_AgreementTemplates_Request>()
                .ForMember(dest => dest.EffectiveDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.TasksJsonData, opt => opt.MapFrom(src => src.TasksJsonData))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Tp_ID, opt => opt.MapFrom(src => src.TemplateID))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.DateStart))
                .ForMember(dest => dest.IsCheckBallance, opt => opt.MapFrom(src => src.CheckBallance))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
                .ForMember(dest => dest.TariffBegin, opt => opt.MapFrom(src => src.TariffBegin))
                .ForMember(dest => dest.Agr_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Rtb_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ActivateServices, opt => opt.MapFrom(src => src.ActivateServices))
                .ForMember(dest => dest.Agr_ID_Old, opt => opt.MapFrom(src => src.Agr_ID_Old))
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfirmationMessage))
                .ForMember(dest => dest.Rtb_ID_Old, opt => opt.MapFrom(src => src.Rtb_ID_Old))
                .ForMember(dest => dest.ServiceMode, opt => opt.MapFrom(src => src.ServiceMode))
                .ForMember(dest => dest.Services, opt => opt.MapFrom(src => src.Services))
                .ForMember(dest => dest.Tp_ID_New, opt => opt.MapFrom(src => src.Tp_ID_New))
                .ForMember(dest => dest.ConfAccepted, opt => opt.MapFrom(src => src.UserAcceptance));
;
#endregion
            #region  [SET_p_ucp_set_AgreementTemplates_Response->TemplateSubscriptions_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_AgreementTemplates_Response] -> WebModel[TemplateSubscriptions_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_AgreementTemplates_Response, TemplateSubscriptions_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Rtb_ID))
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
                .ForMember(dest => dest.ConfirmationMessage, opt => opt.MapFrom(src => src.ConfMessage));
#endregion
            #region (TemplateSubscriptions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_TemplateSubscriptions_Request, GET_p_ucp_get_TemplateSubscriptions_Response>();
            cfg.CreateMap<SET_p_ucp_set_AgreementTemplates_Request, SET_p_ucp_set_AgreementTemplates_Response>();
            #endregion
            #endregion
            #region [TreeNodeHistory]
            #region [TreeNodeHistory_Request_GET]->[GET_p_ucp_get_TreeNodeHistory_Request]
			//********************** DIRECT:    WebModel[TreeNodeHistory_Request_GET] -> CallModel[GET_p_ucp_get_TreeNodeHistory_Request] *************************************
			cfg.CreateMap<TreeNodeHistory_Request_GET, GET_p_ucp_get_TreeNodeHistory_Request>()
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.PageIndex))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize));
;
#endregion
            #region [GET_p_ucp_get_TreeNodeHistory_Response->TreeNodeHistory_Response_GET]
			//**********************BACK(FROM REQUEST not null):   CallModel Response(GET_p_ucp_get_TreeNodeHistory_Response] -> WebModel Response(TreeNodeHistory_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_TreeNodeHistory_Response, TreeNodeHistory_Response_GET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [Filter -> WebModel]
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, TreeNodeHistory_Request_GET>()
					//PageIndex
					.ForMember(dest => dest.PageIndex, opt => opt.MapFrom(src => src.PageIndex))
					//PageSize
					.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.PageSize))
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
#endregion
            #region [GET_p_ucp_get_TreeNodeHistory_Response_OUTPUT] -> WebModel Response Output(TreeNodeHistory_Response_GET_OUTPUT]
			//**********************BACK[OUTPUT]:   CallModel Response Output(GET_p_ucp_get_TreeNodeHistory_Response_OUTPUT] -> WebModel Response Output(TreeNodeHistory_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_TreeNodeHistory_Response_OUTPUT, TreeNodeHistory_Response_GET_OUTPUT>()
                .ForMember(dest => dest.TreeNodeExternalID, opt => opt.MapFrom(src => src.abn_ExternalID))
                .ForMember(dest => dest.TreeNodeParentExternalID, opt => opt.MapFrom(src => src.abn_ExternalID_Boss))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.tnh_ID))
                .ForMember(dest => dest.TreeNodeID, opt => opt.MapFrom(src => src.abn_ID))
                .ForMember(dest => dest.TreeNodeParentID, opt => opt.MapFrom(src => src.abn_ID_Boss))
                .ForMember(dest => dest.ModifiedFrom, opt => opt.MapFrom(src => src.tnh_ModifiedFrom))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.tnh_ModifiedDate))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src.tnh_DateStart))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.tnh_Remark))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.tnh_ModifiedBy));
#endregion
            #region (TreeNodeHistory)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_TreeNodeHistory_Request, GET_p_ucp_get_TreeNodeHistory_Response>();
            #endregion
            #endregion
            #region [TreeNodeProperties]
            #region [TreeNodeProperties_Request_SET]->[SET_p_ucp_set_TreeNodeProperty_Request]
			//********************** DIRECT:    WebModel[TreeNodeProperties_Request_SET] -> CallModel[SET_p_ucp_set_TreeNodeProperty_Request] *************************************
			cfg.CreateMap<TreeNodeProperties_Request_SET, SET_p_ucp_set_TreeNodeProperty_Request>()
                .ForMember(dest => dest.Annul, opt => opt.MapFrom(src => src.Annul))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Prp_ID, opt => opt.MapFrom(src => src.PropertyID))
                .ForMember(dest => dest.Prpv_ID, opt => opt.MapFrom(src => src.PropertyValueID))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnpb_ExternalID, opt => opt.MapFrom(src => src.ExternalID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.IsExternalID, opt => opt.MapFrom(src => src.IDType))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Tnpb_ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Abn_ID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
;
#endregion
            #region  [SET_p_ucp_set_TreeNodeProperty_Response->TreeNodeProperties_Response_SET]
			//********************** BACK:   CallModel(SET_p_ucp_set_TreeNodeProperty_Response] -> WebModel[TreeNodeProperties_Response_SET] *************************************
			cfg.CreateMap<SET_p_ucp_set_TreeNodeProperty_Response, TreeNodeProperties_Response_SET>()
                .ForMember(dest => dest.IDType, opt => opt.MapFrom(src => src.IsExternalID))
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Tnpb_ID));
#endregion
            #region (TreeNodeProperties)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_TreeNodeProperty_Request, SET_p_ucp_set_TreeNodeProperty_Response>();
            #endregion
            #endregion
            ExtendConfiguration(cfg);
            return cfg;
        }

		////////////////////////////////////////////////////////////////
		// Конфигурация, где нулами НЕ перезаписываются финальные значения
		////////////////////////////////////////////////////////////////

		public static MapperConfigurationExpression GetMapperConfigurationWNExpression()
		{
			MapperConfigurationExpression cfg = new MapperConfigurationExpression();
            #region [Accounts]
            #region [Accounts_Request_GET->GET_p_ucp_get_Accounts_Request]
			//********************** DIRECT:    WebModel(Accounts_Request_GET] -> CallModel[GET_p_ucp_get_Accounts_Request] *************************************
			cfg.CreateMap<Accounts_Request_GET, GET_p_ucp_get_Accounts_Request>()
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.Acat_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CategoryID != null);
						opt.MapFrom(src => src.CategoryID);
					})
          		.ForMember(dest => dest.Rgsc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.RegistrCatID != null);
						opt.MapFrom(src => src.RegistrCatID);
					})
          		.ForMember(dest => dest.Accl_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ClassID != null);
						opt.MapFrom(src => src.ClassID);
					})
          		.ForMember(dest => dest.Actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TypeID != null);
						opt.MapFrom(src => src.TypeID);
					})
          		.ForMember(dest => dest.Aptp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PayTypeID != null);
						opt.MapFrom(src => src.PayTypeID);
					})
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.CacheControlDate != null);
						opt.MapFrom(src => src.CacheControlDate);
					})
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					})
          		.ForMember(dest => dest.Dls_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Dls_ID != null);
						opt.MapFrom(src => src.Dls_ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_Accounts_Response] -> WebModel Response(Accounts_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Accounts_Response, Accounts_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
  		           .ForMember(dest => dest.CacheControlDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    });
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Accounts_Request_GET>()

	            	.ForMember(dest => dest.PageIndex, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_Accounts_Response_OUTPUT] -> WebModel Response Output(Accounts_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Accounts_Response_OUTPUT, Accounts_Response_GET_OUTPUT>()
                .ForMember(dest => dest.CurrencyCode, opt => opt.MapFrom(src => src.Currency))
		         .ForMember(dest => dest.CustomerID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.CategoryID, opt => 
					{
						opt.Condition((arg1) => arg1.acat_ID != null);
						opt.MapFrom(src => src.acat_ID);
					})
		         .ForMember(dest => dest.RegistrCatID, opt => 
					{
						opt.Condition((arg1) => arg1.rgsc_ID != null);
						opt.MapFrom(src => src.rgsc_ID);
					})
		         .ForMember(dest => dest.ClassID, opt => 
					{
						opt.Condition((arg1) => arg1.accl_ID != null);
						opt.MapFrom(src => src.accl_ID);
					})
		         .ForMember(dest => dest.TypeID, opt => 
					{
						opt.Condition((arg1) => arg1.actp_ID != null);
						opt.MapFrom(src => src.actp_ID);
					})
		         .ForMember(dest => dest.PayTypeID, opt => 
					{
						opt.Condition((arg1) => arg1.aptp_ID != null);
						opt.MapFrom(src => src.aptp_ID);
					})
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.acatd_Name))
                .ForMember(dest => dest.RegistrCatName, opt => opt.MapFrom(src => src.rgscd_Name))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.accld_Name))
                .ForMember(dest => dest.TypeName, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.PayTypeName, opt => opt.MapFrom(src => src.aptpd_Name))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.acnt_Number))
		         .ForMember(dest => dest.TotalCount, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
		         .ForMember(dest => dest.AccountID, opt => 
					{
						opt.Condition((arg1) => arg1.Acnt_ID != null);
						opt.MapFrom(src => src.Acnt_ID);
					})
		         .ForMember(dest => dest.abc_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Amount != null);
						opt.MapFrom(src => src.abc_Amount);
					})
		         .ForMember(dest => dest.abc_DateCharge, opt => 
					{
						opt.Condition((arg1) => arg1.abc_DateCharge != null);
						opt.MapFrom(src => src.abc_DateCharge);
					})
		         .ForMember(dest => dest.acnt_CreateDate, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_CreateDate != null);
						opt.MapFrom(src => src.acnt_CreateDate);
					})
		         .ForMember(dest => dest.acnt_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ExternalID != null);
						opt.MapFrom(src => src.acnt_ExternalID);
					})
                .ForMember(dest => dest.acnt_ModifiedFrom, opt => opt.MapFrom(src => src.acnt_ModifiedFrom))
                .ForMember(dest => dest.acnt_Remark, opt => opt.MapFrom(src => src.acnt_Remark))
		         .ForMember(dest => dest.adlsb_Code, opt => 
					{
						opt.Condition((arg1) => arg1.adlsb_Code != null);
						opt.MapFrom(src => src.adlsb_Code);
					})
		         .ForMember(dest => dest.dls_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dls_ID != null);
						opt.MapFrom(src => src.dls_ID);
					})
                .ForMember(dest => dest.dlsd_Name, opt => opt.MapFrom(src => src.dlsd_Name))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
		         .ForMember(dest => dest.ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.ModifiedDate != null);
						opt.MapFrom(src => src.ModifiedDate);
					})
		         .ForMember(dest => dest.TaxProfileEnable, opt => 
					{
						opt.Condition((arg1) => arg1.TaxProfileEnable != null);
						opt.MapFrom(src => src.TaxProfileEnable);
					});
            #region [Accounts_Request_SET->SET_p_ucp_set_Accounts_Request]
			//********************** DIRECT:    WebModel(Accounts_Request_SET] -> CallModel[SET_p_ucp_set_Accounts_Request] *************************************
			cfg.CreateMap<Accounts_Request_SET, SET_p_ucp_set_Accounts_Request>()
          		.ForMember(dest => dest.Adlsb_Code, opt => 
					{
						opt.Condition((arg1) => arg1.DeliverZone != null);
						opt.MapFrom(src => src.DeliverZone);
					})
          		.ForMember(dest => dest.Dls_ID, opt => 
					{
						opt.Condition((arg1) => arg1.DeliveryID != null);
						opt.MapFrom(src => src.DeliveryID);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.CurrencyCode))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Acat_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CategoryID != null);
						opt.MapFrom(src => src.CategoryID);
					})
          		.ForMember(dest => dest.Accl_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ClassID != null);
						opt.MapFrom(src => src.ClassID);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
          		.ForMember(dest => dest.Aptp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PayTypeID != null);
						opt.MapFrom(src => src.PayTypeID);
					})
          		.ForMember(dest => dest.Rgsc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.RegistrCatID != null);
						opt.MapFrom(src => src.RegistrCatID);
					})
          		.ForMember(dest => dest.Actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TypeID != null);
						opt.MapFrom(src => src.TypeID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Number))
          		.ForMember(dest => dest.acnt_isAnonymous, opt => 
					{
						opt.Condition((arg1) => arg1.IsAnonymous != null);
						opt.MapFrom(src => src.IsAnonymous);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.Acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_Accounts_Response] -> WebModel Response(Accounts_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_Accounts_Response, Accounts_Response_SET>()
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Acnt_Number))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Acnt_ID != null);
						    opt.MapFrom(src => src.Acnt_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Accounts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Accounts_Request, GET_p_ucp_get_Accounts_Response>();
            cfg.CreateMap<SET_p_ucp_set_Accounts_Request, SET_p_ucp_set_Accounts_Response>();
            #endregion
            #region [Accounts_CustomerAccounts_Request_GET->GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request]
			//********************** DIRECT:    WebModel(Accounts_CustomerAccounts_Request_GET] -> CallModel[GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request] *************************************
			cfg.CreateMap<Accounts_CustomerAccounts_Request_GET, GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request>()
          		.ForMember(dest => dest.isExternalSearch, opt => 
					{
						opt.Condition((arg1) => arg1.isExternalSearch != null);
						opt.MapFrom(src => src.isExternalSearch);
					})
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
          		.ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
          		.ForMember(dest => dest.actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.actp_ID != null);
						opt.MapFrom(src => src.actp_ID);
					})
                .ForMember(dest => dest.bll_Number, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageNumber != null);
						opt.MapFrom(src => src.PageNumber);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response] -> WebModel Response(Accounts_CustomerAccounts_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response, Accounts_CustomerAccounts_Response_GET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Accounts_CustomerAccounts_Request_GET>()

	            	.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response_OUTPUT] -> WebModel Response Output(Accounts_CustomerAccounts_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response_OUTPUT, Accounts_CustomerAccounts_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
		         .ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.actpd_Name, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
		         .ForMember(dest => dest.extCount, opt => 
					{
						opt.Condition((arg1) => arg1.extCount != null);
						opt.MapFrom(src => src.extCount);
					})
		         .ForMember(dest => dest.isClosed, opt => 
					{
						opt.Condition((arg1) => arg1.isClosed != null);
						opt.MapFrom(src => src.isClosed);
					})
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
		         .ForMember(dest => dest.IsSyncEnable, opt => 
					{
						opt.Condition((arg1) => arg1.IsSyncEnable != null);
						opt.MapFrom(src => src.IsSyncEnable);
					})
                .ForMember(dest => dest.msisdn, opt => opt.MapFrom(src => src.msisdn))
		         .ForMember(dest => dest.ParentID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					});
            #region (Accounts/CustomerAccounts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request, GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response>();
            #endregion
            #endregion
            #region [AccountTaxes]
            #region [AccountTaxes_Request_SET->SET_p_ucp_set_AccountTaxes_Request]
			//********************** DIRECT:    WebModel(AccountTaxes_Request_SET] -> CallModel[SET_p_ucp_set_AccountTaxes_Request] *************************************
			cfg.CreateMap<AccountTaxes_Request_SET, SET_p_ucp_set_AccountTaxes_Request>()
          		.ForMember(dest => dest.Enable, opt => 
					{
						opt.Condition((arg1) => arg1.Enable != null);
						opt.MapFrom(src => src.Enable);
					})
          		.ForMember(dest => dest.Txs_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TaxesID != null);
						opt.MapFrom(src => src.TaxesID);
					})
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.Acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Actxb_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_AccountTaxes_Response] -> WebModel Response(AccountTaxes_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_AccountTaxes_Response, AccountTaxes_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Actxb_ID != null);
						    opt.MapFrom(src => src.Actxb_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
            #region (AccountTaxes)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_AccountTaxes_Request, SET_p_ucp_set_AccountTaxes_Response>();
            #endregion
            #endregion
            #region [Addresses]
            #region [Addresses_Request_SET->SET_p_ucp_set_TreeNodeAddresses_Request]
			//********************** DIRECT:    WebModel(Addresses_Request_SET] -> CallModel[SET_p_ucp_set_TreeNodeAddresses_Request] *************************************
			cfg.CreateMap<Addresses_Request_SET, SET_p_ucp_set_TreeNodeAddresses_Request>()
          		.ForMember(dest => dest.Str_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StreetID != null);
						opt.MapFrom(src => src.StreetID);
					})
                .ForMember(dest => dest.Zip_Name, opt => opt.MapFrom(src => src.ZipName))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.House_ID, opt => 
					{
						opt.Condition((arg1) => arg1.HouseID != null);
						opt.MapFrom(src => src.HouseID);
					})
                .ForMember(dest => dest.Appartment, opt => opt.MapFrom(src => src.Appartment))
                .ForMember(dest => dest.Cit_Name, opt => opt.MapFrom(src => src.CityName))
                .ForMember(dest => dest.ContEMail, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.ContFax, opt => opt.MapFrom(src => src.Fax))
                .ForMember(dest => dest.ContPhone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Corpus_Name, opt => opt.MapFrom(src => src.Corpus))
                .ForMember(dest => dest.Cou_Name, opt => opt.MapFrom(src => src.CountryName))
                .ForMember(dest => dest.Dstr_Name, opt => opt.MapFrom(src => src.DistictName))
                .ForMember(dest => dest.House_Name, opt => opt.MapFrom(src => src.HouseName))
                .ForMember(dest => dest.Prov_Name, opt => opt.MapFrom(src => src.ProvinceName))
                .ForMember(dest => dest.Str_Name, opt => opt.MapFrom(src => src.StreetName))
                .ForMember(dest => dest.TextConst, opt => opt.MapFrom(src => src.TextConst))
          		.ForMember(dest => dest.Zip_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ZipID != null);
						opt.MapFrom(src => src.ZipID);
					})
          		.ForMember(dest => dest.Cit_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CityID != null);
						opt.MapFrom(src => src.CityID);
					})
          		.ForMember(dest => dest.Prov_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ProvinceID != null);
						opt.MapFrom(src => src.ProvinceID);
					})
          		.ForMember(dest => dest.Dstr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.DistrictID != null);
						opt.MapFrom(src => src.DistrictID);
					})
          		.ForMember(dest => dest.Cou_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CountyID != null);
						opt.MapFrom(src => src.CountyID);
					})
          		.ForMember(dest => dest.Adrt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.AddressTypeID != null);
						opt.MapFrom(src => src.AddressTypeID);
					})
          		.ForMember(dest => dest.Cttp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CityTypeID != null);
						opt.MapFrom(src => src.CityTypeID);
					})
          		.ForMember(dest => dest.Strt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StreetTypeID != null);
						opt.MapFrom(src => src.StreetTypeID);
					})
          		.ForMember(dest => dest.Adf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.AddressFormat != null);
						opt.MapFrom(src => src.AddressFormat);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.Aadb_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_TreeNodeAddresses_Response] -> WebModel Response(Addresses_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_TreeNodeAddresses_Response, Addresses_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Aadb_ID != null);
						    opt.MapFrom(src => src.Aadb_ID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    });
            #region (Addresses)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_TreeNodeAddresses_Request, SET_p_ucp_set_TreeNodeAddresses_Response>();
            #endregion
            #region [Addresses_Sync_Request_ACTION->ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request]
			//********************** DIRECT:    WebModel(Addresses_Sync_Request_ACTION] -> CallModel[ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request] *************************************
			cfg.CreateMap<Addresses_Sync_Request_ACTION, ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request>()
          		.ForMember(dest => dest.DateEndSync, opt => 
					{
						opt.Condition((arg1) => arg1.DateEndSync != null);
						opt.MapFrom(src => src.DateEndSync);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.wev_User, opt => opt.MapFrom(src => src.wev_User));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response] -> WebModel Response(Addresses_Sync_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response, Addresses_Sync_Response_ACTION>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Addresses/Sync)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request, ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response>();
            #endregion
            #endregion
            #region [Adjustments]
            #region [Adjustments_Request_SET->SET_p_ucp_set_AccountAdjustments_Request]
			//********************** DIRECT:    WebModel(Adjustments_Request_SET] -> CallModel[SET_p_ucp_set_AccountAdjustments_Request] *************************************
			cfg.CreateMap<Adjustments_Request_SET, SET_p_ucp_set_AccountAdjustments_Request>()
          		.ForMember(dest => dest.Aadj_Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TransferTo != null);
						opt.MapFrom(src => src.TransferTo);
					})
          		.ForMember(dest => dest.Aadj_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.Amount != null);
						opt.MapFrom(src => src.Amount);
					})
          		.ForMember(dest => dest.Aadj_Annul, opt => 
					{
						opt.Condition((arg1) => arg1.Annul != null);
						opt.MapFrom(src => src.Annul);
					})
          		.ForMember(dest => dest.Aadj_bll_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BillID != null);
						opt.MapFrom(src => src.BillID);
					})
          		.ForMember(dest => dest.Aadj_Date, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
          		.ForMember(dest => dest.Aadj_DocDate, opt => 
					{
						opt.Condition((arg1) => arg1.DocDate != null);
						opt.MapFrom(src => src.DocDate);
					})
                .ForMember(dest => dest.Aadj_DocNum, opt => opt.MapFrom(src => src.DocNum))
                .ForMember(dest => dest.Aadj_Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Aar_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ReasonID != null);
						opt.MapFrom(src => src.ReasonID);
					})
          		.ForMember(dest => dest.Aat_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TypeID != null);
						opt.MapFrom(src => src.TypeID);
					})
          		.ForMember(dest => dest.Cpay_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PaymentID != null);
						opt.MapFrom(src => src.PaymentID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.Aadj_Aar_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TransferReasonID != null);
						opt.MapFrom(src => src.TransferReasonID);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Sech_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ChargeID != null);
						opt.MapFrom(src => src.ChargeID);
					})
          		.ForMember(dest => dest.Srg_ID, opt => 
					{
						opt.Condition((arg1) => arg1.DetailID != null);
						opt.MapFrom(src => src.DetailID);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Aadj_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.aadj_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.aadj_ExternalID != null);
						opt.MapFrom(src => src.aadj_ExternalID);
					})
          		.ForMember(dest => dest.dnm_id, opt => 
					{
						opt.Condition((arg1) => arg1.dnm_id != null);
						opt.MapFrom(src => src.dnm_id);
					})
          		.ForMember(dest => dest.dsc_id, opt => 
					{
						opt.Condition((arg1) => arg1.dsc_id != null);
						opt.MapFrom(src => src.dsc_id);
					})
          		.ForMember(dest => dest.dsv_id, opt => 
					{
						opt.Condition((arg1) => arg1.dsv_id != null);
						opt.MapFrom(src => src.dsv_id);
					})
          		.ForMember(dest => dest.Ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ExtentionID != null);
						opt.MapFrom(src => src.ExtentionID);
					})
          		.ForMember(dest => dest.NeedCheckPermission, opt => 
					{
						opt.Condition((arg1) => arg1.NeedCheckPermission != null);
						opt.MapFrom(src => src.NeedCheckPermission);
					})
          		.ForMember(dest => dest.NumberATS, opt => 
					{
						opt.Condition((arg1) => arg1.NumberATS != null);
						opt.MapFrom(src => src.NumberATS);
					})
          		.ForMember(dest => dest.pkt_id, opt => 
					{
						opt.Condition((arg1) => arg1.pkt_ID != null);
						opt.MapFrom(src => src.pkt_ID);
					})
          		.ForMember(dest => dest.rpr_id, opt => 
					{
						opt.Condition((arg1) => arg1.rpr_id != null);
						opt.MapFrom(src => src.rpr_id);
					})
          		.ForMember(dest => dest.Srv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ServiceID != null);
						opt.MapFrom(src => src.ServiceID);
					})
          		.ForMember(dest => dest.ss_id, opt => 
					{
						opt.Condition((arg1) => arg1.ss_id != null);
						opt.MapFrom(src => src.ss_id);
					})
          		.ForMember(dest => dest.Subscriber_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Subscriber_ID != null);
						opt.MapFrom(src => src.Subscriber_ID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_AccountAdjustments_Response] -> WebModel Response(Adjustments_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_AccountAdjustments_Response, Adjustments_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Aadj_ID != null);
						    opt.MapFrom(src => src.Aadj_ID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Adjustments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_AccountAdjustments_Request, SET_p_ucp_set_AccountAdjustments_Response>();
            #endregion
            #endregion
            #region [Agreements]
            #region [Agreements_Request_SET->SET_p_ucp_set_SubscriberAgreements_Request]
			//********************** DIRECT:    WebModel(Agreements_Request_SET] -> CallModel[SET_p_ucp_set_SubscriberAgreements_Request] *************************************
			cfg.CreateMap<Agreements_Request_SET, SET_p_ucp_set_SubscriberAgreements_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.TasksJsonData, opt => opt.MapFrom(src => src.TasksJsonData))
          		.ForMember(dest => dest.IsCheckBallance, opt => 
					{
						opt.Condition((arg1) => arg1.IsCheckBallance != null);
						opt.MapFrom(src => src.IsCheckBallance);
					})
          		.ForMember(dest => dest.TemplateIDs, opt => 
					{
						opt.Condition((arg1) => arg1.TemplateIDs != null);
						opt.MapFrom(src => src.TemplateIDs);
					})
          		.ForMember(dest => dest.Rpr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.RepresentationID != null);
						opt.MapFrom(src => src.RepresentationID);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.Grt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PlanGroupID != null);
						opt.MapFrom(src => src.PlanGroupID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Agr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Activate, opt => opt.MapFrom(src => src.Activate))
          		.ForMember(dest => dest.Agr_ID_Old, opt => 
					{
						opt.Condition((arg1) => arg1.Agr_ID_Old != null);
						opt.MapFrom(src => src.Agr_ID_Old);
					})
                .ForMember(dest => dest.Cancel, opt => opt.MapFrom(src => src.Cancel))
          		.ForMember(dest => dest.Grt_ID_New, opt => 
					{
						opt.Condition((arg1) => arg1.Grt_ID_New != null);
						opt.MapFrom(src => src.Grt_ID_New);
					})
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.Rtb_IDs, opt => opt.MapFrom(src => src.Rtb_IDs))
                .ForMember(dest => dest.Services, opt => opt.MapFrom(src => src.Services))
          		.ForMember(dest => dest.TariffBegin, opt => 
					{
						opt.Condition((arg1) => arg1.TariffBegin != null);
						opt.MapFrom(src => src.TariffBegin);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_SubscriberAgreements_Response] -> WebModel Response(Agreements_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_SubscriberAgreements_Response, Agreements_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Agr_ID != null);
						    opt.MapFrom(src => src.Agr_ID);
					    })
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
            #region (Agreements)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_SubscriberAgreements_Request, SET_p_ucp_set_SubscriberAgreements_Response>();
            #endregion
            #region [Agreements_ChangeTariffs_Request_ACTION->ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request]
			//********************** DIRECT:    WebModel(Agreements_ChangeTariffs_Request_ACTION] -> CallModel[ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request] *************************************
			cfg.CreateMap<Agreements_ChangeTariffs_Request_ACTION, ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request>()
                .ForMember(dest => dest.Activate, opt => opt.MapFrom(src => src.Activate))
                .ForMember(dest => dest.Cancel, opt => opt.MapFrom(src => src.Cancel))
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IsCheckBallance, opt => 
					{
						opt.Condition((arg1) => arg1.IsCheckBallance != null);
						opt.MapFrom(src => src.IsCheckBallance);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Agr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Grt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PlanGroupID != null);
						opt.MapFrom(src => src.PlanGroupID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.TariffBegin, opt => 
					{
						opt.Condition((arg1) => arg1.TariffBegin != null);
						opt.MapFrom(src => src.TariffBegin);
					})
                .ForMember(dest => dest.TasksJsonData, opt => opt.MapFrom(src => src.TasksJsonData));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response] -> WebModel Response(Agreements_ChangeTariffs_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response, Agreements_ChangeTariffs_Response_ACTION>()
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Agr_ID != null);
						    opt.MapFrom(src => src.Agr_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Agreements/ChangeTariffs)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request, ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response>();
            #endregion
            #endregion
            #region [Associations]
            #region [Associations_Request_GET->GET_p_ucp_get_Associations_Request]
			//********************** DIRECT:    WebModel(Associations_Request_GET] -> CallModel[GET_p_ucp_get_Associations_Request] *************************************
			cfg.CreateMap<Associations_Request_GET, GET_p_ucp_get_Associations_Request>()
          		.ForMember(dest => dest.mode, opt => 
					{
						opt.Condition((arg1) => arg1.mode != null);
						opt.MapFrom(src => src.mode);
					})
          		.ForMember(dest => dest.Ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Ntw_ID != null);
						opt.MapFrom(src => src.Ntw_ID);
					})
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageNumber != null);
						opt.MapFrom(src => src.PageNumber);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					})
          		.ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
          		.ForMember(dest => dest.Rgsc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Rgsc_ID != null);
						opt.MapFrom(src => src.Rgsc_ID);
					})
          		.ForMember(dest => dest.ShowBalances, opt => 
					{
						opt.Condition((arg1) => arg1.ShowBalances != null);
						opt.MapFrom(src => src.ShowBalances);
					})
                .ForMember(dest => dest.ShowEntities, opt => opt.MapFrom(src => src.ShowEntities))
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection))
          		.ForMember(dest => dest.Srv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Srv_ID != null);
						opt.MapFrom(src => src.Srv_ID);
					})
                .ForMember(dest => dest.Srv_Name, opt => opt.MapFrom(src => src.Srv_Name))
          		.ForMember(dest => dest.Sst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Sst_ID != null);
						opt.MapFrom(src => src.Sst_ID);
					})
                .ForMember(dest => dest.tnst_Code, opt => opt.MapFrom(src => src.tnst_Code))
          		.ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
          		.ForMember(dest => dest.LastModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.LastModifiedDate != null);
						opt.MapFrom(src => src.LastModifiedDate);
					})
                .ForMember(dest => dest.Cntr_Name, opt => opt.MapFrom(src => src.Cntr_Name))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
          		.ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
          		.ForMember(dest => dest.Acat_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Acat_ID != null);
						opt.MapFrom(src => src.Acat_ID);
					})
          		.ForMember(dest => dest.Accl_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Accl_ID != null);
						opt.MapFrom(src => src.Accl_ID);
					})
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Acnt_Number))
          		.ForMember(dest => dest.Actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Actp_ID != null);
						opt.MapFrom(src => src.Actp_ID);
					})
          		.ForMember(dest => dest.Adlsb_Code, opt => 
					{
						opt.Condition((arg1) => arg1.Adlsb_Code != null);
						opt.MapFrom(src => src.Adlsb_Code);
					})
          		.ForMember(dest => dest.Aptp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Aptp_ID != null);
						opt.MapFrom(src => src.Aptp_ID);
					})
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.Bac_Number, opt => opt.MapFrom(src => src.Bac_Number))
                .ForMember(dest => dest.bll_Number, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.BossLastName, opt => opt.MapFrom(src => src.BossLastName))
          		.ForMember(dest => dest.com_ID, opt => 
					{
						opt.Condition((arg1) => arg1.com_ID != null);
						opt.MapFrom(src => src.com_ID);
					})
          		.ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
          		.ForMember(dest => dest.Dls_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Dls_ID != null);
						opt.MapFrom(src => src.Dls_ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
          		.ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.CacheControlDate != null);
						opt.MapFrom(src => src.CacheControlDate);
					})
                .ForMember(dest => dest.jsonFieldsName, opt => opt.MapFrom(src => src.jsonFieldsName))
                .ForMember(dest => dest.jsonFilter, opt => opt.MapFrom(src => src.jsonFilter))
          		.ForMember(dest => dest.jsonFilterContain, opt => 
					{
						opt.Condition((arg1) => arg1.jsonFilterContain != null);
						opt.MapFrom(src => src.jsonFilterContain);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Lng_ID != null);
						opt.MapFrom(src => src.Lng_ID);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_Associations_Response] -> WebModel Response(Associations_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Associations_Response, Associations_Response_GET>()
  		           .ForMember(dest => dest.CacheControlDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Associations_Request_GET>()

	            	.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_Associations_Response_OUTPUT] -> WebModel Response Output(Associations_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Associations_Response_OUTPUT, Associations_Response_GET_OUTPUT>()
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
		         .ForMember(dest => dest.ext_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ID_count != null);
						opt.MapFrom(src => src.ext_ID_count);
					})
		         .ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
		         .ForMember(dest => dest.acnt_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID_count != null);
						opt.MapFrom(src => src.acnt_ID_count);
					})
		         .ForMember(dest => dest.acnt_IsPersonal, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_IsPersonal != null);
						opt.MapFrom(src => src.acnt_IsPersonal);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
		         .ForMember(dest => dest.actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.actp_ID != null);
						opt.MapFrom(src => src.actp_ID);
					})
                .ForMember(dest => dest.actpd_Name, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
		         .ForMember(dest => dest.aut_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.aut_ID_count != null);
						opt.MapFrom(src => src.aut_ID_count);
					})
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
		         .ForMember(dest => dest.aut_NumberAts, opt => 
					{
						opt.Condition((arg1) => arg1.aut_NumberAts != null);
						opt.MapFrom(src => src.aut_NumberAts);
					})
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
		         .ForMember(dest => dest.cntr_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.cntr_ID_count != null);
						opt.MapFrom(src => src.cntr_ID_count);
					})
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
		         .ForMember(dest => dest.com_Id, opt => 
					{
						opt.Condition((arg1) => arg1.com_Id != null);
						opt.MapFrom(src => src.com_Id);
					})
		         .ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
		         .ForMember(dest => dest.isEditAllow, opt => 
					{
						opt.Condition((arg1) => arg1.isEditAllow != null);
						opt.MapFrom(src => src.isEditAllow);
					})
		         .ForMember(dest => dest.isEditWorkPlace, opt => 
					{
						opt.Condition((arg1) => arg1.isEditWorkPlace != null);
						opt.MapFrom(src => src.isEditWorkPlace);
					})
		         .ForMember(dest => dest.lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.lng_ID != null);
						opt.MapFrom(src => src.lng_ID);
					})
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
		         .ForMember(dest => dest.Location_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Location_ID != null);
						opt.MapFrom(src => src.Location_ID);
					})
		         .ForMember(dest => dest.ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ntw_ID != null);
						opt.MapFrom(src => src.ntw_ID);
					})
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
		         .ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
                .ForMember(dest => dest.rptURL, opt => opt.MapFrom(src => src.rptURL))
		         .ForMember(dest => dest.SubsCount, opt => 
					{
						opt.Condition((arg1) => arg1.SubsCount != null);
						opt.MapFrom(src => src.SubsCount);
					})
		         .ForMember(dest => dest.tnst_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ExternalID != null);
						opt.MapFrom(src => src.tnst_ExternalID);
					})
		         .ForMember(dest => dest.tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ID != null);
						opt.MapFrom(src => src.tnst_ID);
					})
		         .ForMember(dest => dest.tnt_AccountMandatory, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_AccountMandatory != null);
						opt.MapFrom(src => src.tnt_AccountMandatory);
					})
		         .ForMember(dest => dest.tnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_ID != null);
						opt.MapFrom(src => src.tnt_ID);
					})
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
		         .ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
		         .ForMember(dest => dest.abn_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Balance != null);
						opt.MapFrom(src => src.abn_Balance);
					})
		         .ForMember(dest => dest.abn_CreateDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_CreateDate != null);
						opt.MapFrom(src => src.abn_CreateDate);
					})
		         .ForMember(dest => dest.abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Date != null);
						opt.MapFrom(src => src.abn_Date);
					})
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
		         .ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
		         .ForMember(dest => dest.abn_Guid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Guid != null);
						opt.MapFrom(src => src.abn_Guid);
					})
		         .ForMember(dest => dest.abn_HasNotEmptyPrepaid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_HasNotEmptyPrepaid != null);
						opt.MapFrom(src => src.abn_HasNotEmptyPrepaid);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.ParentID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID_Boss != null);
						opt.MapFrom(src => src.abn_ID_Boss);
					})
		         .ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
		         .ForMember(dest => dest.abn_IsGuest, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsGuest != null);
						opt.MapFrom(src => src.abn_IsGuest);
					})
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
		         .ForMember(dest => dest.abn_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ModifiedDate != null);
						opt.MapFrom(src => src.abn_ModifiedDate);
					})
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
		         .ForMember(dest => dest.abn_NestedSets_Left, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Left != null);
						opt.MapFrom(src => src.abn_NestedSets_Left);
					})
		         .ForMember(dest => dest.abn_NestedSets_Right, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Right != null);
						opt.MapFrom(src => src.abn_NestedSets_Right);
					})
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
		         .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ShowPhoneDirectory != null);
						opt.MapFrom(src => src.abn_ShowPhoneDirectory);
					})
		         .ForMember(dest => dest.dep_id_boss, opt => 
					{
						opt.Condition((arg1) => arg1.dep_id_boss != null);
						opt.MapFrom(src => src.dep_id_boss);
					})
                .ForMember(dest => dest.dep_Name_boss, opt => opt.MapFrom(src => src.dep_Name_boss))
		         .ForMember(dest => dest.isRefusalChangeName, opt => 
					{
						opt.Condition((arg1) => arg1.isRefusalChangeName != null);
						opt.MapFrom(src => src.isRefusalChangeName);
					})
		         .ForMember(dest => dest.max_ModDate, opt => 
					{
						opt.Condition((arg1) => arg1.max_ModDate != null);
						opt.MapFrom(src => src.max_ModDate);
					})
		         .ForMember(dest => dest.vrr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.vrr_ID != null);
						opt.MapFrom(src => src.vrr_ID);
					});
            #region [Associations_Request_SET->SET_p_ucp_set_Associations_Request]
			//********************** DIRECT:    WebModel(Associations_Request_SET] -> CallModel[SET_p_ucp_set_Associations_Request] *************************************
			cfg.CreateMap<Associations_Request_SET, SET_p_ucp_set_Associations_Request>()
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.Customer_SearchName))
          		.ForMember(dest => dest.Abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.CustomerDate != null);
						opt.MapFrom(src => src.CustomerDate);
					})
          		.ForMember(dest => dest.Lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CustomerLanguageId != null);
						opt.MapFrom(src => src.CustomerLanguageId);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.Abn_IsCreatedWithTariffication, opt => 
					{
						opt.Condition((arg1) => arg1.IsCreatedWithTariffication != null);
						opt.MapFrom(src => src.IsCreatedWithTariffication);
					})
                .ForMember(dest => dest.Abn_Employe_Export_ID, opt => opt.MapFrom(src => src.Export_ID))
          		.ForMember(dest => dest.Grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.GroupID != null);
						opt.MapFrom(src => src.GroupID);
					})
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
          		.ForMember(dest => dest.UpdateAbonentTree, opt => 
					{
						opt.Condition((arg1) => arg1.isUpdateNodeTree != null);
						opt.MapFrom(src => src.isUpdateNodeTree);
					})
                .ForMember(dest => dest.Abn_PositionCode, opt => opt.MapFrom(src => src.PositionCode))
          		.ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
          		.ForMember(dest => dest.Dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.SegmentID != null);
						opt.MapFrom(src => src.SegmentID);
					})
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
                .ForMember(dest => dest.Abn_Employee_ID, opt => opt.MapFrom(src => src.SyncId))
          		.ForMember(dest => dest.Abn_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.TechnicalTag != null);
						opt.MapFrom(src => src.TechnicalTag);
					})
          		.ForMember(dest => dest.Location_ID, opt => 
					{
						opt.Condition((arg1) => arg1.LocationID != null);
						opt.MapFrom(src => src.LocationID);
					})
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Sag_Code, opt => opt.MapFrom(src => src.AgentCode))
          		.ForMember(dest => dest.Sag_ID, opt => 
					{
						opt.Condition((arg1) => arg1.AgentID != null);
						opt.MapFrom(src => src.AgentID);
					})
                .ForMember(dest => dest.Pos_Code, opt => opt.MapFrom(src => src.SalesPointCode))
          		.ForMember(dest => dest.Pos_ID, opt => 
					{
						opt.Condition((arg1) => arg1.SalesPointID != null);
						opt.MapFrom(src => src.SalesPointID);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.Abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.Abn_Guid, opt => 
					{
						opt.Condition((arg1) => arg1.Abn_Guid != null);
						opt.MapFrom(src => src.Abn_Guid);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_Associations_Response] -> WebModel Response(Associations_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_Associations_Response, Associations_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Abn_ID != null);
						    opt.MapFrom(src => src.Abn_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Associations)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Associations_Request, GET_p_ucp_get_Associations_Response>();
            cfg.CreateMap<SET_p_ucp_set_Associations_Request, SET_p_ucp_set_Associations_Response>();
            #endregion
            #region [Associations_Activate_Request_ACTION->ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request]
			//********************** DIRECT:    WebModel(Associations_Activate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request] *************************************
			cfg.CreateMap<Associations_Activate_Request_ACTION, ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request>()
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCode))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response] -> WebModel Response(Associations_Activate_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response, Associations_Activate_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Associations/Activate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request, ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response>();
            #endregion
            #region [Associations_ChangeName_Request_ACTION->ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request]
			//********************** DIRECT:    WebModel(Associations_ChangeName_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request] *************************************
			cfg.CreateMap<Associations_ChangeName_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Abn_FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.SearchName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
          		.ForMember(dest => dest.toClean, opt => 
					{
						opt.Condition((arg1) => arg1.ToClean != null);
						opt.MapFrom(src => src.ToClean);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response] -> WebModel Response(Associations_ChangeName_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response, Associations_ChangeName_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Associations/ChangeName)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request, ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response>();
            #endregion
            #region [Associations_ChangeParent_Request_ACTION->ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request]
			//********************** DIRECT:    WebModel(Associations_ChangeParent_Request_ACTION] -> CallModel[ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request] *************************************
			cfg.CreateMap<Associations_ChangeParent_Request_ACTION, ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request>()
          		.ForMember(dest => dest.ConfAccepted, opt => 
					{
						opt.Condition((arg1) => arg1.ConfAccepted != null);
						opt.MapFrom(src => src.ConfAccepted);
					})
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Parent_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentNode != null);
						opt.MapFrom(src => src.ParentNode);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnst_target_new, opt => 
					{
						opt.Condition((arg1) => arg1.TargetStatusID != null);
						opt.MapFrom(src => src.TargetStatusID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response] -> WebModel Response(Associations_ChangeParent_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response, Associations_ChangeParent_Response_ACTION>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage));
            #region (Associations/ChangeParent)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request, ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response>();
            #endregion
            #region [Associations_ChangeStatus_Request_ACTION->ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request]
			//********************** DIRECT:    WebModel(Associations_ChangeStatus_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request] *************************************
			cfg.CreateMap<Associations_ChangeStatus_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfirmationMessage))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
          		.ForMember(dest => dest.ConfAccepted, opt => 
					{
						opt.Condition((arg1) => arg1.UserAcceptance != null);
						opt.MapFrom(src => src.UserAcceptance);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response] -> WebModel Response(Associations_ChangeStatus_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response, Associations_ChangeStatus_Response_ACTION>()
                .ForMember(dest => dest.ConfirmationMessage, opt => opt.MapFrom(src => src.ConfMessage))
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Associations/ChangeStatus)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request, ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response>();
            #endregion
            #region [Associations_Deactivate_Request_ACTION->ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request]
			//********************** DIRECT:    WebModel(Associations_Deactivate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request] *************************************
			cfg.CreateMap<Associations_Deactivate_Request_ACTION, ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_Code_crnt, opt => opt.MapFrom(src => src.StatusCode))
                .ForMember(dest => dest.Tnst_Code_trgt, opt => opt.MapFrom(src => src.TargetStatusCode));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response] -> WebModel Response(Associations_Deactivate_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response, Associations_Deactivate_Response_ACTION>()
  		           .ForMember(dest => dest.AffectedCount, opt => 
					    {
						    opt.Condition((arg1) => arg1.AffectedCount != null);
						    opt.MapFrom(src => src.AffectedCount);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.WorkEventID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Wev_ID != null);
						    opt.MapFrom(src => src.Wev_ID);
					    });
            #region (Associations/Deactivate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request, ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response>();
            #endregion
            #region [Associations_Details_Request_GET->GET_p_ucp_get_AssociationByID_Associations_Details_Request]
			//********************** DIRECT:    WebModel(Associations_Details_Request_GET] -> CallModel[GET_p_ucp_get_AssociationByID_Associations_Details_Request] *************************************
			cfg.CreateMap<Associations_Details_Request_GET, GET_p_ucp_get_AssociationByID_Associations_Details_Request>()
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.CacheControlDate != null);
						opt.MapFrom(src => src.CacheControlDate);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_AssociationByID_Associations_Details_Response] -> WebModel Response(Associations_Details_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_AssociationByID_Associations_Details_Response, Associations_Details_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.CacheControlDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    });
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Associations_Details_Request_GET>()

					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_AssociationByID_Associations_Details_Response_OUTPUT] -> WebModel Response Output(Associations_Details_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_AssociationByID_Associations_Details_Response_OUTPUT, Associations_Details_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.debt_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.debt_Amount != null);
						opt.MapFrom(src => src.debt_Amount);
					})
		         .ForMember(dest => dest.debt_Date, opt => 
					{
						opt.Condition((arg1) => arg1.debt_Date != null);
						opt.MapFrom(src => src.debt_Date);
					})
		         .ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
		         .ForMember(dest => dest.ext_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ID_count != null);
						opt.MapFrom(src => src.ext_ID_count);
					})
		         .ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
		         .ForMember(dest => dest.isActivated, opt => 
					{
						opt.Condition((arg1) => arg1.isActivated != null);
						opt.MapFrom(src => src.isActivated);
					})
		         .ForMember(dest => dest.isEditAllow, opt => 
					{
						opt.Condition((arg1) => arg1.isEditAllow != null);
						opt.MapFrom(src => src.isEditAllow);
					})
		         .ForMember(dest => dest.isEditWorkPlace, opt => 
					{
						opt.Condition((arg1) => arg1.isEditWorkPlace != null);
						opt.MapFrom(src => src.isEditWorkPlace);
					})
		         .ForMember(dest => dest.lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.lng_ID != null);
						opt.MapFrom(src => src.lng_ID);
					})
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
		         .ForMember(dest => dest.Location_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Location_ID != null);
						opt.MapFrom(src => src.Location_ID);
					})
		         .ForMember(dest => dest.ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ntw_ID != null);
						opt.MapFrom(src => src.ntw_ID);
					})
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
		         .ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
		         .ForMember(dest => dest.SubsCount, opt => 
					{
						opt.Condition((arg1) => arg1.SubsCount != null);
						opt.MapFrom(src => src.SubsCount);
					})
                .ForMember(dest => dest.tnh_LastFM, opt => opt.MapFrom(src => src.tnh_LastFM))
		         .ForMember(dest => dest.tnst_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ExternalID != null);
						opt.MapFrom(src => src.tnst_ExternalID);
					})
		         .ForMember(dest => dest.tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ID != null);
						opt.MapFrom(src => src.tnst_ID);
					})
		         .ForMember(dest => dest.tnt_AccountMandatory, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_AccountMandatory != null);
						opt.MapFrom(src => src.tnt_AccountMandatory);
					})
		         .ForMember(dest => dest.tnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_ID != null);
						opt.MapFrom(src => src.tnt_ID);
					})
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
		         .ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
		         .ForMember(dest => dest.abc_Balance_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Balance_Personal != null);
						opt.MapFrom(src => src.abc_Balance_Personal);
					})
		         .ForMember(dest => dest.abc_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Date != null);
						opt.MapFrom(src => src.abc_Date);
					})
		         .ForMember(dest => dest.abc_Date_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Date_Personal != null);
						opt.MapFrom(src => src.abc_Date_Personal);
					})
		         .ForMember(dest => dest.abn_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Balance != null);
						opt.MapFrom(src => src.abn_Balance);
					})
		         .ForMember(dest => dest.abn_CreateDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_CreateDate != null);
						opt.MapFrom(src => src.abn_CreateDate);
					})
		         .ForMember(dest => dest.abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Date != null);
						opt.MapFrom(src => src.abn_Date);
					})
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
		         .ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
		         .ForMember(dest => dest.abn_Guid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Guid != null);
						opt.MapFrom(src => src.abn_Guid);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID_Boss != null);
						opt.MapFrom(src => src.abn_ID_Boss);
					})
		         .ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
		         .ForMember(dest => dest.abn_IsGuest, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsGuest != null);
						opt.MapFrom(src => src.abn_IsGuest);
					})
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
		         .ForMember(dest => dest.abn_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ModifiedDate != null);
						opt.MapFrom(src => src.abn_ModifiedDate);
					})
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
		         .ForMember(dest => dest.abn_NestedSets_Left, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Left != null);
						opt.MapFrom(src => src.abn_NestedSets_Left);
					})
		         .ForMember(dest => dest.abn_NestedSets_Right, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Right != null);
						opt.MapFrom(src => src.abn_NestedSets_Right);
					})
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
		         .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ShowPhoneDirectory != null);
						opt.MapFrom(src => src.abn_ShowPhoneDirectory);
					})
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.abn_WorkPlace_Personal, opt => opt.MapFrom(src => src.abn_WorkPlace_Personal))
                .ForMember(dest => dest.abn_XmlData, opt => opt.MapFrom(src => src.abn_XmlData))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
		         .ForMember(dest => dest.acnt_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID_count != null);
						opt.MapFrom(src => src.acnt_ID_count);
					})
		         .ForMember(dest => dest.acnt_IsPersonal, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_IsPersonal != null);
						opt.MapFrom(src => src.acnt_IsPersonal);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.Actpd_Name, opt => opt.MapFrom(src => src.Actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
		         .ForMember(dest => dest.abb_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abb_Balance != null);
						opt.MapFrom(src => src.abb_Balance);
					})
		         .ForMember(dest => dest.abb_Balance_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abb_Balance_Personal != null);
						opt.MapFrom(src => src.abb_Balance_Personal);
					})
		         .ForMember(dest => dest.abb_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abb_ModifiedDate != null);
						opt.MapFrom(src => src.abb_ModifiedDate);
					})
		         .ForMember(dest => dest.abb_ModifiedDate_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abb_ModifiedDate_Personal != null);
						opt.MapFrom(src => src.abb_ModifiedDate_Personal);
					})
		         .ForMember(dest => dest.abc_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Balance != null);
						opt.MapFrom(src => src.abc_Balance);
					})
		         .ForMember(dest => dest.atnsb_DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.atnsb_DateEnd != null);
						opt.MapFrom(src => src.atnsb_DateEnd);
					})
		         .ForMember(dest => dest.atnsb_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.atnsb_DateStart != null);
						opt.MapFrom(src => src.atnsb_DateStart);
					})
		         .ForMember(dest => dest.aut_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.aut_ID_count != null);
						opt.MapFrom(src => src.aut_ID_count);
					})
                .ForMember(dest => dest.Boss_Tnt_Type, opt => opt.MapFrom(src => src.Boss_Tnt_Type))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
		         .ForMember(dest => dest.com_Id, opt => 
					{
						opt.Condition((arg1) => arg1.com_Id != null);
						opt.MapFrom(src => src.com_Id);
					})
		         .ForMember(dest => dest.isRefusalChangeName, opt => 
					{
						opt.Condition((arg1) => arg1.isRefusalChangeName != null);
						opt.MapFrom(src => src.isRefusalChangeName);
					});
            #region (Associations/Details)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_AssociationByID_Associations_Details_Request, GET_p_ucp_get_AssociationByID_Associations_Details_Response>();
            #endregion
            #region [Associations_SetLabels_Request_ACTION->ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request]
			//********************** DIRECT:    WebModel(Associations_SetLabels_Request_ACTION] -> CallModel[ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request] *************************************
			cfg.CreateMap<Associations_SetLabels_Request_ACTION, ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.LinkedServer, opt => opt.MapFrom(src => src.LinkedServer))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.SourceQuery, opt => opt.MapFrom(src => src.SourceQuery));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response] -> WebModel Response(Associations_SetLabels_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response, Associations_SetLabels_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Associations/SetLabels)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request, ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response>();
            #endregion
            #endregion
            #region [AuthCodes]
            #region [AuthCodes_Request_SET->SET_p_ucp_set_TreeNodeAuthCodes_Request]
			//********************** DIRECT:    WebModel(AuthCodes_Request_SET] -> CallModel[SET_p_ucp_set_TreeNodeAuthCodes_Request] *************************************
			cfg.CreateMap<AuthCodes_Request_SET, SET_p_ucp_set_TreeNodeAuthCodes_Request>()
                .ForMember(dest => dest.aab_DHCPOption82, opt => opt.MapFrom(src => src.DHCPOption82))
                .ForMember(dest => dest.aab_IdentificationInfo, opt => opt.MapFrom(src => src.IdentificationInfo))
                .ForMember(dest => dest.aab_MACAddress, opt => opt.MapFrom(src => src.MACAddress))
                .ForMember(dest => dest.aab_SessionId, opt => opt.MapFrom(src => src.SessionId))
          		.ForMember(dest => dest.Acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.AccountID != null);
						opt.MapFrom(src => src.AccountID);
					})
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.AccountNumber))
          		.ForMember(dest => dest.aut_ID, opt => 
					{
						opt.Condition((arg1) => arg1.AuthCodeID != null);
						opt.MapFrom(src => src.AuthCodeID);
					})
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCodeName))
                .ForMember(dest => dest.aut_XmlData, opt => opt.MapFrom(src => src.XmlData))
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModifiedFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.NumberAts, opt => 
					{
						opt.Condition((arg1) => arg1.NumberAts != null);
						opt.MapFrom(src => src.NumberAts);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.XmlDataFormat, opt => opt.MapFrom(src => src.XmlDataFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.ipAddress, opt => opt.MapFrom(src => src.IpAddress))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
          		.ForMember(dest => dest.aab_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.ModifiedDate != null);
						opt.MapFrom(src => src.ModifiedDate);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_TreeNodeAuthCodes_Response] -> WebModel Response(AuthCodes_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_TreeNodeAuthCodes_Response, AuthCodes_Response_SET>()
  		           .ForMember(dest => dest.AuthCodeID, opt => 
					    {
						    opt.Condition((arg1) => arg1.aut_ID != null);
						    opt.MapFrom(src => src.aut_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.aab_ID != null);
						    opt.MapFrom(src => src.aab_ID);
					    });
            #region (AuthCodes)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_TreeNodeAuthCodes_Request, SET_p_ucp_set_TreeNodeAuthCodes_Response>();
            #endregion
            #endregion
            #region [BankAccounts]
            #region [BankAccounts_Request_GET->GET_p_ucp_get_BankAccounts_Request]
			//********************** DIRECT:    WebModel(BankAccounts_Request_GET] -> CallModel[GET_p_ucp_get_BankAccounts_Request] *************************************
			cfg.CreateMap<BankAccounts_Request_GET, GET_p_ucp_get_BankAccounts_Request>()
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Abn_ID != null);
						opt.MapFrom(src => src.Abn_ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageNumber != null);
						opt.MapFrom(src => src.PageNumber);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_BankAccounts_Response] -> WebModel Response(BankAccounts_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_BankAccounts_Response, BankAccounts_Response_GET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, BankAccounts_Request_GET>()

	            	.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
	            	.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Id != null);
						opt.MapFrom(src => src.Id);

					});
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_BankAccounts_Response_OUTPUT] -> WebModel Response Output(BankAccounts_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_BankAccounts_Response_OUTPUT, BankAccounts_Response_GET_OUTPUT>()
                .ForMember(dest => dest.AccNumber, opt => opt.MapFrom(src => src.AccNumber))
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.bac_ID != null);
						opt.MapFrom(src => src.bac_ID);
					})
                .ForMember(dest => dest.BankCode, opt => opt.MapFrom(src => src.BankCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.IBAN, opt => opt.MapFrom(src => src.IBAN))
		         .ForMember(dest => dest.loc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.loc_ID != null);
						opt.MapFrom(src => src.loc_ID);
					})
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.OneString, opt => opt.MapFrom(src => src.OneString))
		         .ForMember(dest => dest.bnk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.bnk_ID != null);
						opt.MapFrom(src => src.bnk_ID);
					})
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					});
            #region (BankAccounts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_BankAccounts_Request, GET_p_ucp_get_BankAccounts_Response>();
            #endregion
            #endregion
            #region [BankDetails]
            #region [BankDetails_Request_SET->SET_p_ucp_set_BankDetails_Request]
			//********************** DIRECT:    WebModel(BankDetails_Request_SET] -> CallModel[SET_p_ucp_set_BankDetails_Request] *************************************
			cfg.CreateMap<BankDetails_Request_SET, SET_p_ucp_set_BankDetails_Request>()
          		.ForMember(dest => dest.Esys_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Esys_ID != null);
						opt.MapFrom(src => src.Esys_ID);
					})
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
                .ForMember(dest => dest.Bac_IBANCode, opt => opt.MapFrom(src => src.IBANCode))
          		.ForMember(dest => dest.Bnk_CloseDate, opt => 
					{
						opt.Condition((arg1) => arg1.BankCloseDate != null);
						opt.MapFrom(src => src.BankCloseDate);
					})
                .ForMember(dest => dest.Bnk_JsonData, opt => opt.MapFrom(src => src.BankJsonData))
          		.ForMember(dest => dest.Bnk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BankID != null);
						opt.MapFrom(src => src.BankID);
					})
          		.ForMember(dest => dest.Bac_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BankAccountID != null);
						opt.MapFrom(src => src.BankAccountID);
					})
          		.ForMember(dest => dest.Cit_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CityID != null);
						opt.MapFrom(src => src.CityID);
					})
          		.ForMember(dest => dest.Loc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.LocationID != null);
						opt.MapFrom(src => src.LocationID);
					})
          		.ForMember(dest => dest.Cou_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CountryID != null);
						opt.MapFrom(src => src.CountryID);
					})
                .ForMember(dest => dest.Bnk_Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.Bnkd_Name, opt => opt.MapFrom(src => src.BankName))
                .ForMember(dest => dest.Bnk_BankCode, opt => opt.MapFrom(src => src.BankCode))
                .ForMember(dest => dest.Bac_Number, opt => opt.MapFrom(src => src.BankAccountNumber))
                .ForMember(dest => dest.Bnk_CloseBy, opt => opt.MapFrom(src => src.BankCloseBy))
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.Adab_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_BankDetails_Response] -> WebModel Response(BankDetails_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_BankDetails_Response, BankDetails_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Adab_ID != null);
						    opt.MapFrom(src => src.Adab_ID);
					    })
  		           .ForMember(dest => dest.BankAccountID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Bac_ID != null);
						    opt.MapFrom(src => src.Bac_ID);
					    })
  		           .ForMember(dest => dest.BankID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Bnk_ID != null);
						    opt.MapFrom(src => src.Bnk_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    });
            #region (BankDetails)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_BankDetails_Request, SET_p_ucp_set_BankDetails_Response>();
            #endregion
            #endregion
            #region [BankStatements]
            #region [BankStatements_Request_GET->GET_p_ucp_get_BatchPayDocRecords_Request]
			//********************** DIRECT:    WebModel(BankStatements_Request_GET] -> CallModel[GET_p_ucp_get_BatchPayDocRecords_Request] *************************************
			cfg.CreateMap<BankStatements_Request_GET, GET_p_ucp_get_BatchPayDocRecords_Request>()
                .ForMember(dest => dest.Bank_Account_NUM, opt => opt.MapFrom(src => src.BankAccountNumberTo))
                .ForMember(dest => dest.Bank_MFO, opt => opt.MapFrom(src => src.BankCodeTo))
          		.ForMember(dest => dest.Batch_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BatchID != null);
						opt.MapFrom(src => src.BatchID);
					})
          		.ForMember(dest => dest.Date_doc, opt => 
					{
						opt.Condition((arg1) => arg1.PayDate != null);
						opt.MapFrom(src => src.PayDate);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_BatchPayDocRecords_Response] -> WebModel Response(BankStatements_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_BatchPayDocRecords_Response, BankStatements_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, BankStatements_Request_GET>()

					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_BatchPayDocRecords_Response_OUTPUT] -> WebModel Response Output(BankStatements_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_BatchPayDocRecords_Response_OUTPUT, BankStatements_Response_GET_OUTPUT>()
                .ForMember(dest => dest.BankAccountNumberFrom, opt => opt.MapFrom(src => src.accountfrom))
		         .ForMember(dest => dest.Amount, opt => 
					{
						opt.Condition((arg1) => arg1.amount != null);
						opt.MapFrom(src => src.amount);
					})
		         .ForMember(dest => dest.BankAccountExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.bank_account_ID != null);
						opt.MapFrom(src => src.bank_account_ID);
					})
                .ForMember(dest => dest.BankAccountNumberTo, opt => opt.MapFrom(src => src.bank_account_num))
		         .ForMember(dest => dest.pre_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.bank_st_ID != null);
						opt.MapFrom(src => src.bank_st_ID);
					})
                .ForMember(dest => dest.PaymentOrder, opt => opt.MapFrom(src => src.bank_trx_number))
                .ForMember(dest => dest.BankInternalCodeTo, opt => opt.MapFrom(src => src.bankcode))
		         .ForMember(dest => dest.BatchID, opt => 
					{
						opt.Condition((arg1) => arg1.batch_id != null);
						opt.MapFrom(src => src.batch_id);
					})
		         .ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.creation_date != null);
						opt.MapFrom(src => src.creation_date);
					})
		         .ForMember(dest => dest.PayDate, opt => 
					{
						opt.Condition((arg1) => arg1.date_doc != null);
						opt.MapFrom(src => src.date_doc);
					})
		         .ForMember(dest => dest.cpd_ExportID, opt => 
					{
						opt.Condition((arg1) => arg1.doc_ID != null);
						opt.MapFrom(src => src.doc_ID);
					})
                .ForMember(dest => dest.pre_NumReestr, opt => opt.MapFrom(src => src.list_num))
                .ForMember(dest => dest.BankCodeTo, opt => opt.MapFrom(src => src.mfo))
                .ForMember(dest => dest.BankCodeFrom, opt => opt.MapFrom(src => src.mfofrom))
                .ForMember(dest => dest.BankNameFrom, opt => opt.MapFrom(src => src.namefrom))
                .ForMember(dest => dest.BusinessUIDFrom, opt => opt.MapFrom(src => src.okpofrom))
		         .ForMember(dest => dest.TenantID, opt => 
					{
						opt.Condition((arg1) => arg1.org_ID != null);
						opt.MapFrom(src => src.org_ID);
					})
                .ForMember(dest => dest.RequestNumber, opt => opt.MapFrom(src => src.req_num))
		         .ForMember(dest => dest.PayDocStatusId, opt => 
					{
						opt.Condition((arg1) => arg1.status != null);
						opt.MapFrom(src => src.status);
					})
                .ForMember(dest => dest.TransactionCode, opt => opt.MapFrom(src => src.trx_code))
                .ForMember(dest => dest.TransactionText, opt => opt.MapFrom(src => src.trx_text))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.bill_acc));
            #region [BankStatements_Request_SET->SET_p_ucp_set_BatchPayDocRecords_Request]
			//********************** DIRECT:    WebModel(BankStatements_Request_SET] -> CallModel[SET_p_ucp_set_BatchPayDocRecords_Request] *************************************
			cfg.CreateMap<BankStatements_Request_SET, SET_p_ucp_set_BatchPayDocRecords_Request>()
                .ForMember(dest => dest.Bank_Account_NUM, opt => opt.MapFrom(src => src.BankAccountNumberTo))
                .ForMember(dest => dest.Bank_MFO, opt => opt.MapFrom(src => src.BankCodeTo))
          		.ForMember(dest => dest.Batch_Count, opt => 
					{
						opt.Condition((arg1) => arg1.RowCount != null);
						opt.MapFrom(src => src.RowCount);
					})
          		.ForMember(dest => dest.Batch_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Bil_Account, opt => opt.MapFrom(src => src.IsBillingAccount))
          		.ForMember(dest => dest.Date_doc, opt => 
					{
						opt.Condition((arg1) => arg1.PayDate != null);
						opt.MapFrom(src => src.PayDate);
					})
          		.ForMember(dest => dest.Doc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.cpd_ExportID != null);
						opt.MapFrom(src => src.cpd_ExportID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Org_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TenantID != null);
						opt.MapFrom(src => src.TenantID);
					})
                .ForMember(dest => dest.Remitted, opt => opt.MapFrom(src => src.IsPostponed))
          		.ForMember(dest => dest.Result, opt => 
					{
						opt.Condition((arg1) => arg1.Result != null);
						opt.MapFrom(src => src.Result);
					})
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.PayDocStatusCode))
          		.ForMember(dest => dest.User_ID, opt => 
					{
						opt.Condition((arg1) => arg1.UserID != null);
						opt.MapFrom(src => src.UserID);
					})
          		.ForMember(dest => dest.Bac_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_BatchPayDocRecords_Response] -> WebModel Response(BankStatements_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_BatchPayDocRecords_Response, BankStatements_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Batch_ID != null);
						    opt.MapFrom(src => src.Batch_ID);
					    })
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.Result, opt => 
					    {
						    opt.Condition((arg1) => arg1.Result != null);
						    opt.MapFrom(src => src.Result);
					    });
            #region (BankStatements)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_BatchPayDocRecords_Request, GET_p_ucp_get_BatchPayDocRecords_Response>();
            cfg.CreateMap<SET_p_ucp_set_BatchPayDocRecords_Request, SET_p_ucp_set_BatchPayDocRecords_Response>();
            #endregion
            #region [BankStatements_ChangePaymentsStatus_Request_ACTION->ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request]
			//********************** DIRECT:    WebModel(BankStatements_ChangePaymentsStatus_Request_ACTION] -> CallModel[ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request] *************************************
			cfg.CreateMap<BankStatements_ChangePaymentsStatus_Request_ACTION, ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request>()
          		.ForMember(dest => dest.Doc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.cpd_ExportID != null);
						opt.MapFrom(src => src.cpd_ExportID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Status_AU, opt => 
					{
						opt.Condition((arg1) => arg1.PayDocStatusId != null);
						opt.MapFrom(src => src.PayDocStatusId);
					})
          		.ForMember(dest => dest.Result, opt => 
					{
						opt.Condition((arg1) => arg1.Result != null);
						opt.MapFrom(src => src.Result);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response] -> WebModel Response(BankStatements_ChangePaymentsStatus_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response, BankStatements_ChangePaymentsStatus_Response_ACTION>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.Result, opt => 
					    {
						    opt.Condition((arg1) => arg1.Result != null);
						    opt.MapFrom(src => src.Result);
					    });
            #region (BankStatements/ChangePaymentsStatus)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request, ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response>();
            #endregion
            #region [BankStatements_CheckNoSavePayments_Request_ACTION->ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request]
			//********************** DIRECT:    WebModel(BankStatements_CheckNoSavePayments_Request_ACTION] -> CallModel[ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request] *************************************
			cfg.CreateMap<BankStatements_CheckNoSavePayments_Request_ACTION, ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request>()
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Result, opt => 
					{
						opt.Condition((arg1) => arg1.Result != null);
						opt.MapFrom(src => src.Result);
					})
          		.ForMember(dest => dest.User_ID, opt => 
					{
						opt.Condition((arg1) => arg1.UserID != null);
						opt.MapFrom(src => src.UserID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response] -> WebModel Response(BankStatements_CheckNoSavePayments_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response, BankStatements_CheckNoSavePayments_Response_ACTION>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.Result, opt => 
					    {
						    opt.Condition((arg1) => arg1.Result != null);
						    opt.MapFrom(src => src.Result);
					    });
            #region (BankStatements/CheckNoSavePayments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request, ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response>();
            #endregion
            #region [BankStatements_ClearBatch_Request_ACTION->ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request]
			//********************** DIRECT:    WebModel(BankStatements_ClearBatch_Request_ACTION] -> CallModel[ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request] *************************************
			cfg.CreateMap<BankStatements_ClearBatch_Request_ACTION, ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request>()
          		.ForMember(dest => dest.Batch_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BatchID != null);
						opt.MapFrom(src => src.BatchID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Result, opt => 
					{
						opt.Condition((arg1) => arg1.Result != null);
						opt.MapFrom(src => src.Result);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response] -> WebModel Response(BankStatements_ClearBatch_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response, BankStatements_ClearBatch_Response_ACTION>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.Result, opt => 
					    {
						    opt.Condition((arg1) => arg1.Result != null);
						    opt.MapFrom(src => src.Result);
					    });
            #region (BankStatements/ClearBatch)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request, ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response>();
            #endregion
            #endregion
            #region [BankStatementTransactions]
            #region [BankStatementTransactions_Request_GET->GET_p_ucp_get_BankStatements_Request]
			//********************** DIRECT:    WebModel(BankStatementTransactions_Request_GET] -> CallModel[GET_p_ucp_get_BankStatements_Request] *************************************
			cfg.CreateMap<BankStatementTransactions_Request_GET, GET_p_ucp_get_BankStatements_Request>()
          		.ForMember(dest => dest.Bac_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BankAccountID != null);
						opt.MapFrom(src => src.BankAccountID);
					})
          		.ForMember(dest => dest.DateFrom, opt => 
					{
						opt.Condition((arg1) => arg1.DateFrom != null);
						opt.MapFrom(src => src.DateFrom);
					})
          		.ForMember(dest => dest.DateTo, opt => 
					{
						opt.Condition((arg1) => arg1.DateTo != null);
						opt.MapFrom(src => src.DateTo);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.If_Modified_Since != null);
						opt.MapFrom(src => src.If_Modified_Since);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.Page != null);
						opt.MapFrom(src => src.Page);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					})
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_BankStatements_Response] -> WebModel Response(BankStatementTransactions_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_BankStatements_Response, BankStatementTransactions_Response_GET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
  		           .ForMember(dest => dest.If_Modified_Since, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, BankStatementTransactions_Request_GET>()

	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_BankStatements_Response_OUTPUT] -> WebModel Response Output(BankStatementTransactions_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_BankStatements_Response_OUTPUT, BankStatementTransactions_Response_GET_OUTPUT>()
                .ForMember(dest => dest.BankAccountNumberFrom, opt => opt.MapFrom(src => src.accountfrom))
		         .ForMember(dest => dest.Amount, opt => 
					{
						opt.Condition((arg1) => arg1.amount != null);
						opt.MapFrom(src => src.amount);
					})
		         .ForMember(dest => dest.BankAccountExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.bank_account_ID != null);
						opt.MapFrom(src => src.bank_account_ID);
					})
                .ForMember(dest => dest.BankAccountNumberTo, opt => opt.MapFrom(src => src.bank_account_num))
		         .ForMember(dest => dest.pre_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.bank_st_ID != null);
						opt.MapFrom(src => src.bank_st_ID);
					})
                .ForMember(dest => dest.PaymentOrder, opt => opt.MapFrom(src => src.bank_trx_number))
                .ForMember(dest => dest.BankInternalCodeTo, opt => opt.MapFrom(src => src.bankcode))
		         .ForMember(dest => dest.BatchID, opt => 
					{
						opt.Condition((arg1) => arg1.batch_id != null);
						opt.MapFrom(src => src.batch_id);
					})
		         .ForMember(dest => dest.acnt_Number, opt => 
					{
						opt.Condition((arg1) => arg1.bill_acc != null);
						opt.MapFrom(src => src.bill_acc);
					})
		         .ForMember(dest => dest.CreatedBy, opt => 
					{
						opt.Condition((arg1) => arg1.created_by != null);
						opt.MapFrom(src => src.created_by);
					})
		         .ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.creation_date != null);
						opt.MapFrom(src => src.creation_date);
					})
                .ForMember(dest => dest.crn_CodeISO, opt => opt.MapFrom(src => src.currency_code))
		         .ForMember(dest => dest.PayDate, opt => 
					{
						opt.Condition((arg1) => arg1.date_doc != null);
						opt.MapFrom(src => src.date_doc);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.doc_ID != null);
						opt.MapFrom(src => src.doc_ID);
					})
		         .ForMember(dest => dest.ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.last_update_date != null);
						opt.MapFrom(src => src.last_update_date);
					})
		         .ForMember(dest => dest.ModifiedDBy, opt => 
					{
						opt.Condition((arg1) => arg1.last_updated_by != null);
						opt.MapFrom(src => src.last_updated_by);
					})
                .ForMember(dest => dest.pre_NumReestr, opt => opt.MapFrom(src => src.list_num))
                .ForMember(dest => dest.BankCodeTo, opt => opt.MapFrom(src => src.mfo))
                .ForMember(dest => dest.BankCodeFrom, opt => opt.MapFrom(src => src.mfofrom))
                .ForMember(dest => dest.BankNameFrom, opt => opt.MapFrom(src => src.namefrom))
                .ForMember(dest => dest.BusinessUIDFrom, opt => opt.MapFrom(src => src.okpofrom))
		         .ForMember(dest => dest.TenantID, opt => 
					{
						opt.Condition((arg1) => arg1.org_ID != null);
						opt.MapFrom(src => src.org_ID);
					})
                .ForMember(dest => dest.RequestNumber, opt => opt.MapFrom(src => src.req_num))
		         .ForMember(dest => dest.Status, opt => 
					{
						opt.Condition((arg1) => arg1.status != null);
						opt.MapFrom(src => src.status);
					})
                .ForMember(dest => dest.StatusCode, opt => opt.MapFrom(src => src.status_code))
                .ForMember(dest => dest.StatusName, opt => opt.MapFrom(src => src.statusName))
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
                .ForMember(dest => dest.TransactionCode, opt => opt.MapFrom(src => src.trx_code))
                .ForMember(dest => dest.TransactionText, opt => opt.MapFrom(src => src.trx_text))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.userName));
            #region (BankStatementTransactions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_BankStatements_Request, GET_p_ucp_get_BankStatements_Response>();
            #endregion
            #endregion
            #region [BillingTasks]
            #region [BillingTasks_Request_SET->SET_sp_set_BillingTasks_Request]
			//********************** DIRECT:    WebModel(BillingTasks_Request_SET] -> CallModel[SET_sp_set_BillingTasks_Request] *************************************
			cfg.CreateMap<BillingTasks_Request_SET, SET_sp_set_BillingTasks_Request>()
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.abn_grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.GroupID != null);
						opt.MapFrom(src => src.GroupID);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.opt_XmlData, opt => opt.MapFrom(src => src.Options))
                .ForMember(dest => dest.pkt_IDs, opt => opt.MapFrom(src => src.PacketsIDs))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.srv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ServiceID != null);
						opt.MapFrom(src => src.ServiceID);
					})
          		.ForMember(dest => dest.srv_ID_Accumulative, opt => 
					{
						opt.Condition((arg1) => arg1.ServiceIDAccumulative != null);
						opt.MapFrom(src => src.ServiceIDAccumulative);
					})
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.ExitAfterFirstError, opt => 
					{
						opt.Condition((arg1) => arg1.ExitAfterFirstError != null);
						opt.MapFrom(src => src.ExitAfterFirstError);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.cacheStatus, opt => opt.MapFrom(src => src.cacheStatus))
          		.ForMember(dest => dest.Tsk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.srs_ID_list, opt => opt.MapFrom(src => src.srs_ID_list))
                .ForMember(dest => dest.Tsst_Code, opt => opt.MapFrom(src => src.Tsst_Code));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_sp_set_BillingTasks_Response] -> WebModel Response(BillingTasks_Response_SET) *************************************
			cfg.CreateMap<SET_sp_set_BillingTasks_Response, BillingTasks_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Tsk_ID != null);
						    opt.MapFrom(src => src.Tsk_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    });
            #region (BillingTasks)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_sp_set_BillingTasks_Request, SET_sp_set_BillingTasks_Response>();
            #endregion
            #endregion
            #region [CallCredits]
            #region [CallCredits_Request_SET->SET_p_ucp_set_DiscountValue4Subscriber_Request]
			//********************** DIRECT:    WebModel(CallCredits_Request_SET] -> CallModel[SET_p_ucp_set_DiscountValue4Subscriber_Request] *************************************
			cfg.CreateMap<CallCredits_Request_SET, SET_p_ucp_set_DiscountValue4Subscriber_Request>()
          		.ForMember(dest => dest.DiscountForm, opt => 
					{
						opt.Condition((arg1) => arg1.DiscountForm != null);
						opt.MapFrom(src => src.DiscountForm);
					})
          		.ForMember(dest => dest.DiscountFormParam, opt => 
					{
						opt.Condition((arg1) => arg1.DiscountFormParam != null);
						opt.MapFrom(src => src.DiscountFormParam);
					})
          		.ForMember(dest => dest.dsc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.DiscountID != null);
						opt.MapFrom(src => src.DiscountID);
					})
                .ForMember(dest => dest.dsvs_ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.dsvs_ModifiedFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.isAnnul, opt => 
					{
						opt.Condition((arg1) => arg1.isAnnul != null);
						opt.MapFrom(src => src.isAnnul);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.DateSet, opt => 
					{
						opt.Condition((arg1) => arg1.DateSet != null);
						opt.MapFrom(src => src.DateSet);
					})
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.dab_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_DiscountValue4Subscriber_Response] -> WebModel Response(CallCredits_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_DiscountValue4Subscriber_Response, CallCredits_Response_SET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.dab_ID != null);
						    opt.MapFrom(src => src.dab_ID);
					    });
            #region (CallCredits)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_DiscountValue4Subscriber_Request, SET_p_ucp_set_DiscountValue4Subscriber_Response>();
            #endregion
            #endregion
            #region [CallUserGroups]
            #region [CallUserGroups_Request_SET->SET_p_ucp_set_CodeRegionGroups_Request]
			//********************** DIRECT:    WebModel(CallUserGroups_Request_SET] -> CallModel[SET_p_ucp_set_CodeRegionGroups_Request] *************************************
			cfg.CreateMap<CallUserGroups_Request_SET, SET_p_ucp_set_CodeRegionGroups_Request>()
          		.ForMember(dest => dest.Crg_DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.Crg_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.Crg_Order, opt => 
					{
						opt.Condition((arg1) => arg1.Priority != null);
						opt.MapFrom(src => src.Priority);
					})
                .ForMember(dest => dest.Crg_Prefixes, opt => opt.MapFrom(src => src.Prefixes))
                .ForMember(dest => dest.Crg_RegionName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Crg_RegionNameEN, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.Crgo_Options, opt => opt.MapFrom(src => src.Options))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Type, opt => 
					{
						opt.Condition((arg1) => arg1.Type != null);
						opt.MapFrom(src => src.Type);
					})
          		.ForMember(dest => dest.Crg_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Crg_Default, opt => 
					{
						opt.Condition((arg1) => arg1.Crg_Default != null);
						opt.MapFrom(src => src.Crg_Default);
					})
          		.ForMember(dest => dest.Crg_IsUniqueCodes, opt => 
					{
						opt.Condition((arg1) => arg1.Crg_IsUniqueCodes != null);
						opt.MapFrom(src => src.Crg_IsUniqueCodes);
					})
          		.ForMember(dest => dest.Crgt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Crgt_ID != null);
						opt.MapFrom(src => src.Crgt_ID);
					})
                .ForMember(dest => dest.RegionNameEN, opt => opt.MapFrom(src => src.RegionNameEN))
                .ForMember(dest => dest.RegionNameRU, opt => opt.MapFrom(src => src.RegionNameRU))
                .ForMember(dest => dest.RegionNameUK, opt => opt.MapFrom(src => src.RegionNameUK));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_CodeRegionGroups_Response] -> WebModel Response(CallUserGroups_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_CodeRegionGroups_Response, CallUserGroups_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Crg_ID != null);
						    opt.MapFrom(src => src.Crg_ID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (CallUserGroups)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_CodeRegionGroups_Request, SET_p_ucp_set_CodeRegionGroups_Response>();
            #endregion
            #endregion
            #region [Contracts]
            #region [Contracts_Request_SET->SET_p_ucp_set_Contracts_Request]
			//********************** DIRECT:    WebModel(Contracts_Request_SET] -> CallModel[SET_p_ucp_set_Contracts_Request] *************************************
			cfg.CreateMap<Contracts_Request_SET, SET_p_ucp_set_Contracts_Request>()
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
          		.ForMember(dest => dest.aut_ID, opt => 
					{
						opt.Condition((arg1) => arg1.AuthCodeID != null);
						opt.MapFrom(src => src.AuthCodeID);
					})
          		.ForMember(dest => dest.cntc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ClassID != null);
						opt.MapFrom(src => src.ClassID);
					})
          		.ForMember(dest => dest.cntg_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CategoryID != null);
						opt.MapFrom(src => src.CategoryID);
					})
          		.ForMember(dest => dest.cntr_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.Amount != null);
						opt.MapFrom(src => src.Amount);
					})
          		.ForMember(dest => dest.cntr_DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.cntr_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.cntr_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.ExternalID != null);
						opt.MapFrom(src => src.ExternalID);
					})
                .ForMember(dest => dest.cntr_JsonData, opt => opt.MapFrom(src => src.JsonData))
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.Name))
          		.ForMember(dest => dest.cntr_Primary, opt => 
					{
						opt.Condition((arg1) => arg1.Primary != null);
						opt.MapFrom(src => src.Primary);
					})
                .ForMember(dest => dest.cntr_Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.cnts_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ExtentionID != null);
						opt.MapFrom(src => src.ExtentionID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.cntr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_Contracts_Response] -> WebModel Response(Contracts_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_Contracts_Response, Contracts_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.cntr_ID != null);
						    opt.MapFrom(src => src.cntr_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Contracts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_Contracts_Request, SET_p_ucp_set_Contracts_Response>();
            #endregion
            #endregion
            #region [CustomerPayments]
            #region [CustomerPayments_Request_GET->GET_p_ucp_get_CustomerPayments_Request]
			//********************** DIRECT:    WebModel(CustomerPayments_Request_GET] -> CallModel[GET_p_ucp_get_CustomerPayments_Request] *************************************
			cfg.CreateMap<CustomerPayments_Request_GET, GET_p_ucp_get_CustomerPayments_Request>()
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CustomerID != null);
						opt.MapFrom(src => src.CustomerID);
					})
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
          		.ForMember(dest => dest.AmountFrom, opt => 
					{
						opt.Condition((arg1) => arg1.AmountFrom != null);
						opt.MapFrom(src => src.AmountFrom);
					})
          		.ForMember(dest => dest.AmountTo, opt => 
					{
						opt.Condition((arg1) => arg1.AmountTo != null);
						opt.MapFrom(src => src.AmountTo);
					})
          		.ForMember(dest => dest.Bac_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BankAccountID != null);
						opt.MapFrom(src => src.BankAccountID);
					})
                .ForMember(dest => dest.Bnk_BankCode, opt => opt.MapFrom(src => src.BankCode))
                .ForMember(dest => dest.Cof_Remark, opt => opt.MapFrom(src => src.KassaRemark))
          		.ForMember(dest => dest.Cpay_Annul, opt => 
					{
						opt.Condition((arg1) => arg1.Annul != null);
						opt.MapFrom(src => src.Annul);
					})
          		.ForMember(dest => dest.Cpay_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Cpay_Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Cpc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PayClass != null);
						opt.MapFrom(src => src.PayClass);
					})
                .ForMember(dest => dest.Cpd_ExternalID, opt => opt.MapFrom(src => src.ParentID))
                .ForMember(dest => dest.Cpd_PayDocNumber, opt => opt.MapFrom(src => src.PayDocNumber))
          		.ForMember(dest => dest.Cpif_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PayInterfaceID != null);
						opt.MapFrom(src => src.PayInterfaceID);
					})
                .ForMember(dest => dest.Cpifd_Name, opt => opt.MapFrom(src => src.PayInterfaceName))
          		.ForMember(dest => dest.DateFrom, opt => 
					{
						opt.Condition((arg1) => arg1.DateFrom != null);
						opt.MapFrom(src => src.DateFrom);
					})
          		.ForMember(dest => dest.DateTo, opt => 
					{
						opt.Condition((arg1) => arg1.DateTo != null);
						opt.MapFrom(src => src.DateTo);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.CacheControlDate != null);
						opt.MapFrom(src => src.CacheControlDate);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageNumber != null);
						opt.MapFrom(src => src.PageNumber);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					})
                .ForMember(dest => dest.Pre_NumReestr, opt => opt.MapFrom(src => src.ReestrNumber))
          		.ForMember(dest => dest.aar_ID, opt => 
					{
						opt.Condition((arg1) => arg1.aar_ID != null);
						opt.MapFrom(src => src.aar_ID);
					})
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection))
          		.ForMember(dest => dest.IsExternalSync, opt => 
					{
						opt.Condition((arg1) => arg1.IsExternalSync != null);
						opt.MapFrom(src => src.IsExternalSync);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_CustomerPayments_Response] -> WebModel Response(CustomerPayments_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerPayments_Response, CustomerPayments_Response_GET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
  		           .ForMember(dest => dest.CacheControlDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, CustomerPayments_Request_GET>()

	            	.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_CustomerPayments_Response_OUTPUT] -> WebModel Response Output(CustomerPayments_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerPayments_Response_OUTPUT, CustomerPayments_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.Moved, opt => 
					{
						opt.Condition((arg1) => arg1.cpd_Moved != null);
						opt.MapFrom(src => src.cpd_Moved);
					})
                .ForMember(dest => dest.PayDocNumber, opt => opt.MapFrom(src => src.cpd_PayDocNumber))
                .ForMember(dest => dest.PayINN, opt => opt.MapFrom(src => src.cpd_PayINN))
		         .ForMember(dest => dest.PayInterfaceID, opt => 
					{
						opt.Condition((arg1) => arg1.cpif_ID != null);
						opt.MapFrom(src => src.cpif_ID);
					})
                .ForMember(dest => dest.PayInterfaceName, opt => opt.MapFrom(src => src.cpifd_Name))
                .ForMember(dest => dest.currency_Name, opt => opt.MapFrom(src => src.currency_Name))
                .ForMember(dest => dest.customer_Name, opt => opt.MapFrom(src => src.customer_Name))
		         .ForMember(dest => dest.IsPayDoc, opt => 
					{
						opt.Condition((arg1) => arg1.IsPayDoc != null);
						opt.MapFrom(src => src.IsPayDoc);
					})
		         .ForMember(dest => dest.ReestrDate, opt => 
					{
						opt.Condition((arg1) => arg1.pre_DateReestr != null);
						opt.MapFrom(src => src.pre_DateReestr);
					})
                .ForMember(dest => dest.ReestrNumber, opt => opt.MapFrom(src => src.pre_NumReestr))
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
                .ForMember(dest => dest.BankAccountNumber, opt => opt.MapFrom(src => src.bac_Number))
		         .ForMember(dest => dest.BillDateCreate, opt => 
					{
						opt.Condition((arg1) => arg1.bll_DateCreate != null);
						opt.MapFrom(src => src.bll_DateCreate);
					})
                .ForMember(dest => dest.BillNumber, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.bnkd_Name))
                .ForMember(dest => dest.KassaRemark, opt => opt.MapFrom(src => src.cof_Remark))
                .ForMember(dest => dest.Account, opt => opt.MapFrom(src => src.cpay_Account))
		         .ForMember(dest => dest.cpay_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.cpay_Amount != null);
						opt.MapFrom(src => src.cpay_Amount);
					})
		         .ForMember(dest => dest.cpay_AmountTaxes, opt => 
					{
						opt.Condition((arg1) => arg1.cpay_AmountTaxes != null);
						opt.MapFrom(src => src.cpay_AmountTaxes);
					})
		         .ForMember(dest => dest.Annul, opt => 
					{
						opt.Condition((arg1) => arg1.cpay_Annul != null);
						opt.MapFrom(src => src.cpay_Annul);
					})
		         .ForMember(dest => dest.DatePay, opt => 
					{
						opt.Condition((arg1) => arg1.cpay_DatePay != null);
						opt.MapFrom(src => src.cpay_DatePay);
					})
                .ForMember(dest => dest.cpay_ExternalID, opt => opt.MapFrom(src => src.cpay_ExternalID))
		         .ForMember(dest => dest.cpay_ID, opt => 
					{
						opt.Condition((arg1) => arg1.cpay_ID != null);
						opt.MapFrom(src => src.cpay_ID);
					})
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.cpay_ModifiedBy))
		         .ForMember(dest => dest.ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.cpay_ModifiedDate != null);
						opt.MapFrom(src => src.cpay_ModifiedDate);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.cpay_Remark))
                .ForMember(dest => dest.RemoveBy, opt => opt.MapFrom(src => src.cpay_RemoveBy))
		         .ForMember(dest => dest.RemoveDate, opt => 
					{
						opt.Condition((arg1) => arg1.cpay_RemoveDate != null);
						opt.MapFrom(src => src.cpay_RemoveDate);
					})
                .ForMember(dest => dest.PayClassCode, opt => opt.MapFrom(src => src.cpc_Code))
		         .ForMember(dest => dest.PayClass, opt => 
					{
						opt.Condition((arg1) => arg1.cpc_ID != null);
						opt.MapFrom(src => src.cpc_ID);
					})
                .ForMember(dest => dest.PayClassName, opt => opt.MapFrom(src => src.cpcd_Name))
		         .ForMember(dest => dest.cpd_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.cpd_Amount != null);
						opt.MapFrom(src => src.cpd_Amount);
					})
		         .ForMember(dest => dest.DealerId, opt => 
					{
						opt.Condition((arg1) => arg1.cpd_DealerId != null);
						opt.MapFrom(src => src.cpd_DealerId);
					})
                .ForMember(dest => dest.DesAccount, opt => opt.MapFrom(src => src.cpd_DesAccount))
                .ForMember(dest => dest.DesContract, opt => opt.MapFrom(src => src.cpd_DesContract))
                .ForMember(dest => dest.DesPhone, opt => opt.MapFrom(src => src.cpd_DesPhone))
                .ForMember(dest => dest.ParentID, opt => opt.MapFrom(src => src.cpd_ExternalID))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.cpay_ExternalError, opt => opt.MapFrom(src => src.cpay_ExternalError))
                .ForMember(dest => dest.cps_Code, opt => opt.MapFrom(src => src.cps_Code))
		         .ForMember(dest => dest.cps_ID, opt => 
					{
						opt.Condition((arg1) => arg1.cps_ID != null);
						opt.MapFrom(src => src.cps_ID);
					});
            #region [CustomerPayments_Request_SET->SET_p_ucp_set_CustomerPayments_Request]
			//********************** DIRECT:    WebModel(CustomerPayments_Request_SET] -> CallModel[SET_p_ucp_set_CustomerPayments_Request] *************************************
			cfg.CreateMap<CustomerPayments_Request_SET, SET_p_ucp_set_CustomerPayments_Request>()
          		.ForMember(dest => dest.Cpay_DatePay, opt => 
					{
						opt.Condition((arg1) => arg1.DatePay != null);
						opt.MapFrom(src => src.DatePay);
					})
          		.ForMember(dest => dest.Cpc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PayClass != null);
						opt.MapFrom(src => src.PayClass);
					})
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.AccountNumber))
          		.ForMember(dest => dest.Cpay_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.Amount != null);
						opt.MapFrom(src => src.Amount);
					})
                .ForMember(dest => dest.Сpay_Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Cpd_ExternalID, opt => opt.MapFrom(src => src.PayDocID))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Redistribution, opt => 
					{
						opt.Condition((arg1) => arg1.AllocateAmount != null);
						opt.MapFrom(src => src.AllocateAmount);
					})
          		.ForMember(dest => dest.Pinv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.InvoiceID != null);
						opt.MapFrom(src => src.InvoiceID);
					})
                .ForMember(dest => dest.Pinv_Number, opt => opt.MapFrom(src => src.InvoiceNumber))
          		.ForMember(dest => dest.Cpay_Annul, opt => 
					{
						opt.Condition((arg1) => arg1.Annul != null);
						opt.MapFrom(src => src.Annul);
					})
                .ForMember(dest => dest.Сpay_RemoveBy, opt => opt.MapFrom(src => src.RemoveBy))
                .ForMember(dest => dest.Сpay_RemoveFrom, opt => opt.MapFrom(src => src.RemoveFrom))
          		.ForMember(dest => dest.Cpif_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PayInterfaceID != null);
						opt.MapFrom(src => src.PayInterfaceID);
					})
          		.ForMember(dest => dest.Dlr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.DealerID != null);
						opt.MapFrom(src => src.DealerID);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.Cpay_ExternalID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Cpay_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsDenyPayOff, opt => 
					{
						opt.Condition((arg1) => arg1.IsDenyPayOff != null);
						opt.MapFrom(src => src.IsDenyPayOff);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_CustomerPayments_Response] -> WebModel Response(CustomerPayments_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_CustomerPayments_Response, CustomerPayments_Response_SET>()
                .ForMember(dest => dest.global_unique_id, opt => opt.MapFrom(src => src.Cpay_ExternalID))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Cpay_ID != null);
						    opt.MapFrom(src => src.Cpay_ID);
					    })
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
            #region (CustomerPayments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerPayments_Request, GET_p_ucp_get_CustomerPayments_Response>();
            cfg.CreateMap<SET_p_ucp_set_CustomerPayments_Request, SET_p_ucp_set_CustomerPayments_Response>();
            #endregion
            #region [CustomerPayments_AllocatedPayments_Request_GET->GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request]
			//********************** DIRECT:    WebModel(CustomerPayments_AllocatedPayments_Request_GET] -> CallModel[GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request] *************************************
			cfg.CreateMap<CustomerPayments_AllocatedPayments_Request_GET, GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request>()
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
          		.ForMember(dest => dest.Redistribution, opt => 
					{
						opt.Condition((arg1) => arg1.AllocateAmount != null);
						opt.MapFrom(src => src.AllocateAmount);
					})
          		.ForMember(dest => dest.Amount, opt => 
					{
						opt.Condition((arg1) => arg1.Amount != null);
						opt.MapFrom(src => src.Amount);
					})
          		.ForMember(dest => dest.bll_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.bll_Amount != null);
						opt.MapFrom(src => src.bll_Amount);
					})
          		.ForMember(dest => dest.cpd_ExportID, opt => 
					{
						opt.Condition((arg1) => arg1.cpd_ExportID != null);
						opt.MapFrom(src => src.cpd_ExportID);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.PromisedPayLogic, opt => 
					{
						opt.Condition((arg1) => arg1.PromisedPayLogic != null);
						opt.MapFrom(src => src.PromisedPayLogic);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response] -> WebModel Response(CustomerPayments_AllocatedPayments_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response, CustomerPayments_AllocatedPayments_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, CustomerPayments_AllocatedPayments_Request_GET>()

					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response_OUTPUT] -> WebModel Response Output(CustomerPayments_AllocatedPayments_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response_OUTPUT, CustomerPayments_AllocatedPayments_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.cpc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.cpc_ID != null);
						opt.MapFrom(src => src.cpc_ID);
					})
		         .ForMember(dest => dest.cpif_ID, opt => 
					{
						opt.Condition((arg1) => arg1.cpif_ID != null);
						opt.MapFrom(src => src.cpif_ID);
					})
		         .ForMember(dest => dest.cpay_ID, opt => 
					{
						opt.Condition((arg1) => arg1.cpay_ID != null);
						opt.MapFrom(src => src.cpay_ID);
					})
		         .ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.cpay_ExternalID, opt => opt.MapFrom(src => src.cpay_ExternalID))
		         .ForMember(dest => dest.cpc_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.cpc_ExternalID != null);
						opt.MapFrom(src => src.cpc_ExternalID);
					})
		         .ForMember(dest => dest.cpd_ExportedDate, opt => 
					{
						opt.Condition((arg1) => arg1.cpd_ExportedDate != null);
						opt.MapFrom(src => src.cpd_ExportedDate);
					})
                .ForMember(dest => dest.cpd_ExternalID, opt => opt.MapFrom(src => src.cpd_ExternalID))
		         .ForMember(dest => dest.cpd_Moved, opt => 
					{
						opt.Condition((arg1) => arg1.cpd_Moved != null);
						opt.MapFrom(src => src.cpd_Moved);
					})
		         .ForMember(dest => dest.cpif_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.cpif_ExternalID != null);
						opt.MapFrom(src => src.cpif_ExternalID);
					})
                .ForMember(dest => dest.crn_CodeISO, opt => opt.MapFrom(src => src.crn_CodeISO))
		         .ForMember(dest => dest.divided_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.divided_Amount != null);
						opt.MapFrom(src => src.divided_Amount);
					})
                .ForMember(dest => dest.inv_One_String, opt => opt.MapFrom(src => src.inv_One_String))
		         .ForMember(dest => dest.isBlocked, opt => 
					{
						opt.Condition((arg1) => arg1.isBlocked != null);
						opt.MapFrom(src => src.isBlocked);
					})
		         .ForMember(dest => dest.order_ID, opt => 
					{
						opt.Condition((arg1) => arg1.order_ID != null);
						opt.MapFrom(src => src.order_ID);
					})
		         .ForMember(dest => dest.pinv_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.pinv_Amount != null);
						opt.MapFrom(src => src.pinv_Amount);
					})
		         .ForMember(dest => dest.pinv_Date, opt => 
					{
						opt.Condition((arg1) => arg1.pinv_Date != null);
						opt.MapFrom(src => src.pinv_Date);
					})
		         .ForMember(dest => dest.pinv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.pinv_ID != null);
						opt.MapFrom(src => src.pinv_ID);
					})
                .ForMember(dest => dest.pinv_Number, opt => opt.MapFrom(src => src.pinv_Number))
		         .ForMember(dest => dest.Retry, opt => 
					{
						opt.Condition((arg1) => arg1.Retry != null);
						opt.MapFrom(src => src.Retry);
					})
                .ForMember(dest => dest.global_unique_id, opt => opt.MapFrom(src => src.global_unique_id))
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
		         .ForMember(dest => dest.ParentID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					});
            #region (CustomerPayments/AllocatedPayments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request, GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response>();
            #endregion
            #endregion
            #region [Customers]
            #region [Customers_Request_GET->GET_p_ucp_get_Customers_Request]
			//********************** DIRECT:    WebModel(Customers_Request_GET] -> CallModel[GET_p_ucp_get_Customers_Request] *************************************
			cfg.CreateMap<Customers_Request_GET, GET_p_ucp_get_Customers_Request>()
          		.ForMember(dest => dest.Dls_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Dls_ID != null);
						opt.MapFrom(src => src.Dls_ID);
					})
          		.ForMember(dest => dest.com_ID, opt => 
					{
						opt.Condition((arg1) => arg1.com_ID != null);
						opt.MapFrom(src => src.com_ID);
					})
          		.ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
          		.ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.CacheControlDate != null);
						opt.MapFrom(src => src.CacheControlDate);
					})
                .ForMember(dest => dest.jsonFieldsName, opt => opt.MapFrom(src => src.jsonFieldsName))
                .ForMember(dest => dest.jsonFilter, opt => opt.MapFrom(src => src.jsonFilter))
          		.ForMember(dest => dest.jsonFilterContain, opt => 
					{
						opt.Condition((arg1) => arg1.jsonFilterContain != null);
						opt.MapFrom(src => src.jsonFilterContain);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Lng_ID != null);
						opt.MapFrom(src => src.Lng_ID);
					})
          		.ForMember(dest => dest.mode, opt => 
					{
						opt.Condition((arg1) => arg1.mode != null);
						opt.MapFrom(src => src.mode);
					})
          		.ForMember(dest => dest.Ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Ntw_ID != null);
						opt.MapFrom(src => src.Ntw_ID);
					})
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageNumber != null);
						opt.MapFrom(src => src.PageNumber);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					})
          		.ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
          		.ForMember(dest => dest.Rgsc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Rgsc_ID != null);
						opt.MapFrom(src => src.Rgsc_ID);
					})
          		.ForMember(dest => dest.ShowBalances, opt => 
					{
						opt.Condition((arg1) => arg1.ShowBalances != null);
						opt.MapFrom(src => src.ShowBalances);
					})
                .ForMember(dest => dest.ShowEntities, opt => opt.MapFrom(src => src.ShowEntities))
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection))
          		.ForMember(dest => dest.Srv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Srv_ID != null);
						opt.MapFrom(src => src.Srv_ID);
					})
                .ForMember(dest => dest.Srv_Name, opt => opt.MapFrom(src => src.Srv_Name))
          		.ForMember(dest => dest.Sst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Sst_ID != null);
						opt.MapFrom(src => src.Sst_ID);
					})
                .ForMember(dest => dest.tnst_Code, opt => opt.MapFrom(src => src.tnst_Code))
          		.ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
          		.ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
          		.ForMember(dest => dest.Acat_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Acat_ID != null);
						opt.MapFrom(src => src.Acat_ID);
					})
          		.ForMember(dest => dest.Accl_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Accl_ID != null);
						opt.MapFrom(src => src.Accl_ID);
					})
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Acnt_Number))
          		.ForMember(dest => dest.Actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Actp_ID != null);
						opt.MapFrom(src => src.Actp_ID);
					})
          		.ForMember(dest => dest.Adlsb_Code, opt => 
					{
						opt.Condition((arg1) => arg1.Adlsb_Code != null);
						opt.MapFrom(src => src.Adlsb_Code);
					})
          		.ForMember(dest => dest.Aptp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Aptp_ID != null);
						opt.MapFrom(src => src.Aptp_ID);
					})
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.Bac_Number, opt => opt.MapFrom(src => src.Bac_Number))
                .ForMember(dest => dest.bll_Number, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.BossLastName, opt => opt.MapFrom(src => src.BossLastName))
                .ForMember(dest => dest.Cntr_Name, opt => opt.MapFrom(src => src.Cntr_Name))
          		.ForMember(dest => dest.LastModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.LastModifiedDate != null);
						opt.MapFrom(src => src.LastModifiedDate);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_Customers_Response] -> WebModel Response(Customers_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Customers_Response, Customers_Response_GET>()
  		           .ForMember(dest => dest.CacheControlDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.LastModifiedDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.LastModifiedDate != null);
						    opt.MapFrom(src => src.LastModifiedDate);
					    });
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Customers_Request_GET>()

	            	.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_Customers_Response_OUTPUT] -> WebModel Response Output(Customers_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Customers_Response_OUTPUT, Customers_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.tnt_AccountMandatory, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_AccountMandatory != null);
						opt.MapFrom(src => src.tnt_AccountMandatory);
					})
		         .ForMember(dest => dest.tnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_ID != null);
						opt.MapFrom(src => src.tnt_ID);
					})
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
		         .ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.ParentID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID_Boss != null);
						opt.MapFrom(src => src.abn_ID_Boss);
					})
		         .ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
		         .ForMember(dest => dest.abn_IsGuest, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsGuest != null);
						opt.MapFrom(src => src.abn_IsGuest);
					})
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
		         .ForMember(dest => dest.abn_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ModifiedDate != null);
						opt.MapFrom(src => src.abn_ModifiedDate);
					})
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
		         .ForMember(dest => dest.abn_NestedSets_Left, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Left != null);
						opt.MapFrom(src => src.abn_NestedSets_Left);
					})
		         .ForMember(dest => dest.abn_NestedSets_Right, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Right != null);
						opt.MapFrom(src => src.abn_NestedSets_Right);
					})
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
		         .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ShowPhoneDirectory != null);
						opt.MapFrom(src => src.abn_ShowPhoneDirectory);
					})
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
		         .ForMember(dest => dest.acnt_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID_count != null);
						opt.MapFrom(src => src.acnt_ID_count);
					})
		         .ForMember(dest => dest.acnt_IsPersonal, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_IsPersonal != null);
						opt.MapFrom(src => src.acnt_IsPersonal);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
		         .ForMember(dest => dest.actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.actp_ID != null);
						opt.MapFrom(src => src.actp_ID);
					})
                .ForMember(dest => dest.actpd_Name, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
		         .ForMember(dest => dest.aut_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.aut_ID_count != null);
						opt.MapFrom(src => src.aut_ID_count);
					})
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
		         .ForMember(dest => dest.aut_NumberAts, opt => 
					{
						opt.Condition((arg1) => arg1.aut_NumberAts != null);
						opt.MapFrom(src => src.aut_NumberAts);
					})
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
		         .ForMember(dest => dest.cntr_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.cntr_ID_count != null);
						opt.MapFrom(src => src.cntr_ID_count);
					})
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
		         .ForMember(dest => dest.com_Id, opt => 
					{
						opt.Condition((arg1) => arg1.com_Id != null);
						opt.MapFrom(src => src.com_Id);
					})
		         .ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
		         .ForMember(dest => dest.ext_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ID_count != null);
						opt.MapFrom(src => src.ext_ID_count);
					})
		         .ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
		         .ForMember(dest => dest.isEditAllow, opt => 
					{
						opt.Condition((arg1) => arg1.isEditAllow != null);
						opt.MapFrom(src => src.isEditAllow);
					})
		         .ForMember(dest => dest.isEditWorkPlace, opt => 
					{
						opt.Condition((arg1) => arg1.isEditWorkPlace != null);
						opt.MapFrom(src => src.isEditWorkPlace);
					})
		         .ForMember(dest => dest.lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.lng_ID != null);
						opt.MapFrom(src => src.lng_ID);
					})
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
		         .ForMember(dest => dest.Location_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Location_ID != null);
						opt.MapFrom(src => src.Location_ID);
					})
		         .ForMember(dest => dest.ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ntw_ID != null);
						opt.MapFrom(src => src.ntw_ID);
					})
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
		         .ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
                .ForMember(dest => dest.rptURL, opt => opt.MapFrom(src => src.rptURL))
		         .ForMember(dest => dest.SubsCount, opt => 
					{
						opt.Condition((arg1) => arg1.SubsCount != null);
						opt.MapFrom(src => src.SubsCount);
					})
		         .ForMember(dest => dest.tnst_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ExternalID != null);
						opt.MapFrom(src => src.tnst_ExternalID);
					})
		         .ForMember(dest => dest.tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ID != null);
						opt.MapFrom(src => src.tnst_ID);
					})
		         .ForMember(dest => dest.abn_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Balance != null);
						opt.MapFrom(src => src.abn_Balance);
					})
		         .ForMember(dest => dest.abn_CreateDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_CreateDate != null);
						opt.MapFrom(src => src.abn_CreateDate);
					})
		         .ForMember(dest => dest.abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Date != null);
						opt.MapFrom(src => src.abn_Date);
					})
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
		         .ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
		         .ForMember(dest => dest.abn_Guid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Guid != null);
						opt.MapFrom(src => src.abn_Guid);
					})
		         .ForMember(dest => dest.abn_HasNotEmptyPrepaid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_HasNotEmptyPrepaid != null);
						opt.MapFrom(src => src.abn_HasNotEmptyPrepaid);
					})
		         .ForMember(dest => dest.dep_id_boss, opt => 
					{
						opt.Condition((arg1) => arg1.dep_id_boss != null);
						opt.MapFrom(src => src.dep_id_boss);
					})
                .ForMember(dest => dest.dep_Name_boss, opt => opt.MapFrom(src => src.dep_Name_boss))
		         .ForMember(dest => dest.isRefusalChangeName, opt => 
					{
						opt.Condition((arg1) => arg1.isRefusalChangeName != null);
						opt.MapFrom(src => src.isRefusalChangeName);
					})
		         .ForMember(dest => dest.max_ModDate, opt => 
					{
						opt.Condition((arg1) => arg1.max_ModDate != null);
						opt.MapFrom(src => src.max_ModDate);
					})
		         .ForMember(dest => dest.vrr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.vrr_ID != null);
						opt.MapFrom(src => src.vrr_ID);
					});
            #region [Customers_Request_SET->SET_p_ucp_set_Customers_Request]
			//********************** DIRECT:    WebModel(Customers_Request_SET] -> CallModel[SET_p_ucp_set_Customers_Request] *************************************
			cfg.CreateMap<Customers_Request_SET, SET_p_ucp_set_Customers_Request>()
          		.ForMember(dest => dest.Lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CustomerLanguageId != null);
						opt.MapFrom(src => src.CustomerLanguageId);
					})
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
          		.ForMember(dest => dest.Dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.SegmentID != null);
						opt.MapFrom(src => src.SegmentID);
					})
                .ForMember(dest => dest.Abn_FirstName, opt => opt.MapFrom(src => src.Customer_FirstName))
                .ForMember(dest => dest.Abn_PositionCode, opt => opt.MapFrom(src => src.PositionCode))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.CustomerLogin))
                .ForMember(dest => dest.Abn_MiddleName, opt => opt.MapFrom(src => src.Customer_MiddleName))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.CustomerPassword))
          		.ForMember(dest => dest.Abn_IsCreatedWithTariffication, opt => 
					{
						opt.Condition((arg1) => arg1.IsCreatedWithTariffication != null);
						opt.MapFrom(src => src.IsCreatedWithTariffication);
					})
          		.ForMember(dest => dest.Abn_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.TechnicalTag != null);
						opt.MapFrom(src => src.TechnicalTag);
					})
                .ForMember(dest => dest.Abn_Employe_Export_ID, opt => opt.MapFrom(src => src.Export_ID))
                .ForMember(dest => dest.Abn_Employee_ID, opt => opt.MapFrom(src => src.SyncId))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
          		.ForMember(dest => dest.Abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.CustomerDate != null);
						opt.MapFrom(src => src.CustomerDate);
					})
          		.ForMember(dest => dest.UpdateAbonentTree, opt => 
					{
						opt.Condition((arg1) => arg1.isUpdateNodeTree != null);
						opt.MapFrom(src => src.isUpdateNodeTree);
					})
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.Customer_SearchName))
          		.ForMember(dest => dest.Grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.GroupID != null);
						opt.MapFrom(src => src.GroupID);
					})
          		.ForMember(dest => dest.Location_ID, opt => 
					{
						opt.Condition((arg1) => arg1.LocationID != null);
						opt.MapFrom(src => src.LocationID);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
          		.ForMember(dest => dest.DebugLevel, opt => 
					{
						opt.Condition((arg1) => arg1.DebugLevel != null);
						opt.MapFrom(src => src.DebugLevel);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.Sag_Code, opt => opt.MapFrom(src => src.AgentCode))
          		.ForMember(dest => dest.Sag_ID, opt => 
					{
						opt.Condition((arg1) => arg1.AgentID != null);
						opt.MapFrom(src => src.AgentID);
					})
                .ForMember(dest => dest.Pos_Code, opt => opt.MapFrom(src => src.SalesPointCode))
          		.ForMember(dest => dest.Pos_ID, opt => 
					{
						opt.Condition((arg1) => arg1.SalesPointID != null);
						opt.MapFrom(src => src.SalesPointID);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.NetworkID != null);
						opt.MapFrom(src => src.NetworkID);
					})
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.Abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_Customers_Response] -> WebModel Response(Customers_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_Customers_Response, Customers_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Abn_ID != null);
						    opt.MapFrom(src => src.Abn_ID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    });
            #region (Customers)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Customers_Request, GET_p_ucp_get_Customers_Response>();
            cfg.CreateMap<SET_p_ucp_set_Customers_Request, SET_p_ucp_set_Customers_Response>();
            #endregion
            #region [Customers_Activate_Request_ACTION->ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request]
			//********************** DIRECT:    WebModel(Customers_Activate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request] *************************************
			cfg.CreateMap<Customers_Activate_Request_ACTION, ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request>()
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCode))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response] -> WebModel Response(Customers_Activate_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response, Customers_Activate_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Customers/Activate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request, ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response>();
            #endregion
            #region [Customers_CalcCharges_Request_ACTION->ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request]
			//********************** DIRECT:    WebModel(Customers_CalcCharges_Request_ACTION] -> CallModel[ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request] *************************************
			cfg.CreateMap<Customers_CalcCharges_Request_ACTION, ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request>()
                .ForMember(dest => dest.ChargeCode, opt => opt.MapFrom(src => src.ChargeCode))
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
          		.ForMember(dest => dest.EmulateMode, opt => 
					{
						opt.Condition((arg1) => arg1.EmulateMode != null);
						opt.MapFrom(src => src.EmulateMode);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.Ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ExtentionID != null);
						opt.MapFrom(src => src.ExtentionID);
					})
          		.ForMember(dest => dest.ID_GroupATS, opt => 
					{
						opt.Condition((arg1) => arg1.ID_GroupATS != null);
						opt.MapFrom(src => src.ID_GroupATS);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IsReCharge, opt => 
					{
						opt.Condition((arg1) => arg1.IsReCharge != null);
						opt.MapFrom(src => src.IsReCharge);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Srv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ServiceID != null);
						opt.MapFrom(src => src.ServiceID);
					})
                .ForMember(dest => dest.Srs_SessionID, opt => opt.MapFrom(src => src.Srs_SessionID));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response] -> WebModel Response(Customers_CalcCharges_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response, Customers_CalcCharges_Response_ACTION>()
  		           .ForMember(dest => dest.Amount, opt => 
					    {
						    opt.Condition((arg1) => arg1.Amount != null);
						    opt.MapFrom(src => src.Amount);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.WorkEventID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Wev_ID != null);
						    opt.MapFrom(src => src.Wev_ID);
					    });
            #region (Customers/CalcCharges)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request, ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response>();
            #endregion
            #region [Customers_ChangeName_Request_ACTION->ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request]
			//********************** DIRECT:    WebModel(Customers_ChangeName_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request] *************************************
			cfg.CreateMap<Customers_ChangeName_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Abn_FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.SearchName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
          		.ForMember(dest => dest.toClean, opt => 
					{
						opt.Condition((arg1) => arg1.ToClean != null);
						opt.MapFrom(src => src.ToClean);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response] -> WebModel Response(Customers_ChangeName_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response, Customers_ChangeName_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Customers/ChangeName)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request, ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response>();
            #endregion
            #region [Customers_ChangeParent_Request_ACTION->ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request]
			//********************** DIRECT:    WebModel(Customers_ChangeParent_Request_ACTION] -> CallModel[ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request] *************************************
			cfg.CreateMap<Customers_ChangeParent_Request_ACTION, ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request>()
          		.ForMember(dest => dest.ConfAccepted, opt => 
					{
						opt.Condition((arg1) => arg1.ConfAccepted != null);
						opt.MapFrom(src => src.ConfAccepted);
					})
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Parent_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentNode != null);
						opt.MapFrom(src => src.ParentNode);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnst_target_new, opt => 
					{
						opt.Condition((arg1) => arg1.TargetStatusID != null);
						opt.MapFrom(src => src.TargetStatusID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response] -> WebModel Response(Customers_ChangeParent_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response, Customers_ChangeParent_Response_ACTION>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage));
            #region (Customers/ChangeParent)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request, ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response>();
            #endregion
            #region [Customers_ChangeStatus_Request_ACTION->ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request]
			//********************** DIRECT:    WebModel(Customers_ChangeStatus_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request] *************************************
			cfg.CreateMap<Customers_ChangeStatus_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfirmationMessage))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
          		.ForMember(dest => dest.ConfAccepted, opt => 
					{
						opt.Condition((arg1) => arg1.UserAcceptance != null);
						opt.MapFrom(src => src.UserAcceptance);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response] -> WebModel Response(Customers_ChangeStatus_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response, Customers_ChangeStatus_Response_ACTION>()
                .ForMember(dest => dest.ConfirmationMessage, opt => opt.MapFrom(src => src.ConfMessage))
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Customers/ChangeStatus)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request, ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response>();
            #endregion
            #region [Customers_Copy_Request_ACTION->ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request]
			//********************** DIRECT:    WebModel(Customers_Copy_Request_ACTION] -> CallModel[ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request] *************************************
			cfg.CreateMap<Customers_Copy_Request_ACTION, ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request>()
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.AccountNumber))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Wev_ID, opt => 
					{
						opt.Condition((arg1) => arg1.WorkEventID != null);
						opt.MapFrom(src => src.WorkEventID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response] -> WebModel Response(Customers_Copy_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response, Customers_Copy_Response_ACTION>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.WorkEventID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Wev_ID != null);
						    opt.MapFrom(src => src.Wev_ID);
					    });
            #region (Customers/Copy)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request, ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response>();
            #endregion
            #region [Customers_CustomerExtentions_Request_GET->GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request]
			//********************** DIRECT:    WebModel(Customers_CustomerExtentions_Request_GET] -> CallModel[GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request] *************************************
			cfg.CreateMap<Customers_CustomerExtentions_Request_GET, GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request>()
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageNumber != null);
						opt.MapFrom(src => src.PageNumber);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response] -> WebModel Response(Customers_CustomerExtentions_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response, Customers_CustomerExtentions_Response_GET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Customers_CustomerExtentions_Request_GET>()

	            	.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response_OUTPUT] -> WebModel Response Output(Customers_CustomerExtentions_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response_OUTPUT, Customers_CustomerExtentions_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ID != null);
						opt.MapFrom(src => src.ext_ID);
					})
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
		         .ForMember(dest => dest.ParentID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					});
            #region (Customers/CustomerExtentions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request, GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response>();
            #endregion
            #region [Customers_Deactivate_Request_ACTION->ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request]
			//********************** DIRECT:    WebModel(Customers_Deactivate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request] *************************************
			cfg.CreateMap<Customers_Deactivate_Request_ACTION, ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_Code_crnt, opt => opt.MapFrom(src => src.StatusCode))
                .ForMember(dest => dest.Tnst_Code_trgt, opt => opt.MapFrom(src => src.TargetStatusCode));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response] -> WebModel Response(Customers_Deactivate_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response, Customers_Deactivate_Response_ACTION>()
  		           .ForMember(dest => dest.AffectedCount, opt => 
					    {
						    opt.Condition((arg1) => arg1.AffectedCount != null);
						    opt.MapFrom(src => src.AffectedCount);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.WorkEventID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Wev_ID != null);
						    opt.MapFrom(src => src.Wev_ID);
					    });
            #region (Customers/Deactivate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request, ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response>();
            #endregion
            #region [Customers_Details_Request_GET->GET_p_ucp_get_CustomerByID_Customers_Details_Request]
			//********************** DIRECT:    WebModel(Customers_Details_Request_GET] -> CallModel[GET_p_ucp_get_CustomerByID_Customers_Details_Request] *************************************
			cfg.CreateMap<Customers_Details_Request_GET, GET_p_ucp_get_CustomerByID_Customers_Details_Request>()
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.CacheControlDate != null);
						opt.MapFrom(src => src.CacheControlDate);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_CustomerByID_Customers_Details_Response] -> WebModel Response(Customers_Details_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerByID_Customers_Details_Response, Customers_Details_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.CacheControlDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    });
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Customers_Details_Request_GET>()

					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_CustomerByID_Customers_Details_Response_OUTPUT] -> WebModel Response Output(Customers_Details_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerByID_Customers_Details_Response_OUTPUT, Customers_Details_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.abc_Date_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Date_Personal != null);
						opt.MapFrom(src => src.abc_Date_Personal);
					})
		         .ForMember(dest => dest.abn_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Balance != null);
						opt.MapFrom(src => src.abn_Balance);
					})
		         .ForMember(dest => dest.abn_CreateDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_CreateDate != null);
						opt.MapFrom(src => src.abn_CreateDate);
					})
		         .ForMember(dest => dest.abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Date != null);
						opt.MapFrom(src => src.abn_Date);
					})
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
		         .ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
		         .ForMember(dest => dest.abn_Guid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Guid != null);
						opt.MapFrom(src => src.abn_Guid);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID_Boss != null);
						opt.MapFrom(src => src.abn_ID_Boss);
					})
		         .ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
		         .ForMember(dest => dest.abn_IsGuest, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsGuest != null);
						opt.MapFrom(src => src.abn_IsGuest);
					})
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
		         .ForMember(dest => dest.abn_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ModifiedDate != null);
						opt.MapFrom(src => src.abn_ModifiedDate);
					})
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
		         .ForMember(dest => dest.abn_NestedSets_Left, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Left != null);
						opt.MapFrom(src => src.abn_NestedSets_Left);
					})
		         .ForMember(dest => dest.abn_NestedSets_Right, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Right != null);
						opt.MapFrom(src => src.abn_NestedSets_Right);
					})
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
		         .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ShowPhoneDirectory != null);
						opt.MapFrom(src => src.abn_ShowPhoneDirectory);
					})
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.abn_WorkPlace_Personal, opt => opt.MapFrom(src => src.abn_WorkPlace_Personal))
                .ForMember(dest => dest.abn_XmlData, opt => opt.MapFrom(src => src.abn_XmlData))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
		         .ForMember(dest => dest.acnt_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID_count != null);
						opt.MapFrom(src => src.acnt_ID_count);
					})
		         .ForMember(dest => dest.acnt_IsPersonal, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_IsPersonal != null);
						opt.MapFrom(src => src.acnt_IsPersonal);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.Actpd_Name, opt => opt.MapFrom(src => src.Actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
		         .ForMember(dest => dest.atnsb_DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.atnsb_DateEnd != null);
						opt.MapFrom(src => src.atnsb_DateEnd);
					})
		         .ForMember(dest => dest.atnsb_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.atnsb_DateStart != null);
						opt.MapFrom(src => src.atnsb_DateStart);
					})
		         .ForMember(dest => dest.aut_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.aut_ID_count != null);
						opt.MapFrom(src => src.aut_ID_count);
					})
		         .ForMember(dest => dest.abb_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abb_Balance != null);
						opt.MapFrom(src => src.abb_Balance);
					})
		         .ForMember(dest => dest.abb_Balance_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abb_Balance_Personal != null);
						opt.MapFrom(src => src.abb_Balance_Personal);
					})
		         .ForMember(dest => dest.abb_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abb_ModifiedDate != null);
						opt.MapFrom(src => src.abb_ModifiedDate);
					})
		         .ForMember(dest => dest.abb_ModifiedDate_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abb_ModifiedDate_Personal != null);
						opt.MapFrom(src => src.abb_ModifiedDate_Personal);
					})
		         .ForMember(dest => dest.abc_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Balance != null);
						opt.MapFrom(src => src.abc_Balance);
					})
		         .ForMember(dest => dest.abc_Balance_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Balance_Personal != null);
						opt.MapFrom(src => src.abc_Balance_Personal);
					})
		         .ForMember(dest => dest.abc_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Date != null);
						opt.MapFrom(src => src.abc_Date);
					})
                .ForMember(dest => dest.Boss_Tnt_Type, opt => opt.MapFrom(src => src.Boss_Tnt_Type))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
		         .ForMember(dest => dest.com_Id, opt => 
					{
						opt.Condition((arg1) => arg1.com_Id != null);
						opt.MapFrom(src => src.com_Id);
					})
		         .ForMember(dest => dest.debt_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.debt_Amount != null);
						opt.MapFrom(src => src.debt_Amount);
					})
		         .ForMember(dest => dest.debt_Date, opt => 
					{
						opt.Condition((arg1) => arg1.debt_Date != null);
						opt.MapFrom(src => src.debt_Date);
					})
		         .ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
		         .ForMember(dest => dest.ext_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ID_count != null);
						opt.MapFrom(src => src.ext_ID_count);
					})
		         .ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
		         .ForMember(dest => dest.isActivated, opt => 
					{
						opt.Condition((arg1) => arg1.isActivated != null);
						opt.MapFrom(src => src.isActivated);
					})
		         .ForMember(dest => dest.isEditAllow, opt => 
					{
						opt.Condition((arg1) => arg1.isEditAllow != null);
						opt.MapFrom(src => src.isEditAllow);
					})
		         .ForMember(dest => dest.isEditWorkPlace, opt => 
					{
						opt.Condition((arg1) => arg1.isEditWorkPlace != null);
						opt.MapFrom(src => src.isEditWorkPlace);
					})
		         .ForMember(dest => dest.lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.lng_ID != null);
						opt.MapFrom(src => src.lng_ID);
					})
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
		         .ForMember(dest => dest.Location_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Location_ID != null);
						opt.MapFrom(src => src.Location_ID);
					})
		         .ForMember(dest => dest.ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ntw_ID != null);
						opt.MapFrom(src => src.ntw_ID);
					})
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
		         .ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
		         .ForMember(dest => dest.SubsCount, opt => 
					{
						opt.Condition((arg1) => arg1.SubsCount != null);
						opt.MapFrom(src => src.SubsCount);
					})
                .ForMember(dest => dest.tnh_LastFM, opt => opt.MapFrom(src => src.tnh_LastFM))
		         .ForMember(dest => dest.tnt_AccountMandatory, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_AccountMandatory != null);
						opt.MapFrom(src => src.tnt_AccountMandatory);
					})
		         .ForMember(dest => dest.tnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_ID != null);
						opt.MapFrom(src => src.tnt_ID);
					})
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
		         .ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
		         .ForMember(dest => dest.tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ID != null);
						opt.MapFrom(src => src.tnst_ID);
					})
		         .ForMember(dest => dest.tnst_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ExternalID != null);
						opt.MapFrom(src => src.tnst_ExternalID);
					})
		         .ForMember(dest => dest.isRefusalChangeName, opt => 
					{
						opt.Condition((arg1) => arg1.isRefusalChangeName != null);
						opt.MapFrom(src => src.isRefusalChangeName);
					});
            #region (Customers/Details)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerByID_Customers_Details_Request, GET_p_ucp_get_CustomerByID_Customers_Details_Response>();
            #endregion
            #region [Customers_postponeInvoice_Request_ACTION->ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request]
			//********************** DIRECT:    WebModel(Customers_postponeInvoice_Request_ACTION] -> CallModel[ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request] *************************************
			cfg.CreateMap<Customers_postponeInvoice_Request_ACTION, ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request>()
          		.ForMember(dest => dest.DateLimit, opt => 
					{
						opt.Condition((arg1) => arg1.DateLimit != null);
						opt.MapFrom(src => src.DateLimit);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark));
#endregion
            #region (Customers/postponeInvoice)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            #endregion
            #region [Customers_SetLabels_Request_ACTION->ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request]
			//********************** DIRECT:    WebModel(Customers_SetLabels_Request_ACTION] -> CallModel[ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request] *************************************
			cfg.CreateMap<Customers_SetLabels_Request_ACTION, ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.LinkedServer, opt => opt.MapFrom(src => src.LinkedServer))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.SourceQuery, opt => opt.MapFrom(src => src.SourceQuery));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response] -> WebModel Response(Customers_SetLabels_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response, Customers_SetLabels_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Customers/SetLabels)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request, ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response>();
            #endregion
            #endregion
            #region [CustomerTypes]
            #region [CustomerTypes_Request_GET->GET_p_ucp_get_CustomerTypes_Request]
			//********************** DIRECT:    WebModel(CustomerTypes_Request_GET] -> CallModel[GET_p_ucp_get_CustomerTypes_Request] *************************************
			cfg.CreateMap<CustomerTypes_Request_GET, GET_p_ucp_get_CustomerTypes_Request>()
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_CustomerTypes_Response] -> WebModel Response(CustomerTypes_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerTypes_Response, CustomerTypes_Response_GET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, CustomerTypes_Request_GET>()

					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_CustomerTypes_Response_OUTPUT] -> WebModel Response Output(CustomerTypes_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_CustomerTypes_Response_OUTPUT, CustomerTypes_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.AccountTypeID != null);
						opt.MapFrom(src => src.AccountTypeID);
					})
                .ForMember(dest => dest.AccountTypeName, opt => opt.MapFrom(src => src.AccountTypeName))
		         .ForMember(dest => dest.Idtype, opt => 
					{
						opt.Condition((arg1) => arg1.Idtype != null);
						opt.MapFrom(src => src.Idtype);
					});
            #region (CustomerTypes)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_CustomerTypes_Request, GET_p_ucp_get_CustomerTypes_Response>();
            #endregion
            #endregion
            #region [Discounts]
            #region [Discounts_Request_SET->SET_p_ucp_set_DiscountAbonentBind_Request]
			//********************** DIRECT:    WebModel(Discounts_Request_SET] -> CallModel[SET_p_ucp_set_DiscountAbonentBind_Request] *************************************
			cfg.CreateMap<Discounts_Request_SET, SET_p_ucp_set_DiscountAbonentBind_Request>()
          		.ForMember(dest => dest.DateSet, opt => 
					{
						opt.Condition((arg1) => arg1.DateSet != null);
						opt.MapFrom(src => src.DateSet);
					})
          		.ForMember(dest => dest.dsc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.DiscountID != null);
						opt.MapFrom(src => src.DiscountID);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.isAnnul, opt => 
					{
						opt.Condition((arg1) => arg1.isAnnul != null);
						opt.MapFrom(src => src.isAnnul);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.dab_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_DiscountAbonentBind_Response] -> WebModel Response(Discounts_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_DiscountAbonentBind_Response, Discounts_Response_SET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.dab_ID != null);
						    opt.MapFrom(src => src.dab_ID);
					    });
            #region (Discounts)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_DiscountAbonentBind_Request, SET_p_ucp_set_DiscountAbonentBind_Response>();
            #endregion
            #endregion
            #region [Environment]
            #region [Environment_Request_GET->GET_p_ucp_get_Variables_Request]
			//********************** DIRECT:    WebModel(Environment_Request_GET] -> CallModel[GET_p_ucp_get_Variables_Request] *************************************
			cfg.CreateMap<Environment_Request_GET, GET_p_ucp_get_Variables_Request>()
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.var_Name, opt => opt.MapFrom(src => src.var_Name))
                .ForMember(dest => dest.var_Group, opt => opt.MapFrom(src => src.var_Group));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_Variables_Response] -> WebModel Response(Environment_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Variables_Response, Environment_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Environment_Request_GET>()

					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_Variables_Response_OUTPUT] -> WebModel Response Output(Environment_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Variables_Response_OUTPUT, Environment_Response_GET_OUTPUT>()
                .ForMember(dest => dest.var_Description, opt => opt.MapFrom(src => src.var_Description))
		         .ForMember(dest => dest.var_Error, opt => 
					{
						opt.Condition((arg1) => arg1.var_Error != null);
						opt.MapFrom(src => src.var_Error);
					})
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.var_Name))
                .ForMember(dest => dest.var_Value, opt => opt.MapFrom(src => src.var_Value))
		         .ForMember(dest => dest.var_ValueDatetime, opt => 
					{
						opt.Condition((arg1) => arg1.var_ValueDatetime != null);
						opt.MapFrom(src => src.var_ValueDatetime);
					})
		         .ForMember(dest => dest.var_ValueDecimal, opt => 
					{
						opt.Condition((arg1) => arg1.var_ValueDecimal != null);
						opt.MapFrom(src => src.var_ValueDecimal);
					})
		         .ForMember(dest => dest.var_ValueInt, opt => 
					{
						opt.Condition((arg1) => arg1.var_ValueInt != null);
						opt.MapFrom(src => src.var_ValueInt);
					})
		         .ForMember(dest => dest.ddat, opt => 
					{
						opt.Condition((arg1) => arg1.ddat != null);
						opt.MapFrom(src => src.ddat);
					})
		         .ForMember(dest => dest.ddec, opt => 
					{
						opt.Condition((arg1) => arg1.ddec != null);
						opt.MapFrom(src => src.ddec);
					})
		         .ForMember(dest => dest.dint, opt => 
					{
						opt.Condition((arg1) => arg1.dint != null);
						opt.MapFrom(src => src.dint);
					})
		         .ForMember(dest => dest.dstr, opt => 
					{
						opt.Condition((arg1) => arg1.dstr != null);
						opt.MapFrom(src => src.dstr);
					})
                .ForMember(dest => dest.var_Group, opt => opt.MapFrom(src => src.var_Group));
            #region (Environment)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Variables_Request, GET_p_ucp_get_Variables_Response>();
            #endregion
            #endregion
            #region [Extentions]
            #region [Extentions_Request_SET->SET_p_ucp_set_SubscriberExtentions_Request]
			//********************** DIRECT:    WebModel(Extentions_Request_SET] -> CallModel[SET_p_ucp_set_SubscriberExtentions_Request] *************************************
			cfg.CreateMap<Extentions_Request_SET, SET_p_ucp_set_SubscriberExtentions_Request>()
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.ModifiedDateExst, opt => 
					{
						opt.Condition((arg1) => arg1.StatusModifiedDate != null);
						opt.MapFrom(src => src.StatusModifiedDate);
					})
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModifiedFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.XmlDataFormat, opt => opt.MapFrom(src => src.XmlDataFormat))
          		.ForMember(dest => dest.Ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ExtentionID != null);
						opt.MapFrom(src => src.ExtentionID);
					})
          		.ForMember(dest => dest.Ext_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.ExternalID != null);
						opt.MapFrom(src => src.ExternalID);
					})
                .ForMember(dest => dest.Ext_XmlData, opt => opt.MapFrom(src => src.XmlData))
          		.ForMember(dest => dest.Exct_ID, opt => 
					{
						opt.Condition((arg1) => arg1.CategoryID != null);
						opt.MapFrom(src => src.CategoryID);
					})
          		.ForMember(dest => dest.Excl_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ClassID != null);
						opt.MapFrom(src => src.ClassID);
					})
          		.ForMember(dest => dest.Exst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
          		.ForMember(dest => dest.Extp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TypeID != null);
						opt.MapFrom(src => src.TypeID);
					})
          		.ForMember(dest => dest.Cpt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ConnectionPointID != null);
						opt.MapFrom(src => src.ConnectionPointID);
					})
          		.ForMember(dest => dest.NumberAts, opt => 
					{
						opt.Condition((arg1) => arg1.NumberAts != null);
						opt.MapFrom(src => src.NumberAts);
					})
                .ForMember(dest => dest.Ext_ExtNum, opt => opt.MapFrom(src => src.ExtentionNumber))
          		.ForMember(dest => dest.Ext_IsCreatedWithTariffication, opt => 
					{
						opt.Condition((arg1) => arg1.IsCreatedWithTariffication != null);
						opt.MapFrom(src => src.IsCreatedWithTariffication);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.DebugLevel, opt => 
					{
						opt.Condition((arg1) => arg1.DebugLevel != null);
						opt.MapFrom(src => src.DebugLevel);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Eab_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.ext_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ShowPhoneDirectory != null);
						opt.MapFrom(src => src.ext_ShowPhoneDirectory);
					})
          		.ForMember(dest => dest.ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.ModifiedDate != null);
						opt.MapFrom(src => src.ModifiedDate);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_SubscriberExtentions_Response] -> WebModel Response(Extentions_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_SubscriberExtentions_Response, Extentions_Response_SET>()
  		           .ForMember(dest => dest.ExtentionID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Ext_ID != null);
						    opt.MapFrom(src => src.Ext_ID);
					    })
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Eab_ID != null);
						    opt.MapFrom(src => src.Eab_ID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    });
            #region (Extentions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_SubscriberExtentions_Request, SET_p_ucp_set_SubscriberExtentions_Response>();
            #endregion
            #endregion
            #region [Gains]
            #region [Gains_Request_SET->SET_p_ucp_set_AccountCredits_Request]
			//********************** DIRECT:    WebModel(Gains_Request_SET] -> CallModel[SET_p_ucp_set_AccountCredits_Request] *************************************
			cfg.CreateMap<Gains_Request_SET, SET_p_ucp_set_AccountCredits_Request>()
                .ForMember(dest => dest.Accrr_Code, opt => opt.MapFrom(src => src.ReasonCode))
                .ForMember(dest => dest.Ctpro_Code, opt => opt.MapFrom(src => src.ProgrammCode))
          		.ForMember(dest => dest.Accr_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.Amount != null);
						opt.MapFrom(src => src.Amount);
					})
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Crtp_Code, opt => opt.MapFrom(src => src.TypeCode))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Accr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.Accr_Break, opt => 
					{
						opt.Condition((arg1) => arg1.Accr_Break != null);
						opt.MapFrom(src => src.Accr_Break);
					})
          		.ForMember(dest => dest.Accr_Warning, opt => 
					{
						opt.Condition((arg1) => arg1.Accr_Warning != null);
						opt.MapFrom(src => src.Accr_Warning);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_AccountCredits_Response] -> WebModel Response(Gains_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_AccountCredits_Response, Gains_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Accr_ID != null);
						    opt.MapFrom(src => src.Accr_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Gains)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_AccountCredits_Request, SET_p_ucp_set_AccountCredits_Response>();
            #endregion
            #endregion
            #region [Memberships]
            #region [Memberships_Request_SET->SET_p_ucp_set_CodeRegions_Memberships_Request]
			//********************** DIRECT:    WebModel(Memberships_Request_SET] -> CallModel[SET_p_ucp_set_CodeRegions_Memberships_Request] *************************************
			cfg.CreateMap<Memberships_Request_SET, SET_p_ucp_set_CodeRegions_Memberships_Request>()
          		.ForMember(dest => dest.IncludeNumbers, opt => 
					{
						opt.Condition((arg1) => arg1.IncludeNumbers != null);
						opt.MapFrom(src => src.IncludeNumbers);
					})
                .ForMember(dest => dest.Cds_FullCode, opt => opt.MapFrom(src => src.PhoneNumber))
          		.ForMember(dest => dest.Cds_IsRemoved, opt => 
					{
						opt.Condition((arg1) => arg1.IsRemoved != null);
						opt.MapFrom(src => src.IsRemoved);
					})
          		.ForMember(dest => dest.Crg_ID, opt => 
					{
						opt.Condition((arg1) => arg1.GroupID != null);
						opt.MapFrom(src => src.GroupID);
					})
          		.ForMember(dest => dest.Crgb_DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.Crgb_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Crgb_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Cds_CityAddCode, opt => opt.MapFrom(src => src.Cds_CityAddCode))
                .ForMember(dest => dest.Cds_CityCode, opt => opt.MapFrom(src => src.Cds_CityCode))
                .ForMember(dest => dest.Cds_CountryCode, opt => opt.MapFrom(src => src.Cds_CountryCode))
          		.ForMember(dest => dest.Cds_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Cds_ID != null);
						opt.MapFrom(src => src.Cds_ID);
					})
                .ForMember(dest => dest.Cds_Name, opt => opt.MapFrom(src => src.Cds_Name))
                .ForMember(dest => dest.Crg_RegionNameEN, opt => opt.MapFrom(src => src.Crg_RegionNameEN));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_CodeRegions_Memberships_Response] -> WebModel Response(Memberships_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_CodeRegions_Memberships_Response, Memberships_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Crgb_ID != null);
						    opt.MapFrom(src => src.Crgb_ID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.Cds_ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Cds_ID != null);
						    opt.MapFrom(src => src.Cds_ID);
					    });
            #region (Memberships)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_CodeRegions_Memberships_Request, SET_p_ucp_set_CodeRegions_Memberships_Response>();
            #endregion
            #endregion
            #region [Networks]
            #region [Networks_Request_GET->GET_p_ucp_get_Networks_Request]
			//********************** DIRECT:    WebModel(Networks_Request_GET] -> CallModel[GET_p_ucp_get_Networks_Request] *************************************
			cfg.CreateMap<Networks_Request_GET, GET_p_ucp_get_Networks_Request>()
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Ntwd_Name, opt => opt.MapFrom(src => src.NetworkName))
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_Networks_Response] -> WebModel Response(Networks_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Networks_Response, Networks_Response_GET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Networks_Request_GET>()

	            	.ForMember(dest => dest.PageIndex, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_Networks_Response_OUTPUT] -> WebModel Response Output(Networks_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Networks_Response_OUTPUT, Networks_Response_GET_OUTPUT>()
                .ForMember(dest => dest.NameATS, opt => opt.MapFrom(src => src.NameATS))
		         .ForMember(dest => dest.NetworkExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.ntw_ExternalID != null);
						opt.MapFrom(src => src.ntw_ExternalID);
					})
		         .ForMember(dest => dest.NetworkID, opt => 
					{
						opt.Condition((arg1) => arg1.ntw_ID != null);
						opt.MapFrom(src => src.ntw_ID);
					})
                .ForMember(dest => dest.NetworkName, opt => opt.MapFrom(src => src.ntwd_Name))
		         .ForMember(dest => dest.NumberATS, opt => 
					{
						opt.Condition((arg1) => arg1.NumberATS != null);
						opt.MapFrom(src => src.NumberATS);
					});
            #region (Networks)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Networks_Request, GET_p_ucp_get_Networks_Response>();
            #endregion
            #region [Networks_ClearLogins_Request_ACTION->ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request]
			//********************** DIRECT:    WebModel(Networks_ClearLogins_Request_ACTION] -> CallModel[ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request] *************************************
			cfg.CreateMap<Networks_ClearLogins_Request_ACTION, ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request>()
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.ntw_id, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModifiedFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.NewLoginSource, opt => opt.MapFrom(src => src.NewLoginSource))
                .ForMember(dest => dest.NewPassword, opt => opt.MapFrom(src => src.NewPassword))
                .ForMember(dest => dest.RegExpValue, opt => opt.MapFrom(src => src.RegExpValue))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response] -> WebModel Response(Networks_ClearLogins_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response, Networks_ClearLogins_Response_ACTION>()
  		           .ForMember(dest => dest.AffectedCount, opt => 
					    {
						    opt.Condition((arg1) => arg1.UpdatedAbnCount != null);
						    opt.MapFrom(src => src.UpdatedAbnCount);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Networks/ClearLogins)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request, ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response>();
            #endregion
            #endregion
            #region [PaymentDocuments]
            #region [PaymentDocuments_Request_SET->SET_p_ucp_set_PayDocs_Request]
			//********************** DIRECT:    WebModel(PaymentDocuments_Request_SET] -> CallModel[SET_p_ucp_set_PayDocs_Request] *************************************
			cfg.CreateMap<PaymentDocuments_Request_SET, SET_p_ucp_set_PayDocs_Request>()
          		.ForMember(dest => dest.Cpd_PayDate, opt => 
					{
						opt.Condition((arg1) => arg1.PayDate != null);
						opt.MapFrom(src => src.PayDate);
					})
          		.ForMember(dest => dest.Pre_DateReestr, opt => 
					{
						opt.Condition((arg1) => arg1.ReestrDate != null);
						opt.MapFrom(src => src.ReestrDate);
					})
          		.ForMember(dest => dest.Cpd_AnnulDate, opt => 
					{
						opt.Condition((arg1) => arg1.AnnulDate != null);
						opt.MapFrom(src => src.AnnulDate);
					})
          		.ForMember(dest => dest.Cpd_ExportedDate, opt => 
					{
						opt.Condition((arg1) => arg1.ExportedDate != null);
						opt.MapFrom(src => src.ExportedDate);
					})
          		.ForMember(dest => dest.Cpd_Moved, opt => 
					{
						opt.Condition((arg1) => arg1.Moved != null);
						opt.MapFrom(src => src.Moved);
					})
          		.ForMember(dest => dest.Cpd_Annul, opt => 
					{
						opt.Condition((arg1) => arg1.Annul != null);
						opt.MapFrom(src => src.Annul);
					})
          		.ForMember(dest => dest.Pre_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.ReestrID != null);
						opt.MapFrom(src => src.ReestrID);
					})
          		.ForMember(dest => dest.Bnk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BankID != null);
						opt.MapFrom(src => src.BankID);
					})
          		.ForMember(dest => dest.Cof_ID, opt => 
					{
						opt.Condition((arg1) => arg1.KassaID != null);
						opt.MapFrom(src => src.KassaID);
					})
          		.ForMember(dest => dest.Loc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.LocationID != null);
						opt.MapFrom(src => src.LocationID);
					})
          		.ForMember(dest => dest.Cpc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PayClass != null);
						opt.MapFrom(src => src.PayClass);
					})
                .ForMember(dest => dest.Pre_NumReestr, opt => opt.MapFrom(src => src.ReestrNumber))
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.AccountNumber))
                .ForMember(dest => dest.Cpd_AnnulBy, opt => opt.MapFrom(src => src.AnnulBy))
          		.ForMember(dest => dest.Cpif_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PayInterfaceID != null);
						opt.MapFrom(src => src.PayInterfaceID);
					})
                .ForMember(dest => dest.Crn_CodeISO, opt => opt.MapFrom(src => src.CurrencyCode))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.Cpd_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.Amount != null);
						opt.MapFrom(src => src.Amount);
					})
          		.ForMember(dest => dest.Cpd_PayEffDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Cpd_DesPhone, opt => opt.MapFrom(src => src.ExtentionNumber))
          		.ForMember(dest => dest.Bac_ID, opt => 
					{
						opt.Condition((arg1) => arg1.BankAccountID != null);
						opt.MapFrom(src => src.BankAccountID);
					})
          		.ForMember(dest => dest.Cpd_DealerId, opt => 
					{
						opt.Condition((arg1) => arg1.DealerId != null);
						opt.MapFrom(src => src.DealerId);
					})
                .ForMember(dest => dest.Cpd_PayDocNumber, opt => opt.MapFrom(src => src.PayDocNumber))
          		.ForMember(dest => dest.Cpd_ExportID, opt => 
					{
						opt.Condition((arg1) => arg1.ExportID != null);
						opt.MapFrom(src => src.ExportID);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.cacheStatus, opt => opt.MapFrom(src => src.cacheStatus))
                .ForMember(dest => dest.Cpd_ExternalID, opt => opt.MapFrom(src => src.global_unique_id))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_PayDocs_Response] -> WebModel Response(PaymentDocuments_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_PayDocs_Response, PaymentDocuments_Response_SET>()
                .ForMember(dest => dest.global_unique_id, opt => opt.MapFrom(src => src.Cpd_ExternalID))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID));
            #region (PaymentDocuments)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_PayDocs_Request, SET_p_ucp_set_PayDocs_Response>();
            #endregion
            #endregion
            #region [PaymentRegistry]
            #region [PaymentRegistry_Request_GET->GET_p_ucp_get_PayReestres_Request]
			//********************** DIRECT:    WebModel(PaymentRegistry_Request_GET] -> CallModel[GET_p_ucp_get_PayReestres_Request] *************************************
			cfg.CreateMap<PaymentRegistry_Request_GET, GET_p_ucp_get_PayReestres_Request>()
          		.ForMember(dest => dest.bac_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.bnk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.bnk_ID != null);
						opt.MapFrom(src => src.bnk_ID);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.pre_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.pre_ExternalID != null);
						opt.MapFrom(src => src.pre_ExternalID);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_PayReestres_Response] -> WebModel Response(PaymentRegistry_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_PayReestres_Response, PaymentRegistry_Response_GET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, PaymentRegistry_Request_GET>()

					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_PayReestres_Response_OUTPUT] -> WebModel Response Output(PaymentRegistry_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_PayReestres_Response_OUTPUT, PaymentRegistry_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.pre_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.pre_ExternalID != null);
						opt.MapFrom(src => src.pre_ExternalID);
					})
		         .ForMember(dest => dest.pre_DateReestr, opt => 
					{
						opt.Condition((arg1) => arg1.pre_DateReestr != null);
						opt.MapFrom(src => src.pre_DateReestr);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.pre_ID != null);
						opt.MapFrom(src => src.pre_ID);
					})
                .ForMember(dest => dest.pre_NumReestr, opt => opt.MapFrom(src => src.pre_NumReestr))
		         .ForMember(dest => dest.bac_ID, opt => 
					{
						opt.Condition((arg1) => arg1.bac_ID != null);
						opt.MapFrom(src => src.bac_ID);
					})
		         .ForMember(dest => dest.bnk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.bnk_ID != null);
						opt.MapFrom(src => src.bnk_ID);
					});
            #region [PaymentRegistry_Request_SET->SET_p_ucp_set_PayReestres_Request]
			//********************** DIRECT:    WebModel(PaymentRegistry_Request_SET] -> CallModel[SET_p_ucp_set_PayReestres_Request] *************************************
			cfg.CreateMap<PaymentRegistry_Request_SET, SET_p_ucp_set_PayReestres_Request>()
          		.ForMember(dest => dest.bac_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.crn_CodeISO, opt => opt.MapFrom(src => src.crn_CodeISO))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.pre_DateReestr, opt => 
					{
						opt.Condition((arg1) => arg1.pre_DateReestr != null);
						opt.MapFrom(src => src.pre_DateReestr);
					})
          		.ForMember(dest => dest.pre_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.pre_ExternalID != null);
						opt.MapFrom(src => src.pre_ExternalID);
					})
          		.ForMember(dest => dest.pre_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.pre_NumReestr, opt => opt.MapFrom(src => src.pre_NumReestr))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.bnk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.bnk_ID != null);
						opt.MapFrom(src => src.bnk_ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_PayReestres_Response] -> WebModel Response(PaymentRegistry_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_PayReestres_Response, PaymentRegistry_Response_SET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.pre_ID != null);
						    opt.MapFrom(src => src.pre_ID);
					    })
  		           .ForMember(dest => dest.bnk_ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.bnk_ID != null);
						    opt.MapFrom(src => src.bnk_ID);
					    });
            #region (PaymentRegistry)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_PayReestres_Request, GET_p_ucp_get_PayReestres_Response>();
            cfg.CreateMap<SET_p_ucp_set_PayReestres_Request, SET_p_ucp_set_PayReestres_Response>();
            #endregion
            #endregion
            #region [PhoneNumbers]
            #region [PhoneNumbers_Request_SET->SET_p_ucp_set_CodeRegions_PhoneNumbers_Request]
			//********************** DIRECT:    WebModel(PhoneNumbers_Request_SET] -> CallModel[SET_p_ucp_set_CodeRegions_PhoneNumbers_Request] *************************************
			cfg.CreateMap<PhoneNumbers_Request_SET, SET_p_ucp_set_CodeRegions_PhoneNumbers_Request>()
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.Cds_FullCode, opt => opt.MapFrom(src => src.PhoneNumber))
          		.ForMember(dest => dest.Cds_IsRemoved, opt => 
					{
						opt.Condition((arg1) => arg1.IsRemoved != null);
						opt.MapFrom(src => src.IsRemoved);
					})
          		.ForMember(dest => dest.Crgb_DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.Crgb_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Crgb_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.Crg_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Cds_CityAddCode, opt => opt.MapFrom(src => src.Cds_CityAddCode))
                .ForMember(dest => dest.Cds_CityCode, opt => opt.MapFrom(src => src.Cds_CityCode))
                .ForMember(dest => dest.Cds_CountryCode, opt => opt.MapFrom(src => src.Cds_CountryCode))
          		.ForMember(dest => dest.Cds_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Cds_ID != null);
						opt.MapFrom(src => src.Cds_ID);
					})
                .ForMember(dest => dest.Cds_Name, opt => opt.MapFrom(src => src.Cds_Name))
                .ForMember(dest => dest.Crg_RegionNameEN, opt => opt.MapFrom(src => src.Crg_RegionNameEN));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_CodeRegions_PhoneNumbers_Response] -> WebModel Response(PhoneNumbers_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_CodeRegions_PhoneNumbers_Response, PhoneNumbers_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Crgb_ID != null);
						    opt.MapFrom(src => src.Crgb_ID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.Cds_ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Cds_ID != null);
						    opt.MapFrom(src => src.Cds_ID);
					    });
            #region (PhoneNumbers)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_CodeRegions_PhoneNumbers_Request, SET_p_ucp_set_CodeRegions_PhoneNumbers_Response>();
            #endregion
            #endregion
            #region [PortabilityNumbers]
            #region [PortabilityNumbers_Request_SET->SET_p_ucp_set_CodeRegions_Request]
			//********************** DIRECT:    WebModel(PortabilityNumbers_Request_SET] -> CallModel[SET_p_ucp_set_CodeRegions_Request] *************************************
			cfg.CreateMap<PortabilityNumbers_Request_SET, SET_p_ucp_set_CodeRegions_Request>()
                .ForMember(dest => dest.Cds_FullCode, opt => opt.MapFrom(src => src.PhoneNumber))
          		.ForMember(dest => dest.Cds_IsRemoved, opt => 
					{
						opt.Condition((arg1) => arg1.IsRemoved != null);
						opt.MapFrom(src => src.IsRemoved);
					})
          		.ForMember(dest => dest.Crgb_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.PortedDate != null);
						opt.MapFrom(src => src.PortedDate);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Crg_RegionNameEN, opt => opt.MapFrom(src => src.RecipientRC))
          		.ForMember(dest => dest.Crgb_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Abn_ID != null);
						opt.MapFrom(src => src.Abn_ID);
					})
                .ForMember(dest => dest.Cds_CityAddCode, opt => opt.MapFrom(src => src.Cds_CityAddCode))
                .ForMember(dest => dest.Cds_CityCode, opt => opt.MapFrom(src => src.Cds_CityCode))
                .ForMember(dest => dest.Cds_CountryCode, opt => opt.MapFrom(src => src.Cds_CountryCode))
          		.ForMember(dest => dest.Cds_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Cds_ID != null);
						opt.MapFrom(src => src.Cds_ID);
					})
                .ForMember(dest => dest.Cds_Name, opt => opt.MapFrom(src => src.Cds_Name))
          		.ForMember(dest => dest.Crg_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Crg_ID != null);
						opt.MapFrom(src => src.Crg_ID);
					})
          		.ForMember(dest => dest.Crgb_DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.Crgb_DateEnd != null);
						opt.MapFrom(src => src.Crgb_DateEnd);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IncludeNumbers, opt => 
					{
						opt.Condition((arg1) => arg1.IncludeNumbers != null);
						opt.MapFrom(src => src.IncludeNumbers);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_CodeRegions_Response] -> WebModel Response(PortabilityNumbers_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_CodeRegions_Response, PortabilityNumbers_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Crgb_ID != null);
						    opt.MapFrom(src => src.Crgb_ID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.Cds_ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Cds_ID != null);
						    opt.MapFrom(src => src.Cds_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    });
            #region (PortabilityNumbers)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_CodeRegions_Request, SET_p_ucp_set_CodeRegions_Response>();
            #endregion
            #endregion
            #region [Profiles]
            #region [Profiles_Request_SET->SET_p_ucp_set_Profiles_Request]
			//********************** DIRECT:    WebModel(Profiles_Request_SET] -> CallModel[SET_p_ucp_set_Profiles_Request] *************************************
			cfg.CreateMap<Profiles_Request_SET, SET_p_ucp_set_Profiles_Request>()
                .ForMember(dest => dest.JsonData, opt => opt.MapFrom(src => src.Attributes))
          		.ForMember(dest => dest.vrr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.IdentityType != null);
						opt.MapFrom(src => src.IdentityType);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.tnv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TemplateID != null);
						opt.MapFrom(src => src.TemplateID);
					})
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.aatr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_Profiles_Response] -> WebModel Response(Profiles_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_Profiles_Response, Profiles_Response_SET>()
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.aatr_ID != null);
						    opt.MapFrom(src => src.aatr_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    });
            #region (Profiles)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_Profiles_Request, SET_p_ucp_set_Profiles_Response>();
            #endregion
            #endregion
            #region [RatingData]
            #region [RatingData_Request_SET->SET_p_ucp_set_ServiceReservations_Request]
			//********************** DIRECT:    WebModel(RatingData_Request_SET] -> CallModel[SET_p_ucp_set_ServiceReservations_Request] *************************************
			cfg.CreateMap<RatingData_Request_SET, SET_p_ucp_set_ServiceReservations_Request>()
          		.ForMember(dest => dest.beginTimeStamp, opt => 
					{
						opt.Condition((arg1) => arg1.beginTimeStamp != null);
						opt.MapFrom(src => src.beginTimeStamp);
					})
          		.ForMember(dest => dest.CheckBalanceMode, opt => 
					{
						opt.Condition((arg1) => arg1.CheckBalanceMode != null);
						opt.MapFrom(src => src.CheckBalanceMode);
					})
          		.ForMember(dest => dest.consumedUnit, opt => 
					{
						opt.Condition((arg1) => arg1.consumedUnit != null);
						opt.MapFrom(src => src.consumedUnit);
					})
                .ForMember(dest => dest.destinationIdData, opt => opt.MapFrom(src => src.destinationIdData))
                .ForMember(dest => dest.destinationIdType, opt => opt.MapFrom(src => src.destinationIdType))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.srsv_UniqueID, opt => opt.MapFrom(src => src.ID))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.invocationTimeStamp, opt => 
					{
						opt.Condition((arg1) => arg1.invocationTimeStamp != null);
						opt.MapFrom(src => src.invocationTimeStamp);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.nfConsumerIdentification, opt => opt.MapFrom(src => src.nfConsumerIdentification))
                .ForMember(dest => dest.oneTimeEvent, opt => opt.MapFrom(src => src.oneTimeEvent))
                .ForMember(dest => dest.oneTimeEventType, opt => opt.MapFrom(src => src.oneTimeEventType))
          		.ForMember(dest => dest.ratingGroup, opt => 
					{
						opt.Condition((arg1) => arg1.ratingGroup != null);
						opt.MapFrom(src => src.ratingGroup);
					})
          		.ForMember(dest => dest.requestedUnit, opt => 
					{
						opt.Condition((arg1) => arg1.requestedUnit != null);
						opt.MapFrom(src => src.requestedUnit);
					})
                .ForMember(dest => dest.requestSubType, opt => opt.MapFrom(src => src.requestSubType))
                .ForMember(dest => dest.serviceContextId, opt => opt.MapFrom(src => src.serviceContextId))
          		.ForMember(dest => dest.serviceId, opt => 
					{
						opt.Condition((arg1) => arg1.serviceId != null);
						opt.MapFrom(src => src.serviceId);
					})
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
          		.ForMember(dest => dest.srsv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.srsv_ID != null);
						opt.MapFrom(src => src.srsv_ID);
					})
          		.ForMember(dest => dest.srsv_LinkID, opt => 
					{
						opt.Condition((arg1) => arg1.srsv_LinkID != null);
						opt.MapFrom(src => src.srsv_LinkID);
					})
                .ForMember(dest => dest.srsv_Remark, opt => opt.MapFrom(src => src.srsv_Remark))
                .ForMember(dest => dest.subscriptionId, opt => opt.MapFrom(src => src.subscriptionId))
          		.ForMember(dest => dest.invocationSequenceNumber, opt => 
					{
						opt.Condition((arg1) => arg1.invocationSequenceNumber != null);
						opt.MapFrom(src => src.invocationSequenceNumber);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.location, opt => opt.MapFrom(src => src.location));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_ServiceReservations_Response] -> WebModel Response(RatingData_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_ServiceReservations_Response, RatingData_Response_SET>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.srsv_UniqueID))
  		           .ForMember(dest => dest.invocationTimeStamp, opt => 
					    {
						    opt.Condition((arg1) => arg1.invocationTimeStamp != null);
						    opt.MapFrom(src => src.invocationTimeStamp);
					    })
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
  		           .ForMember(dest => dest.srsv_ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.srsv_ID != null);
						    opt.MapFrom(src => src.srsv_ID);
					    })
  		           .ForMember(dest => dest.srsv_LinkID, opt => 
					    {
						    opt.Condition((arg1) => arg1.srsv_LinkID != null);
						    opt.MapFrom(src => src.srsv_LinkID);
					    })
  		           .ForMember(dest => dest.invocationSequenceNumber, opt => 
					    {
						    opt.Condition((arg1) => arg1.invocationSequenceNumber != null);
						    opt.MapFrom(src => src.invocationSequenceNumber);
					    })
                .ForMember(dest => dest.location, opt => opt.MapFrom(src => src.location));
            #region (RatingData)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_ServiceReservations_Request, SET_p_ucp_set_ServiceReservations_Response>();
            #endregion
            #region [RatingData_Release_Request_ACTION->ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request]
			//********************** DIRECT:    WebModel(RatingData_Release_Request_ACTION] -> CallModel[ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request] *************************************
			cfg.CreateMap<RatingData_Release_Request_ACTION, ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request>()
          		.ForMember(dest => dest.beginTimeStamp, opt => 
					{
						opt.Condition((arg1) => arg1.beginTimeStamp != null);
						opt.MapFrom(src => src.beginTimeStamp);
					})
          		.ForMember(dest => dest.CheckBalanceMode, opt => 
					{
						opt.Condition((arg1) => arg1.CheckBalanceMode != null);
						opt.MapFrom(src => src.CheckBalanceMode);
					})
          		.ForMember(dest => dest.consumedUnit, opt => 
					{
						opt.Condition((arg1) => arg1.consumedUnit != null);
						opt.MapFrom(src => src.consumedUnit);
					})
                .ForMember(dest => dest.destinationIdData, opt => opt.MapFrom(src => src.destinationIdData))
                .ForMember(dest => dest.destinationIdType, opt => opt.MapFrom(src => src.destinationIdType))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.invocationSequenceNumber, opt => 
					{
						opt.Condition((arg1) => arg1.invocationSequenceNumber != null);
						opt.MapFrom(src => src.invocationSequenceNumber);
					})
          		.ForMember(dest => dest.invocationTimeStamp, opt => 
					{
						opt.Condition((arg1) => arg1.invocationTimeStamp != null);
						opt.MapFrom(src => src.invocationTimeStamp);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.nfConsumerIdentification, opt => opt.MapFrom(src => src.nfConsumerIdentification))
                .ForMember(dest => dest.srsv_UniqueID, opt => opt.MapFrom(src => src.ParentID))
          		.ForMember(dest => dest.ratingGroup, opt => 
					{
						opt.Condition((arg1) => arg1.ratingGroup != null);
						opt.MapFrom(src => src.ratingGroup);
					})
          		.ForMember(dest => dest.requestedUnit, opt => 
					{
						opt.Condition((arg1) => arg1.requestedUnit != null);
						opt.MapFrom(src => src.requestedUnit);
					})
                .ForMember(dest => dest.requestSubType, opt => opt.MapFrom(src => src.requestSubType))
                .ForMember(dest => dest.serviceContextId, opt => opt.MapFrom(src => src.serviceContextId))
          		.ForMember(dest => dest.serviceId, opt => 
					{
						opt.Condition((arg1) => arg1.serviceId != null);
						opt.MapFrom(src => src.serviceId);
					})
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
          		.ForMember(dest => dest.srsv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.srsv_ID != null);
						opt.MapFrom(src => src.srsv_ID);
					})
          		.ForMember(dest => dest.srsv_LinkID, opt => 
					{
						opt.Condition((arg1) => arg1.srsv_LinkID != null);
						opt.MapFrom(src => src.srsv_LinkID);
					})
                .ForMember(dest => dest.srsv_Remark, opt => opt.MapFrom(src => src.srsv_Remark))
                .ForMember(dest => dest.subscriptionId, opt => opt.MapFrom(src => src.subscriptionId));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response] -> WebModel Response(RatingData_Release_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response, RatingData_Release_Response_ACTION>()
  		           .ForMember(dest => dest.invocationSequenceNumber, opt => 
					    {
						    opt.Condition((arg1) => arg1.invocationSequenceNumber != null);
						    opt.MapFrom(src => src.invocationSequenceNumber);
					    })
  		           .ForMember(dest => dest.invocationTimeStamp, opt => 
					    {
						    opt.Condition((arg1) => arg1.invocationTimeStamp != null);
						    opt.MapFrom(src => src.invocationTimeStamp);
					    })
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
  		           .ForMember(dest => dest.srsv_ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.srsv_ID != null);
						    opt.MapFrom(src => src.srsv_ID);
					    })
  		           .ForMember(dest => dest.srsv_LinkID, opt => 
					    {
						    opt.Condition((arg1) => arg1.srsv_LinkID != null);
						    opt.MapFrom(src => src.srsv_LinkID);
					    });
            #region (RatingData/Release)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request, ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response>();
            #endregion
            #region [RatingData_Update_Request_ACTION->ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request]
			//********************** DIRECT:    WebModel(RatingData_Update_Request_ACTION] -> CallModel[ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request] *************************************
			cfg.CreateMap<RatingData_Update_Request_ACTION, ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request>()
          		.ForMember(dest => dest.beginTimeStamp, opt => 
					{
						opt.Condition((arg1) => arg1.beginTimeStamp != null);
						opt.MapFrom(src => src.beginTimeStamp);
					})
          		.ForMember(dest => dest.CheckBalanceMode, opt => 
					{
						opt.Condition((arg1) => arg1.CheckBalanceMode != null);
						opt.MapFrom(src => src.CheckBalanceMode);
					})
          		.ForMember(dest => dest.consumedUnit, opt => 
					{
						opt.Condition((arg1) => arg1.consumedUnit != null);
						opt.MapFrom(src => src.consumedUnit);
					})
                .ForMember(dest => dest.destinationIdData, opt => opt.MapFrom(src => src.destinationIdData))
                .ForMember(dest => dest.destinationIdType, opt => opt.MapFrom(src => src.destinationIdType))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.invocationSequenceNumber, opt => 
					{
						opt.Condition((arg1) => arg1.invocationSequenceNumber != null);
						opt.MapFrom(src => src.invocationSequenceNumber);
					})
          		.ForMember(dest => dest.invocationTimeStamp, opt => 
					{
						opt.Condition((arg1) => arg1.invocationTimeStamp != null);
						opt.MapFrom(src => src.invocationTimeStamp);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.location, opt => opt.MapFrom(src => src.location))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.mode))
                .ForMember(dest => dest.nfConsumerIdentification, opt => opt.MapFrom(src => src.nfConsumerIdentification))
                .ForMember(dest => dest.oneTimeEvent, opt => opt.MapFrom(src => src.oneTimeEvent))
                .ForMember(dest => dest.oneTimeEventType, opt => opt.MapFrom(src => src.oneTimeEventType))
                .ForMember(dest => dest.srsv_UniqueID, opt => opt.MapFrom(src => src.ParentID))
          		.ForMember(dest => dest.ratingGroup, opt => 
					{
						opt.Condition((arg1) => arg1.ratingGroup != null);
						opt.MapFrom(src => src.ratingGroup);
					})
          		.ForMember(dest => dest.requestedUnit, opt => 
					{
						opt.Condition((arg1) => arg1.requestedUnit != null);
						opt.MapFrom(src => src.requestedUnit);
					})
                .ForMember(dest => dest.requestSubType, opt => opt.MapFrom(src => src.requestSubType))
                .ForMember(dest => dest.serviceContextId, opt => opt.MapFrom(src => src.serviceContextId))
          		.ForMember(dest => dest.serviceId, opt => 
					{
						opt.Condition((arg1) => arg1.serviceId != null);
						opt.MapFrom(src => src.serviceId);
					})
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
          		.ForMember(dest => dest.srsv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.srsv_ID != null);
						opt.MapFrom(src => src.srsv_ID);
					})
          		.ForMember(dest => dest.srsv_LinkID, opt => 
					{
						opt.Condition((arg1) => arg1.srsv_LinkID != null);
						opt.MapFrom(src => src.srsv_LinkID);
					})
                .ForMember(dest => dest.srsv_Remark, opt => opt.MapFrom(src => src.srsv_Remark))
                .ForMember(dest => dest.subscriptionId, opt => opt.MapFrom(src => src.subscriptionId));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response] -> WebModel Response(RatingData_Update_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response, RatingData_Update_Response_ACTION>()
  		           .ForMember(dest => dest.invocationSequenceNumber, opt => 
					    {
						    opt.Condition((arg1) => arg1.invocationSequenceNumber != null);
						    opt.MapFrom(src => src.invocationSequenceNumber);
					    })
  		           .ForMember(dest => dest.invocationTimeStamp, opt => 
					    {
						    opt.Condition((arg1) => arg1.invocationTimeStamp != null);
						    opt.MapFrom(src => src.invocationTimeStamp);
					    })
                .ForMember(dest => dest.location, opt => opt.MapFrom(src => src.location))
                .ForMember(dest => dest.serviceRating, opt => opt.MapFrom(src => src.serviceRating))
  		           .ForMember(dest => dest.srsv_ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.srsv_ID != null);
						    opt.MapFrom(src => src.srsv_ID);
					    })
  		           .ForMember(dest => dest.srsv_LinkID, opt => 
					    {
						    opt.Condition((arg1) => arg1.srsv_LinkID != null);
						    opt.MapFrom(src => src.srsv_LinkID);
					    });
            #region (RatingData/Update)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request, ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response>();
            #endregion
            #endregion
            #region [ServiceSubscriptions]
            #region [ServiceSubscriptions_Request_SET->SET_p_ucp_set_ServiceSubscriptions_Request]
			//********************** DIRECT:    WebModel(ServiceSubscriptions_Request_SET] -> CallModel[SET_p_ucp_set_ServiceSubscriptions_Request] *************************************
			cfg.CreateMap<ServiceSubscriptions_Request_SET, SET_p_ucp_set_ServiceSubscriptions_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.Srs_JsonData, opt => opt.MapFrom(src => src.TaskJsonData))
          		.ForMember(dest => dest.Srs_DateDrop, opt => 
					{
						opt.Condition((arg1) => arg1.DateDrop != null);
						opt.MapFrom(src => src.DateDrop);
					})
          		.ForMember(dest => dest.Amount, opt => 
					{
						opt.Condition((arg1) => arg1.Amount != null);
						opt.MapFrom(src => src.Amount);
					})
          		.ForMember(dest => dest.Srs_PriceRatio, opt => 
					{
						opt.Condition((arg1) => arg1.PriceRatio != null);
						opt.MapFrom(src => src.PriceRatio);
					})
          		.ForMember(dest => dest.Srs_Count, opt => 
					{
						opt.Condition((arg1) => arg1.Count != null);
						opt.MapFrom(src => src.Count);
					})
          		.ForMember(dest => dest.Pkt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PacketID != null);
						opt.MapFrom(src => src.PacketID);
					})
          		.ForMember(dest => dest.Tsk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TaskID != null);
						opt.MapFrom(src => src.TaskID);
					})
          		.ForMember(dest => dest.Sst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
                .ForMember(dest => dest.Srs_Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Srs_DateSet, opt => 
					{
						opt.Condition((arg1) => arg1.DateSet != null);
						opt.MapFrom(src => src.DateSet);
					})
                .ForMember(dest => dest.Srv_Code, opt => opt.MapFrom(src => src.ServiceCode))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Sst_IsStatusHistory, opt => 
					{
						opt.Condition((arg1) => arg1.OverrideHistory != null);
						opt.MapFrom(src => src.OverrideHistory);
					})
          		.ForMember(dest => dest.Rtb_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Srs_SessionID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
          		.ForMember(dest => dest.Ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ExtentionID != null);
						opt.MapFrom(src => src.ExtentionID);
					})
          		.ForMember(dest => dest.ModDate, opt => 
					{
						opt.Condition((arg1) => arg1.ModDate != null);
						opt.MapFrom(src => src.ModDate);
					})
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.ServiceMode, opt => opt.MapFrom(src => src.ServiceMode))
          		.ForMember(dest => dest.TariffBegin, opt => 
					{
						opt.Condition((arg1) => arg1.TariffBegin != null);
						opt.MapFrom(src => src.TariffBegin);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_ServiceSubscriptions_Response] -> WebModel Response(ServiceSubscriptions_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_ServiceSubscriptions_Response, ServiceSubscriptions_Response_SET>()
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.TaskID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Tsk_ID != null);
						    opt.MapFrom(src => src.Tsk_ID);
					    })
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Srs_SessionID));
            #region (ServiceSubscriptions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_ServiceSubscriptions_Request, SET_p_ucp_set_ServiceSubscriptions_Response>();
            #endregion
            #endregion
            #region [Subscribers]
            #region [Subscribers_Request_GET->GET_p_ucp_get_Subscribers_Request]
			//********************** DIRECT:    WebModel(Subscribers_Request_GET] -> CallModel[GET_p_ucp_get_Subscribers_Request] *************************************
			cfg.CreateMap<Subscribers_Request_GET, GET_p_ucp_get_Subscribers_Request>()
                .ForMember(dest => dest.SortColumn, opt => opt.MapFrom(src => src.SortColumn))
                .ForMember(dest => dest.SortDirection, opt => opt.MapFrom(src => src.SortDirection))
          		.ForMember(dest => dest.Srv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Srv_ID != null);
						opt.MapFrom(src => src.Srv_ID);
					})
                .ForMember(dest => dest.Srv_Name, opt => opt.MapFrom(src => src.Srv_Name))
          		.ForMember(dest => dest.Sst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Sst_ID != null);
						opt.MapFrom(src => src.Sst_ID);
					})
                .ForMember(dest => dest.tnst_Code, opt => opt.MapFrom(src => src.tnst_Code))
          		.ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
          		.ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.LastModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.LastModifiedDate != null);
						opt.MapFrom(src => src.LastModifiedDate);
					})
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
          		.ForMember(dest => dest.abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
          		.ForMember(dest => dest.Acat_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Acat_ID != null);
						opt.MapFrom(src => src.Acat_ID);
					})
          		.ForMember(dest => dest.Accl_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Accl_ID != null);
						opt.MapFrom(src => src.Accl_ID);
					})
                .ForMember(dest => dest.Acnt_Number, opt => opt.MapFrom(src => src.Acnt_Number))
          		.ForMember(dest => dest.Actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Actp_ID != null);
						opt.MapFrom(src => src.Actp_ID);
					})
          		.ForMember(dest => dest.Adlsb_Code, opt => 
					{
						opt.Condition((arg1) => arg1.Adlsb_Code != null);
						opt.MapFrom(src => src.Adlsb_Code);
					})
          		.ForMember(dest => dest.Aptp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Aptp_ID != null);
						opt.MapFrom(src => src.Aptp_ID);
					})
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
                .ForMember(dest => dest.Bac_Number, opt => opt.MapFrom(src => src.Bac_Number))
                .ForMember(dest => dest.bll_Number, opt => opt.MapFrom(src => src.bll_Number))
                .ForMember(dest => dest.BossLastName, opt => opt.MapFrom(src => src.BossLastName))
                .ForMember(dest => dest.Cntr_Name, opt => opt.MapFrom(src => src.Cntr_Name))
          		.ForMember(dest => dest.com_ID, opt => 
					{
						opt.Condition((arg1) => arg1.com_ID != null);
						opt.MapFrom(src => src.com_ID);
					})
          		.ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
          		.ForMember(dest => dest.Dls_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Dls_ID != null);
						opt.MapFrom(src => src.Dls_ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
          		.ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.CacheControlDate != null);
						opt.MapFrom(src => src.CacheControlDate);
					})
                .ForMember(dest => dest.jsonFieldsName, opt => opt.MapFrom(src => src.jsonFieldsName))
                .ForMember(dest => dest.jsonFilter, opt => opt.MapFrom(src => src.jsonFilter))
          		.ForMember(dest => dest.jsonFilterContain, opt => 
					{
						opt.Condition((arg1) => arg1.jsonFilterContain != null);
						opt.MapFrom(src => src.jsonFilterContain);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Lng_ID != null);
						opt.MapFrom(src => src.Lng_ID);
					})
          		.ForMember(dest => dest.mode, opt => 
					{
						opt.Condition((arg1) => arg1.mode != null);
						opt.MapFrom(src => src.mode);
					})
          		.ForMember(dest => dest.Ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Ntw_ID != null);
						opt.MapFrom(src => src.Ntw_ID);
					})
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageNumber != null);
						opt.MapFrom(src => src.PageNumber);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					})
          		.ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
          		.ForMember(dest => dest.Rgsc_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Rgsc_ID != null);
						opt.MapFrom(src => src.Rgsc_ID);
					})
          		.ForMember(dest => dest.ShowBalances, opt => 
					{
						opt.Condition((arg1) => arg1.ShowBalances != null);
						opt.MapFrom(src => src.ShowBalances);
					})
                .ForMember(dest => dest.ShowEntities, opt => opt.MapFrom(src => src.ShowEntities));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_Subscribers_Response] -> WebModel Response(Subscribers_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_Subscribers_Response, Subscribers_Response_GET>()
  		           .ForMember(dest => dest.CacheControlDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Subscribers_Request_GET>()

	            	.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_Subscribers_Response_OUTPUT] -> WebModel Response Output(Subscribers_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_Subscribers_Response_OUTPUT, Subscribers_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.abn_HasNotEmptyPrepaid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_HasNotEmptyPrepaid != null);
						opt.MapFrom(src => src.abn_HasNotEmptyPrepaid);
					})
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
		         .ForMember(dest => dest.abn_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Balance != null);
						opt.MapFrom(src => src.abn_Balance);
					})
		         .ForMember(dest => dest.abn_CreateDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_CreateDate != null);
						opt.MapFrom(src => src.abn_CreateDate);
					})
		         .ForMember(dest => dest.abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Date != null);
						opt.MapFrom(src => src.abn_Date);
					})
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
		         .ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
		         .ForMember(dest => dest.abn_Guid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Guid != null);
						opt.MapFrom(src => src.abn_Guid);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.ParentID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID_Boss != null);
						opt.MapFrom(src => src.abn_ID_Boss);
					})
		         .ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
		         .ForMember(dest => dest.abn_IsGuest, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsGuest != null);
						opt.MapFrom(src => src.abn_IsGuest);
					})
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
		         .ForMember(dest => dest.abn_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ModifiedDate != null);
						opt.MapFrom(src => src.abn_ModifiedDate);
					})
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
		         .ForMember(dest => dest.abn_NestedSets_Left, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Left != null);
						opt.MapFrom(src => src.abn_NestedSets_Left);
					})
		         .ForMember(dest => dest.abn_NestedSets_Right, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Right != null);
						opt.MapFrom(src => src.abn_NestedSets_Right);
					})
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
		         .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ShowPhoneDirectory != null);
						opt.MapFrom(src => src.abn_ShowPhoneDirectory);
					})
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
		         .ForMember(dest => dest.acnt_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID_count != null);
						opt.MapFrom(src => src.acnt_ID_count);
					})
		         .ForMember(dest => dest.acnt_IsPersonal, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_IsPersonal != null);
						opt.MapFrom(src => src.acnt_IsPersonal);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
		         .ForMember(dest => dest.actp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.actp_ID != null);
						opt.MapFrom(src => src.actp_ID);
					})
		         .ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
                .ForMember(dest => dest.actpd_Name, opt => opt.MapFrom(src => src.actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
		         .ForMember(dest => dest.aut_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.aut_ID_count != null);
						opt.MapFrom(src => src.aut_ID_count);
					})
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.aut_NameAuthCode))
		         .ForMember(dest => dest.aut_NumberAts, opt => 
					{
						opt.Condition((arg1) => arg1.aut_NumberAts != null);
						opt.MapFrom(src => src.aut_NumberAts);
					})
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
		         .ForMember(dest => dest.cntr_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.cntr_ID_count != null);
						opt.MapFrom(src => src.cntr_ID_count);
					})
                .ForMember(dest => dest.cntr_Name, opt => opt.MapFrom(src => src.cntr_Name))
		         .ForMember(dest => dest.com_Id, opt => 
					{
						opt.Condition((arg1) => arg1.com_Id != null);
						opt.MapFrom(src => src.com_Id);
					})
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
		         .ForMember(dest => dest.ext_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ID_count != null);
						opt.MapFrom(src => src.ext_ID_count);
					})
		         .ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
		         .ForMember(dest => dest.isEditAllow, opt => 
					{
						opt.Condition((arg1) => arg1.isEditAllow != null);
						opt.MapFrom(src => src.isEditAllow);
					})
		         .ForMember(dest => dest.lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.lng_ID != null);
						opt.MapFrom(src => src.lng_ID);
					})
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
		         .ForMember(dest => dest.Location_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Location_ID != null);
						opt.MapFrom(src => src.Location_ID);
					})
		         .ForMember(dest => dest.ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ntw_ID != null);
						opt.MapFrom(src => src.ntw_ID);
					})
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
		         .ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
                .ForMember(dest => dest.rptURL, opt => opt.MapFrom(src => src.rptURL))
		         .ForMember(dest => dest.SubsCount, opt => 
					{
						opt.Condition((arg1) => arg1.SubsCount != null);
						opt.MapFrom(src => src.SubsCount);
					})
		         .ForMember(dest => dest.tnst_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ExternalID != null);
						opt.MapFrom(src => src.tnst_ExternalID);
					})
		         .ForMember(dest => dest.tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ID != null);
						opt.MapFrom(src => src.tnst_ID);
					})
		         .ForMember(dest => dest.tnt_AccountMandatory, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_AccountMandatory != null);
						opt.MapFrom(src => src.tnt_AccountMandatory);
					})
		         .ForMember(dest => dest.tnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_ID != null);
						opt.MapFrom(src => src.tnt_ID);
					})
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
		         .ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
		         .ForMember(dest => dest.isEditWorkPlace, opt => 
					{
						opt.Condition((arg1) => arg1.isEditWorkPlace != null);
						opt.MapFrom(src => src.isEditWorkPlace);
					})
		         .ForMember(dest => dest.dep_id_boss, opt => 
					{
						opt.Condition((arg1) => arg1.dep_id_boss != null);
						opt.MapFrom(src => src.dep_id_boss);
					})
                .ForMember(dest => dest.dep_Name_boss, opt => opt.MapFrom(src => src.dep_Name_boss))
		         .ForMember(dest => dest.isRefusalChangeName, opt => 
					{
						opt.Condition((arg1) => arg1.isRefusalChangeName != null);
						opt.MapFrom(src => src.isRefusalChangeName);
					})
		         .ForMember(dest => dest.max_ModDate, opt => 
					{
						opt.Condition((arg1) => arg1.max_ModDate != null);
						opt.MapFrom(src => src.max_ModDate);
					})
		         .ForMember(dest => dest.vrr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.vrr_ID != null);
						opt.MapFrom(src => src.vrr_ID);
					});
            #region [Subscribers_Request_SET->SET_p_ucp_set_Subscribers_Request]
			//********************** DIRECT:    WebModel(Subscribers_Request_SET] -> CallModel[SET_p_ucp_set_Subscribers_Request] *************************************
			cfg.CreateMap<Subscribers_Request_SET, SET_p_ucp_set_Subscribers_Request>()
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
          		.ForMember(dest => dest.Ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StandartID != null);
						opt.MapFrom(src => src.StandartID);
					})
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
          		.ForMember(dest => dest.AutoCreateContract, opt => 
					{
						opt.Condition((arg1) => arg1.AutoCreateContract != null);
						opt.MapFrom(src => src.AutoCreateContract);
					})
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.Customer_SearchName))
          		.ForMember(dest => dest.Abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.CustomerDate != null);
						opt.MapFrom(src => src.CustomerDate);
					})
          		.ForMember(dest => dest.DebugLevel, opt => 
					{
						opt.Condition((arg1) => arg1.DebugLevel != null);
						opt.MapFrom(src => src.DebugLevel);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.Abn_Employe_Export_ID, opt => opt.MapFrom(src => src.Export_ID))
                .ForMember(dest => dest.Abn_PositionCode, opt => opt.MapFrom(src => src.PositionCode))
                .ForMember(dest => dest.Sag_Code, opt => opt.MapFrom(src => src.AgentCode))
          		.ForMember(dest => dest.Sag_ID, opt => 
					{
						opt.Condition((arg1) => arg1.AgentID != null);
						opt.MapFrom(src => src.AgentID);
					})
                .ForMember(dest => dest.Pos_Code, opt => opt.MapFrom(src => src.SalesPointCode))
          		.ForMember(dest => dest.Pos_ID, opt => 
					{
						opt.Condition((arg1) => arg1.SalesPointID != null);
						opt.MapFrom(src => src.SalesPointID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.Abn_IsCreatedWithTariffication, opt => 
					{
						opt.Condition((arg1) => arg1.IsCreatedWithTariffication != null);
						opt.MapFrom(src => src.IsCreatedWithTariffication);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
                .ForMember(dest => dest.Abn_Employee_ID, opt => opt.MapFrom(src => src.SyncId))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.SubscriberLogin))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.SubscriberPassword))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.Abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_Subscribers_Response] -> WebModel Response(Subscribers_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_Subscribers_Response, Subscribers_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Abn_ID != null);
						    opt.MapFrom(src => src.Abn_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Subscribers)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_Subscribers_Request, GET_p_ucp_get_Subscribers_Response>();
            cfg.CreateMap<SET_p_ucp_set_Subscribers_Request, SET_p_ucp_set_Subscribers_Response>();
            #endregion
            #region [Subscribers_Activate_Request_ACTION->ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request]
			//********************** DIRECT:    WebModel(Subscribers_Activate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request] *************************************
			cfg.CreateMap<Subscribers_Activate_Request_ACTION, ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request>()
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCode))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response] -> WebModel Response(Subscribers_Activate_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response, Subscribers_Activate_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Subscribers/Activate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request, ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response>();
            #endregion
            #region [Subscribers_CalcCharges_Request_ACTION->ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request]
			//********************** DIRECT:    WebModel(Subscribers_CalcCharges_Request_ACTION] -> CallModel[ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request] *************************************
			cfg.CreateMap<Subscribers_CalcCharges_Request_ACTION, ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request>()
                .ForMember(dest => dest.ChargeCode, opt => opt.MapFrom(src => src.ChargeCode))
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
          		.ForMember(dest => dest.EmulateMode, opt => 
					{
						opt.Condition((arg1) => arg1.EmulateMode != null);
						opt.MapFrom(src => src.EmulateMode);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.Ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ExtentionID != null);
						opt.MapFrom(src => src.ExtentionID);
					})
          		.ForMember(dest => dest.ID_GroupATS, opt => 
					{
						opt.Condition((arg1) => arg1.ID_GroupATS != null);
						opt.MapFrom(src => src.ID_GroupATS);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IsReCharge, opt => 
					{
						opt.Condition((arg1) => arg1.IsReCharge != null);
						opt.MapFrom(src => src.IsReCharge);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Srv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ServiceID != null);
						opt.MapFrom(src => src.ServiceID);
					})
                .ForMember(dest => dest.Srs_SessionID, opt => opt.MapFrom(src => src.Srs_SessionID));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response] -> WebModel Response(Subscribers_CalcCharges_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response, Subscribers_CalcCharges_Response_ACTION>()
  		           .ForMember(dest => dest.Amount, opt => 
					    {
						    opt.Condition((arg1) => arg1.Amount != null);
						    opt.MapFrom(src => src.Amount);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.WorkEventID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Wev_ID != null);
						    opt.MapFrom(src => src.Wev_ID);
					    });
            #region (Subscribers/CalcCharges)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request, ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response>();
            #endregion
            #region [Subscribers_ChangeAccount_Request_ACTION->ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request]
			//********************** DIRECT:    WebModel(Subscribers_ChangeAccount_Request_ACTION] -> CallModel[ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request] *************************************
			cfg.CreateMap<Subscribers_ChangeAccount_Request_ACTION, ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request>()
          		.ForMember(dest => dest.Acnt_ID_New, opt => 
					{
						opt.Condition((arg1) => arg1.AccountID != null);
						opt.MapFrom(src => src.AccountID);
					})
                .ForMember(dest => dest.aut_NameAuthCode, opt => opt.MapFrom(src => src.AuthCode))
                .ForMember(dest => dest.aut_NameAuthCodePrivate, opt => opt.MapFrom(src => src.AuthCodePrivate))
          		.ForMember(dest => dest.ConfAccepted, opt => 
					{
						opt.Condition((arg1) => arg1.ConfAccepted != null);
						opt.MapFrom(src => src.ConfAccepted);
					})
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.RunBilling, opt => 
					{
						opt.Condition((arg1) => arg1.RunBilling != null);
						opt.MapFrom(src => src.RunBilling);
					})
          		.ForMember(dest => dest.Tnst_target_old, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
                .ForMember(dest => dest.Abn_Login, opt => opt.MapFrom(src => src.SubscriberLogin))
                .ForMember(dest => dest.Abn_Password, opt => opt.MapFrom(src => src.SubscriberPassword))
          		.ForMember(dest => dest.Tnst_target_new, opt => 
					{
						opt.Condition((arg1) => arg1.TargetStatusID != null);
						opt.MapFrom(src => src.TargetStatusID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response] -> WebModel Response(Subscribers_ChangeAccount_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response, Subscribers_ChangeAccount_Response_ACTION>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfMessage));
            #region (Subscribers/ChangeAccount)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request, ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response>();
            #endregion
            #region [Subscribers_ChangeName_Request_ACTION->ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request]
			//********************** DIRECT:    WebModel(Subscribers_ChangeName_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request] *************************************
			cfg.CreateMap<Subscribers_ChangeName_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Abn_FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Abn_FullName, opt => opt.MapFrom(src => src.FullName))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.Abn_MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Abn_LastName, opt => opt.MapFrom(src => src.Name))
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Abn_WorkPlace, opt => opt.MapFrom(src => src.SearchName))
                .ForMember(dest => dest.Abn_ShortName, opt => opt.MapFrom(src => src.ShortName))
          		.ForMember(dest => dest.toClean, opt => 
					{
						opt.Condition((arg1) => arg1.ToClean != null);
						opt.MapFrom(src => src.ToClean);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response] -> WebModel Response(Subscribers_ChangeName_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response, Subscribers_ChangeName_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Subscribers/ChangeName)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request, ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response>();
            #endregion
            #region [Subscribers_ChangeStatus_Request_ACTION->ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request]
			//********************** DIRECT:    WebModel(Subscribers_ChangeStatus_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request] *************************************
			cfg.CreateMap<Subscribers_ChangeStatus_Request_ACTION, ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request>()
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfirmationMessage))
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
          		.ForMember(dest => dest.ConfAccepted, opt => 
					{
						opt.Condition((arg1) => arg1.UserAcceptance != null);
						opt.MapFrom(src => src.UserAcceptance);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response] -> WebModel Response(Subscribers_ChangeStatus_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response, Subscribers_ChangeStatus_Response_ACTION>()
                .ForMember(dest => dest.ConfirmationMessage, opt => opt.MapFrom(src => src.ConfMessage))
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Subscribers/ChangeStatus)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request, ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response>();
            #endregion
            #region [Subscribers_Deactivate_Request_ACTION->ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request]
			//********************** DIRECT:    WebModel(Subscribers_Deactivate_Request_ACTION] -> CallModel[ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request] *************************************
			cfg.CreateMap<Subscribers_Deactivate_Request_ACTION, ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.UniqueID, opt => opt.MapFrom(src => src.global_unique_id))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Tnst_Code_crnt, opt => opt.MapFrom(src => src.StatusCode))
                .ForMember(dest => dest.Tnst_Code_trgt, opt => opt.MapFrom(src => src.TargetStatusCode));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response] -> WebModel Response(Subscribers_Deactivate_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response, Subscribers_Deactivate_Response_ACTION>()
  		           .ForMember(dest => dest.AffectedCount, opt => 
					    {
						    opt.Condition((arg1) => arg1.AffectedCount != null);
						    opt.MapFrom(src => src.AffectedCount);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.WorkEventID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Wev_ID != null);
						    opt.MapFrom(src => src.Wev_ID);
					    });
            #region (Subscribers/Deactivate)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request, ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response>();
            #endregion
            #region [Subscribers_Details_Request_GET->GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request]
			//********************** DIRECT:    WebModel(Subscribers_Details_Request_GET] -> CallModel[GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request] *************************************
			cfg.CreateMap<Subscribers_Details_Request_GET, GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request>()
          		.ForMember(dest => dest.IfModifiedSinceDate, opt => 
					{
						opt.Condition((arg1) => arg1.CacheControlDate != null);
						opt.MapFrom(src => src.CacheControlDate);
					})
          		.ForMember(dest => dest.abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response] -> WebModel Response(Subscribers_Details_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response, Subscribers_Details_Response_GET>()
  		           .ForMember(dest => dest.CacheControlDate, opt => 
					    {
						    opt.Condition((arg1) => arg1.IfModifiedSinceDate != null);
						    opt.MapFrom(src => src.IfModifiedSinceDate);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, Subscribers_Details_Request_GET>()

					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response_OUTPUT] -> WebModel Response Output(Subscribers_Details_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response_OUTPUT, Subscribers_Details_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.abn_IsGuest, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsGuest != null);
						opt.MapFrom(src => src.abn_IsGuest);
					})
		         .ForMember(dest => dest.abc_Date_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Date_Personal != null);
						opt.MapFrom(src => src.abc_Date_Personal);
					})
		         .ForMember(dest => dest.abn_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Balance != null);
						opt.MapFrom(src => src.abn_Balance);
					})
		         .ForMember(dest => dest.abn_CreateDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_CreateDate != null);
						opt.MapFrom(src => src.abn_CreateDate);
					})
		         .ForMember(dest => dest.abn_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Date != null);
						opt.MapFrom(src => src.abn_Date);
					})
                .ForMember(dest => dest.abn_Employe_Export_ID, opt => opt.MapFrom(src => src.abn_Employe_Export_ID))
                .ForMember(dest => dest.abn_Employee_ID, opt => opt.MapFrom(src => src.abn_Employee_ID))
		         .ForMember(dest => dest.abn_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
                .ForMember(dest => dest.abn_FirstName, opt => opt.MapFrom(src => src.abn_FirstName))
		         .ForMember(dest => dest.abn_Guid, opt => 
					{
						opt.Condition((arg1) => arg1.abn_Guid != null);
						opt.MapFrom(src => src.abn_Guid);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.abn_ID_Boss, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID_Boss != null);
						opt.MapFrom(src => src.abn_ID_Boss);
					})
		         .ForMember(dest => dest.abn_IsExistAD, opt => 
					{
						opt.Condition((arg1) => arg1.abn_IsExistAD != null);
						opt.MapFrom(src => src.abn_IsExistAD);
					})
                .ForMember(dest => dest.abn_LastFM, opt => opt.MapFrom(src => src.abn_LastFM))
                .ForMember(dest => dest.abn_LastName, opt => opt.MapFrom(src => src.abn_LastName))
                .ForMember(dest => dest.abn_Login, opt => opt.MapFrom(src => src.abn_Login))
                .ForMember(dest => dest.abn_MiddleName, opt => opt.MapFrom(src => src.abn_MiddleName))
                .ForMember(dest => dest.abn_ModifiedBy, opt => opt.MapFrom(src => src.abn_ModifiedBy))
		         .ForMember(dest => dest.abn_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ModifiedDate != null);
						opt.MapFrom(src => src.abn_ModifiedDate);
					})
                .ForMember(dest => dest.abn_ModifiedFrom, opt => opt.MapFrom(src => src.abn_ModifiedFrom))
		         .ForMember(dest => dest.abn_NestedSets_Left, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Left != null);
						opt.MapFrom(src => src.abn_NestedSets_Left);
					})
		         .ForMember(dest => dest.abn_NestedSets_Right, opt => 
					{
						opt.Condition((arg1) => arg1.abn_NestedSets_Right != null);
						opt.MapFrom(src => src.abn_NestedSets_Right);
					})
                .ForMember(dest => dest.abn_Password, opt => opt.MapFrom(src => src.abn_Password))
                .ForMember(dest => dest.abn_PositionCode, opt => opt.MapFrom(src => src.abn_PositionCode))
		         .ForMember(dest => dest.abn_ShowPhoneDirectory, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ShowPhoneDirectory != null);
						opt.MapFrom(src => src.abn_ShowPhoneDirectory);
					})
                .ForMember(dest => dest.abn_WorkPlace, opt => opt.MapFrom(src => src.abn_WorkPlace))
                .ForMember(dest => dest.abn_WorkPlace_Personal, opt => opt.MapFrom(src => src.abn_WorkPlace_Personal))
                .ForMember(dest => dest.abn_XmlData, opt => opt.MapFrom(src => src.abn_XmlData))
                .ForMember(dest => dest.AbonentFullName, opt => opt.MapFrom(src => src.AbonentFullName))
		         .ForMember(dest => dest.acnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID != null);
						opt.MapFrom(src => src.acnt_ID);
					})
		         .ForMember(dest => dest.acnt_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_ID_count != null);
						opt.MapFrom(src => src.acnt_ID_count);
					})
		         .ForMember(dest => dest.acnt_IsPersonal, opt => 
					{
						opt.Condition((arg1) => arg1.acnt_IsPersonal != null);
						opt.MapFrom(src => src.acnt_IsPersonal);
					})
                .ForMember(dest => dest.acnt_Number, opt => opt.MapFrom(src => src.acnt_Number))
                .ForMember(dest => dest.acnt_Number_Personal, opt => opt.MapFrom(src => src.acnt_Number_Personal))
                .ForMember(dest => dest.Actpd_Name, opt => opt.MapFrom(src => src.Actpd_Name))
                .ForMember(dest => dest.Actpd_Name_Personal, opt => opt.MapFrom(src => src.Actpd_Name_Personal))
		         .ForMember(dest => dest.atnsb_DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.atnsb_DateEnd != null);
						opt.MapFrom(src => src.atnsb_DateEnd);
					})
		         .ForMember(dest => dest.atnsb_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.atnsb_DateStart != null);
						opt.MapFrom(src => src.atnsb_DateStart);
					})
		         .ForMember(dest => dest.abb_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abb_Balance != null);
						opt.MapFrom(src => src.abb_Balance);
					})
		         .ForMember(dest => dest.abb_Balance_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abb_Balance_Personal != null);
						opt.MapFrom(src => src.abb_Balance_Personal);
					})
		         .ForMember(dest => dest.abb_ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.abb_ModifiedDate != null);
						opt.MapFrom(src => src.abb_ModifiedDate);
					})
		         .ForMember(dest => dest.abb_ModifiedDate_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abb_ModifiedDate_Personal != null);
						opt.MapFrom(src => src.abb_ModifiedDate_Personal);
					})
		         .ForMember(dest => dest.abc_Balance, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Balance != null);
						opt.MapFrom(src => src.abc_Balance);
					})
		         .ForMember(dest => dest.abc_Balance_Personal, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Balance_Personal != null);
						opt.MapFrom(src => src.abc_Balance_Personal);
					})
		         .ForMember(dest => dest.abc_Date, opt => 
					{
						opt.Condition((arg1) => arg1.abc_Date != null);
						opt.MapFrom(src => src.abc_Date);
					})
		         .ForMember(dest => dest.aut_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.aut_ID_count != null);
						opt.MapFrom(src => src.aut_ID_count);
					})
                .ForMember(dest => dest.Boss_Tnt_Type, opt => opt.MapFrom(src => src.Boss_Tnt_Type))
                .ForMember(dest => dest.BossFullName, opt => opt.MapFrom(src => src.BossFullName))
		         .ForMember(dest => dest.com_Id, opt => 
					{
						opt.Condition((arg1) => arg1.com_Id != null);
						opt.MapFrom(src => src.com_Id);
					})
		         .ForMember(dest => dest.debt_Amount, opt => 
					{
						opt.Condition((arg1) => arg1.debt_Amount != null);
						opt.MapFrom(src => src.debt_Amount);
					})
		         .ForMember(dest => dest.debt_Date, opt => 
					{
						opt.Condition((arg1) => arg1.debt_Date != null);
						opt.MapFrom(src => src.debt_Date);
					})
		         .ForMember(dest => dest.dep_ID, opt => 
					{
						opt.Condition((arg1) => arg1.dep_ID != null);
						opt.MapFrom(src => src.dep_ID);
					})
                .ForMember(dest => dest.ext_ExtNum, opt => opt.MapFrom(src => src.ext_ExtNum))
		         .ForMember(dest => dest.ext_ID_count, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ID_count != null);
						opt.MapFrom(src => src.ext_ID_count);
					})
		         .ForMember(dest => dest.grp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grp_ID != null);
						opt.MapFrom(src => src.grp_ID);
					})
                .ForMember(dest => dest.grp_Name, opt => opt.MapFrom(src => src.grp_Name))
		         .ForMember(dest => dest.isActivated, opt => 
					{
						opt.Condition((arg1) => arg1.isActivated != null);
						opt.MapFrom(src => src.isActivated);
					})
		         .ForMember(dest => dest.isEditAllow, opt => 
					{
						opt.Condition((arg1) => arg1.isEditAllow != null);
						opt.MapFrom(src => src.isEditAllow);
					})
		         .ForMember(dest => dest.isEditWorkPlace, opt => 
					{
						opt.Condition((arg1) => arg1.isEditWorkPlace != null);
						opt.MapFrom(src => src.isEditWorkPlace);
					})
		         .ForMember(dest => dest.lng_ID, opt => 
					{
						opt.Condition((arg1) => arg1.lng_ID != null);
						opt.MapFrom(src => src.lng_ID);
					})
                .ForMember(dest => dest.loc_Name, opt => opt.MapFrom(src => src.loc_Name))
		         .ForMember(dest => dest.Location_ID, opt => 
					{
						opt.Condition((arg1) => arg1.Location_ID != null);
						opt.MapFrom(src => src.Location_ID);
					})
		         .ForMember(dest => dest.ntw_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ntw_ID != null);
						opt.MapFrom(src => src.ntw_ID);
					})
                .ForMember(dest => dest.pbx_networkName, opt => opt.MapFrom(src => src.pbx_networkName))
		         .ForMember(dest => dest.ProfileType, opt => 
					{
						opt.Condition((arg1) => arg1.ProfileType != null);
						opt.MapFrom(src => src.ProfileType);
					})
		         .ForMember(dest => dest.SubsCount, opt => 
					{
						opt.Condition((arg1) => arg1.SubsCount != null);
						opt.MapFrom(src => src.SubsCount);
					})
                .ForMember(dest => dest.tnh_LastFM, opt => opt.MapFrom(src => src.tnh_LastFM))
		         .ForMember(dest => dest.tnst_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ExternalID != null);
						opt.MapFrom(src => src.tnst_ExternalID);
					})
		         .ForMember(dest => dest.tnst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnst_ID != null);
						opt.MapFrom(src => src.tnst_ID);
					})
		         .ForMember(dest => dest.tnt_AccountMandatory, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_AccountMandatory != null);
						opt.MapFrom(src => src.tnt_AccountMandatory);
					})
		         .ForMember(dest => dest.tnt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnt_ID != null);
						opt.MapFrom(src => src.tnt_ID);
					})
                .ForMember(dest => dest.TreeNodeType, opt => opt.MapFrom(src => src.TreeNodeType))
		         .ForMember(dest => dest.trf_ID, opt => 
					{
						opt.Condition((arg1) => arg1.trf_ID != null);
						opt.MapFrom(src => src.trf_ID);
					})
		         .ForMember(dest => dest.isRefusalChangeName, opt => 
					{
						opt.Condition((arg1) => arg1.isRefusalChangeName != null);
						opt.MapFrom(src => src.isRefusalChangeName);
					});
            #region (Subscribers/Details)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request, GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response>();
            #endregion
            #region [Subscribers_Recharge_Request_ACTION->ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request]
			//********************** DIRECT:    WebModel(Subscribers_Recharge_Request_ACTION] -> CallModel[ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request] *************************************
			cfg.CreateMap<Subscribers_Recharge_Request_ACTION, ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request>()
          		.ForMember(dest => dest.Amount, opt => 
					{
						opt.Condition((arg1) => arg1.AMOUNT != null);
						opt.MapFrom(src => src.AMOUNT);
					})
                .ForMember(dest => dest.ChargeCode, opt => opt.MapFrom(src => src.ChargeCode))
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
          		.ForMember(dest => dest.EmulateMode, opt => 
					{
						opt.Condition((arg1) => arg1.EmulateMode != null);
						opt.MapFrom(src => src.EmulateMode);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.Ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ExtentionID != null);
						opt.MapFrom(src => src.ExtentionID);
					})
          		.ForMember(dest => dest.ID_GroupATS, opt => 
					{
						opt.Condition((arg1) => arg1.ID_GroupATS != null);
						opt.MapFrom(src => src.ID_GroupATS);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.IsOnline, opt => 
					{
						opt.Condition((arg1) => arg1.IsOnline != null);
						opt.MapFrom(src => src.IsOnline);
					})
          		.ForMember(dest => dest.IsReCharge, opt => 
					{
						opt.Condition((arg1) => arg1.IsReCharge != null);
						opt.MapFrom(src => src.IsReCharge);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.Mode, opt => 
					{
						opt.Condition((arg1) => arg1.Mode != null);
						opt.MapFrom(src => src.Mode);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.NumberATS, opt => 
					{
						opt.Condition((arg1) => arg1.NumberATS != null);
						opt.MapFrom(src => src.NumberATS);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Srv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ServiceID != null);
						opt.MapFrom(src => src.ServiceID);
					})
                .ForMember(dest => dest.Srs_SessionID, opt => opt.MapFrom(src => src.Srs_SessionID))
                .ForMember(dest => dest.Wev_CurrrentState, opt => opt.MapFrom(src => src.Wev_CurrrentState))
          		.ForMember(dest => dest.Wev_ID, opt => 
					{
						opt.Condition((arg1) => arg1.WorkEventID != null);
						opt.MapFrom(src => src.WorkEventID);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response] -> WebModel Response(Subscribers_Recharge_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response, Subscribers_Recharge_Response_ACTION>()
  		           .ForMember(dest => dest.Amount, opt => 
					    {
						    opt.Condition((arg1) => arg1.Amount != null);
						    opt.MapFrom(src => src.Amount);
					    })
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.WorkEventID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Wev_ID != null);
						    opt.MapFrom(src => src.Wev_ID);
					    });
            #region (Subscribers/Recharge)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request, ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response>();
            #endregion
            #region [Subscribers_SetLabels_Request_ACTION->ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request]
			//********************** DIRECT:    WebModel(Subscribers_SetLabels_Request_ACTION] -> CallModel[ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request] *************************************
			cfg.CreateMap<Subscribers_SetLabels_Request_ACTION, ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lbl_Code, opt => opt.MapFrom(src => src.LabelCode))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
                .ForMember(dest => dest.LinkedServer, opt => opt.MapFrom(src => src.LinkedServer))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.SourceQuery, opt => opt.MapFrom(src => src.SourceQuery));
#endregion
			//**********************REVERSE[y] :   CallModel Response(ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response] -> WebModel Response(Subscribers_SetLabels_Response_ACTION) *************************************
			cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response, Subscribers_SetLabels_Response_ACTION>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
            #region (Subscribers/SetLabels)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request, ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response>();
            #endregion
            #endregion
            #region [Tasks]
            #region [Tasks_Request_SET->SET_p_ucp_set_ServiceTask_Request]
			//********************** DIRECT:    WebModel(Tasks_Request_SET] -> CallModel[SET_p_ucp_set_ServiceTask_Request] *************************************
			cfg.CreateMap<Tasks_Request_SET, SET_p_ucp_set_ServiceTask_Request>()
          		.ForMember(dest => dest.Tsk_DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.Tsk_PeriodBegin, opt => 
					{
						opt.Condition((arg1) => arg1.PeriodBegin != null);
						opt.MapFrom(src => src.PeriodBegin);
					})
          		.ForMember(dest => dest.Tsk_PeriodEnd, opt => 
					{
						opt.Condition((arg1) => arg1.PeriodEnd != null);
						opt.MapFrom(src => src.PeriodEnd);
					})
          		.ForMember(dest => dest.ID_GroupATS, opt => 
					{
						opt.Condition((arg1) => arg1.DeviceGroupID != null);
						opt.MapFrom(src => src.DeviceGroupID);
					})
          		.ForMember(dest => dest.Lig_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ListGroupID != null);
						opt.MapFrom(src => src.ListGroupID);
					})
                .ForMember(dest => dest.Tsk_JsonData, opt => opt.MapFrom(src => src.JsonData))
                .ForMember(dest => dest.DataFormat, opt => opt.MapFrom(src => src.DataFormat))
          		.ForMember(dest => dest.Tsst_ID, opt => 
					{
						opt.Condition((arg1) => arg1.StatusID != null);
						opt.MapFrom(src => src.StatusID);
					})
                .ForMember(dest => dest.Tsk_StateMessage, opt => opt.MapFrom(src => src.Message))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
                .ForMember(dest => dest.cacheStatus, opt => opt.MapFrom(src => src.cacheStatus))
          		.ForMember(dest => dest.Tsk_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.HostName, opt => opt.MapFrom(src => src.HostName))
          		.ForMember(dest => dest.Tsk_IsReady, opt => 
					{
						opt.Condition((arg1) => arg1.Tsk_IsReady != null);
						opt.MapFrom(src => src.Tsk_IsReady);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_ServiceTask_Response] -> WebModel Response(Tasks_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_ServiceTask_Response, Tasks_Response_SET>()
  		           .ForMember(dest => dest.PeriodBegin, opt => 
					    {
						    opt.Condition((arg1) => arg1.Tsk_PeriodBegin != null);
						    opt.MapFrom(src => src.Tsk_PeriodBegin);
					    })
  		           .ForMember(dest => dest.PeriodEnd, opt => 
					    {
						    opt.Condition((arg1) => arg1.Tsk_PeriodEnd != null);
						    opt.MapFrom(src => src.Tsk_PeriodEnd);
					    })
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Tsk_ID != null);
						    opt.MapFrom(src => src.Tsk_ID);
					    })
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang));
            #region (Tasks)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_ServiceTask_Request, SET_p_ucp_set_ServiceTask_Response>();
            #endregion
            #endregion
            #region [TemplateSubscriptions]
            #region [TemplateSubscriptions_Request_GET->GET_p_ucp_get_TemplateSubscriptions_Request]
			//********************** DIRECT:    WebModel(TemplateSubscriptions_Request_GET] -> CallModel[GET_p_ucp_get_TemplateSubscriptions_Request] *************************************
			cfg.CreateMap<TemplateSubscriptions_Request_GET, GET_p_ucp_get_TemplateSubscriptions_Request>()
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TreeNodeID != null);
						opt.MapFrom(src => src.TreeNodeID);
					})
          		.ForMember(dest => dest.Agr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.Ext_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ExtentionID != null);
						opt.MapFrom(src => src.ExtentionID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageNumber != null);
						opt.MapFrom(src => src.PageNumber);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					})
          		.ForMember(dest => dest.ShowBasicTP, opt => 
					{
						opt.Condition((arg1) => arg1.ShowBasicTP != null);
						opt.MapFrom(src => src.ShowBasicTP);
					})
                .ForMember(dest => dest.TariffName, opt => opt.MapFrom(src => src.TariffName));
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_TemplateSubscriptions_Response] -> WebModel Response(TemplateSubscriptions_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_TemplateSubscriptions_Response, TemplateSubscriptions_Response_GET>()
;			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, TemplateSubscriptions_Request_GET>()

	            	.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_TemplateSubscriptions_Response_OUTPUT] -> WebModel Response Output(TemplateSubscriptions_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_TemplateSubscriptions_Response_OUTPUT, TemplateSubscriptions_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.SubscriberID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.AgreementID, opt => 
					{
						opt.Condition((arg1) => arg1.agr_ID != null);
						opt.MapFrom(src => src.agr_ID);
					})
		         .ForMember(dest => dest.ExtentionID, opt => 
					{
						opt.Condition((arg1) => arg1.ext_ID != null);
						opt.MapFrom(src => src.ext_ID);
					})
                .ForMember(dest => dest.TarifPlanName, opt => opt.MapFrom(src => src.grt_Name))
		         .ForMember(dest => dest.PolicyID, opt => 
					{
						opt.Condition((arg1) => arg1.ptp_ID != null);
						opt.MapFrom(src => src.ptp_ID);
					})
                .ForMember(dest => dest.PolicyName, opt => opt.MapFrom(src => src.ptp_UserGroupName))
		         .ForMember(dest => dest.RepresentationID, opt => 
					{
						opt.Condition((arg1) => arg1.rpr_ID != null);
						opt.MapFrom(src => src.rpr_ID);
					})
		         .ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.rtb_DateDrop != null);
						opt.MapFrom(src => src.rtb_DateDrop);
					})
		         .ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.rtb_DateSet != null);
						opt.MapFrom(src => src.rtb_DateSet);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.rtb_ID != null);
						opt.MapFrom(src => src.rtb_ID);
					})
                .ForMember(dest => dest.TariffDescription, opt => opt.MapFrom(src => src.TariffDescription))
                .ForMember(dest => dest.TariffName, opt => opt.MapFrom(src => src.TariffName))
		         .ForMember(dest => dest.PriceRatio, opt => 
					{
						opt.Condition((arg1) => arg1.tgb_PriceRatio != null);
						opt.MapFrom(src => src.tgb_PriceRatio);
					})
		         .ForMember(dest => dest.Total, opt => 
					{
						opt.Condition((arg1) => arg1.Total != null);
						opt.MapFrom(src => src.Total);
					})
		         .ForMember(dest => dest.PacketExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.tp_ExternalID != null);
						opt.MapFrom(src => src.tp_ExternalID);
					})
		         .ForMember(dest => dest.PacketParentID, opt => 
					{
						opt.Condition((arg1) => arg1.tp_ID_Boss != null);
						opt.MapFrom(src => src.tp_ID_Boss);
					})
		         .ForMember(dest => dest.grt_ExternalId, opt => 
					{
						opt.Condition((arg1) => arg1.grt_ExternalId != null);
						opt.MapFrom(src => src.grt_ExternalId);
					})
		         .ForMember(dest => dest.grt_ID, opt => 
					{
						opt.Condition((arg1) => arg1.grt_ID != null);
						opt.MapFrom(src => src.grt_ID);
					})
		         .ForMember(dest => dest.IdTariffPlan, opt => 
					{
						opt.Condition((arg1) => arg1.IdTariffPlan != null);
						opt.MapFrom(src => src.IdTariffPlan);
					})
                .ForMember(dest => dest.tpgnd_Name, opt => opt.MapFrom(src => src.tpgnd_Name));
            #region [TemplateSubscriptions_Request_SET->SET_p_ucp_set_AgreementTemplates_Request]
			//********************** DIRECT:    WebModel(TemplateSubscriptions_Request_SET] -> CallModel[SET_p_ucp_set_AgreementTemplates_Request] *************************************
			cfg.CreateMap<TemplateSubscriptions_Request_SET, SET_p_ucp_set_AgreementTemplates_Request>()
          		.ForMember(dest => dest.EffectiveDate, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.TasksJsonData, opt => opt.MapFrom(src => src.TasksJsonData))
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Tp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.TemplateID != null);
						opt.MapFrom(src => src.TemplateID);
					})
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
          		.ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
          		.ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.DateStart != null);
						opt.MapFrom(src => src.DateStart);
					})
          		.ForMember(dest => dest.IsCheckBallance, opt => 
					{
						opt.Condition((arg1) => arg1.CheckBallance != null);
						opt.MapFrom(src => src.CheckBallance);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
          		.ForMember(dest => dest.TariffBegin, opt => 
					{
						opt.Condition((arg1) => arg1.TariffBegin != null);
						opt.MapFrom(src => src.TariffBegin);
					})
          		.ForMember(dest => dest.Agr_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
          		.ForMember(dest => dest.Rtb_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.ActivateServices, opt => opt.MapFrom(src => src.ActivateServices))
          		.ForMember(dest => dest.Agr_ID_Old, opt => 
					{
						opt.Condition((arg1) => arg1.Agr_ID_Old != null);
						opt.MapFrom(src => src.Agr_ID_Old);
					})
                .ForMember(dest => dest.ConfMessage, opt => opt.MapFrom(src => src.ConfirmationMessage))
          		.ForMember(dest => dest.Rtb_ID_Old, opt => 
					{
						opt.Condition((arg1) => arg1.Rtb_ID_Old != null);
						opt.MapFrom(src => src.Rtb_ID_Old);
					})
                .ForMember(dest => dest.ServiceMode, opt => opt.MapFrom(src => src.ServiceMode))
                .ForMember(dest => dest.Services, opt => opt.MapFrom(src => src.Services))
          		.ForMember(dest => dest.Tp_ID_New, opt => 
					{
						opt.Condition((arg1) => arg1.Tp_ID_New != null);
						opt.MapFrom(src => src.Tp_ID_New);
					})
          		.ForMember(dest => dest.ConfAccepted, opt => 
					{
						opt.Condition((arg1) => arg1.UserAcceptance != null);
						opt.MapFrom(src => src.UserAcceptance);
					});
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_AgreementTemplates_Response] -> WebModel Response(TemplateSubscriptions_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_AgreementTemplates_Response, TemplateSubscriptions_Response_SET>()
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Rtb_ID != null);
						    opt.MapFrom(src => src.Rtb_ID);
					    })
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.Lang))
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.Entities))
                .ForMember(dest => dest.ConfirmationMessage, opt => opt.MapFrom(src => src.ConfMessage));
            #region (TemplateSubscriptions)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_TemplateSubscriptions_Request, GET_p_ucp_get_TemplateSubscriptions_Response>();
            cfg.CreateMap<SET_p_ucp_set_AgreementTemplates_Request, SET_p_ucp_set_AgreementTemplates_Response>();
            #endregion
            #endregion
            #region [TreeNodeHistory]
            #region [TreeNodeHistory_Request_GET->GET_p_ucp_get_TreeNodeHistory_Request]
			//********************** DIRECT:    WebModel(TreeNodeHistory_Request_GET] -> CallModel[GET_p_ucp_get_TreeNodeHistory_Request] *************************************
			cfg.CreateMap<TreeNodeHistory_Request_GET, GET_p_ucp_get_TreeNodeHistory_Request>()
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.Date, opt => 
					{
						opt.Condition((arg1) => arg1.EffectiveDate != null);
						opt.MapFrom(src => src.EffectiveDate);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang))
          		.ForMember(dest => dest.PageNumber, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);
					})
          		.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);
					});
#endregion
			//**********************BACK(FROM REQUEST):   CallModel Response(GET_p_ucp_get_TreeNodeHistory_Response] -> WebModel Response(TreeNodeHistory_Response_GET) *************************************
			cfg.CreateMap<GET_p_ucp_get_TreeNodeHistory_Response, TreeNodeHistory_Response_GET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//********************** Filter -> WebModel *************************************
			cfg.CreateMap<Filter, TreeNodeHistory_Request_GET>()

	            	.ForMember(dest => dest.PageIndex, opt => 
					{
						opt.Condition((arg1) => arg1.PageIndex != null);
						opt.MapFrom(src => src.PageIndex);

					})
	            	.ForMember(dest => dest.PageSize, opt => 
					{
						opt.Condition((arg1) => arg1.PageSize != null);
						opt.MapFrom(src => src.PageSize);

					})
					//Lang
					.ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang));
			//**********************BACK[OUTPUT] :   CallModel Response Output(GET_p_ucp_get_TreeNodeHistory_Response_OUTPUT] -> WebModel Response Output(TreeNodeHistory_Response_GET_OUTPUT) *************************************
			cfg.CreateMap<GET_p_ucp_get_TreeNodeHistory_Response_OUTPUT, TreeNodeHistory_Response_GET_OUTPUT>()
		         .ForMember(dest => dest.TreeNodeExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID != null);
						opt.MapFrom(src => src.abn_ExternalID);
					})
		         .ForMember(dest => dest.TreeNodeParentExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ExternalID_Boss != null);
						opt.MapFrom(src => src.abn_ExternalID_Boss);
					})
		         .ForMember(dest => dest.ID, opt => 
					{
						opt.Condition((arg1) => arg1.tnh_ID != null);
						opt.MapFrom(src => src.tnh_ID);
					})
		         .ForMember(dest => dest.TreeNodeID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID != null);
						opt.MapFrom(src => src.abn_ID);
					})
		         .ForMember(dest => dest.TreeNodeParentID, opt => 
					{
						opt.Condition((arg1) => arg1.abn_ID_Boss != null);
						opt.MapFrom(src => src.abn_ID_Boss);
					})
                .ForMember(dest => dest.ModifiedFrom, opt => opt.MapFrom(src => src.tnh_ModifiedFrom))
		         .ForMember(dest => dest.ModifiedDate, opt => 
					{
						opt.Condition((arg1) => arg1.tnh_ModifiedDate != null);
						opt.MapFrom(src => src.tnh_ModifiedDate);
					})
		         .ForMember(dest => dest.DateStart, opt => 
					{
						opt.Condition((arg1) => arg1.tnh_DateStart != null);
						opt.MapFrom(src => src.tnh_DateStart);
					})
		         .ForMember(dest => dest.DateEnd, opt => 
					{
						opt.Condition((arg1) => arg1.DateEnd != null);
						opt.MapFrom(src => src.DateEnd);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.tnh_Remark))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.tnh_ModifiedBy));
            #region (TreeNodeHistory)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<GET_p_ucp_get_TreeNodeHistory_Request, GET_p_ucp_get_TreeNodeHistory_Response>();
            #endregion
            #endregion
            #region [TreeNodeProperties]
            #region [TreeNodeProperties_Request_SET->SET_p_ucp_set_TreeNodeProperty_Request]
			//********************** DIRECT:    WebModel(TreeNodeProperties_Request_SET] -> CallModel[SET_p_ucp_set_TreeNodeProperty_Request] *************************************
			cfg.CreateMap<TreeNodeProperties_Request_SET, SET_p_ucp_set_TreeNodeProperty_Request>()
          		.ForMember(dest => dest.Annul, opt => 
					{
						opt.Condition((arg1) => arg1.Annul != null);
						opt.MapFrom(src => src.Annul);
					})
                .ForMember(dest => dest.ModBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dest => dest.ModFrom, opt => opt.MapFrom(src => src.ModifiedFrom))
          		.ForMember(dest => dest.Prp_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PropertyID != null);
						opt.MapFrom(src => src.PropertyID);
					})
          		.ForMember(dest => dest.Prpv_ID, opt => 
					{
						opt.Condition((arg1) => arg1.PropertyValueID != null);
						opt.MapFrom(src => src.PropertyValueID);
					})
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
          		.ForMember(dest => dest.Tnpb_ExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.ExternalID != null);
						opt.MapFrom(src => src.ExternalID);
					})
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
          		.ForMember(dest => dest.IsExternalID, opt => 
					{
						opt.Condition((arg1) => arg1.IDType != null);
						opt.MapFrom(src => src.IDType);
					})
                .ForMember(dest => dest.ExternalSystemCode, opt => opt.MapFrom(src => src.System))
                .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.EntityName))
          		.ForMember(dest => dest.Tnpb_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ID != null);
						opt.MapFrom(src => src.ID);
					})
          		.ForMember(dest => dest.Abn_ID, opt => 
					{
						opt.Condition((arg1) => arg1.ParentID != null);
						opt.MapFrom(src => src.ParentID);
					})
                .ForMember(dest => dest.ErrFormat, opt => opt.MapFrom(src => src.ErrFormat))
                .ForMember(dest => dest.Lang, opt => opt.MapFrom(src => src.lang));
#endregion
			//**********************REVERSE[y] :   CallModel Response(SET_p_ucp_set_TreeNodeProperty_Response] -> WebModel Response(TreeNodeProperties_Response_SET) *************************************
			cfg.CreateMap<SET_p_ucp_set_TreeNodeProperty_Response, TreeNodeProperties_Response_SET>()
  		           .ForMember(dest => dest.IDType, opt => 
					    {
						    opt.Condition((arg1) => arg1.IsExternalID != null);
						    opt.MapFrom(src => src.IsExternalID);
					    })
                .ForMember(dest => dest.lang, opt => opt.MapFrom(src => src.Lang))
  		           .ForMember(dest => dest.ID, opt => 
					    {
						    opt.Condition((arg1) => arg1.Tnpb_ID != null);
						    opt.MapFrom(src => src.Tnpb_ID);
					    });
            #region (TreeNodeProperties)[Call Request -> Call Response]
            //********************************** [Call Request -> Call Response]
            cfg.CreateMap<SET_p_ucp_set_TreeNodeProperty_Request, SET_p_ucp_set_TreeNodeProperty_Response>();
            #endregion
            #endregion
            ExtendConfigurationWN(cfg);
            return cfg;
        }

    }
}
