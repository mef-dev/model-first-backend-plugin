////////////////////////////////////////////////////////
// Прокси класс моделей вызовов хранимых процедур. Альфа версия - с 
// expressions для Output параметров в Dapper
// Сгенерирован из файла C:\Users\keiqsa\Projects\model-first-backend-plugin\models.xml 10/21/2022 12:54:28
////////////////////////////////////////////////////////

using System; 
using System.Linq.Expressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
#region [Accounts]
	[DocIgnore]
	public class GET_p_ucp_get_Accounts_Request : ICallProcedureModel<GET_p_ucp_get_Accounts_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_Accounts_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_Accounts_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор клиента (узла типа Customers)
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Acnt_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор категории Лицевого счета
		/// <para/>
		/// CategoryID
		/// </summary>
		public global::System.Int32? Acat_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор категории регистрации
		/// <para/>
		/// RegistrCatID
		/// </summary>
		public global::System.Int32? Rgsc_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор класса Лицевого счета
		/// <para/>
		/// ClassID
		/// </summary>
		public global::System.Int32? Accl_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа лицевого счета
		/// <para/>
		/// TypeID
		/// </summary>
		public global::System.Int32? Actp_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа платежа лицевого счета
		/// <para/>
		/// PayTypeID
		/// </summary>
		public global::System.Int32? Aptp_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер лицевого счета
		/// <para/>
		/// Number
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Номер страницы (server paging)
		/// <para/>
		/// pageIndex
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Dls_ID
		/// </summary>
		public global::System.Int32? Dls_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_Accounts_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_Accounts_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_Accounts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_ID, (v) => this.Acnt_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Acnt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acat_ID, (v) => this.Acat_ID = (global::System.Int32?)v) /*--CategoryID--*/
			{
				Name = "Acat_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acat_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Rgsc_ID, (v) => this.Rgsc_ID = (global::System.Int32?)v) /*--RegistrCatID--*/
			{
				Name = "Rgsc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rgsc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Accl_ID, (v) => this.Accl_ID = (global::System.Int32?)v) /*--ClassID--*/
			{
				Name = "Accl_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accl_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Actp_ID, (v) => this.Actp_ID = (global::System.Int32?)v) /*--TypeID--*/
			{
				Name = "Actp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Actp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aptp_ID, (v) => this.Aptp_ID = (global::System.Int32?)v) /*--PayTypeID--*/
			{
				Name = "Aptp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aptp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--Number--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--CacheControlDate--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--pageIndex--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Dls_ID, (v) => this.Dls_ID = (global::System.Int32?)v) /*--Dls_ID--*/
			{
				Name = "Dls_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dls_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_Accounts_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_Accounts_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Код Валюты
		/// <para/>
		/// CurrencyCode
		/// </summary>
		[Required]
		public global::System.String Currency { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор клиента (узла типа Customers)
		/// <para/>
		/// CustomerID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор категории Лицевого счета
		/// <para/>
		/// CategoryID
		/// </summary>
		[Required]
		public global::System.Int32? acat_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор категории регистрации
		/// <para/>
		/// RegistrCatID
		/// </summary>
		[Required]
		public global::System.Int32? rgsc_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор класса Лицевого счета
		/// <para/>
		/// ClassID
		/// </summary>
		[Required]
		public global::System.Int32? accl_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор типа лицевого счета
		/// <para/>
		/// TypeID
		/// </summary>
		[Required]
		public global::System.Int32? actp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор типа платежа лицевого счета
		/// <para/>
		/// PayTypeID
		/// </summary>
		[Required]
		public global::System.Int32? aptp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование категории лицевого счета (multi-language)
		/// <para/>
		/// CategoryName
		/// </summary>
		[Required]
		public global::System.String acatd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование категории регистрации (multi-language)
		/// <para/>
		/// RegistrCatName
		/// </summary>
		[Required]
		public global::System.String rgscd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование класса лицевых счетов (multi-language)
		/// <para/>
		/// ClassName
		/// </summary>
		[Required]
		public global::System.String accld_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование типа лицевого счета  (multi-language)
		/// <para/>
		/// TypeName
		/// </summary>
		[Required]
		public global::System.String actpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование типа платежай (multi-language)
		/// <para/>
		/// PayTypeName
		/// </summary>
		[Required]
		public global::System.String aptpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер лицевого счета
		/// <para/>
		/// Number
		/// </summary>
		[Required]
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// Общее количество записей (server paging)
		/// <para/>
		/// TotalCount
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// AccountID
		/// </summary>
		[Required]
		public global::System.Int32? Acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Вычисляемое: Значение/сумма актуального баланса
		/// <para/>
		/// abc_Amount
		/// </summary>
		[Required]
		public global::System.Decimal? abc_Amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_DateCharge
		/// </summary>
		[Required]
		public global::System.DateTime? abc_DateCharge { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_CreateDate
		/// </summary>
		public global::System.DateTime? acnt_CreateDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ExternalID
		/// </summary>
		public global::System.Int32? acnt_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// IP-адрес/имя копьютера, с которого производилось изменение записи
		/// <para/>
		/// acnt_ModifiedFrom
		/// </summary>
		public global::System.String acnt_ModifiedFrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// Комментарий к лицевому счету (статичный внешний). Изменять не планируется. Комментировать изменения следует в изменяемых сущностях
		/// <para/>
		/// acnt_Remark
		/// </summary>
		public global::System.String acnt_Remark { get; set; } /*OUTPUT*/
			/// <summary>
		/// Код доставки (возможно, номер доставочного участка и т.п.)
		/// <para/>
		/// adlsb_Code
		/// </summary>
		public global::System.Int32? adlsb_Code { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор способа доставки
		/// <para/>
		/// dls_ID
		/// </summary>
		public global::System.Int32? dls_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование cпособа доставки (локальное)
		/// <para/>
		/// dlsd_Name
		/// </summary>
		[Required]
		public global::System.String dlsd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModifiedBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModifiedDate
		/// </summary>
		public global::System.DateTime? ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TaxProfileEnable
		/// </summary>
		[Required]
		public global::System.Int32? TaxProfileEnable { get; set; } /*OUTPUT*/
#endregion
	}
	[DocIgnore]
	public class SET_p_ucp_set_Accounts_Request : ICallProcedureModel<SET_p_ucp_set_Accounts_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Accounts_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Accounts_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор Доставочного участка
		/// <para/>
		/// DeliverZone
		/// </summary>
		public global::System.Int32? Adlsb_Code { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Типа доставки
		/// <para/>
		/// DeliveryID
		/// </summary>
		public global::System.Int32? Dls_ID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Код Валюты
		/// <para/>
		/// CurrencyCode
		/// </summary>
		public global::System.String Currency { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор категории Лицевого счета
		/// <para/>
		/// CategoryID
		/// </summary>
		public global::System.Int32? Acat_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор класса Лицевого счета
		/// <para/>
		/// ClassID
		/// </summary>
		public global::System.Int32? Accl_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа платежа лицевого счета
		/// <para/>
		/// PayTypeID
		/// </summary>
		public global::System.Int32? Aptp_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор категории регистрации
		/// <para/>
		/// RegistrCatID
		/// </summary>
		public global::System.Int32? Rgsc_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа лицевого счета (multi-language)
		/// <para/>
		/// TypeID
		/// </summary>
		public global::System.Int32? Actp_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Номер лицевого счета
		/// <para/>
		/// Number
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*INOUT*/
			/// <summary>
		/// Признак анонимности Лицевого счета
		/// <para/>
		/// IsAnonymous
		/// </summary>
		public global::System.Int32? acnt_isAnonymous { get; set; } /*IN*/
			/// <summary>
		/// Код внешней системы - инициатора запроса
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Acnt_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор клиента (узла типа Customers)
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_Accounts_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Acnt_Number); // INOUT
			expressions.Add((m) => m.Acnt_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Accounts_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Accounts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Adlsb_Code, (v) => this.Adlsb_Code = (global::System.Int32?)v) /*--DeliverZone--*/
			{
				Name = "Adlsb_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Adlsb_Code,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Dls_ID, (v) => this.Dls_ID = (global::System.Int32?)v) /*--DeliveryID--*/
			{
				Name = "Dls_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dls_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Currency, (v) => this.Currency = (global::System.String)v) /*--CurrencyCode--*/
			{
				Name = "Currency",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Currency,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Acat_ID, (v) => this.Acat_ID = (global::System.Int32?)v) /*--CategoryID--*/
			{
				Name = "Acat_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acat_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Accl_ID, (v) => this.Accl_ID = (global::System.Int32?)v) /*--ClassID--*/
			{
				Name = "Accl_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accl_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Aptp_ID, (v) => this.Aptp_ID = (global::System.Int32?)v) /*--PayTypeID--*/
			{
				Name = "Aptp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aptp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Rgsc_ID, (v) => this.Rgsc_ID = (global::System.Int32?)v) /*--RegistrCatID--*/
			{
				Name = "Rgsc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rgsc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Actp_ID, (v) => this.Actp_ID = (global::System.Int32?)v) /*--TypeID--*/
			{
				Name = "Actp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Actp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--Number--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.acnt_isAnonymous, (v) => this.acnt_isAnonymous = (global::System.Int32?)v) /*--IsAnonymous--*/
			{
				Name = "acnt_isAnonymous",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.acnt_isAnonymous,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Acnt_ID, (v) => this.Acnt_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Acnt_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Acnt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_Accounts_Response : ICallProcedureModel<SET_p_ucp_set_Accounts_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Accounts_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Accounts_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Номер лицевого счета
		/// <para/>
		/// Number
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Acnt_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_Accounts_Response()
		{
			expressions.Add((m) => m.Acnt_Number); // OUT
			expressions.Add((m) => m.Acnt_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Accounts_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Accounts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--Number--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Acnt_ID, (v) => this.Acnt_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Acnt_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Acnt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Accounts/CustomerAccounts]
	[DocIgnore]
	public class GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request : ICallProcedureModel<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// isExternalSearch
		/// </summary>
		public global::System.Int32? isExternalSearch { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastFM
		/// </summary>
		public global::System.String abn_LastFM { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? acnt_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		public global::System.String acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// actp_ID
		/// </summary>
		public global::System.Int32? actp_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// bll_Number
		/// </summary>
		public global::System.String bll_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// cntr_Name
		/// </summary>
		public global::System.String cntr_Name { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		public global::System.String ext_ExtNum { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageNumber
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
			/// <summary>
		/// Код внешней системы
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_CustomerAccounts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.isExternalSearch, (v) => this.isExternalSearch = (global::System.Int32?)v) /*--isExternalSearch--*/
			{
				Name = "isExternalSearch",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.isExternalSearch,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_LastFM, (v) => this.abn_LastFM = (global::System.String)v) /*--abn_LastFM--*/
			{
				Name = "abn_LastFM",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_LastFM,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_WorkPlace, (v) => this.abn_WorkPlace = (global::System.String)v) /*--abn_WorkPlace--*/
			{
				Name = "abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.acnt_ID, (v) => this.acnt_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "acnt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.acnt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.acnt_Number, (v) => this.acnt_Number = (global::System.String)v) /*--acnt_Number--*/
			{
				Name = "acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.actp_ID, (v) => this.actp_ID = (global::System.Int32?)v) /*--actp_ID--*/
			{
				Name = "actp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.actp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.bll_Number, (v) => this.bll_Number = (global::System.String)v) /*--bll_Number--*/
			{
				Name = "bll_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.bll_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.cntr_Name, (v) => this.cntr_Name = (global::System.String)v) /*--cntr_Name--*/
			{
				Name = "cntr_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ext_ExtNum, (v) => this.ext_ExtNum = (global::System.String)v) /*--ext_ExtNum--*/
			{
				Name = "ext_ExtNum",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ext_ExtNum,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageNumber--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastFM
		/// </summary>
		[Required]
		public global::System.String abn_LastFM { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		[Required]
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		[Required]
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// actpd_Name
		/// </summary>
		[Required]
		public global::System.String actpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cntr_Name
		/// </summary>
		[Required]
		public global::System.String cntr_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// extCount
		/// </summary>
		[Required]
		public global::System.Int32? extCount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isClosed
		/// </summary>
		[Required]
		public global::System.Int32? isClosed { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор результирующей таблицы, например, pkt_ID для Packets...
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsSyncEnable
		/// </summary>
		[Required]
		public global::System.Int32? IsSyncEnable { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер MSISDN
		/// <para/>
		/// msisdn
		/// </summary>
		public global::System.String msisdn { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? ParentID { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [AccountTaxes]
	[DocIgnore]
	public class SET_p_ucp_set_AccountTaxes_Request : ICallProcedureModel<SET_p_ucp_set_AccountTaxes_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_AccountTaxes_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_AccountTaxes_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак включения - выключения
		/// <para/>
		/// Enable
		/// </summary>
		[Required]
		public global::System.Int32? Enable { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор налога
		/// <para/>
		/// TaxesID
		/// </summary>
		[Required]
		public global::System.Int32? Txs_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания действия
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор клиента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Acnt_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор истории налогов лицевого счета
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Actxb_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_AccountTaxes_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Actxb_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_AccountTaxes_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_AccountTaxes";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Enable, (v) => this.Enable = (global::System.Int32?)v) /*--Enable--*/
			{
				Name = "Enable",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Enable,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Txs_ID, (v) => this.Txs_ID = (global::System.Int32?)v) /*--TaxesID--*/
			{
				Name = "Txs_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Txs_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_ID, (v) => this.Acnt_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Acnt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Actxb_ID, (v) => this.Actxb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Actxb_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Actxb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_AccountTaxes_Response : ICallProcedureModel<SET_p_ucp_set_AccountTaxes_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_AccountTaxes_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_AccountTaxes_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор истории налогов лицевого счета
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Actxb_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_AccountTaxes_Response()
		{
			expressions.Add((m) => m.Actxb_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_AccountTaxes_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_AccountTaxes";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Actxb_ID, (v) => this.Actxb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Actxb_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Actxb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Addresses]
	[DocIgnore]
	public class SET_p_ucp_set_TreeNodeAddresses_Request : ICallProcedureModel<SET_p_ucp_set_TreeNodeAddresses_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_TreeNodeAddresses_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_TreeNodeAddresses_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор улицы
		/// <para/>
		/// StreetID
		/// </summary>
		public global::System.Int32? Str_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер почтового индекса (текст)
		/// <para/>
		/// ZipName
		/// </summary>
		public global::System.String Zip_Name { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор дома
		/// <para/>
		/// HouseID
		/// </summary>
		public global::System.Int32? House_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер квартиры
		/// <para/>
		/// Appartment
		/// </summary>
		public global::System.String Appartment { get; set; } /*IN*/
			/// <summary>
		/// Название населеннго пункта
		/// <para/>
		/// CityName
		/// </summary>
		public global::System.String Cit_Name { get; set; } /*IN*/
			/// <summary>
		/// Контактный Email
		/// <para/>
		/// Email
		/// </summary>
		public global::System.String ContEMail { get; set; } /*IN*/
			/// <summary>
		/// Контактный Номер факса
		/// <para/>
		/// Fax
		/// </summary>
		public global::System.String ContFax { get; set; } /*IN*/
			/// <summary>
		/// Контактный Номер телефона
		/// <para/>
		/// Phone
		/// </summary>
		public global::System.String ContPhone { get; set; } /*IN*/
			/// <summary>
		/// Корпус
		/// <para/>
		/// Corpus
		/// </summary>
		public global::System.String Corpus_Name { get; set; } /*IN*/
			/// <summary>
		/// Название страны
		/// <para/>
		/// CountryName
		/// </summary>
		public global::System.String Cou_Name { get; set; } /*IN*/
			/// <summary>
		/// Название района
		/// <para/>
		/// DistictName
		/// </summary>
		public global::System.String Dstr_Name { get; set; } /*IN*/
			/// <summary>
		/// Название дома
		/// <para/>
		/// HouseName
		/// </summary>
		public global::System.String House_Name { get; set; } /*IN*/
			/// <summary>
		/// Название области
		/// <para/>
		/// ProvinceName
		/// </summary>
		public global::System.String Prov_Name { get; set; } /*IN*/
			/// <summary>
		/// Название улицы
		/// <para/>
		/// StreetName
		/// </summary>
		public global::System.String Str_Name { get; set; } /*IN*/
			/// <summary>
		/// Адресная константа для печати, например в Налоговых накладных
		/// <para/>
		/// TextConst
		/// </summary>
		public global::System.String TextConst { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор почтового индекса
		/// <para/>
		/// ZipID
		/// </summary>
		public global::System.Int32? Zip_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор населенного пункта
		/// <para/>
		/// CityID
		/// </summary>
		public global::System.Int32? Cit_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор области
		/// <para/>
		/// ProvinceID
		/// </summary>
		public global::System.Int32? Prov_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор района
		/// <para/>
		/// DistrictID
		/// </summary>
		public global::System.Int32? Dstr_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор страны
		/// <para/>
		/// CountyID
		/// </summary>
		public global::System.Int32? Cou_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа адреса
		/// <para/>
		/// AddressTypeID
		/// </summary>
		[Required]
		public global::System.Int32? Adrt_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа населенного пункта
		/// <para/>
		/// CityTypeID
		/// </summary>
		public global::System.Int32? Cttp_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа улицы
		/// <para/>
		/// StreetTypeID
		/// </summary>
		public global::System.Int32? Strt_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа адреса
		/// <para/>
		/// AddressFormat
		/// </summary>
		public global::System.Int32? Adf_ID { get; set; } /*IN*/
			/// <summary>
		/// Код внешней системы - инициатора запроса
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор истории адреса абонента
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Aadb_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор вышестоящего узла дерева
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_TreeNodeAddresses_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Aadb_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_TreeNodeAddresses_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_TreeNodeAddresses";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Str_ID, (v) => this.Str_ID = (global::System.Int32?)v) /*--StreetID--*/
			{
				Name = "Str_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Str_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Zip_Name, (v) => this.Zip_Name = (global::System.String)v) /*--ZipName--*/
			{
				Name = "Zip_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Zip_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.House_ID, (v) => this.House_ID = (global::System.Int32?)v) /*--HouseID--*/
			{
				Name = "House_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.House_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Appartment, (v) => this.Appartment = (global::System.String)v) /*--Appartment--*/
			{
				Name = "Appartment",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Appartment,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cit_Name, (v) => this.Cit_Name = (global::System.String)v) /*--CityName--*/
			{
				Name = "Cit_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cit_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ContEMail, (v) => this.ContEMail = (global::System.String)v) /*--Email--*/
			{
				Name = "ContEMail",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ContEMail,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ContFax, (v) => this.ContFax = (global::System.String)v) /*--Fax--*/
			{
				Name = "ContFax",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ContFax,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ContPhone, (v) => this.ContPhone = (global::System.String)v) /*--Phone--*/
			{
				Name = "ContPhone",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ContPhone,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Corpus_Name, (v) => this.Corpus_Name = (global::System.String)v) /*--Corpus--*/
			{
				Name = "Corpus_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Corpus_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cou_Name, (v) => this.Cou_Name = (global::System.String)v) /*--CountryName--*/
			{
				Name = "Cou_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cou_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Dstr_Name, (v) => this.Dstr_Name = (global::System.String)v) /*--DistictName--*/
			{
				Name = "Dstr_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dstr_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.House_Name, (v) => this.House_Name = (global::System.String)v) /*--HouseName--*/
			{
				Name = "House_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.House_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Prov_Name, (v) => this.Prov_Name = (global::System.String)v) /*--ProvinceName--*/
			{
				Name = "Prov_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Prov_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Str_Name, (v) => this.Str_Name = (global::System.String)v) /*--StreetName--*/
			{
				Name = "Str_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Str_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.TextConst, (v) => this.TextConst = (global::System.String)v) /*--TextConst--*/
			{
				Name = "TextConst",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TextConst,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Zip_ID, (v) => this.Zip_ID = (global::System.Int32?)v) /*--ZipID--*/
			{
				Name = "Zip_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Zip_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cit_ID, (v) => this.Cit_ID = (global::System.Int32?)v) /*--CityID--*/
			{
				Name = "Cit_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cit_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Prov_ID, (v) => this.Prov_ID = (global::System.Int32?)v) /*--ProvinceID--*/
			{
				Name = "Prov_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Prov_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Dstr_ID, (v) => this.Dstr_ID = (global::System.Int32?)v) /*--DistrictID--*/
			{
				Name = "Dstr_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dstr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cou_ID, (v) => this.Cou_ID = (global::System.Int32?)v) /*--CountyID--*/
			{
				Name = "Cou_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cou_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Adrt_ID, (v) => this.Adrt_ID = (global::System.Int32?)v) /*--AddressTypeID--*/
			{
				Name = "Adrt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Adrt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cttp_ID, (v) => this.Cttp_ID = (global::System.Int32?)v) /*--CityTypeID--*/
			{
				Name = "Cttp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cttp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Strt_ID, (v) => this.Strt_ID = (global::System.Int32?)v) /*--StreetTypeID--*/
			{
				Name = "Strt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Strt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Adf_ID, (v) => this.Adf_ID = (global::System.Int32?)v) /*--AddressFormat--*/
			{
				Name = "Adf_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Adf_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Aadb_ID, (v) => this.Aadb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Aadb_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Aadb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_TreeNodeAddresses_Response : ICallProcedureModel<SET_p_ucp_set_TreeNodeAddresses_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_TreeNodeAddresses_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_TreeNodeAddresses_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор истории адреса абонента
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Aadb_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_TreeNodeAddresses_Response()
		{
			expressions.Add((m) => m.Aadb_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_TreeNodeAddresses_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_TreeNodeAddresses";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Aadb_ID, (v) => this.Aadb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Aadb_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Aadb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Addresses/Sync]
	[DocIgnore]
	public class ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request : ICallProcedureModel<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// DateEndSync
		/// </summary>
		public global::System.DateTime? DateEndSync { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь, изменивший запись
		/// <para/>
		/// wev_User
		/// </summary>
		public global::System.String wev_User { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "sp_RunSyncAddressDict";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.DateEndSync, (v) => this.DateEndSync = (global::System.DateTime?)v) /*--DateEndSync--*/
			{
				Name = "DateEndSync",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEndSync,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.wev_User, (v) => this.wev_User = (global::System.String)v) /*--wev_User--*/
			{
				Name = "wev_User",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.wev_User,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response : ICallProcedureModel<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "sp_RunSyncAddressDict";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Adjustments]
	[DocIgnore]
	public class SET_p_ucp_set_AccountAdjustments_Request : ICallProcedureModel<SET_p_ucp_set_AccountAdjustments_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_AccountAdjustments_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_AccountAdjustments_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор другого лицевого счета-назначения для корректировки баланса С... НА... (Target Customer ID)
		/// <para/>
		/// TransferTo
		/// </summary>
		public global::System.Int32? Aadj_Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Сумма корректировки, включая налоги
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? Aadj_Amount { get; set; } /*IN*/
			/// <summary>
		/// Признак аннулирования корректировки (1 - да, 0 - нет)
		/// <para/>
		/// Annul
		/// </summary>
		[Required]
		public global::System.Int32? Aadj_Annul { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор биллингового счета для корректировки 
		/// <para/>
		/// BillID
		/// </summary>
		public global::System.Int64? Aadj_bll_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата корректировки (по умолчанию - текущая дата)
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? Aadj_Date { get; set; } /*IN*/
			/// <summary>
		/// Дата документа-основания для корректировки
		/// <para/>
		/// DocDate
		/// </summary>
		public global::System.DateTime? Aadj_DocDate { get; set; } /*IN*/
			/// <summary>
		/// Номер документа-основания для корректировки
		/// <para/>
		/// DocNum
		/// </summary>
		public global::System.String Aadj_DocNum { get; set; } /*IN*/
			/// <summary>
		/// Комментарий для корректировки
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Aadj_Remark { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор причины корректировки
		/// <para/>
		/// ReasonID
		/// </summary>
		public global::System.Int32? Aar_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа корректировки
		/// <para/>
		/// TypeID
		/// </summary>
		public global::System.Int32? Aat_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор платежа для корректировки платежа клиента
		/// <para/>
		/// PaymentID
		/// </summary>
		public global::System.Int64? Cpay_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// TransferReasonID
		/// </summary>
		public global::System.Int32? Aadj_Aar_ID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор начисления для корректировки начисления
		/// <para/>
		/// ChargeID
		/// </summary>
		public global::System.Int64? Sech_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор детали счета для корректировки начисления
		/// <para/>
		/// DetailID
		/// </summary>
		public global::System.Int32? Srg_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор корректировки
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Aadj_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Внешний идентификатор
		/// <para/>
		/// aadj_ExternalID
		/// </summary>
		public global::System.Int32? aadj_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор динамического типа
		/// <para/>
		/// dnm_id
		/// </summary>
		public global::System.Int32? dnm_id { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор скидки
		/// <para/>
		/// dsc_id
		/// </summary>
		public global::System.Int32? dsc_id { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор примененного порога скидки. Ссылка на DiscountValues
		/// <para/>
		/// dsv_id
		/// </summary>
		public global::System.Int32? dsv_id { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Extentions (Номера MSISDN)
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? Ext_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// NeedCheckPermission
		/// </summary>
		public global::System.Int32? NeedCheckPermission { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор устройства
		/// <para/>
		/// NumberATS
		/// </summary>
		public global::System.Int32? NumberATS { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор пакета (биллинговый цикл)
		/// <para/>
		/// pkt_ID
		/// </summary>
		public global::System.Int32? pkt_id { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор представления
		/// <para/>
		/// rpr_id
		/// </summary>
		public global::System.Int32? rpr_id { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор технической услуги ""выписка счета
		/// <para/>
		/// ServiceID
		/// </summary>
		public global::System.Int32? Srv_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор SourceString (ETLCDR) 
		/// <para/>
		/// ss_id
		/// </summary>
		public global::System.Int64? ss_id { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Subscriber_ID
		/// </summary>
		public global::System.Int32? Subscriber_ID { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_AccountAdjustments_Request()
		{
			expressions.Add((m) => m.Aadj_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_AccountAdjustments_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_AccountAdjustments";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Aadj_Abn_ID, (v) => this.Aadj_Abn_ID = (global::System.Int32?)v) /*--TransferTo--*/
			{
				Name = "Aadj_Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aadj_Amount, (v) => this.Aadj_Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Aadj_Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Aadj_Annul, (v) => this.Aadj_Annul = (global::System.Int32?)v) /*--Annul--*/
			{
				Name = "Aadj_Annul",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_Annul,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aadj_bll_ID, (v) => this.Aadj_bll_ID = (global::System.Int64?)v) /*--BillID--*/
			{
				Name = "Aadj_bll_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_bll_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.Aadj_Date, (v) => this.Aadj_Date = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "Aadj_Date",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_Date,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Aadj_DocDate, (v) => this.Aadj_DocDate = (global::System.DateTime?)v) /*--DocDate--*/
			{
				Name = "Aadj_DocDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_DocDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Aadj_DocNum, (v) => this.Aadj_DocNum = (global::System.String)v) /*--DocNum--*/
			{
				Name = "Aadj_DocNum",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_DocNum,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Aadj_Remark, (v) => this.Aadj_Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Aadj_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Aar_ID, (v) => this.Aar_ID = (global::System.Int32?)v) /*--ReasonID--*/
			{
				Name = "Aar_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aar_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aat_ID, (v) => this.Aat_ID = (global::System.Int32?)v) /*--TypeID--*/
			{
				Name = "Aat_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aat_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpay_ID, (v) => this.Cpay_ID = (global::System.Int64?)v) /*--PaymentID--*/
			{
				Name = "Cpay_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpay_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aadj_Aar_ID, (v) => this.Aadj_Aar_ID = (global::System.Int32?)v) /*--TransferReasonID--*/
			{
				Name = "Aadj_Aar_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aadj_Aar_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sech_ID, (v) => this.Sech_ID = (global::System.Int64?)v) /*--ChargeID--*/
			{
				Name = "Sech_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sech_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.Srg_ID, (v) => this.Srg_ID = (global::System.Int32?)v) /*--DetailID--*/
			{
				Name = "Srg_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srg_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aadj_ID, (v) => this.Aadj_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Aadj_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Aadj_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aadj_ExternalID, (v) => this.aadj_ExternalID = (global::System.Int32?)v) /*--aadj_ExternalID--*/
			{
				Name = "aadj_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aadj_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dnm_id, (v) => this.dnm_id = (global::System.Int32?)v) /*--dnm_id--*/
			{
				Name = "dnm_id",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dnm_id,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dsc_id, (v) => this.dsc_id = (global::System.Int32?)v) /*--dsc_id--*/
			{
				Name = "dsc_id",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dsc_id,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dsv_id, (v) => this.dsv_id = (global::System.Int32?)v) /*--dsv_id--*/
			{
				Name = "dsv_id",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dsv_id,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ext_ID, (v) => this.Ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "Ext_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.NeedCheckPermission, (v) => this.NeedCheckPermission = (global::System.Int32?)v) /*--NeedCheckPermission--*/
			{
				Name = "NeedCheckPermission",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.NeedCheckPermission,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.NumberATS, (v) => this.NumberATS = (global::System.Int32?)v) /*--NumberATS--*/
			{
				Name = "NumberATS",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.NumberATS,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.pkt_id, (v) => this.pkt_id = (global::System.Int32?)v) /*--pkt_ID--*/
			{
				Name = "pkt_id",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.pkt_id,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.rpr_id, (v) => this.rpr_id = (global::System.Int32?)v) /*--rpr_id--*/
			{
				Name = "rpr_id",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.rpr_id,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srv_ID, (v) => this.Srv_ID = (global::System.Int32?)v) /*--ServiceID--*/
			{
				Name = "Srv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ss_id, (v) => this.ss_id = (global::System.Int64?)v) /*--ss_id--*/
			{
				Name = "ss_id",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ss_id,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.Subscriber_ID, (v) => this.Subscriber_ID = (global::System.Int32?)v) /*--Subscriber_ID--*/
			{
				Name = "Subscriber_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Subscriber_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_AccountAdjustments_Response : ICallProcedureModel<SET_p_ucp_set_AccountAdjustments_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_AccountAdjustments_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_AccountAdjustments_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Уникальный идентификатор корректировки
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Aadj_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_AccountAdjustments_Response()
		{
			expressions.Add((m) => m.Aadj_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_AccountAdjustments_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_AccountAdjustments";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Aadj_ID, (v) => this.Aadj_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Aadj_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Aadj_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Agreements]
	[DocIgnore]
	public class SET_p_ucp_set_SubscriberAgreements_Request : ICallProcedureModel<SET_p_ucp_set_SubscriberAgreements_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_SubscriberAgreements_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_SubscriberAgreements_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Эффективная дата для изменения подписки на Тарифный План, используется как DateSet для новых изменений подписки - смены Тарифного плана
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Дополнительные параметры для provisioning (для каждой услуги отдельно)
		/// <para/>
		/// TasksJsonData
		/// </summary>
		public global::System.String TasksJsonData { get; set; } /*IN*/
			/// <summary>
		/// Признак проверки достаточности баланса
		/// <para/>
		/// IsCheckBallance
		/// </summary>
		public global::System.Int32? IsCheckBallance { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор шаблона
		/// <para/>
		/// TemplateIDs
		/// </summary>
		public global::System.Int32? TemplateIDs { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор представления (техническая связка Agreements)
		/// <para/>
		/// RepresentationID
		/// </summary>
		public global::System.Int32? Rpr_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Зарезервировано для Response
		/// <para/>
		/// Entities
		/// </summary>
		public global::System.String Entities { get; set; } /*INOUT*/
			/// <summary>
		/// Дата окончания действия
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор тарифного плана
		/// <para/>
		/// PlanGroupID
		/// </summary>
		public global::System.Int32? Grt_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор соглашения
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Agr_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Сценарий подключения пакетов
		/// <para/>
		/// Activate
		/// </summary>
		public global::System.String Activate { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Agr_ID_Old
		/// </summary>
		public global::System.Int32? Agr_ID_Old { get; set; } /*IN*/
			/// <summary>
		/// Сценарий отключения пакетов
		/// <para/>
		/// Cancel
		/// </summary>
		public global::System.String Cancel { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Grt_ID_New
		/// </summary>
		public global::System.Int32? Grt_ID_New { get; set; } /*IN*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// Mode
		/// </summary>
		public global::System.String Mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Rtb_IDs
		/// </summary>
		public global::System.String Rtb_IDs { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Services
		/// </summary>
		public global::System.String Services { get; set; } /*IN*/
			/// <summary>
		/// Признак первичной активации или изменения существующей подписки
		/// <para/>
		/// TariffBegin
		/// </summary>
		public global::System.Int32? TariffBegin { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_SubscriberAgreements_Request()
		{
			expressions.Add((m) => m.Entities); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Agr_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_SubscriberAgreements_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_SubscriberAgreements";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.TasksJsonData, (v) => this.TasksJsonData = (global::System.String)v) /*--TasksJsonData--*/
			{
				Name = "TasksJsonData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TasksJsonData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsCheckBallance, (v) => this.IsCheckBallance = (global::System.Int32?)v) /*--IsCheckBallance--*/
			{
				Name = "IsCheckBallance",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsCheckBallance,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.TemplateIDs, (v) => this.TemplateIDs = (global::System.Int32?)v) /*--TemplateIDs--*/
			{
				Name = "TemplateIDs",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TemplateIDs,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Rpr_ID, (v) => this.Rpr_ID = (global::System.Int32?)v) /*--RepresentationID--*/
			{
				Name = "Rpr_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rpr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Entities, (v) => this.Entities = (global::System.String)v) /*--Entities--*/
			{
				Name = "Entities",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Entities,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.Grt_ID, (v) => this.Grt_ID = (global::System.Int32?)v) /*--PlanGroupID--*/
			{
				Name = "Grt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Grt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Agr_ID, (v) => this.Agr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Agr_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Agr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Activate, (v) => this.Activate = (global::System.String)v) /*--Activate--*/
			{
				Name = "Activate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Activate,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Agr_ID_Old, (v) => this.Agr_ID_Old = (global::System.Int32?)v) /*--Agr_ID_Old--*/
			{
				Name = "Agr_ID_Old",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Agr_ID_Old,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cancel, (v) => this.Cancel = (global::System.String)v) /*--Cancel--*/
			{
				Name = "Cancel",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cancel,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Grt_ID_New, (v) => this.Grt_ID_New = (global::System.Int32?)v) /*--Grt_ID_New--*/
			{
				Name = "Grt_ID_New",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Grt_ID_New,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Mode, (v) => this.Mode = (global::System.String)v) /*--Mode--*/
			{
				Name = "Mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Mode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Rtb_IDs, (v) => this.Rtb_IDs = (global::System.String)v) /*--Rtb_IDs--*/
			{
				Name = "Rtb_IDs",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rtb_IDs,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Services, (v) => this.Services = (global::System.String)v) /*--Services--*/
			{
				Name = "Services",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Services,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.TariffBegin, (v) => this.TariffBegin = (global::System.Int32?)v) /*--TariffBegin--*/
			{
				Name = "TariffBegin",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TariffBegin,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_SubscriberAgreements_Response : ICallProcedureModel<SET_p_ucp_set_SubscriberAgreements_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_SubscriberAgreements_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_SubscriberAgreements_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор соглашения
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Agr_ID { get; set; } /*OUT*/
			/// <summary>
		/// Список сущностей, созданных в результате выполнения операции
		/// <para/>
		/// Entities
		/// </summary>
		public global::System.String Entities { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_SubscriberAgreements_Response()
		{
			expressions.Add((m) => m.Agr_ID); // OUT
			expressions.Add((m) => m.Entities); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_SubscriberAgreements_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_SubscriberAgreements";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Agr_ID, (v) => this.Agr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Agr_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Agr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Entities, (v) => this.Entities = (global::System.String)v) /*--Entities--*/
			{
				Name = "Entities",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Entities,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Agreements/ChangeTariffs]
	[DocIgnore]
	public class ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request : ICallProcedureModel<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Сценарий подключения пакетов
		/// <para/>
		/// Activate
		/// </summary>
		public global::System.String Activate { get; set; } /*IN*/
			/// <summary>
		/// Сценарий отключения пакетов
		/// <para/>
		/// Cancel
		/// </summary>
		public global::System.String Cancel { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания подписки новых пакетов и услуг
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата смены подписки старых пакетов на новые пакеты
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Дата начала подписок при подключении акционных пакетов ""задним"" числом
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Зарезервировано 
		/// <para/>
		/// Entities
		/// </summary>
		public global::System.String Entities { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Признак проверки баланса при подключении Пакетов
		/// <para/>
		/// IsCheckBallance
		/// </summary>
		public global::System.Int32? IsCheckBallance { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// Mode
		/// </summary>
		public global::System.String Mode { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор соглашения с абонентом
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Agr_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор Тарифного Плана
		/// <para/>
		/// PlanGroupID
		/// </summary>
		public global::System.Int32? Grt_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Признак применения тарифных условий
		/// <para/>
		/// TariffBegin
		/// </summary>
		public global::System.Int32? TariffBegin { get; set; } /*IN*/
			/// <summary>
		/// Дополнительные параметры провижилнинга услуг
		/// <para/>
		/// TasksJsonData
		/// </summary>
		public global::System.String TasksJsonData { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request()
		{
			expressions.Add((m) => m.Entities); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Agr_ID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_SubscriberAgreements";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Activate, (v) => this.Activate = (global::System.String)v) /*--Activate--*/
			{
				Name = "Activate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Activate,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cancel, (v) => this.Cancel = (global::System.String)v) /*--Cancel--*/
			{
				Name = "Cancel",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cancel,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Entities, (v) => this.Entities = (global::System.String)v) /*--Entities--*/
			{
				Name = "Entities",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Entities,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsCheckBallance, (v) => this.IsCheckBallance = (global::System.Int32?)v) /*--IsCheckBallance--*/
			{
				Name = "IsCheckBallance",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsCheckBallance,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Mode, (v) => this.Mode = (global::System.String)v) /*--Mode--*/
			{
				Name = "Mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Mode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Agr_ID, (v) => this.Agr_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Agr_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Agr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Grt_ID, (v) => this.Grt_ID = (global::System.Int32?)v) /*--PlanGroupID--*/
			{
				Name = "Grt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Grt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.TariffBegin, (v) => this.TariffBegin = (global::System.Int32?)v) /*--TariffBegin--*/
			{
				Name = "TariffBegin",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TariffBegin,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.TasksJsonData, (v) => this.TasksJsonData = (global::System.String)v) /*--TasksJsonData--*/
			{
				Name = "TasksJsonData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TasksJsonData,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response : ICallProcedureModel<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Список сущностей, созданных в результате выполнения операции
		/// <para/>
		/// Entities
		/// </summary>
		public global::System.String Entities { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор соглашения с абонентом
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Agr_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response()
		{
			expressions.Add((m) => m.Entities); // OUT
			expressions.Add((m) => m.Agr_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_SubscriberAgreements";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Entities, (v) => this.Entities = (global::System.String)v) /*--Entities--*/
			{
				Name = "Entities",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Entities,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Agr_ID, (v) => this.Agr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Agr_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Agr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Associations]
	[DocIgnore]
	public class GET_p_ucp_get_Associations_Request : ICallProcedureModel<GET_p_ucp_get_Associations_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_Associations_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_Associations_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// mode
		/// </summary>
		public global::System.Int32? mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Ntw_ID
		/// </summary>
		public global::System.Int32? Ntw_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageNumber
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
			/// <summary>
		/// Тип профиля
		/// <para/>
		/// ProfileType
		/// </summary>
		public global::System.Int32? ProfileType { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Rgsc_ID
		/// </summary>
		public global::System.Int32? Rgsc_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ShowBalances
		/// </summary>
		public global::System.Int32? ShowBalances { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ShowEntities
		/// </summary>
		public global::System.String ShowEntities { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortColumn
		/// </summary>
		public global::System.String SortColumn { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortDirection
		/// </summary>
		public global::System.String SortDirection { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Srv_ID
		/// </summary>
		public global::System.Int32? Srv_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Srv_Name
		/// </summary>
		public global::System.String Srv_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Sst_ID
		/// </summary>
		public global::System.Int32? Sst_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_Code
		/// </summary>
		public global::System.String tnst_Code { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		public global::System.Int32? trf_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// LastModifiedDate
		/// </summary>
		public global::System.DateTime? LastModifiedDate { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Cntr_Name
		/// </summary>
		public global::System.String Cntr_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		public global::System.String abn_Employee_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		public global::System.Int32? abn_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Ассоциации или корня 
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		public global::System.Int32? abn_IsExistAD { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Acat_ID
		/// </summary>
		public global::System.Int32? Acat_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Accl_ID
		/// </summary>
		public global::System.Int32? Accl_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Acnt_Number
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actp_ID
		/// </summary>
		public global::System.Int32? Actp_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Adlsb_Code
		/// </summary>
		public global::System.Int32? Adlsb_Code { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Aptp_ID
		/// </summary>
		public global::System.Int32? Aptp_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NameAuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Bac_Number
		/// </summary>
		public global::System.String Bac_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// bll_Number
		/// </summary>
		public global::System.String bll_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossLastName
		/// </summary>
		public global::System.String BossLastName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_ID
		/// </summary>
		public global::System.Int32? com_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		public global::System.Int32? dep_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Dls_ID
		/// </summary>
		public global::System.Int32? Dls_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		public global::System.String ext_ExtNum { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Format
		/// </summary>
		public global::System.String Format { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		public global::System.Int32? grp_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFieldsName
		/// </summary>
		public global::System.String jsonFieldsName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFilter
		/// </summary>
		public global::System.String jsonFilter { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFilterContain
		/// </summary>
		public global::System.Int32? jsonFilterContain { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Lng_ID
		/// </summary>
		public global::System.Int32? Lng_ID { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_Associations_Request()
		{
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_Associations_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_Associations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.mode, (v) => this.mode = (global::System.Int32?)v) /*--mode--*/
			{
				Name = "mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.mode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ntw_ID, (v) => this.Ntw_ID = (global::System.Int32?)v) /*--Ntw_ID--*/
			{
				Name = "Ntw_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ntw_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageNumber--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ProfileType, (v) => this.ProfileType = (global::System.Int32?)v) /*--ProfileType--*/
			{
				Name = "ProfileType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ProfileType,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Rgsc_ID, (v) => this.Rgsc_ID = (global::System.Int32?)v) /*--Rgsc_ID--*/
			{
				Name = "Rgsc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rgsc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ShowBalances, (v) => this.ShowBalances = (global::System.Int32?)v) /*--ShowBalances--*/
			{
				Name = "ShowBalances",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ShowBalances,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ShowEntities, (v) => this.ShowEntities = (global::System.String)v) /*--ShowEntities--*/
			{
				Name = "ShowEntities",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ShowEntities,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SortColumn, (v) => this.SortColumn = (global::System.String)v) /*--SortColumn--*/
			{
				Name = "SortColumn",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortColumn,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SortDirection, (v) => this.SortDirection = (global::System.String)v) /*--SortDirection--*/
			{
				Name = "SortDirection",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortDirection,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Srv_ID, (v) => this.Srv_ID = (global::System.Int32?)v) /*--Srv_ID--*/
			{
				Name = "Srv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srv_Name, (v) => this.Srv_Name = (global::System.String)v) /*--Srv_Name--*/
			{
				Name = "Srv_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sst_ID, (v) => this.Sst_ID = (global::System.Int32?)v) /*--Sst_ID--*/
			{
				Name = "Sst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.tnst_Code, (v) => this.tnst_Code = (global::System.String)v) /*--tnst_Code--*/
			{
				Name = "tnst_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.tnst_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.trf_ID, (v) => this.trf_ID = (global::System.Int32?)v) /*--trf_ID--*/
			{
				Name = "trf_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.trf_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.LastModifiedDate, (v) => this.LastModifiedDate = (global::System.DateTime?)v) /*--LastModifiedDate--*/
			{
				Name = "LastModifiedDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.LastModifiedDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Cntr_Name, (v) => this.Cntr_Name = (global::System.String)v) /*--Cntr_Name--*/
			{
				Name = "Cntr_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cntr_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_Employee_ID, (v) => this.abn_Employee_ID = (global::System.String)v) /*--abn_Employee_ID--*/
			{
				Name = "abn_Employee_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_Employee_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ExternalID, (v) => this.abn_ExternalID = (global::System.Int32?)v) /*--abn_ExternalID--*/
			{
				Name = "abn_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_ID_Boss, (v) => this.abn_ID_Boss = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID_Boss",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID_Boss,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_IsExistAD, (v) => this.abn_IsExistAD = (global::System.Int32?)v) /*--abn_IsExistAD--*/
			{
				Name = "abn_IsExistAD",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_IsExistAD,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_LastName, (v) => this.abn_LastName = (global::System.String)v) /*--abn_LastName--*/
			{
				Name = "abn_LastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_LastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_WorkPlace, (v) => this.abn_WorkPlace = (global::System.String)v) /*--abn_WorkPlace--*/
			{
				Name = "abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Acat_ID, (v) => this.Acat_ID = (global::System.Int32?)v) /*--Acat_ID--*/
			{
				Name = "Acat_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acat_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Accl_ID, (v) => this.Accl_ID = (global::System.Int32?)v) /*--Accl_ID--*/
			{
				Name = "Accl_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accl_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--Acnt_Number--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Actp_ID, (v) => this.Actp_ID = (global::System.Int32?)v) /*--Actp_ID--*/
			{
				Name = "Actp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Actp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Adlsb_Code, (v) => this.Adlsb_Code = (global::System.Int32?)v) /*--Adlsb_Code--*/
			{
				Name = "Adlsb_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Adlsb_Code,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aptp_ID, (v) => this.Aptp_ID = (global::System.Int32?)v) /*--Aptp_ID--*/
			{
				Name = "Aptp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aptp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.aut_NameAuthCode, (v) => this.aut_NameAuthCode = (global::System.String)v) /*--aut_NameAuthCode--*/
			{
				Name = "aut_NameAuthCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bac_Number, (v) => this.Bac_Number = (global::System.String)v) /*--Bac_Number--*/
			{
				Name = "Bac_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.bll_Number, (v) => this.bll_Number = (global::System.String)v) /*--bll_Number--*/
			{
				Name = "bll_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.bll_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.BossLastName, (v) => this.BossLastName = (global::System.String)v) /*--BossLastName--*/
			{
				Name = "BossLastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.BossLastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.com_ID, (v) => this.com_ID = (global::System.Int32?)v) /*--com_ID--*/
			{
				Name = "com_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.com_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dep_ID, (v) => this.dep_ID = (global::System.Int32?)v) /*--dep_ID--*/
			{
				Name = "dep_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dep_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Dls_ID, (v) => this.Dls_ID = (global::System.Int32?)v) /*--Dls_ID--*/
			{
				Name = "Dls_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dls_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ext_ExtNum, (v) => this.ext_ExtNum = (global::System.String)v) /*--ext_ExtNum--*/
			{
				Name = "ext_ExtNum",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ext_ExtNum,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Format, (v) => this.Format = (global::System.String)v) /*--Format--*/
			{
				Name = "Format",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Format,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.grp_ID, (v) => this.grp_ID = (global::System.Int32?)v) /*--grp_ID--*/
			{
				Name = "grp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.grp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--CacheControlDate--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.jsonFieldsName, (v) => this.jsonFieldsName = (global::System.String)v) /*--jsonFieldsName--*/
			{
				Name = "jsonFieldsName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFieldsName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.jsonFilter, (v) => this.jsonFilter = (global::System.String)v) /*--jsonFilter--*/
			{
				Name = "jsonFilter",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFilter,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.jsonFilterContain, (v) => this.jsonFilterContain = (global::System.Int32?)v) /*--jsonFilterContain--*/
			{
				Name = "jsonFilterContain",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFilterContain,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lng_ID, (v) => this.Lng_ID = (global::System.Int32?)v) /*--Lng_ID--*/
			{
				Name = "Lng_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lng_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_Associations_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_Associations_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		public global::System.String ext_ExtNum { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? ext_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		public global::System.Int32? grp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// AbonentFullName
		/// </summary>
		[Required]
		public global::System.String AbonentFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_IsPersonal
		/// </summary>
		[Required]
		public global::System.Int32? acnt_IsPersonal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number_Personal
		/// </summary>
		[Required]
		public global::System.String acnt_Number_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// actp_ID
		/// </summary>
		public global::System.Int32? actp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// actpd_Name
		/// </summary>
		[Required]
		public global::System.String actpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name_Personal
		/// </summary>
		[Required]
		public global::System.String Actpd_Name_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? aut_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NameAuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NumberAts
		/// </summary>
		[Required]
		public global::System.Int32? aut_NumberAts { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossFullName
		/// </summary>
		[Required]
		public global::System.String BossFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cntr_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? cntr_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cntr_Name
		/// </summary>
		public global::System.String cntr_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_Id
		/// </summary>
		public global::System.Int32? com_Id { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		public global::System.Int32? dep_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_Name
		/// </summary>
		[Required]
		public global::System.String grp_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditAllow
		/// </summary>
		[Required]
		public global::System.Int32? isEditAllow { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditWorkPlace
		/// </summary>
		[Required]
		public global::System.Int32? isEditWorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// lng_ID
		/// </summary>
		public global::System.Int32? lng_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// loc_Name
		/// </summary>
		[Required]
		public global::System.String loc_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Location_ID
		/// </summary>
		[Required]
		public global::System.Int32? Location_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ntw_ID
		/// </summary>
		public global::System.Int32? ntw_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pbx_networkName
		/// </summary>
		[Required]
		public global::System.String pbx_networkName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ProfileType
		/// </summary>
		public global::System.Int32? ProfileType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// rptURL
		/// </summary>
		[Required]
		public global::System.String rptURL { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// SubsCount
		/// </summary>
		[Required]
		public global::System.Int32? SubsCount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_AccountMandatory
		/// </summary>
		[Required]
		public global::System.Int32? tnt_AccountMandatory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TreeNodeType
		/// </summary>
		[Required]
		public global::System.String TreeNodeType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		public global::System.Int32? trf_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abn_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_CreateDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_CreateDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abn_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employe_Export_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employe_Export_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		public global::System.String abn_Employee_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		public global::System.Int32? abn_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_FirstName
		/// </summary>
		[Required]
		public global::System.String abn_FirstName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Guid
		/// </summary>
		[Required]
		public global::System.Guid? abn_Guid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_HasNotEmptyPrepaid
		/// </summary>
		[Required]
		public global::System.Int32? abn_HasNotEmptyPrepaid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		public global::System.Int32? abn_IsExistAD { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsGuest
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsGuest { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Login
		/// </summary>
		[Required]
		public global::System.String abn_Login { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_MiddleName
		/// </summary>
		[Required]
		public global::System.String abn_MiddleName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedBy
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedFrom
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedFrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Left
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Left { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Right
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Right { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Password
		/// </summary>
		[Required]
		public global::System.String abn_Password { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_PositionCode
		/// </summary>
		[Required]
		public global::System.String abn_PositionCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ShowPhoneDirectory
		/// </summary>
		[Required]
		public global::System.Int32? abn_ShowPhoneDirectory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_id_boss
		/// </summary>
		[Required]
		public global::System.Int32? dep_id_boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_Name_boss
		/// </summary>
		[Required]
		public global::System.String dep_Name_boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isRefusalChangeName
		/// </summary>
		[Required]
		public global::System.Int32? isRefusalChangeName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// max_ModDate
		/// </summary>
		public global::System.DateTime? max_ModDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор причины версии
		/// <para/>
		/// vrr_ID
		/// </summary>
		[Required]
		public global::System.Int32? vrr_ID { get; set; } /*OUTPUT*/
#endregion
	}
	[DocIgnore]
	public class SET_p_ucp_set_Associations_Request : ICallProcedureModel<SET_p_ucp_set_Associations_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Associations_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Associations_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Краткое название для поиска
		/// <para/>
		/// Customer_SearchName
		/// </summary>
		public global::System.String Abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// Дата с которой начинается отсчёт стажа
		/// <para/>
		/// CustomerDate
		/// </summary>
		public global::System.DateTime? Abn_Date { get; set; } /*IN*/
			/// <summary>
		/// Язык общения с клиентом
		/// <para/>
		/// CustomerLanguageId
		/// </summary>
		public global::System.Int32? Lng_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Признак ""создание узла дерева не завершено
		/// <para/>
		/// IsCreatedWithTariffication
		/// </summary>
		public global::System.Int32? Abn_IsCreatedWithTariffication { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор для экспорта
		/// <para/>
		/// Export_ID
		/// </summary>
		public global::System.String Abn_Employe_Export_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор биллинговой группы 
		/// <para/>
		/// GroupID
		/// </summary>
		public global::System.Int32? Grp_ID { get; set; } /*IN*/
			/// <summary>
		/// Полное юридическое наименование 
		/// <para/>
		/// FullName
		/// </summary>
		public global::System.String Abn_FullName { get; set; } /*IN*/
			/// <summary>
		/// Короткое наименование
		/// <para/>
		/// ShortName
		/// </summary>
		public global::System.String Abn_ShortName { get; set; } /*IN*/
			/// <summary>
		/// Признак выполнять нормализацию дерева узлов
		/// <para/>
		/// isUpdateNodeTree
		/// </summary>
		public global::System.Int32? UpdateAbonentTree { get; set; } /*IN*/
			/// <summary>
		/// PositionCode для синхронизации иерархии узлов дерева
		/// <para/>
		/// PositionCode
		/// </summary>
		public global::System.String Abn_PositionCode { get; set; } /*IN*/
			/// <summary>
		/// Тип профиля
		/// <para/>
		/// ProfileType
		/// </summary>
		[Required]
		public global::System.Int32? ProfileType { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор сегмента
		/// <para/>
		/// SegmentID
		/// </summary>
		public global::System.Int32? Dep_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор статуса узла дерева
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный номер узла дерева для синхронизации с внешней системой
		/// <para/>
		/// SyncId
		/// </summary>
		public global::System.String Abn_Employee_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак узла дерева, исключенного из расчетов (техническая запись)
		/// <para/>
		/// TechnicalTag
		/// </summary>
		public global::System.Int32? Abn_ShowPhoneDirectory { get; set; } /*IN*/
			/// <summary>
		/// Номер Филиала
		/// <para/>
		/// LocationID
		/// </summary>
		public global::System.Int32? Location_ID { get; set; } /*IN*/
			/// <summary>
		/// Название ассоциации
		/// <para/>
		/// Name
		/// </summary>
		[Required]
		public global::System.String Abn_LastName { get; set; } /*IN*/
			/// <summary>
		/// Код диллера
		/// <para/>
		/// AgentCode
		/// </summary>
		public global::System.String Sag_Code { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор диллера
		/// <para/>
		/// AgentID
		/// </summary>
		public global::System.Int32? Sag_ID { get; set; } /*IN*/
			/// <summary>
		/// Код точки продаж
		/// <para/>
		/// SalesPointCode
		/// </summary>
		public global::System.String Pos_Code { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор точки продаж
		/// <para/>
		/// SalesPointID
		/// </summary>
		public global::System.Int32? Pos_ID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Ассоциации
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор Ассоциации уровня выше
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID_Boss { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор
		/// <para/>
		/// Abn_Guid
		/// </summary>
		public global::System.Guid? Abn_Guid { get; set; } /*IN*/
			/// <summary>
		/// Код внешней системы
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_Associations_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Abn_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Associations_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Associations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_WorkPlace, (v) => this.Abn_WorkPlace = (global::System.String)v) /*--Customer_SearchName--*/
			{
				Name = "Abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Date, (v) => this.Abn_Date = (global::System.DateTime?)v) /*--CustomerDate--*/
			{
				Name = "Abn_Date",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Date,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Lng_ID, (v) => this.Lng_ID = (global::System.Int32?)v) /*--CustomerLanguageId--*/
			{
				Name = "Lng_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lng_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_IsCreatedWithTariffication, (v) => this.Abn_IsCreatedWithTariffication = (global::System.Int32?)v) /*--IsCreatedWithTariffication--*/
			{
				Name = "Abn_IsCreatedWithTariffication",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_IsCreatedWithTariffication,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_Employe_Export_ID, (v) => this.Abn_Employe_Export_ID = (global::System.String)v) /*--Export_ID--*/
			{
				Name = "Abn_Employe_Export_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Employe_Export_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Grp_ID, (v) => this.Grp_ID = (global::System.Int32?)v) /*--GroupID--*/
			{
				Name = "Grp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Grp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_FullName, (v) => this.Abn_FullName = (global::System.String)v) /*--FullName--*/
			{
				Name = "Abn_FullName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FullName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ShortName, (v) => this.Abn_ShortName = (global::System.String)v) /*--ShortName--*/
			{
				Name = "Abn_ShortName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ShortName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UpdateAbonentTree, (v) => this.UpdateAbonentTree = (global::System.Int32?)v) /*--isUpdateNodeTree--*/
			{
				Name = "UpdateAbonentTree",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UpdateAbonentTree,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_PositionCode, (v) => this.Abn_PositionCode = (global::System.String)v) /*--PositionCode--*/
			{
				Name = "Abn_PositionCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_PositionCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ProfileType, (v) => this.ProfileType = (global::System.Int32?)v) /*--ProfileType--*/
			{
				Name = "ProfileType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ProfileType,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Dep_ID, (v) => this.Dep_ID = (global::System.Int32?)v) /*--SegmentID--*/
			{
				Name = "Dep_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dep_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_Employee_ID, (v) => this.Abn_Employee_ID = (global::System.String)v) /*--SyncId--*/
			{
				Name = "Abn_Employee_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Employee_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ShowPhoneDirectory, (v) => this.Abn_ShowPhoneDirectory = (global::System.Int32?)v) /*--TechnicalTag--*/
			{
				Name = "Abn_ShowPhoneDirectory",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ShowPhoneDirectory,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Location_ID, (v) => this.Location_ID = (global::System.Int32?)v) /*--LocationID--*/
			{
				Name = "Location_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Location_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_LastName, (v) => this.Abn_LastName = (global::System.String)v) /*--Name--*/
			{
				Name = "Abn_LastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_LastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sag_Code, (v) => this.Sag_Code = (global::System.String)v) /*--AgentCode--*/
			{
				Name = "Sag_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sag_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sag_ID, (v) => this.Sag_ID = (global::System.Int32?)v) /*--AgentID--*/
			{
				Name = "Sag_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sag_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pos_Code, (v) => this.Pos_Code = (global::System.String)v) /*--SalesPointCode--*/
			{
				Name = "Pos_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pos_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Pos_ID, (v) => this.Pos_ID = (global::System.Int32?)v) /*--SalesPointID--*/
			{
				Name = "Pos_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pos_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID_Boss, (v) => this.Abn_ID_Boss = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID_Boss",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID_Boss,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Guid, (v) => this.Abn_Guid = (global::System.Guid?)v) /*--Abn_Guid--*/
			{
				Name = "Abn_Guid",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Guid,
				DBType = System.Data.DbType.Guid
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_Associations_Response : ICallProcedureModel<SET_p_ucp_set_Associations_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Associations_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Associations_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_Associations_Response()
		{
			expressions.Add((m) => m.Abn_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Associations_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Associations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Associations/Activate]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// AuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*IN*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// уникальное значение логина, например Option82 
		/// <para/>
		/// Login
		/// </summary>
		public global::System.String Abn_Login { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Адрес для нотификации об активации
		/// <para/>
		/// Notification
		/// </summary>
		public global::System.String Notification { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// пароль
		/// <para/>
		/// Password
		/// </summary>
		public global::System.String Abn_Password { get; set; } /*IN*/
			/// <summary>
		/// Телефон для нотификации об активации
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String PhoneNumber { get; set; } /*IN*/
			/// <summary>
		/// Комментарий для активации
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Статус узла дерева после активаци
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeActivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.aut_NameAuthCode, (v) => this.aut_NameAuthCode = (global::System.String)v) /*--AuthCode--*/
			{
				Name = "aut_NameAuthCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Login, (v) => this.Abn_Login = (global::System.String)v) /*--Login--*/
			{
				Name = "Abn_Login",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Login,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Notification, (v) => this.Notification = (global::System.String)v) /*--Notification--*/
			{
				Name = "Notification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Notification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_Password, (v) => this.Abn_Password = (global::System.String)v) /*--Password--*/
			{
				Name = "Abn_Password",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Password,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PhoneNumber, (v) => this.PhoneNumber = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "PhoneNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PhoneNumber,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeActivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Associations/ChangeName]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Имя
		/// <para/>
		/// FirstName
		/// </summary>
		public global::System.String Abn_FirstName { get; set; } /*IN*/
			/// <summary>
		/// Юридическое наименование
		/// <para/>
		/// FullName
		/// </summary>
		public global::System.String Abn_FullName { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Отчество
		/// <para/>
		/// MiddleName
		/// </summary>
		public global::System.String Abn_MiddleName { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Название или Фамилия
		/// <para/>
		/// Name
		/// </summary>
		public global::System.String Abn_LastName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Ассоциации 
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// ОКПО или Паспорт
		/// <para/>
		/// SearchName
		/// </summary>
		public global::System.String Abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// Сокращенное наименование
		/// <para/>
		/// ShortName
		/// </summary>
		public global::System.String Abn_ShortName { get; set; } /*IN*/
			/// <summary>
		/// Указание очистить значение, в случае передачи ПУСТО в значении
		/// <para/>
		/// ToClean
		/// </summary>
		public global::System.Int32? toClean { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeName";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_FirstName, (v) => this.Abn_FirstName = (global::System.String)v) /*--FirstName--*/
			{
				Name = "Abn_FirstName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FirstName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_FullName, (v) => this.Abn_FullName = (global::System.String)v) /*--FullName--*/
			{
				Name = "Abn_FullName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FullName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_MiddleName, (v) => this.Abn_MiddleName = (global::System.String)v) /*--MiddleName--*/
			{
				Name = "Abn_MiddleName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_MiddleName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_LastName, (v) => this.Abn_LastName = (global::System.String)v) /*--Name--*/
			{
				Name = "Abn_LastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_LastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_WorkPlace, (v) => this.Abn_WorkPlace = (global::System.String)v) /*--SearchName--*/
			{
				Name = "Abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ShortName, (v) => this.Abn_ShortName = (global::System.String)v) /*--ShortName--*/
			{
				Name = "Abn_ShortName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ShortName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.toClean, (v) => this.toClean = (global::System.Int32?)v) /*--ToClean--*/
			{
				Name = "toClean",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.toClean,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeName";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Associations/ChangeParent]
	[DocIgnore]
	public class ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request : ICallProcedureModel<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак получения акцепта пользователя перед выполнением операции
		/// <para/>
		/// ConfAccepted
		/// </summary>
		public global::System.Int32? ConfAccepted { get; set; } /*IN*/
			/// <summary>
		/// Сообщение для конечного пользователя, требующее его обязательного подтверждения
		/// <para/>
		/// ConfMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*INOUT*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор узла дерева
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор вышестоящего узла дерева, на который делается перенос
		/// <para/>
		/// ParentNode
		/// </summary>
		[Required]
		public global::System.Int32? Parent_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий 
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Статус узла дерева после перерегистрации
		/// <para/>
		/// TargetStatusID
		/// </summary>
		public global::System.Int32? Tnst_target_new { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request()
		{
			expressions.Add((m) => m.ConfMessage); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_ChangeParent";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfAccepted, (v) => this.ConfAccepted = (global::System.Int32?)v) /*--ConfAccepted--*/
			{
				Name = "ConfAccepted",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ConfAccepted,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Parent_ID, (v) => this.Parent_ID = (global::System.Int32?)v) /*--ParentNode--*/
			{
				Name = "Parent_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Parent_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_target_new, (v) => this.Tnst_target_new = (global::System.Int32?)v) /*--TargetStatusID--*/
			{
				Name = "Tnst_target_new",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_target_new,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response : ICallProcedureModel<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Сообщение для конечного пользователя, требующее его обязательного подтверждения
		/// <para/>
		/// ConfMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response()
		{
			expressions.Add((m) => m.ConfMessage); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_ChangeParent";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Associations/ChangeStatus]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// ConfirmationMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*INOUT*/
			/// <summary>
		/// Дата изменения статуса
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента, клиента или ассоциации
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения статуса
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Статус узла дерева
		/// <para/>
		/// StatusID
		/// </summary>
		[Required]
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак подтверждения операции со стороны пользователя
		/// <para/>
		/// UserAcceptance
		/// </summary>
		public global::System.Int32? ConfAccepted { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request()
		{
			expressions.Add((m) => m.ConfMessage); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeStatus";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfirmationMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ConfAccepted, (v) => this.ConfAccepted = (global::System.Int32?)v) /*--UserAcceptance--*/
			{
				Name = "ConfAccepted",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ConfAccepted,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Ответ АПИ с текстом предупреждения перед изменением статуса
		/// <para/>
		/// ConfirmationMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response()
		{
			expressions.Add((m) => m.ConfMessage); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeStatus";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfirmationMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Associations/Deactivate]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата деактивации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Имя сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		[Required]
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Фильтр для отбора узлов по коду метки
		/// <para/>
		/// LabelCode
		/// </summary>
		public global::System.String Lbl_Code { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Адрес для нотификации о деактивации
		/// <para/>
		/// Notification
		/// </summary>
		public global::System.String Notification { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Телефон для нотификации о деактивации
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String PhoneNumber { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Фильтр для отбора узлов по текущему статусу узла дерева
		/// <para/>
		/// StatusCode
		/// </summary>
		public global::System.String Tnst_Code_crnt { get; set; } /*IN*/
			/// <summary>
		/// Значение статуса узла после выполнения операции
		/// <para/>
		/// TargetStatusCode
		/// </summary>
		public global::System.String Tnst_Code_trgt { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeDeactivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lbl_Code, (v) => this.Lbl_Code = (global::System.String)v) /*--LabelCode--*/
			{
				Name = "Lbl_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lbl_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Notification, (v) => this.Notification = (global::System.String)v) /*--Notification--*/
			{
				Name = "Notification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Notification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PhoneNumber, (v) => this.PhoneNumber = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "PhoneNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PhoneNumber,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_Code_crnt, (v) => this.Tnst_Code_crnt = (global::System.String)v) /*--StatusCode--*/
			{
				Name = "Tnst_Code_crnt",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_Code_crnt,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_Code_trgt, (v) => this.Tnst_Code_trgt = (global::System.String)v) /*--TargetStatusCode--*/
			{
				Name = "Tnst_Code_trgt",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_Code_trgt,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Кол-во обработанных записей 
		/// <para/>
		/// AffectedCount
		/// </summary>
		public global::System.Int32? AffectedCount { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор процесса 
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int32? Wev_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response()
		{
			expressions.Add((m) => m.AffectedCount); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Wev_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeDeactivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.AffectedCount, (v) => this.AffectedCount = (global::System.Int32?)v) /*--AffectedCount--*/
			{
				Name = "AffectedCount",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.AffectedCount,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int32?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Associations/Details]
	[DocIgnore]
	public class GET_p_ucp_get_AssociationByID_Associations_Details_Request : ICallProcedureModel<GET_p_ucp_get_AssociationByID_Associations_Details_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_AssociationByID_Associations_Details_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_AssociationByID_Associations_Details_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
#endregion

		#region ctor
		public GET_p_ucp_get_AssociationByID_Associations_Details_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_AssociationByID_Associations_Details_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_AssociationByID";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--CacheControlDate--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.DateTime
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_AssociationByID_Associations_Details_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_AssociationByID_Associations_Details_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// debt_Amount
		/// </summary>
		[Required]
		public global::System.Decimal? debt_Amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// debt_Date
		/// </summary>
		[Required]
		public global::System.DateTime? debt_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		[Required]
		public global::System.Int32? dep_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		[Required]
		public global::System.String ext_ExtNum { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? ext_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		[Required]
		public global::System.Int32? grp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_Name
		/// </summary>
		[Required]
		public global::System.String grp_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isActivated
		/// </summary>
		[Required]
		public global::System.Int32? isActivated { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditAllow
		/// </summary>
		[Required]
		public global::System.Int32? isEditAllow { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditWorkPlace
		/// </summary>
		[Required]
		public global::System.Int32? isEditWorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// lng_ID
		/// </summary>
		[Required]
		public global::System.Int32? lng_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// loc_Name
		/// </summary>
		[Required]
		public global::System.String loc_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Location_ID
		/// </summary>
		[Required]
		public global::System.Int32? Location_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ntw_ID
		/// </summary>
		[Required]
		public global::System.Int32? ntw_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pbx_networkName
		/// </summary>
		[Required]
		public global::System.String pbx_networkName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ProfileType
		/// </summary>
		[Required]
		public global::System.Int32? ProfileType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// SubsCount
		/// </summary>
		[Required]
		public global::System.Int32? SubsCount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnh_LastFM
		/// </summary>
		[Required]
		public global::System.String tnh_LastFM { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_AccountMandatory
		/// </summary>
		[Required]
		public global::System.Int32? tnt_AccountMandatory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TreeNodeType
		/// </summary>
		public global::System.String TreeNodeType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		[Required]
		public global::System.Int32? trf_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_FirstName
		/// </summary>
		[Required]
		public global::System.String abn_FirstName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Balance_Personal
		/// </summary>
		[Required]
		public global::System.Decimal? abc_Balance_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abc_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Date_Personal
		/// </summary>
		[Required]
		public global::System.DateTime? abc_Date_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abn_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_CreateDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_CreateDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abn_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employe_Export_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employe_Export_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employee_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Guid
		/// </summary>
		[Required]
		public global::System.Guid? abn_Guid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ID_Boss
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsExistAD { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsGuest
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsGuest { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastFM
		/// </summary>
		[Required]
		public global::System.String abn_LastFM { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_MiddleName
		/// </summary>
		[Required]
		public global::System.String abn_MiddleName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedBy
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedFrom
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedFrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Left
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Left { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Right
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Right { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Password
		/// </summary>
		[Required]
		public global::System.String abn_Password { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_PositionCode
		/// </summary>
		[Required]
		public global::System.String abn_PositionCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ShowPhoneDirectory
		/// </summary>
		[Required]
		public global::System.Int32? abn_ShowPhoneDirectory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		[Required]
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace_Personal
		/// </summary>
		[Required]
		public global::System.String abn_WorkPlace_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_XmlData
		/// </summary>
		[Required]
		public global::System.String abn_XmlData { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// AbonentFullName
		/// </summary>
		[Required]
		public global::System.String AbonentFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_IsPersonal
		/// </summary>
		[Required]
		public global::System.Int32? acnt_IsPersonal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		[Required]
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number_Personal
		/// </summary>
		[Required]
		public global::System.String acnt_Number_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name
		/// </summary>
		[Required]
		public global::System.String Actpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name_Personal
		/// </summary>
		[Required]
		public global::System.String Actpd_Name_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Login
		/// </summary>
		[Required]
		public global::System.String abn_Login { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abb_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_Balance_Personal
		/// </summary>
		[Required]
		public global::System.Decimal? abb_Balance_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abb_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_ModifiedDate_Personal
		/// </summary>
		[Required]
		public global::System.DateTime? abb_ModifiedDate_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abc_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// atnsb_DateEnd
		/// </summary>
		[Required]
		public global::System.DateTime? atnsb_DateEnd { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// atnsb_DateStart
		/// </summary>
		[Required]
		public global::System.DateTime? atnsb_DateStart { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? aut_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Boss_Tnt_Type
		/// </summary>
		[Required]
		public global::System.String Boss_Tnt_Type { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossFullName
		/// </summary>
		[Required]
		public global::System.String BossFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_Id
		/// </summary>
		[Required]
		public global::System.Int32? com_Id { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isRefusalChangeName
		/// </summary>
		[Required]
		public global::System.Int32? isRefusalChangeName { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [Associations/SetLabels]
	[DocIgnore]
	public class ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request : ICallProcedureModel<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		[Required]
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Код метки
		/// <para/>
		/// LabelCode
		/// </summary>
		[Required]
		public global::System.String Lbl_Code { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// LinkedServer
		/// </summary>
		public global::System.String LinkedServer { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// SELECT запрос на отбор идентификаторов узлов дерева - должен учитыавать значение IDType
		/// <para/>
		/// SourceQuery
		/// </summary>
		public global::System.String SourceQuery { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_LabelApply";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lbl_Code, (v) => this.Lbl_Code = (global::System.String)v) /*--LabelCode--*/
			{
				Name = "Lbl_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lbl_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.LinkedServer, (v) => this.LinkedServer = (global::System.String)v) /*--LinkedServer--*/
			{
				Name = "LinkedServer",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.LinkedServer,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SourceQuery, (v) => this.SourceQuery = (global::System.String)v) /*--SourceQuery--*/
			{
				Name = "SourceQuery",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SourceQuery,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response : ICallProcedureModel<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_LabelApply";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [AuthCodes]
	[DocIgnore]
	public class SET_p_ucp_set_TreeNodeAuthCodes_Request : ICallProcedureModel<SET_p_ucp_set_TreeNodeAuthCodes_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_TreeNodeAuthCodes_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_TreeNodeAuthCodes_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Сетевой идентификатор при активации (DHCP Option82)
		/// <para/>
		/// DHCPOption82
		/// </summary>
		public global::System.String aab_DHCPOption82 { get; set; } /*IN*/
			/// <summary>
		/// Сетевой идентификатор при активации (доп. информация)
		/// <para/>
		/// IdentificationInfo
		/// </summary>
		public global::System.String aab_IdentificationInfo { get; set; } /*IN*/
			/// <summary>
		/// Сетевой идентификатор при активации (MAC адрес)
		/// <para/>
		/// MACAddress
		/// </summary>
		public global::System.String aab_MACAddress { get; set; } /*IN*/
			/// <summary>
		/// Сетевой идентификатор при активации (SessionId)
		/// <para/>
		/// SessionId
		/// </summary>
		public global::System.String aab_SessionId { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Лицевого счета
		/// <para/>
		/// AccountID
		/// </summary>
		public global::System.Int32? Acnt_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер Лицевого счета
		/// <para/>
		/// AccountNumber
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор Кода авторизации
		/// <para/>
		/// AuthCodeID
		/// </summary>
		public global::System.Int64? aut_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Уникальный номер Кода авторизации
		/// <para/>
		/// AuthCodeName
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*IN*/
			/// <summary>
		/// Дополнительная информация для учета
		/// <para/>
		/// XmlData
		/// </summary>
		public global::System.String aut_XmlData { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания связки Кода с узлом дерева
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала связки Кода с узлом дерева
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModifiedBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModifiedFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор устройства, связанного с Кодом Авторизации
		/// <para/>
		/// NumberAts
		/// </summary>
		public global::System.Int32? NumberAts { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Формат данных дополнительной информации для учета
		/// <para/>
		/// XmlDataFormat
		/// </summary>
		public global::System.String XmlDataFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Сетевой идентификатор при активации (IP адрес)
		/// <para/>
		/// IpAddress
		/// </summary>
		public global::System.String ipAddress { get; set; } /*IN*/
			/// <summary>
		/// Код внешней системы - инициатора запроса
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор связки с абонентом или клиентом
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int64? aab_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента или клиента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModifiedDate
		/// </summary>
		public global::System.DateTime? ModifiedDate { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_TreeNodeAuthCodes_Request()
		{
			expressions.Add((m) => m.aut_ID); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.aab_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_TreeNodeAuthCodes_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_TreeNodeAuthCodes";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.aab_DHCPOption82, (v) => this.aab_DHCPOption82 = (global::System.String)v) /*--DHCPOption82--*/
			{
				Name = "aab_DHCPOption82",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aab_DHCPOption82,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aab_IdentificationInfo, (v) => this.aab_IdentificationInfo = (global::System.String)v) /*--IdentificationInfo--*/
			{
				Name = "aab_IdentificationInfo",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aab_IdentificationInfo,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aab_MACAddress, (v) => this.aab_MACAddress = (global::System.String)v) /*--MACAddress--*/
			{
				Name = "aab_MACAddress",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aab_MACAddress,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aab_SessionId, (v) => this.aab_SessionId = (global::System.String)v) /*--SessionId--*/
			{
				Name = "aab_SessionId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aab_SessionId,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Acnt_ID, (v) => this.Acnt_ID = (global::System.Int32?)v) /*--AccountID--*/
			{
				Name = "Acnt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--AccountNumber--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aut_ID, (v) => this.aut_ID = (global::System.Int64?)v) /*--AuthCodeID--*/
			{
				Name = "aut_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.aut_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.aut_NameAuthCode, (v) => this.aut_NameAuthCode = (global::System.String)v) /*--AuthCodeName--*/
			{
				Name = "aut_NameAuthCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aut_XmlData, (v) => this.aut_XmlData = (global::System.String)v) /*--XmlData--*/
			{
				Name = "aut_XmlData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_XmlData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ModifiedBy, (v) => this.ModifiedBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModifiedBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModifiedFrom, (v) => this.ModifiedFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModifiedFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.NumberAts, (v) => this.NumberAts = (global::System.Int32?)v) /*--NumberAts--*/
			{
				Name = "NumberAts",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.NumberAts,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.XmlDataFormat, (v) => this.XmlDataFormat = (global::System.String)v) /*--XmlDataFormat--*/
			{
				Name = "XmlDataFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.XmlDataFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ipAddress, (v) => this.ipAddress = (global::System.String)v) /*--IpAddress--*/
			{
				Name = "ipAddress",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ipAddress,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aab_ID, (v) => this.aab_ID = (global::System.Int64?)v) /*--ID--*/
			{
				Name = "aab_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.aab_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModifiedDate, (v) => this.ModifiedDate = (global::System.DateTime?)v) /*--ModifiedDate--*/
			{
				Name = "ModifiedDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedDate,
				DBType = System.Data.DbType.DateTime
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_TreeNodeAuthCodes_Response : ICallProcedureModel<SET_p_ucp_set_TreeNodeAuthCodes_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_TreeNodeAuthCodes_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_TreeNodeAuthCodes_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Уникальный идентификатор Кода авторизации
		/// <para/>
		/// AuthCodeID
		/// </summary>
		[Required]
		public global::System.Int64? aut_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Уникальный идентификатор связки с абонентом или клиентом
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int64? aab_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_TreeNodeAuthCodes_Response()
		{
			expressions.Add((m) => m.aut_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.aab_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_TreeNodeAuthCodes_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_TreeNodeAuthCodes";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.aut_ID, (v) => this.aut_ID = (global::System.Int64?)v) /*--AuthCodeID--*/
			{
				Name = "aut_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.aut_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aab_ID, (v) => this.aab_ID = (global::System.Int64?)v) /*--ID--*/
			{
				Name = "aab_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.aab_ID,
				DBType = System.Data.DbType.Int64
			};
		}
	}
#endregion
#region [BankAccounts]
	[DocIgnore]
	public class GET_p_ucp_get_BankAccounts_Request : ICallProcedureModel<GET_p_ucp_get_BankAccounts_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_BankAccounts_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_BankAccounts_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// Abn_ID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageNumber
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_BankAccounts_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_BankAccounts_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_BankAccounts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--Abn_ID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageNumber--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_BankAccounts_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_BankAccounts_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// AccNumber
		/// </summary>
		[Required]
		public global::System.String AccNumber { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? bac_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BankCode
		/// </summary>
		[Required]
		public global::System.String BankCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Code
		/// </summary>
		[Required]
		public global::System.String Code { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// IBAN
		/// </summary>
		[Required]
		public global::System.String IBAN { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// loc_ID
		/// </summary>
		[Required]
		public global::System.Int32? loc_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Name
		/// </summary>
		[Required]
		public global::System.String Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// OneString
		/// </summary>
		[Required]
		public global::System.String OneString { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// bnk_ID
		/// </summary>
		[Required]
		public global::System.Int32? bnk_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [BankDetails]
	[DocIgnore]
	public class SET_p_ucp_set_BankDetails_Request : ICallProcedureModel<SET_p_ucp_set_BankDetails_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_BankDetails_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_BankDetails_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор внешней системы
		/// <para/>
		/// Esys_ID
		/// </summary>
		public global::System.Int32? Esys_ID { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Формат данных аттрибутов банковских деталей
		/// <para/>
		/// DataFormat
		/// </summary>
		public global::System.String DataFormat { get; set; } /*IN*/
			/// <summary>
		/// Номер банковского счета в формате IBAN
		/// <para/>
		/// IBANCode
		/// </summary>
		public global::System.String Bac_IBANCode { get; set; } /*IN*/
			/// <summary>
		/// Дата закрытия банковского счета
		/// <para/>
		/// BankCloseDate
		/// </summary>
		public global::System.DateTime? Bnk_CloseDate { get; set; } /*IN*/
			/// <summary>
		/// Дополнительные атрибуты банка
		/// <para/>
		/// BankJsonData
		/// </summary>
		public global::System.String Bnk_JsonData { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор банка
		/// <para/>
		/// BankID
		/// </summary>
		public global::System.Int32? Bnk_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор банковского счета
		/// <para/>
		/// BankAccountID
		/// </summary>
		public global::System.Int32? Bac_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор населенного пункта
		/// <para/>
		/// CityID
		/// </summary>
		public global::System.Int32? Cit_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер Филиала
		/// <para/>
		/// LocationID
		/// </summary>
		public global::System.Int32? Loc_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор страны
		/// <para/>
		/// CountryID
		/// </summary>
		public global::System.Int32? Cou_ID { get; set; } /*IN*/
			/// <summary>
		/// Код банка (внутренний)
		/// <para/>
		/// Code
		/// </summary>
		public global::System.String Bnk_Code { get; set; } /*IN*/
			/// <summary>
		/// Наименование банка
		/// <para/>
		/// BankName
		/// </summary>
		public global::System.String Bnkd_Name { get; set; } /*IN*/
			/// <summary>
		/// Национальный код банка (МФО, БИК, BLZ, sort code, ABA RTN)
		/// <para/>
		/// BankCode
		/// </summary>
		public global::System.String Bnk_BankCode { get; set; } /*IN*/
			/// <summary>
		/// Номер банковского счета
		/// <para/>
		/// BankAccountNumber
		/// </summary>
		public global::System.String Bac_Number { get; set; } /*IN*/
			/// <summary>
		/// Пользователь, указавший о закрытии банковского счета
		/// <para/>
		/// BankCloseBy
		/// </summary>
		public global::System.String Bnk_CloseBy { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания действия
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Код внешней системы - инициатора запроса
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор истории банковского счета
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Adab_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор узла дерева
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_BankDetails_Request()
		{
			expressions.Add((m) => m.Bnk_ID); // INOUT
			expressions.Add((m) => m.Bac_ID); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Adab_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_BankDetails_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_BankDetails";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Esys_ID, (v) => this.Esys_ID = (global::System.Int32?)v) /*--Esys_ID--*/
			{
				Name = "Esys_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Esys_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DataFormat, (v) => this.DataFormat = (global::System.String)v) /*--DataFormat--*/
			{
				Name = "DataFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DataFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bac_IBANCode, (v) => this.Bac_IBANCode = (global::System.String)v) /*--IBANCode--*/
			{
				Name = "Bac_IBANCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_IBANCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bnk_CloseDate, (v) => this.Bnk_CloseDate = (global::System.DateTime?)v) /*--BankCloseDate--*/
			{
				Name = "Bnk_CloseDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bnk_CloseDate,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.Bnk_JsonData, (v) => this.Bnk_JsonData = (global::System.String)v) /*--BankJsonData--*/
			{
				Name = "Bnk_JsonData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bnk_JsonData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bnk_ID, (v) => this.Bnk_ID = (global::System.Int32?)v) /*--BankID--*/
			{
				Name = "Bnk_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Bnk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Bac_ID, (v) => this.Bac_ID = (global::System.Int32?)v) /*--BankAccountID--*/
			{
				Name = "Bac_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Bac_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cit_ID, (v) => this.Cit_ID = (global::System.Int32?)v) /*--CityID--*/
			{
				Name = "Cit_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cit_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Loc_ID, (v) => this.Loc_ID = (global::System.Int32?)v) /*--LocationID--*/
			{
				Name = "Loc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Loc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cou_ID, (v) => this.Cou_ID = (global::System.Int32?)v) /*--CountryID--*/
			{
				Name = "Cou_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cou_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Bnk_Code, (v) => this.Bnk_Code = (global::System.String)v) /*--Code--*/
			{
				Name = "Bnk_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bnk_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bnkd_Name, (v) => this.Bnkd_Name = (global::System.String)v) /*--BankName--*/
			{
				Name = "Bnkd_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bnkd_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bnk_BankCode, (v) => this.Bnk_BankCode = (global::System.String)v) /*--BankCode--*/
			{
				Name = "Bnk_BankCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bnk_BankCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bac_Number, (v) => this.Bac_Number = (global::System.String)v) /*--BankAccountNumber--*/
			{
				Name = "Bac_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bnk_CloseBy, (v) => this.Bnk_CloseBy = (global::System.String)v) /*--BankCloseBy--*/
			{
				Name = "Bnk_CloseBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bnk_CloseBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Adab_ID, (v) => this.Adab_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Adab_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Adab_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_BankDetails_Response : ICallProcedureModel<SET_p_ucp_set_BankDetails_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_BankDetails_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_BankDetails_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор истории банковского счета
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Adab_ID { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор банковского счета
		/// <para/>
		/// BankAccountID
		/// </summary>
		public global::System.Int32? Bac_ID { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор банка
		/// <para/>
		/// BankID
		/// </summary>
		public global::System.Int32? Bnk_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_BankDetails_Response()
		{
			expressions.Add((m) => m.Adab_ID); // OUT
			expressions.Add((m) => m.Bac_ID); // OUT
			expressions.Add((m) => m.Bnk_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_BankDetails_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_BankDetails";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Adab_ID, (v) => this.Adab_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Adab_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Adab_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Bac_ID, (v) => this.Bac_ID = (global::System.Int32?)v) /*--BankAccountID--*/
			{
				Name = "Bac_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Bac_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Bnk_ID, (v) => this.Bnk_ID = (global::System.Int32?)v) /*--BankID--*/
			{
				Name = "Bnk_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Bnk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [BankStatements]
	[DocIgnore]
	public class GET_p_ucp_get_BatchPayDocRecords_Request : ICallProcedureModel<GET_p_ucp_get_BatchPayDocRecords_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_BatchPayDocRecords_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_BatchPayDocRecords_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Номер банковского счета компании, на который поступил платеж
		/// <para/>
		/// BankAccountNumberTo
		/// </summary>
		public global::System.String Bank_Account_NUM { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// BankCodeTo
		/// </summary>
		public global::System.String Bank_MFO { get; set; } /*IN*/
			/// <summary>
		/// ID пачки платежей, которая находится в обработке в АРМ
		/// <para/>
		/// BatchID
		/// </summary>
		public global::System.Int32? Batch_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата платежа
		/// <para/>
		/// PayDate
		/// </summary>
		public global::System.DateTime? Date_doc { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public GET_p_ucp_get_BatchPayDocRecords_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_BatchPayDocRecords_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_BatchPayDocRecords";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Bank_Account_NUM, (v) => this.Bank_Account_NUM = (global::System.String)v) /*--BankAccountNumberTo--*/
			{
				Name = "Bank_Account_NUM",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bank_Account_NUM,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bank_MFO, (v) => this.Bank_MFO = (global::System.String)v) /*--BankCodeTo--*/
			{
				Name = "Bank_MFO",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bank_MFO,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Batch_ID, (v) => this.Batch_ID = (global::System.Int32?)v) /*--BatchID--*/
			{
				Name = "Batch_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Batch_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Date_doc, (v) => this.Date_doc = (global::System.DateTime?)v) /*--PayDate--*/
			{
				Name = "Date_doc",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Date_doc,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_BatchPayDocRecords_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_BatchPayDocRecords_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Счет отправителя платежа, соответствует полю  BANK_ACCOUNT_TEXT таблицы CE.CE_STATEMENT_LINES
		/// <para/>
		/// BankAccountNumberFrom
		/// </summary>
		[Required]
		public global::System.String accountfrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// Сумма платежа. Сумма в ГРН с копейками
		/// <para/>
		/// Amount
		/// </summary>
		[Required]
		public global::System.Decimal? amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// ID банковского счета, соответствует полю CE.CE_STATEMENT_HEADERS_ALL.BANK_ACCOUNT_ID
		/// <para/>
		/// BankAccountExternalID
		/// </summary>
		[Required]
		public global::System.Int32? bank_account_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер банковского счета компании, на который поступил платеж
		/// <para/>
		/// BankAccountNumberTo
		/// </summary>
		[Required]
		public global::System.String bank_account_num { get; set; } /*OUTPUT*/
			/// <summary>
		/// ID банковской выписки
		/// <para/>
		/// pre_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? bank_st_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер платежного поручения
		/// <para/>
		/// PaymentOrder
		/// </summary>
		[Required]
		public global::System.String bank_trx_number { get; set; } /*OUTPUT*/
			/// <summary>
		/// Название банковского счета, по которому получен платеж
		/// <para/>
		/// BankInternalCodeTo
		/// </summary>
		[Required]
		public global::System.String bankcode { get; set; } /*OUTPUT*/
			/// <summary>
		/// ID пачки платежей, которая находится в обработке в АРМ
		/// <para/>
		/// BatchID
		/// </summary>
		[Required]
		public global::System.Int32? batch_id { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата создания записи в интерфейсной таблице
		/// <para/>
		/// EffectiveDate
		/// </summary>
		[Required]
		public global::System.DateTime? creation_date { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата платежа
		/// <para/>
		/// PayDate
		/// </summary>
		[Required]
		public global::System.DateTime? date_doc { get; set; } /*OUTPUT*/
			/// <summary>
		/// Значение данного поля соответствует значению поля  DOC_ID из интерфейсной таблицы. Необходим уникальный индекс.
		/// <para/>
		/// cpd_ExportID
		/// </summary>
		[Required]
		public global::System.Int32? doc_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер выписки в биллинговой системе.
		/// <para/>
		/// pre_NumReestr
		/// </summary>
		[Required]
		public global::System.String list_num { get; set; } /*OUTPUT*/
			/// <summary>
		/// МФО банковского счета, на который поступил платеж
		/// <para/>
		/// BankCodeTo
		/// </summary>
		[Required]
		public global::System.String mfo { get; set; } /*OUTPUT*/
			/// <summary>
		/// МФО банка отправителя
		/// <para/>
		/// BankCodeFrom
		/// </summary>
		[Required]
		public global::System.String mfofrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование отправителя
		/// <para/>
		/// BankNameFrom
		/// </summary>
		[Required]
		public global::System.String namefrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// ОКПО отправителя
		/// <para/>
		/// BusinessUIDFrom
		/// </summary>
		[Required]
		public global::System.String okpofrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// org_id - идентификатор организации
		/// <para/>
		/// TenantID
		/// </summary>
		[Required]
		public global::System.Int32? org_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер заявки на покупки валюты
		/// <para/>
		/// RequestNumber
		/// </summary>
		[Required]
		public global::System.String req_num { get; set; } /*OUTPUT*/
			/// <summary>
		/// Статус блока(пачки): 0 - в работе; 1 - закрыта
		/// <para/>
		/// PayDocStatusId
		/// </summary>
		[Required]
		public global::System.Int32? status { get; set; } /*OUTPUT*/
			/// <summary>
		/// Код транзакции при проведении операции покупки, продажи валюты
		/// <para/>
		/// TransactionCode
		/// </summary>
		[Required]
		public global::System.String trx_code { get; set; } /*OUTPUT*/
			/// <summary>
		/// Назначение платежа
		/// <para/>
		/// TransactionText
		/// </summary>
		[Required]
		public global::System.String trx_text { get; set; } /*OUTPUT*/
			/// <summary>
		/// Лицевой счет абонента
		/// <para/>
		/// acnt_Number
		/// </summary>
		[Required]
		public global::System.String bill_acc { get; set; } /*OUTPUT*/
#endregion
	}
	[DocIgnore]
	public class SET_p_ucp_set_BatchPayDocRecords_Request : ICallProcedureModel<SET_p_ucp_set_BatchPayDocRecords_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_BatchPayDocRecords_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_BatchPayDocRecords_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Номер банковского счета компании, на который поступил платеж
		/// <para/>
		/// BankAccountNumberTo
		/// </summary>
		public global::System.String Bank_Account_NUM { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// BankCodeTo
		/// </summary>
		public global::System.String Bank_MFO { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// RowCount
		/// </summary>
		public global::System.Int32? Batch_Count { get; set; } /*IN*/
			/// <summary>
		/// ID пачки платежей, которая находится в обработке в АРМ
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Batch_ID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsBillingAccount
		/// </summary>
		public global::System.String Bil_Account { get; set; } /*IN*/
			/// <summary>
		/// Дата платежа
		/// <para/>
		/// PayDate
		/// </summary>
		public global::System.DateTime? Date_doc { get; set; } /*IN*/
			/// <summary>
		/// Значение данного поля соответствует значению поля  DOC_ID из интерфейсной таблицы. Необходим уникальный индекс.
		/// <para/>
		/// cpd_ExportID
		/// </summary>
		public global::System.Int32? Doc_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// org_id - идентификатор организации
		/// <para/>
		/// TenantID
		/// </summary>
		public global::System.Int32? Org_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsPostponed
		/// </summary>
		public global::System.String Remitted { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Result
		/// </summary>
		[Required]
		public global::System.Int32? Result { get; set; } /*INOUT*/
			/// <summary>
		/// Категория Закрытой группы (односторонняя, двусторонняя и т.д.)
		/// <para/>
		/// PayDocStatusCode
		/// </summary>
		public global::System.String Type { get; set; } /*IN*/
			/// <summary>
		/// ID пользователя
		/// <para/>
		/// UserID
		/// </summary>
		[Required]
		public global::System.Int32? User_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор банковского счета
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Bac_ID { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_BatchPayDocRecords_Request()
		{
			expressions.Add((m) => m.Batch_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Result); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_BatchPayDocRecords_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_BatchPayDocRecords";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Bank_Account_NUM, (v) => this.Bank_Account_NUM = (global::System.String)v) /*--BankAccountNumberTo--*/
			{
				Name = "Bank_Account_NUM",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bank_Account_NUM,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bank_MFO, (v) => this.Bank_MFO = (global::System.String)v) /*--BankCodeTo--*/
			{
				Name = "Bank_MFO",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bank_MFO,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Batch_Count, (v) => this.Batch_Count = (global::System.Int32?)v) /*--RowCount--*/
			{
				Name = "Batch_Count",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Batch_Count,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Batch_ID, (v) => this.Batch_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Batch_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Batch_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Bil_Account, (v) => this.Bil_Account = (global::System.String)v) /*--IsBillingAccount--*/
			{
				Name = "Bil_Account",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bil_Account,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Date_doc, (v) => this.Date_doc = (global::System.DateTime?)v) /*--PayDate--*/
			{
				Name = "Date_doc",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Date_doc,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Doc_ID, (v) => this.Doc_ID = (global::System.Int32?)v) /*--cpd_ExportID--*/
			{
				Name = "Doc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Doc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Org_ID, (v) => this.Org_ID = (global::System.Int32?)v) /*--TenantID--*/
			{
				Name = "Org_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Org_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remitted, (v) => this.Remitted = (global::System.String)v) /*--IsPostponed--*/
			{
				Name = "Remitted",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remitted,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Result, (v) => this.Result = (global::System.Int32?)v) /*--Result--*/
			{
				Name = "Result",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Result,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Type, (v) => this.Type = (global::System.String)v) /*--PayDocStatusCode--*/
			{
				Name = "Type",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Type,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.User_ID, (v) => this.User_ID = (global::System.Int32?)v) /*--UserID--*/
			{
				Name = "User_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.User_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Bac_ID, (v) => this.Bac_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Bac_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_BatchPayDocRecords_Response : ICallProcedureModel<SET_p_ucp_set_BatchPayDocRecords_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_BatchPayDocRecords_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_BatchPayDocRecords_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// ID пачки платежей, которая находится в обработке в АРМ
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Batch_ID { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Result
		/// </summary>
		[Required]
		public global::System.Int32? Result { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_BatchPayDocRecords_Response()
		{
			expressions.Add((m) => m.Batch_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Result); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_BatchPayDocRecords_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_BatchPayDocRecords";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Batch_ID, (v) => this.Batch_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Batch_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Batch_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Result, (v) => this.Result = (global::System.Int32?)v) /*--Result--*/
			{
				Name = "Result",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Result,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [BankStatements/ChangePaymentsStatus]
	[DocIgnore]
	public class ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request : ICallProcedureModel<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Значение данного поля соответствует значению поля  DOC_ID из интерфейсной таблицы. Необходим уникальный индекс.
		/// <para/>
		/// cpd_ExportID
		/// </summary>
		[Required]
		public global::System.Int32? Doc_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayDocStatusId
		/// </summary>
		[Required]
		public global::System.Int32? Status_AU { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Result
		/// </summary>
		[Required]
		public global::System.Int32? Result { get; set; } /*INOUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Result); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_ChangePayDocRecordStatus";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Doc_ID, (v) => this.Doc_ID = (global::System.Int32?)v) /*--cpd_ExportID--*/
			{
				Name = "Doc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Doc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Status_AU, (v) => this.Status_AU = (global::System.Int32?)v) /*--PayDocStatusId--*/
			{
				Name = "Status_AU",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Status_AU,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Result, (v) => this.Result = (global::System.Int32?)v) /*--Result--*/
			{
				Name = "Result",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Result,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response : ICallProcedureModel<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Result
		/// </summary>
		[Required]
		public global::System.Int32? Result { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Result); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_ChangePayDocRecordStatus";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Result, (v) => this.Result = (global::System.Int32?)v) /*--Result--*/
			{
				Name = "Result",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Result,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [BankStatements/CheckNoSavePayments]
	[DocIgnore]
	public class ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request : ICallProcedureModel<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Result
		/// </summary>
		[Required]
		public global::System.Int32? Result { get; set; } /*INOUT*/
			/// <summary>
		/// ID пользователя
		/// <para/>
		/// UserID
		/// </summary>
		[Required]
		public global::System.Int32? User_ID { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Result); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_CheckNoSavePayDocRecords";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Result, (v) => this.Result = (global::System.Int32?)v) /*--Result--*/
			{
				Name = "Result",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Result,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.User_ID, (v) => this.User_ID = (global::System.Int32?)v) /*--UserID--*/
			{
				Name = "User_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.User_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response : ICallProcedureModel<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Result
		/// </summary>
		[Required]
		public global::System.Int32? Result { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Result); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_CheckNoSavePayDocRecords";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Result, (v) => this.Result = (global::System.Int32?)v) /*--Result--*/
			{
				Name = "Result",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Result,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [BankStatements/ClearBatch]
	[DocIgnore]
	public class ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request : ICallProcedureModel<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// ID пачки платежей, которая находится на обработке в АРМ
		/// <para/>
		/// BatchID
		/// </summary>
		[Required]
		public global::System.Int32? Batch_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Result
		/// </summary>
		[Required]
		public global::System.Int32? Result { get; set; } /*INOUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Result); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_del_BatchPayDocRecords";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Batch_ID, (v) => this.Batch_ID = (global::System.Int32?)v) /*--BatchID--*/
			{
				Name = "Batch_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Batch_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Result, (v) => this.Result = (global::System.Int32?)v) /*--Result--*/
			{
				Name = "Result",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Result,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response : ICallProcedureModel<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Result
		/// </summary>
		[Required]
		public global::System.Int32? Result { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Result); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_del_BatchPayDocRecords";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Result, (v) => this.Result = (global::System.Int32?)v) /*--Result--*/
			{
				Name = "Result",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Result,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [BankStatementTransactions]
	[DocIgnore]
	public class GET_p_ucp_get_BankStatements_Request : ICallProcedureModel<GET_p_ucp_get_BankStatements_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_BankStatements_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_BankStatements_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор банковского счета
		/// <para/>
		/// BankAccountID
		/// </summary>
		public global::System.Int32? Bac_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// DateFrom
		/// </summary>
		public global::System.DateTime? DateFrom { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// DateTo
		/// </summary>
		public global::System.DateTime? DateTo { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// If-Modified-Since
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Page
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortColumn
		/// </summary>
		public global::System.String SortColumn { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortDirection
		/// </summary>
		public global::System.String SortDirection { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_BankStatements_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_BankStatements_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_BankStatements";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Bac_ID, (v) => this.Bac_ID = (global::System.Int32?)v) /*--BankAccountID--*/
			{
				Name = "Bac_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateFrom, (v) => this.DateFrom = (global::System.DateTime?)v) /*--DateFrom--*/
			{
				Name = "DateFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateFrom,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DateTo, (v) => this.DateTo = (global::System.DateTime?)v) /*--DateTo--*/
			{
				Name = "DateTo",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateTo,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--If-Modified-Since--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--Page--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.SortColumn, (v) => this.SortColumn = (global::System.String)v) /*--SortColumn--*/
			{
				Name = "SortColumn",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortColumn,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SortDirection, (v) => this.SortDirection = (global::System.String)v) /*--SortDirection--*/
			{
				Name = "SortDirection",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortDirection,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_BankStatements_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// If-Modified-Since
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_BankStatements_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Счет отправителя платежа, соответствует полю  BANK_ACCOUNT_TEXT таблицы CE.CE_STATEMENT_LINES
		/// <para/>
		/// BankAccountNumberFrom
		/// </summary>
		public global::System.String accountfrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// Сумма платежа. Сумма в ГРН с копейками
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// ID банковского счета, соответствует полю CE.CE_STATEMENT_HEADERS_ALL.BANK_ACCOUNT_ID
		/// <para/>
		/// BankAccountExternalID
		/// </summary>
		public global::System.Int32? bank_account_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер банковского счета компании, на который поступил платеж
		/// <para/>
		/// BankAccountNumberTo
		/// </summary>
		public global::System.String bank_account_num { get; set; } /*OUTPUT*/
			/// <summary>
		/// ID банковской выписки
		/// <para/>
		/// pre_ExternalID
		/// </summary>
		public global::System.Int32? bank_st_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер платежного поручения
		/// <para/>
		/// PaymentOrder
		/// </summary>
		public global::System.String bank_trx_number { get; set; } /*OUTPUT*/
			/// <summary>
		/// Название банковского счета, по которому получен платеж
		/// <para/>
		/// BankInternalCodeTo
		/// </summary>
		public global::System.String bankcode { get; set; } /*OUTPUT*/
			/// <summary>
		/// ID пачки платежей, которая находится на обработке в АРМ
		/// <para/>
		/// BatchID
		/// </summary>
		public global::System.Int32? batch_id { get; set; } /*OUTPUT*/
			/// <summary>
		/// Лицевой счет абонента
		/// <para/>
		/// acnt_Number
		/// </summary>
		public global::System.Int32? bill_acc { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// CreatedBy
		/// </summary>
		[Required]
		public global::System.Int32? created_by { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата создания записи в интерфейсной таблице
		/// <para/>
		/// EffectiveDate
		/// </summary>
		[Required]
		public global::System.DateTime? creation_date { get; set; } /*OUTPUT*/
			/// <summary>
		/// Код валюты
		/// <para/>
		/// crn_CodeISO
		/// </summary>
		public global::System.String currency_code { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата платежа
		/// <para/>
		/// PayDate
		/// </summary>
		public global::System.DateTime? date_doc { get; set; } /*OUTPUT*/
			/// <summary>
		/// Значение данного поля соответствует значению поля  DOC_ID из интерфейсной таблицы. Необходим уникальный индекс.
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? doc_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата обновления записи в интерфейсной таблице
		/// <para/>
		/// ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? last_update_date { get; set; } /*OUTPUT*/
			/// <summary>
		/// Пользователь обновивший запись
		/// <para/>
		/// ModifiedDBy
		/// </summary>
		[Required]
		public global::System.Int32? last_updated_by { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер выписки в биллинговой системе.
		/// <para/>
		/// pre_NumReestr
		/// </summary>
		public global::System.String list_num { get; set; } /*OUTPUT*/
			/// <summary>
		/// МФО банковского счета, на который поступил платеж
		/// <para/>
		/// BankCodeTo
		/// </summary>
		public global::System.String mfo { get; set; } /*OUTPUT*/
			/// <summary>
		/// МФО банка отправителя
		/// <para/>
		/// BankCodeFrom
		/// </summary>
		public global::System.String mfofrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование отправителя
		/// <para/>
		/// BankNameFrom
		/// </summary>
		public global::System.String namefrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// ОКПО отправителя
		/// <para/>
		/// BusinessUIDFrom
		/// </summary>
		public global::System.String okpofrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// org_id - идентификатор организации
		/// <para/>
		/// TenantID
		/// </summary>
		public global::System.Int32? org_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Номер заявки на покупки валюты
		/// <para/>
		/// RequestNumber
		/// </summary>
		public global::System.String req_num { get; set; } /*OUTPUT*/
			/// <summary>
		/// Статус строки интерфейса
		/// <para/>
		/// Status
		/// </summary>
		public global::System.Int32? status { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// StatusCode
		/// </summary>
		public global::System.String status_code { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// StatusName
		/// </summary>
		public global::System.String statusName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// Код транзакции при проведении операции покупки, продажи валюты
		/// <para/>
		/// TransactionCode
		/// </summary>
		public global::System.String trx_code { get; set; } /*OUTPUT*/
			/// <summary>
		/// Назначение платежа
		/// <para/>
		/// TransactionText
		/// </summary>
		public global::System.String trx_text { get; set; } /*OUTPUT*/
			/// <summary>
		/// Учетная запись, под которой запущена сессия активного процесса (sysprocesses)
		/// <para/>
		/// UserName
		/// </summary>
		public global::System.String userName { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [BillingTasks]
	[DocIgnore]
	public class SET_sp_set_BillingTasks_Request : ICallProcedureModel<SET_sp_set_BillingTasks_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_sp_set_BillingTasks_Request, object>>> expressions = 
			new List<Expression<Func<SET_sp_set_BillingTasks_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор биллинговой группы 
		/// <para/>
		/// GroupID
		/// </summary>
		public global::System.Int32? abn_grp_ID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Параметры выписки счетов
		/// <para/>
		/// Options
		/// </summary>
		public global::System.String opt_XmlData { get; set; } /*IN*/
			/// <summary>
		/// Перечень пакетов (биллинговых циклов) для выписки счетов
		/// <para/>
		/// PacketsIDs
		/// </summary>
		public global::System.String pkt_IDs { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор технической услуги ""выписка счета
		/// <para/>
		/// ServiceID
		/// </summary>
		public global::System.Int32? srv_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор технической услуги ""куммулятивная выписка счета
		/// <para/>
		/// ServiceIDAccumulative
		/// </summary>
		public global::System.Int32? srv_ID_Accumulative { get; set; } /*IN*/
			/// <summary>
		/// Формат данных параметров выписки счетов
		/// <para/>
		/// DataFormat
		/// </summary>
		public global::System.String DataFormat { get; set; } /*IN*/
			/// <summary>
		/// Дата проведения биллинга (в случае вызова для ЛС - внеочередного) 
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Признак прекратить пакетную выписку счетов после первой ошибки
		/// <para/>
		/// ExitAfterFirstError
		/// </summary>
		public global::System.Int32? ExitAfterFirstError { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cacheStatus
		/// </summary>
		public global::System.String cacheStatus { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор задачи
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int64? Tsk_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// srs_ID_list
		/// </summary>
		public global::System.String srs_ID_list { get; set; } /*IN*/
			/// <summary>
		/// Код задачи
		/// <para/>
		/// Tsst_Code
		/// </summary>
		public global::System.String Tsst_Code { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_sp_set_BillingTasks_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Tsk_ID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_sp_set_BillingTasks_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "sp_set_BillingTasks";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_grp_ID, (v) => this.abn_grp_ID = (global::System.Int32?)v) /*--GroupID--*/
			{
				Name = "abn_grp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_grp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.opt_XmlData, (v) => this.opt_XmlData = (global::System.String)v) /*--Options--*/
			{
				Name = "opt_XmlData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.opt_XmlData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.pkt_IDs, (v) => this.pkt_IDs = (global::System.String)v) /*--PacketsIDs--*/
			{
				Name = "pkt_IDs",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.pkt_IDs,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srv_ID, (v) => this.srv_ID = (global::System.Int32?)v) /*--ServiceID--*/
			{
				Name = "srv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.srv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.srv_ID_Accumulative, (v) => this.srv_ID_Accumulative = (global::System.Int32?)v) /*--ServiceIDAccumulative--*/
			{
				Name = "srv_ID_Accumulative",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.srv_ID_Accumulative,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DataFormat, (v) => this.DataFormat = (global::System.String)v) /*--DataFormat--*/
			{
				Name = "DataFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DataFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ExitAfterFirstError, (v) => this.ExitAfterFirstError = (global::System.Int32?)v) /*--ExitAfterFirstError--*/
			{
				Name = "ExitAfterFirstError",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExitAfterFirstError,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.cacheStatus, (v) => this.cacheStatus = (global::System.String)v) /*--cacheStatus--*/
			{
				Name = "cacheStatus",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cacheStatus,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tsk_ID, (v) => this.Tsk_ID = (global::System.Int64?)v) /*--ID--*/
			{
				Name = "Tsk_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Tsk_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srs_ID_list, (v) => this.srs_ID_list = (global::System.String)v) /*--srs_ID_list--*/
			{
				Name = "srs_ID_list",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.srs_ID_list,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tsst_Code, (v) => this.Tsst_Code = (global::System.String)v) /*--Tsst_Code--*/
			{
				Name = "Tsst_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tsst_Code,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_sp_set_BillingTasks_Response : ICallProcedureModel<SET_sp_set_BillingTasks_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_sp_set_BillingTasks_Response, object>>> expressions = 
			new List<Expression<Func<SET_sp_set_BillingTasks_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор задачи
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int64? Tsk_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_sp_set_BillingTasks_Response()
		{
			expressions.Add((m) => m.Tsk_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_sp_set_BillingTasks_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "sp_set_BillingTasks";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Tsk_ID, (v) => this.Tsk_ID = (global::System.Int64?)v) /*--ID--*/
			{
				Name = "Tsk_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Tsk_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [CallCredits]
	[DocIgnore]
	public class SET_p_ucp_set_DiscountValue4Subscriber_Request : ICallProcedureModel<SET_p_ucp_set_DiscountValue4Subscriber_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_DiscountValue4Subscriber_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_DiscountValue4Subscriber_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор формы скидки
		/// <para/>
		/// DiscountForm
		/// </summary>
		public global::System.Int32? DiscountForm { get; set; } /*IN*/
			/// <summary>
		/// Параметры формы скидки
		/// <para/>
		/// DiscountFormParam
		/// </summary>
		public global::System.Decimal? DiscountFormParam { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор скидки
		/// <para/>
		/// DiscountID
		/// </summary>
		public global::System.Int32? dsc_ID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String dsvs_ModifiedBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String dsvs_ModifiedFrom { get; set; } /*IN*/
			/// <summary>
		/// Признак закрытия действия скидки с указанной даты DateSet
		/// <para/>
		/// isAnnul
		/// </summary>
		public global::System.Int32? isAnnul { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменений
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Дата установки изменений (начала действия или окончания)
		/// <para/>
		/// DateSet
		/// </summary>
		public global::System.DateTime? DateSet { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор исторической связки абонента и скидки
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? dab_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_DiscountValue4Subscriber_Request()
		{
			expressions.Add((m) => m.dab_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_DiscountValue4Subscriber_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_DiscountValue4Subscriber";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.DiscountForm, (v) => this.DiscountForm = (global::System.Int32?)v) /*--DiscountForm--*/
			{
				Name = "DiscountForm",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DiscountForm,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DiscountFormParam, (v) => this.DiscountFormParam = (global::System.Decimal?)v) /*--DiscountFormParam--*/
			{
				Name = "DiscountFormParam",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DiscountFormParam,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.dsc_ID, (v) => this.dsc_ID = (global::System.Int32?)v) /*--DiscountID--*/
			{
				Name = "dsc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dsc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dsvs_ModifiedBy, (v) => this.dsvs_ModifiedBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "dsvs_ModifiedBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dsvs_ModifiedBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.dsvs_ModifiedFrom, (v) => this.dsvs_ModifiedFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "dsvs_ModifiedFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dsvs_ModifiedFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.isAnnul, (v) => this.isAnnul = (global::System.Int32?)v) /*--isAnnul--*/
			{
				Name = "isAnnul",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.isAnnul,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateSet, (v) => this.DateSet = (global::System.DateTime?)v) /*--DateSet--*/
			{
				Name = "DateSet",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateSet,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dab_ID, (v) => this.dab_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "dab_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.dab_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_DiscountValue4Subscriber_Response : ICallProcedureModel<SET_p_ucp_set_DiscountValue4Subscriber_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_DiscountValue4Subscriber_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_DiscountValue4Subscriber_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Уникальный идентификатор исторической связки абонента и скидки
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? dab_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_DiscountValue4Subscriber_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.dab_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_DiscountValue4Subscriber_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_DiscountValue4Subscriber";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.dab_ID, (v) => this.dab_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "dab_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.dab_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [CallUserGroups]
	[DocIgnore]
	public class SET_p_ucp_set_CodeRegionGroups_Request : ICallProcedureModel<SET_p_ucp_set_CodeRegionGroups_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CodeRegionGroups_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CodeRegionGroups_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата окончания действия Закрытой абонентской группы
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? Crg_DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия Закрытой абонентской группы
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? Crg_DateStart { get; set; } /*IN*/
			/// <summary>
		/// Приоритет Закрытой абонентской группы
		/// <para/>
		/// Priority
		/// </summary>
		public global::System.Int32? Crg_Order { get; set; } /*IN*/
			/// <summary>
		/// Перечень возможных префиксов для набора номеров в Закрытой абонентской группе
		/// <para/>
		/// Prefixes
		/// </summary>
		public global::System.String Crg_Prefixes { get; set; } /*IN*/
			/// <summary>
		/// Название Закрытой абонентской группы
		/// <para/>
		/// Name
		/// </summary>
		public global::System.String Crg_RegionName { get; set; } /*IN*/
			/// <summary>
		/// Уникальный код Закрытой абонентской группы
		/// <para/>
		/// Code
		/// </summary>
		public global::System.String Crg_RegionNameEN { get; set; } /*IN*/
			/// <summary>
		/// Набор динамических типов, используемых для данной группы 
		/// <para/>
		/// Options
		/// </summary>
		public global::System.String Crgo_Options { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Категория Закрытой группы (односторонняя, двусторонняя и т.д.)
		/// <para/>
		/// Type
		/// </summary>
		public global::System.Int32? Type { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Закрытой абонентской группы
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Crg_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Crg_Default
		/// </summary>
		public global::System.Int32? Crg_Default { get; set; } /*IN*/
			/// <summary>
		/// Признак, что зона содержит лишь уникальные коды (т.е. не входящие в др.зоны)
		/// <para/>
		/// Crg_IsUniqueCodes
		/// </summary>
		public global::System.Int32? Crg_IsUniqueCodes { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа типа внешней зоны. Связь с CodeRegionTypes
		/// <para/>
		/// Crgt_ID
		/// </summary>
		public global::System.Int32? Crgt_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// RegionNameEN
		/// </summary>
		public global::System.String RegionNameEN { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// RegionNameRU
		/// </summary>
		public global::System.String RegionNameRU { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// RegionNameUK
		/// </summary>
		public global::System.String RegionNameUK { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_CodeRegionGroups_Request()
		{
			expressions.Add((m) => m.Crg_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CodeRegionGroups_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CodeRegionGroups";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Crg_DateEnd, (v) => this.Crg_DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "Crg_DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Crg_DateStart, (v) => this.Crg_DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "Crg_DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Crg_Order, (v) => this.Crg_Order = (global::System.Int32?)v) /*--Priority--*/
			{
				Name = "Crg_Order",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_Order,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crg_Prefixes, (v) => this.Crg_Prefixes = (global::System.String)v) /*--Prefixes--*/
			{
				Name = "Crg_Prefixes",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_Prefixes,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crg_RegionName, (v) => this.Crg_RegionName = (global::System.String)v) /*--Name--*/
			{
				Name = "Crg_RegionName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_RegionName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crg_RegionNameEN, (v) => this.Crg_RegionNameEN = (global::System.String)v) /*--Code--*/
			{
				Name = "Crg_RegionNameEN",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_RegionNameEN,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crgo_Options, (v) => this.Crgo_Options = (global::System.String)v) /*--Options--*/
			{
				Name = "Crgo_Options",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crgo_Options,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Type, (v) => this.Type = (global::System.Int32?)v) /*--Type--*/
			{
				Name = "Type",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Type,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crg_ID, (v) => this.Crg_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Crg_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Crg_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crg_Default, (v) => this.Crg_Default = (global::System.Int32?)v) /*--Crg_Default--*/
			{
				Name = "Crg_Default",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_Default,
				DBType = System.Data.DbType.Int16
			};
			yield return new DynamicParameter(() => this.Crg_IsUniqueCodes, (v) => this.Crg_IsUniqueCodes = (global::System.Int32?)v) /*--Crg_IsUniqueCodes--*/
			{
				Name = "Crg_IsUniqueCodes",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_IsUniqueCodes,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crgt_ID, (v) => this.Crgt_ID = (global::System.Int32?)v) /*--Crgt_ID--*/
			{
				Name = "Crgt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crgt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.RegionNameEN, (v) => this.RegionNameEN = (global::System.String)v) /*--RegionNameEN--*/
			{
				Name = "RegionNameEN",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.RegionNameEN,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.RegionNameRU, (v) => this.RegionNameRU = (global::System.String)v) /*--RegionNameRU--*/
			{
				Name = "RegionNameRU",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.RegionNameRU,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.RegionNameUK, (v) => this.RegionNameUK = (global::System.String)v) /*--RegionNameUK--*/
			{
				Name = "RegionNameUK",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.RegionNameUK,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_CodeRegionGroups_Response : ICallProcedureModel<SET_p_ucp_set_CodeRegionGroups_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CodeRegionGroups_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CodeRegionGroups_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор Закрытой абонентской группы
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Crg_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_CodeRegionGroups_Response()
		{
			expressions.Add((m) => m.Crg_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CodeRegionGroups_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CodeRegionGroups";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Crg_ID, (v) => this.Crg_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Crg_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Crg_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Contracts]
	[DocIgnore]
	public class SET_p_ucp_set_Contracts_Request : ICallProcedureModel<SET_p_ucp_set_Contracts_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Contracts_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Contracts_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Формат данных дополнительных аттрибутов договора
		/// <para/>
		/// DataFormat
		/// </summary>
		public global::System.String DataFormat { get; set; } /*IN*/
			/// <summary>
		/// зарезервировано
		/// <para/>
		/// AuthCodeID
		/// </summary>
		public global::System.Int32? aut_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор класса Договора
		/// <para/>
		/// ClassID
		/// </summary>
		public global::System.Int32? cntc_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор категории Договора
		/// <para/>
		/// CategoryID
		/// </summary>
		public global::System.Int32? cntg_ID { get; set; } /*IN*/
			/// <summary>
		/// Сумма Договора
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? cntr_Amount { get; set; } /*IN*/
			/// <summary>
		/// Дата подписания или начала действия Договора
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? cntr_DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Срок действия Договора
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? cntr_DateStart { get; set; } /*IN*/
			/// <summary>
		/// Внешний Идентификатор Договора
		/// <para/>
		/// ExternalID
		/// </summary>
		public global::System.Int32? cntr_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// JsonData
		/// </summary>
		public global::System.String cntr_JsonData { get; set; } /*IN*/
			/// <summary>
		/// Номер Договора
		/// <para/>
		/// Name
		/// </summary>
		public global::System.String cntr_Name { get; set; } /*IN*/
			/// <summary>
		/// Признак Первичного Договора
		/// <para/>
		/// Primary
		/// </summary>
		public global::System.Int32? cntr_Primary { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String cntr_Remark { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор статуса Договора
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? cnts_ID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Extentions (Номера MSISDN), который выдан согласно Договора 
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? ext_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Код внешней системы - инициатора запроса
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Клиента (узла типа Customers) или Идентификатор Ассоциации
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Договора
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? cntr_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_Contracts_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.cntr_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Contracts_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Contracts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.DataFormat, (v) => this.DataFormat = (global::System.String)v) /*--DataFormat--*/
			{
				Name = "DataFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DataFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aut_ID, (v) => this.aut_ID = (global::System.Int32?)v) /*--AuthCodeID--*/
			{
				Name = "aut_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.cntc_ID, (v) => this.cntc_ID = (global::System.Int32?)v) /*--ClassID--*/
			{
				Name = "cntc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.cntg_ID, (v) => this.cntg_ID = (global::System.Int32?)v) /*--CategoryID--*/
			{
				Name = "cntg_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntg_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.cntr_Amount, (v) => this.cntr_Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "cntr_Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.cntr_DateEnd, (v) => this.cntr_DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "cntr_DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.cntr_DateStart, (v) => this.cntr_DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "cntr_DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.cntr_ExternalID, (v) => this.cntr_ExternalID = (global::System.Int32?)v) /*--ExternalID--*/
			{
				Name = "cntr_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.cntr_JsonData, (v) => this.cntr_JsonData = (global::System.String)v) /*--JsonData--*/
			{
				Name = "cntr_JsonData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_JsonData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.cntr_Name, (v) => this.cntr_Name = (global::System.String)v) /*--Name--*/
			{
				Name = "cntr_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.cntr_Primary, (v) => this.cntr_Primary = (global::System.Int32?)v) /*--Primary--*/
			{
				Name = "cntr_Primary",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_Primary,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.cntr_Remark, (v) => this.cntr_Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "cntr_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cntr_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.cnts_ID, (v) => this.cnts_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "cnts_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cnts_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ext_ID, (v) => this.ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "ext_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.cntr_ID, (v) => this.cntr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "cntr_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.cntr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_Contracts_Response : ICallProcedureModel<SET_p_ucp_set_Contracts_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Contracts_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Contracts_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор Договора
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? cntr_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_Contracts_Response()
		{
			expressions.Add((m) => m.cntr_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Contracts_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Contracts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.cntr_ID, (v) => this.cntr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "cntr_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.cntr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [CustomerPayments]
	[DocIgnore]
	public class GET_p_ucp_get_CustomerPayments_Request : ICallProcedureModel<GET_p_ucp_get_CustomerPayments_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_CustomerPayments_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_CustomerPayments_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// CustomerID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Явное указание суммы подписки - для переопределения цены пакета в случае использования FMC подписок (сумма списания на основании суммы платежа)
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.String Amount { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// AmountFrom
		/// </summary>
		public global::System.Decimal? AmountFrom { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// AmountTo
		/// </summary>
		public global::System.Decimal? AmountTo { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор расчетного банковского счета (для безналичніх платежных документов)
		/// <para/>
		/// BankAccountID
		/// </summary>
		public global::System.Int32? Bac_ID { get; set; } /*IN*/
			/// <summary>
		/// Национальный код банка (МФО, БИК, BLZ, sort code, ABA RTN)
		/// <para/>
		/// BankCode
		/// </summary>
		public global::System.String Bnk_BankCode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// KassaRemark
		/// </summary>
		public global::System.String Cof_Remark { get; set; } /*IN*/
			/// <summary>
		/// Признак аннулирования платежа
		/// <para/>
		/// Annul
		/// </summary>
		public global::System.Int32? Cpay_Annul { get; set; } /*IN*/
			/// <summary>
		/// Внутренний идентификатор разнесенного платежа клиента (суммы на Лицевом счету)
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int64? Cpay_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Cpay_Remark { get; set; } /*IN*/
			/// <summary>
		/// Класс платежа
		/// <para/>
		/// PayClass
		/// </summary>
		public global::System.Int32? Cpc_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.String Cpd_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Номер платежного документа (номер чека или платежки)
		/// <para/>
		/// PayDocNumber
		/// </summary>
		public global::System.String Cpd_PayDocNumber { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Платежного интерфейса 
		/// <para/>
		/// PayInterfaceID
		/// </summary>
		public global::System.Int32? Cpif_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayInterfaceName
		/// </summary>
		public global::System.String Cpifd_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// DateFrom
		/// </summary>
		public global::System.DateTime? DateFrom { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// DateTo
		/// </summary>
		public global::System.DateTime? DateTo { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageNumber
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
			/// <summary>
		/// Номер реестра (для кассовых) или банковской выписки (для безналичных платежных документов)
		/// <para/>
		/// ReestrNumber
		/// </summary>
		public global::System.String Pre_NumReestr { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор причины корректировки баланса. Ссылка на AccountAdjustReasons
		/// <para/>
		/// aar_ID
		/// </summary>
		public global::System.Int32? aar_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortColumn
		/// </summary>
		public global::System.String SortColumn { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortDirection
		/// </summary>
		public global::System.String SortDirection { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsExternalSync
		/// </summary>
		public global::System.Int32? IsExternalSync { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_CustomerPayments_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_CustomerPayments_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_CustomerPayments";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--CustomerID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Amount, (v) => this.Amount = (global::System.String)v) /*--Amount--*/
			{
				Name = "Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Amount,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.AmountFrom, (v) => this.AmountFrom = (global::System.Decimal?)v) /*--AmountFrom--*/
			{
				Name = "AmountFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.AmountFrom,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.AmountTo, (v) => this.AmountTo = (global::System.Decimal?)v) /*--AmountTo--*/
			{
				Name = "AmountTo",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.AmountTo,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Bac_ID, (v) => this.Bac_ID = (global::System.Int32?)v) /*--BankAccountID--*/
			{
				Name = "Bac_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Bnk_BankCode, (v) => this.Bnk_BankCode = (global::System.String)v) /*--BankCode--*/
			{
				Name = "Bnk_BankCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bnk_BankCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cof_Remark, (v) => this.Cof_Remark = (global::System.String)v) /*--KassaRemark--*/
			{
				Name = "Cof_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cof_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpay_Annul, (v) => this.Cpay_Annul = (global::System.Int32?)v) /*--Annul--*/
			{
				Name = "Cpay_Annul",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpay_Annul,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpay_ID, (v) => this.Cpay_ID = (global::System.Int64?)v) /*--ID--*/
			{
				Name = "Cpay_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpay_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.Cpay_Remark, (v) => this.Cpay_Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Cpay_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpay_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpc_ID, (v) => this.Cpc_ID = (global::System.Int32?)v) /*--PayClass--*/
			{
				Name = "Cpc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpd_ExternalID, (v) => this.Cpd_ExternalID = (global::System.String)v) /*--ParentID--*/
			{
				Name = "Cpd_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_ExternalID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpd_PayDocNumber, (v) => this.Cpd_PayDocNumber = (global::System.String)v) /*--PayDocNumber--*/
			{
				Name = "Cpd_PayDocNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_PayDocNumber,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpif_ID, (v) => this.Cpif_ID = (global::System.Int32?)v) /*--PayInterfaceID--*/
			{
				Name = "Cpif_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpif_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpifd_Name, (v) => this.Cpifd_Name = (global::System.String)v) /*--PayInterfaceName--*/
			{
				Name = "Cpifd_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpifd_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateFrom, (v) => this.DateFrom = (global::System.DateTime?)v) /*--DateFrom--*/
			{
				Name = "DateFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateFrom,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.DateTo, (v) => this.DateTo = (global::System.DateTime?)v) /*--DateTo--*/
			{
				Name = "DateTo",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateTo,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--CacheControlDate--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageNumber--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pre_NumReestr, (v) => this.Pre_NumReestr = (global::System.String)v) /*--ReestrNumber--*/
			{
				Name = "Pre_NumReestr",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pre_NumReestr,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aar_ID, (v) => this.aar_ID = (global::System.Int32?)v) /*--aar_ID--*/
			{
				Name = "aar_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aar_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.SortColumn, (v) => this.SortColumn = (global::System.String)v) /*--SortColumn--*/
			{
				Name = "SortColumn",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortColumn,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SortDirection, (v) => this.SortDirection = (global::System.String)v) /*--SortDirection--*/
			{
				Name = "SortDirection",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortDirection,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalSync, (v) => this.IsExternalSync = (global::System.Int32?)v) /*--IsExternalSync--*/
			{
				Name = "IsExternalSync",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalSync,
				DBType = System.Data.DbType.Int32
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_CustomerPayments_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_CustomerPayments_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// Moved
		/// </summary>
		[Required]
		public global::System.Int32? cpd_Moved { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayDocNumber
		/// </summary>
		public global::System.String cpd_PayDocNumber { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayINN
		/// </summary>
		[Required]
		public global::System.String cpd_PayINN { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayInterfaceID
		/// </summary>
		public global::System.Int32? cpif_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayInterfaceName
		/// </summary>
		public global::System.String cpifd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// currency_Name
		/// </summary>
		[Required]
		public global::System.String currency_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// customer_Name
		/// </summary>
		[Required]
		public global::System.String customer_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsPayDoc
		/// </summary>
		[Required]
		public global::System.Int32? IsPayDoc { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ReestrDate
		/// </summary>
		[Required]
		public global::System.DateTime? pre_DateReestr { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ReestrNumber
		/// </summary>
		public global::System.String pre_NumReestr { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BankAccountNumber
		/// </summary>
		[Required]
		public global::System.String bac_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BillDateCreate
		/// </summary>
		[Required]
		public global::System.DateTime? bll_DateCreate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BillNumber
		/// </summary>
		[Required]
		public global::System.String bll_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BankName
		/// </summary>
		[Required]
		public global::System.String bnkd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// KassaRemark
		/// </summary>
		public global::System.String cof_Remark { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Account
		/// </summary>
		[Required]
		public global::System.String cpay_Account { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpay_Amount
		/// </summary>
		[Required]
		public global::System.Decimal? cpay_Amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpay_AmountTaxes
		/// </summary>
		[Required]
		public global::System.Decimal? cpay_AmountTaxes { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Annul
		/// </summary>
		public global::System.Int32? cpay_Annul { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// DatePay
		/// </summary>
		[Required]
		public global::System.DateTime? cpay_DatePay { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpay_ExternalID
		/// </summary>
		[Required]
		public global::System.String cpay_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpay_ID
		/// </summary>
		public global::System.Int64? cpay_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		[Required]
		public global::System.String cpay_ModifiedBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата изменения записи
		/// <para/>
		/// ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? cpay_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String cpay_Remark { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// RemoveBy
		/// </summary>
		[Required]
		public global::System.String cpay_RemoveBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// RemoveDate
		/// </summary>
		[Required]
		public global::System.DateTime? cpay_RemoveDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayClassCode
		/// </summary>
		[Required]
		public global::System.String cpc_Code { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayClass
		/// </summary>
		public global::System.Int32? cpc_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PayClassName
		/// </summary>
		[Required]
		public global::System.String cpcd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpd_Amount
		/// </summary>
		[Required]
		public global::System.Decimal? cpd_Amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// DealerId
		/// </summary>
		[Required]
		public global::System.Int32? cpd_DealerId { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// DesAccount
		/// </summary>
		[Required]
		public global::System.String cpd_DesAccount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// DesContract
		/// </summary>
		[Required]
		public global::System.String cpd_DesContract { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// DesPhone
		/// </summary>
		[Required]
		public global::System.String cpd_DesPhone { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.String cpd_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		[Required]
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// Ошибка внешней синхронизации
		/// <para/>
		/// cpay_ExternalError
		/// </summary>
		public global::System.String cpay_ExternalError { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cps_Code
		/// </summary>
		public global::System.String cps_Code { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cps_ID
		/// </summary>
		[Required]
		public global::System.Int32? cps_ID { get; set; } /*OUTPUT*/
#endregion
	}
	[DocIgnore]
	public class SET_p_ucp_set_CustomerPayments_Request : ICallProcedureModel<SET_p_ucp_set_CustomerPayments_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CustomerPayments_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CustomerPayments_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата разнесенного платежа, может не совпадать с датой платежного документа
		/// <para/>
		/// DatePay
		/// </summary>
		public global::System.DateTime? Cpay_DatePay { get; set; } /*IN*/
			/// <summary>
		/// Класс платежа
		/// <para/>
		/// PayClass
		/// </summary>
		public global::System.Int32? Cpc_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер лицевого счета, переопределяет значение CustomerID
		/// <para/>
		/// AccountNumber
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// Сумма платежа, включая все налоги Лицевого счета
		/// <para/>
		/// Amount
		/// </summary>
		[Required]
		public global::System.Decimal? Cpay_Amount { get; set; } /*IN*/
			/// <summary>
		/// Комментарий к платежу, обязателен при аннулировании
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Сpay_Remark { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор платежного документа в спец. формате (20 символов), включающем в себя код системы, генерирующий платежный документ
		/// <para/>
		/// PayDocID
		/// </summary>
		public global::System.String Cpd_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Признак разделения сумм аванса и сумм погашения инвойсов из указанной суммы Amount
		/// <para/>
		/// AllocateAmount
		/// </summary>
		public global::System.Int32? Redistribution { get; set; } /*IN*/
			/// <summary>
		/// Внутренний ID инвойса для погашения
		/// <para/>
		/// InvoiceID
		/// </summary>
		public global::System.Int32? Pinv_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер инвойса для погашения
		/// <para/>
		/// InvoiceNumber
		/// </summary>
		public global::System.String Pinv_Number { get; set; } /*IN*/
			/// <summary>
		/// Признак аннулирования платежа
		/// <para/>
		/// Annul
		/// </summary>
		public global::System.Int32? Cpay_Annul { get; set; } /*IN*/
			/// <summary>
		/// Кем аннулирован платеж (имя пользователя из контекста приложения)
		/// <para/>
		/// RemoveBy
		/// </summary>
		public global::System.String Сpay_RemoveBy { get; set; } /*IN*/
			/// <summary>
		/// Откуда было сделано аннулирование (IP-адрес или имя компьютера из контекста приложения)
		/// <para/>
		/// RemoveFrom
		/// </summary>
		public global::System.String Сpay_RemoveFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор платежного интерфейса
		/// <para/>
		/// PayInterfaceID
		/// </summary>
		[Required]
		public global::System.Int32? Cpif_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Диллера из внешней системы
		/// <para/>
		/// DealerID
		/// </summary>
		public global::System.Int32? Dlr_ID { get; set; } /*IN*/
			/// <summary>
		/// Код внешней системы
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор платежа в спец. формате (20 символов), включающем в себя код системы, генерирующий платежный документ
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String Cpay_ExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор Клиента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Внутренний идентификатор разнесенного платежа клиента (суммы на Лицевом счету)
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int64? Cpay_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsDenyPayOff
		/// </summary>
		public global::System.Int32? IsDenyPayOff { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_CustomerPayments_Request()
		{
			expressions.Add((m) => m.Cpay_ExternalID); // INOUT
			expressions.Add((m) => m.Cpay_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CustomerPayments_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CustomerPayments";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Cpay_DatePay, (v) => this.Cpay_DatePay = (global::System.DateTime?)v) /*--DatePay--*/
			{
				Name = "Cpay_DatePay",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpay_DatePay,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Cpc_ID, (v) => this.Cpc_ID = (global::System.Int32?)v) /*--PayClass--*/
			{
				Name = "Cpc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--AccountNumber--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpay_Amount, (v) => this.Cpay_Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Cpay_Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpay_Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Сpay_Remark, (v) => this.Сpay_Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Сpay_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Сpay_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpd_ExternalID, (v) => this.Cpd_ExternalID = (global::System.String)v) /*--PayDocID--*/
			{
				Name = "Cpd_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_ExternalID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Redistribution, (v) => this.Redistribution = (global::System.Int32?)v) /*--AllocateAmount--*/
			{
				Name = "Redistribution",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Redistribution,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pinv_ID, (v) => this.Pinv_ID = (global::System.Int32?)v) /*--InvoiceID--*/
			{
				Name = "Pinv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pinv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pinv_Number, (v) => this.Pinv_Number = (global::System.String)v) /*--InvoiceNumber--*/
			{
				Name = "Pinv_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pinv_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpay_Annul, (v) => this.Cpay_Annul = (global::System.Int32?)v) /*--Annul--*/
			{
				Name = "Cpay_Annul",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpay_Annul,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Сpay_RemoveBy, (v) => this.Сpay_RemoveBy = (global::System.String)v) /*--RemoveBy--*/
			{
				Name = "Сpay_RemoveBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Сpay_RemoveBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Сpay_RemoveFrom, (v) => this.Сpay_RemoveFrom = (global::System.String)v) /*--RemoveFrom--*/
			{
				Name = "Сpay_RemoveFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Сpay_RemoveFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpif_ID, (v) => this.Cpif_ID = (global::System.Int32?)v) /*--PayInterfaceID--*/
			{
				Name = "Cpif_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpif_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Dlr_ID, (v) => this.Dlr_ID = (global::System.Int32?)v) /*--DealerID--*/
			{
				Name = "Dlr_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dlr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpay_ExternalID, (v) => this.Cpay_ExternalID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "Cpay_ExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Cpay_ExternalID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpay_ID, (v) => this.Cpay_ID = (global::System.Int64?)v) /*--ID--*/
			{
				Name = "Cpay_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Cpay_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsDenyPayOff, (v) => this.IsDenyPayOff = (global::System.Int32?)v) /*--IsDenyPayOff--*/
			{
				Name = "IsDenyPayOff",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsDenyPayOff,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_CustomerPayments_Response : ICallProcedureModel<SET_p_ucp_set_CustomerPayments_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CustomerPayments_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CustomerPayments_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Уникальный идентификатор платежа в спец. формате (20 символов), включающем в себя код системы, генерирующий платежный документ
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String Cpay_ExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Внутренний идентификатор разнесенного платежа клиента (суммы на Лицевом счету)
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int64? Cpay_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_CustomerPayments_Response()
		{
			expressions.Add((m) => m.Cpay_ExternalID); // OUT
			expressions.Add((m) => m.Cpay_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CustomerPayments_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CustomerPayments";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Cpay_ExternalID, (v) => this.Cpay_ExternalID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "Cpay_ExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Cpay_ExternalID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpay_ID, (v) => this.Cpay_ID = (global::System.Int64?)v) /*--ID--*/
			{
				Name = "Cpay_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Cpay_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [CustomerPayments/AllocatedPayments]
	[DocIgnore]
	public class GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request : ICallProcedureModel<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		public global::System.String acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// Признак разделения сумм аванса и сум погашения инвойсов из указанной суммы Amount
		/// <para/>
		/// AllocateAmount
		/// </summary>
		public global::System.Int32? Redistribution { get; set; } /*IN*/
			/// <summary>
		/// Явное указание суммы подписки - для переопределения цены пакета в случае использования FMC подписок (сумма списания на основании суммы платежа)
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? Amount { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// bll_Amount
		/// </summary>
		public global::System.Decimal? bll_Amount { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpd_ExportID
		/// </summary>
		public global::System.Int32? cpd_ExportID { get; set; } /*IN*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PromisedPayLogic
		/// </summary>
		public global::System.Int32? PromisedPayLogic { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_AllocatedPayments";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_WorkPlace, (v) => this.abn_WorkPlace = (global::System.String)v) /*--abn_WorkPlace--*/
			{
				Name = "abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.acnt_Number, (v) => this.acnt_Number = (global::System.String)v) /*--acnt_Number--*/
			{
				Name = "acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Redistribution, (v) => this.Redistribution = (global::System.Int32?)v) /*--AllocateAmount--*/
			{
				Name = "Redistribution",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Redistribution,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Amount, (v) => this.Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.bll_Amount, (v) => this.bll_Amount = (global::System.Decimal?)v) /*--bll_Amount--*/
			{
				Name = "bll_Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.bll_Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.cpd_ExportID, (v) => this.cpd_ExportID = (global::System.Int32?)v) /*--cpd_ExportID--*/
			{
				Name = "cpd_ExportID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cpd_ExportID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PromisedPayLogic, (v) => this.PromisedPayLogic = (global::System.Int32?)v) /*--PromisedPayLogic--*/
			{
				Name = "PromisedPayLogic",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PromisedPayLogic,
				DBType = System.Data.DbType.Int32
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// cpc_ID
		/// </summary>
		[Required]
		public global::System.Int32? cpc_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpif_ID
		/// </summary>
		[Required]
		public global::System.Int32? cpif_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpay_ID
		/// </summary>
		[Required]
		public global::System.Int32? cpay_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpay_ExternalID
		/// </summary>
		[Required]
		public global::System.String cpay_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpc_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? cpc_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpd_ExportedDate
		/// </summary>
		[Required]
		public global::System.DateTime? cpd_ExportedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpd_ExternalID
		/// </summary>
		[Required]
		public global::System.String cpd_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpd_Moved
		/// </summary>
		[Required]
		public global::System.Int32? cpd_Moved { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cpif_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? cpif_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// crn_CodeISO
		/// </summary>
		[Required]
		public global::System.String crn_CodeISO { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// divided_Amount
		/// </summary>
		[Required]
		public global::System.Decimal? divided_Amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// inv_One_String
		/// </summary>
		[Required]
		public global::System.String inv_One_String { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isBlocked
		/// </summary>
		[Required]
		public global::System.Int32? isBlocked { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// order_ID
		/// </summary>
		[Required]
		public global::System.Int64? order_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pinv_Amount
		/// </summary>
		[Required]
		public global::System.Decimal? pinv_Amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pinv_Date
		/// </summary>
		[Required]
		public global::System.DateTime? pinv_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pinv_ID
		/// </summary>
		[Required]
		public global::System.Int64? pinv_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pinv_Number
		/// </summary>
		[Required]
		public global::System.String pinv_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Retry
		/// </summary>
		[Required]
		public global::System.Int32? Retry { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String global_unique_id { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор результирующей таблицы, например, pkt_ID для Packets...
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int64? ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? ParentID { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [Customers]
	[DocIgnore]
	public class GET_p_ucp_get_Customers_Request : ICallProcedureModel<GET_p_ucp_get_Customers_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_Customers_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_Customers_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// Dls_ID
		/// </summary>
		public global::System.Int32? Dls_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_ID
		/// </summary>
		public global::System.Int32? com_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		public global::System.Int32? dep_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		public global::System.String ext_ExtNum { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Format
		/// </summary>
		public global::System.String Format { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		public global::System.Int32? grp_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFieldsName
		/// </summary>
		public global::System.String jsonFieldsName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFilter
		/// </summary>
		public global::System.String jsonFilter { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFilterContain
		/// </summary>
		public global::System.Int32? jsonFilterContain { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Lng_ID
		/// </summary>
		public global::System.Int32? Lng_ID { get; set; } /*IN*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// mode
		/// </summary>
		public global::System.Int32? mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Ntw_ID
		/// </summary>
		public global::System.Int32? Ntw_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageNumber
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
			/// <summary>
		/// Тип профиля
		/// <para/>
		/// ProfileType
		/// </summary>
		public global::System.Int32? ProfileType { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Rgsc_ID
		/// </summary>
		public global::System.Int32? Rgsc_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ShowBalances
		/// </summary>
		public global::System.Int32? ShowBalances { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ShowEntities
		/// </summary>
		public global::System.String ShowEntities { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortColumn
		/// </summary>
		public global::System.String SortColumn { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortDirection
		/// </summary>
		public global::System.String SortDirection { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Srv_ID
		/// </summary>
		public global::System.Int32? Srv_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Srv_Name
		/// </summary>
		public global::System.String Srv_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Sst_ID
		/// </summary>
		public global::System.Int32? Sst_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_Code
		/// </summary>
		public global::System.String tnst_Code { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		public global::System.Int32? trf_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		public global::System.String abn_Employee_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		public global::System.Int32? abn_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Ассоциации или корня 
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		public global::System.Int32? abn_IsExistAD { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Acat_ID
		/// </summary>
		public global::System.Int32? Acat_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Accl_ID
		/// </summary>
		public global::System.Int32? Accl_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Acnt_Number
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actp_ID
		/// </summary>
		public global::System.Int32? Actp_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Adlsb_Code
		/// </summary>
		public global::System.Int32? Adlsb_Code { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Aptp_ID
		/// </summary>
		public global::System.Int32? Aptp_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NameAuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Bac_Number
		/// </summary>
		public global::System.String Bac_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// bll_Number
		/// </summary>
		public global::System.String bll_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossLastName
		/// </summary>
		public global::System.String BossLastName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Cntr_Name
		/// </summary>
		public global::System.String Cntr_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// LastModifiedDate
		/// </summary>
		public global::System.DateTime? LastModifiedDate { get; set; } /*INOUT*/
#endregion

		#region ctor
		public GET_p_ucp_get_Customers_Request()
		{
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.LastModifiedDate); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_Customers_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_Customers";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Dls_ID, (v) => this.Dls_ID = (global::System.Int32?)v) /*--Dls_ID--*/
			{
				Name = "Dls_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dls_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.com_ID, (v) => this.com_ID = (global::System.Int32?)v) /*--com_ID--*/
			{
				Name = "com_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.com_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dep_ID, (v) => this.dep_ID = (global::System.Int32?)v) /*--dep_ID--*/
			{
				Name = "dep_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dep_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ext_ExtNum, (v) => this.ext_ExtNum = (global::System.String)v) /*--ext_ExtNum--*/
			{
				Name = "ext_ExtNum",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ext_ExtNum,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Format, (v) => this.Format = (global::System.String)v) /*--Format--*/
			{
				Name = "Format",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Format,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.grp_ID, (v) => this.grp_ID = (global::System.Int32?)v) /*--grp_ID--*/
			{
				Name = "grp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.grp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--CacheControlDate--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.jsonFieldsName, (v) => this.jsonFieldsName = (global::System.String)v) /*--jsonFieldsName--*/
			{
				Name = "jsonFieldsName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFieldsName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.jsonFilter, (v) => this.jsonFilter = (global::System.String)v) /*--jsonFilter--*/
			{
				Name = "jsonFilter",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFilter,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.jsonFilterContain, (v) => this.jsonFilterContain = (global::System.Int32?)v) /*--jsonFilterContain--*/
			{
				Name = "jsonFilterContain",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFilterContain,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lng_ID, (v) => this.Lng_ID = (global::System.Int32?)v) /*--Lng_ID--*/
			{
				Name = "Lng_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lng_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.mode, (v) => this.mode = (global::System.Int32?)v) /*--mode--*/
			{
				Name = "mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.mode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ntw_ID, (v) => this.Ntw_ID = (global::System.Int32?)v) /*--Ntw_ID--*/
			{
				Name = "Ntw_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ntw_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageNumber--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ProfileType, (v) => this.ProfileType = (global::System.Int32?)v) /*--ProfileType--*/
			{
				Name = "ProfileType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ProfileType,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Rgsc_ID, (v) => this.Rgsc_ID = (global::System.Int32?)v) /*--Rgsc_ID--*/
			{
				Name = "Rgsc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rgsc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ShowBalances, (v) => this.ShowBalances = (global::System.Int32?)v) /*--ShowBalances--*/
			{
				Name = "ShowBalances",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ShowBalances,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ShowEntities, (v) => this.ShowEntities = (global::System.String)v) /*--ShowEntities--*/
			{
				Name = "ShowEntities",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ShowEntities,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SortColumn, (v) => this.SortColumn = (global::System.String)v) /*--SortColumn--*/
			{
				Name = "SortColumn",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortColumn,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SortDirection, (v) => this.SortDirection = (global::System.String)v) /*--SortDirection--*/
			{
				Name = "SortDirection",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortDirection,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Srv_ID, (v) => this.Srv_ID = (global::System.Int32?)v) /*--Srv_ID--*/
			{
				Name = "Srv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srv_Name, (v) => this.Srv_Name = (global::System.String)v) /*--Srv_Name--*/
			{
				Name = "Srv_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sst_ID, (v) => this.Sst_ID = (global::System.Int32?)v) /*--Sst_ID--*/
			{
				Name = "Sst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.tnst_Code, (v) => this.tnst_Code = (global::System.String)v) /*--tnst_Code--*/
			{
				Name = "tnst_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.tnst_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.trf_ID, (v) => this.trf_ID = (global::System.Int32?)v) /*--trf_ID--*/
			{
				Name = "trf_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.trf_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_Employee_ID, (v) => this.abn_Employee_ID = (global::System.String)v) /*--abn_Employee_ID--*/
			{
				Name = "abn_Employee_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_Employee_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ExternalID, (v) => this.abn_ExternalID = (global::System.Int32?)v) /*--abn_ExternalID--*/
			{
				Name = "abn_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_ID_Boss, (v) => this.abn_ID_Boss = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID_Boss",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID_Boss,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_IsExistAD, (v) => this.abn_IsExistAD = (global::System.Int32?)v) /*--abn_IsExistAD--*/
			{
				Name = "abn_IsExistAD",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_IsExistAD,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_LastName, (v) => this.abn_LastName = (global::System.String)v) /*--abn_LastName--*/
			{
				Name = "abn_LastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_LastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_WorkPlace, (v) => this.abn_WorkPlace = (global::System.String)v) /*--abn_WorkPlace--*/
			{
				Name = "abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Acat_ID, (v) => this.Acat_ID = (global::System.Int32?)v) /*--Acat_ID--*/
			{
				Name = "Acat_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acat_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Accl_ID, (v) => this.Accl_ID = (global::System.Int32?)v) /*--Accl_ID--*/
			{
				Name = "Accl_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accl_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--Acnt_Number--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Actp_ID, (v) => this.Actp_ID = (global::System.Int32?)v) /*--Actp_ID--*/
			{
				Name = "Actp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Actp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Adlsb_Code, (v) => this.Adlsb_Code = (global::System.Int32?)v) /*--Adlsb_Code--*/
			{
				Name = "Adlsb_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Adlsb_Code,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aptp_ID, (v) => this.Aptp_ID = (global::System.Int32?)v) /*--Aptp_ID--*/
			{
				Name = "Aptp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aptp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.aut_NameAuthCode, (v) => this.aut_NameAuthCode = (global::System.String)v) /*--aut_NameAuthCode--*/
			{
				Name = "aut_NameAuthCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bac_Number, (v) => this.Bac_Number = (global::System.String)v) /*--Bac_Number--*/
			{
				Name = "Bac_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.bll_Number, (v) => this.bll_Number = (global::System.String)v) /*--bll_Number--*/
			{
				Name = "bll_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.bll_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.BossLastName, (v) => this.BossLastName = (global::System.String)v) /*--BossLastName--*/
			{
				Name = "BossLastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.BossLastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cntr_Name, (v) => this.Cntr_Name = (global::System.String)v) /*--Cntr_Name--*/
			{
				Name = "Cntr_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cntr_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.LastModifiedDate, (v) => this.LastModifiedDate = (global::System.DateTime?)v) /*--LastModifiedDate--*/
			{
				Name = "LastModifiedDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.LastModifiedDate,
				DBType = System.Data.DbType.DateTime
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_Customers_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// LastModifiedDate
		/// </summary>
		public global::System.DateTime? LastModifiedDate { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_Customers_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_AccountMandatory
		/// </summary>
		[Required]
		public global::System.Int32? tnt_AccountMandatory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TreeNodeType
		/// </summary>
		[Required]
		public global::System.String TreeNodeType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		public global::System.Int32? trf_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		public global::System.Int32? abn_IsExistAD { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsGuest
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsGuest { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Login
		/// </summary>
		[Required]
		public global::System.String abn_Login { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_MiddleName
		/// </summary>
		[Required]
		public global::System.String abn_MiddleName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedBy
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedFrom
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedFrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Left
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Left { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Right
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Right { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Password
		/// </summary>
		[Required]
		public global::System.String abn_Password { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_PositionCode
		/// </summary>
		[Required]
		public global::System.String abn_PositionCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ShowPhoneDirectory
		/// </summary>
		[Required]
		public global::System.Int32? abn_ShowPhoneDirectory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// AbonentFullName
		/// </summary>
		[Required]
		public global::System.String AbonentFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_IsPersonal
		/// </summary>
		[Required]
		public global::System.Int32? acnt_IsPersonal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number_Personal
		/// </summary>
		[Required]
		public global::System.String acnt_Number_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// actp_ID
		/// </summary>
		public global::System.Int32? actp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// actpd_Name
		/// </summary>
		[Required]
		public global::System.String actpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name_Personal
		/// </summary>
		[Required]
		public global::System.String Actpd_Name_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? aut_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NameAuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NumberAts
		/// </summary>
		[Required]
		public global::System.Int32? aut_NumberAts { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossFullName
		/// </summary>
		[Required]
		public global::System.String BossFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cntr_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? cntr_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cntr_Name
		/// </summary>
		public global::System.String cntr_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_Id
		/// </summary>
		public global::System.Int32? com_Id { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		public global::System.Int32? dep_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		public global::System.String ext_ExtNum { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? ext_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		public global::System.Int32? grp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_Name
		/// </summary>
		[Required]
		public global::System.String grp_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditAllow
		/// </summary>
		[Required]
		public global::System.Int32? isEditAllow { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditWorkPlace
		/// </summary>
		[Required]
		public global::System.Int32? isEditWorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// lng_ID
		/// </summary>
		public global::System.Int32? lng_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// loc_Name
		/// </summary>
		[Required]
		public global::System.String loc_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Location_ID
		/// </summary>
		[Required]
		public global::System.Int32? Location_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ntw_ID
		/// </summary>
		public global::System.Int32? ntw_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pbx_networkName
		/// </summary>
		[Required]
		public global::System.String pbx_networkName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ProfileType
		/// </summary>
		public global::System.Int32? ProfileType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// rptURL
		/// </summary>
		[Required]
		public global::System.String rptURL { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// SubsCount
		/// </summary>
		[Required]
		public global::System.Int32? SubsCount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abn_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_CreateDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_CreateDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abn_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employe_Export_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employe_Export_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		public global::System.String abn_Employee_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		public global::System.Int32? abn_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_FirstName
		/// </summary>
		[Required]
		public global::System.String abn_FirstName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Guid
		/// </summary>
		[Required]
		public global::System.Guid? abn_Guid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_HasNotEmptyPrepaid
		/// </summary>
		[Required]
		public global::System.Int32? abn_HasNotEmptyPrepaid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_id_boss
		/// </summary>
		[Required]
		public global::System.Int32? dep_id_boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_Name_boss
		/// </summary>
		[Required]
		public global::System.String dep_Name_boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isRefusalChangeName
		/// </summary>
		[Required]
		public global::System.Int32? isRefusalChangeName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// max_ModDate
		/// </summary>
		public global::System.DateTime? max_ModDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор причины версии
		/// <para/>
		/// vrr_ID
		/// </summary>
		[Required]
		public global::System.Int32? vrr_ID { get; set; } /*OUTPUT*/
#endregion
	}
	[DocIgnore]
	public class SET_p_ucp_set_Customers_Request : ICallProcedureModel<SET_p_ucp_set_Customers_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Customers_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Customers_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Язык общения с клиентом
		/// <para/>
		/// CustomerLanguageId
		/// </summary>
		public global::System.Int32? Lng_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор статуса узла дерева
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор сегмента
		/// <para/>
		/// SegmentID
		/// </summary>
		public global::System.Int32? Dep_ID { get; set; } /*IN*/
			/// <summary>
		/// Имя клиента Физ.лица (владельца лицевого счета)
		/// <para/>
		/// Customer_FirstName
		/// </summary>
		public global::System.String Abn_FirstName { get; set; } /*IN*/
			/// <summary>
		/// PositionCode для синхронизации иерархии узлов дерева
		/// <para/>
		/// PositionCode
		/// </summary>
		public global::System.String Abn_PositionCode { get; set; } /*IN*/
			/// <summary>
		/// Логин Клиента (в личный кабинет)
		/// <para/>
		/// CustomerLogin
		/// </summary>
		public global::System.String Abn_Login { get; set; } /*IN*/
			/// <summary>
		/// Отчество клиента Физ.лица (владельца лицевого счета) 
		/// <para/>
		/// Customer_MiddleName
		/// </summary>
		public global::System.String Abn_MiddleName { get; set; } /*IN*/
			/// <summary>
		/// Пароль клиента (личный кабинет)
		/// <para/>
		/// CustomerPassword
		/// </summary>
		public global::System.String Abn_Password { get; set; } /*IN*/
			/// <summary>
		/// Признак ""создание узла дерева не завершено
		/// <para/>
		/// IsCreatedWithTariffication
		/// </summary>
		public global::System.Int32? Abn_IsCreatedWithTariffication { get; set; } /*IN*/
			/// <summary>
		/// Признак узла дерева, исключенного из расчетов (техническая запись)
		/// <para/>
		/// TechnicalTag
		/// </summary>
		public global::System.Int32? Abn_ShowPhoneDirectory { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор для экспорта
		/// <para/>
		/// Export_ID
		/// </summary>
		public global::System.String Abn_Employe_Export_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный номер узла дерева для синхронизации с внешней системой
		/// <para/>
		/// SyncId
		/// </summary>
		public global::System.String Abn_Employee_ID { get; set; } /*IN*/
			/// <summary>
		/// Название (Наименование Юр.лица или ФИО) 
		/// <para/>
		/// Name
		/// </summary>
		[Required]
		public global::System.String Abn_LastName { get; set; } /*IN*/
			/// <summary>
		/// Дата с которой начинается отсчёт стажа клиента
		/// <para/>
		/// CustomerDate
		/// </summary>
		public global::System.DateTime? Abn_Date { get; set; } /*IN*/
			/// <summary>
		/// Признак выполнясть нормализацию дерева узлов
		/// <para/>
		/// isUpdateNodeTree
		/// </summary>
		public global::System.Int32? UpdateAbonentTree { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор для поиска
		/// <para/>
		/// Customer_SearchName
		/// </summary>
		public global::System.String Abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор биллинговой группы 
		/// <para/>
		/// GroupID
		/// </summary>
		public global::System.Int32? Grp_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер Филиала
		/// <para/>
		/// LocationID
		/// </summary>
		public global::System.Int32? Location_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Режим отладки (зарезервировано)
		/// <para/>
		/// DebugLevel
		/// </summary>
		public global::System.Int32? DebugLevel { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Тип профиля
		/// <para/>
		/// ProfileType
		/// </summary>
		[Required]
		public global::System.Int32? ProfileType { get; set; } /*IN*/
			/// <summary>
		/// Полное юридическое наименование 
		/// <para/>
		/// FullName
		/// </summary>
		public global::System.String Abn_FullName { get; set; } /*IN*/
			/// <summary>
		/// Короткое наименование
		/// <para/>
		/// ShortName
		/// </summary>
		public global::System.String Abn_ShortName { get; set; } /*IN*/
			/// <summary>
		/// Код диллера
		/// <para/>
		/// AgentCode
		/// </summary>
		public global::System.String Sag_Code { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор диллера
		/// <para/>
		/// AgentID
		/// </summary>
		public global::System.Int32? Sag_ID { get; set; } /*IN*/
			/// <summary>
		/// Код точки продаж
		/// <para/>
		/// SalesPointCode
		/// </summary>
		public global::System.String Pos_Code { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор точки продаж
		/// <para/>
		/// SalesPointID
		/// </summary>
		public global::System.Int32? Pos_ID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Стандарта 
		/// <para/>
		/// NetworkID
		/// </summary>
		public global::System.Int32? Ntw_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Ассоциации или корня 
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID_Boss { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Код внешней системы
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_Customers_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Abn_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Customers_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Customers";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lng_ID, (v) => this.Lng_ID = (global::System.Int32?)v) /*--CustomerLanguageId--*/
			{
				Name = "Lng_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lng_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Dep_ID, (v) => this.Dep_ID = (global::System.Int32?)v) /*--SegmentID--*/
			{
				Name = "Dep_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dep_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_FirstName, (v) => this.Abn_FirstName = (global::System.String)v) /*--Customer_FirstName--*/
			{
				Name = "Abn_FirstName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FirstName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_PositionCode, (v) => this.Abn_PositionCode = (global::System.String)v) /*--PositionCode--*/
			{
				Name = "Abn_PositionCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_PositionCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Login, (v) => this.Abn_Login = (global::System.String)v) /*--CustomerLogin--*/
			{
				Name = "Abn_Login",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Login,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_MiddleName, (v) => this.Abn_MiddleName = (global::System.String)v) /*--Customer_MiddleName--*/
			{
				Name = "Abn_MiddleName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_MiddleName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Password, (v) => this.Abn_Password = (global::System.String)v) /*--CustomerPassword--*/
			{
				Name = "Abn_Password",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Password,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_IsCreatedWithTariffication, (v) => this.Abn_IsCreatedWithTariffication = (global::System.Int32?)v) /*--IsCreatedWithTariffication--*/
			{
				Name = "Abn_IsCreatedWithTariffication",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_IsCreatedWithTariffication,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ShowPhoneDirectory, (v) => this.Abn_ShowPhoneDirectory = (global::System.Int32?)v) /*--TechnicalTag--*/
			{
				Name = "Abn_ShowPhoneDirectory",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ShowPhoneDirectory,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_Employe_Export_ID, (v) => this.Abn_Employe_Export_ID = (global::System.String)v) /*--Export_ID--*/
			{
				Name = "Abn_Employe_Export_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Employe_Export_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Employee_ID, (v) => this.Abn_Employee_ID = (global::System.String)v) /*--SyncId--*/
			{
				Name = "Abn_Employee_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Employee_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_LastName, (v) => this.Abn_LastName = (global::System.String)v) /*--Name--*/
			{
				Name = "Abn_LastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_LastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Date, (v) => this.Abn_Date = (global::System.DateTime?)v) /*--CustomerDate--*/
			{
				Name = "Abn_Date",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Date,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.UpdateAbonentTree, (v) => this.UpdateAbonentTree = (global::System.Int32?)v) /*--isUpdateNodeTree--*/
			{
				Name = "UpdateAbonentTree",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UpdateAbonentTree,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_WorkPlace, (v) => this.Abn_WorkPlace = (global::System.String)v) /*--Customer_SearchName--*/
			{
				Name = "Abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Grp_ID, (v) => this.Grp_ID = (global::System.Int32?)v) /*--GroupID--*/
			{
				Name = "Grp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Grp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Location_ID, (v) => this.Location_ID = (global::System.Int32?)v) /*--LocationID--*/
			{
				Name = "Location_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Location_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DebugLevel, (v) => this.DebugLevel = (global::System.Int32?)v) /*--DebugLevel--*/
			{
				Name = "DebugLevel",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DebugLevel,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ProfileType, (v) => this.ProfileType = (global::System.Int32?)v) /*--ProfileType--*/
			{
				Name = "ProfileType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ProfileType,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_FullName, (v) => this.Abn_FullName = (global::System.String)v) /*--FullName--*/
			{
				Name = "Abn_FullName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FullName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ShortName, (v) => this.Abn_ShortName = (global::System.String)v) /*--ShortName--*/
			{
				Name = "Abn_ShortName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ShortName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sag_Code, (v) => this.Sag_Code = (global::System.String)v) /*--AgentCode--*/
			{
				Name = "Sag_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sag_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sag_ID, (v) => this.Sag_ID = (global::System.Int32?)v) /*--AgentID--*/
			{
				Name = "Sag_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sag_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pos_Code, (v) => this.Pos_Code = (global::System.String)v) /*--SalesPointCode--*/
			{
				Name = "Pos_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pos_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Pos_ID, (v) => this.Pos_ID = (global::System.Int32?)v) /*--SalesPointID--*/
			{
				Name = "Pos_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pos_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ntw_ID, (v) => this.Ntw_ID = (global::System.Int32?)v) /*--NetworkID--*/
			{
				Name = "Ntw_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ntw_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID_Boss, (v) => this.Abn_ID_Boss = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID_Boss",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID_Boss,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_Customers_Response : ICallProcedureModel<SET_p_ucp_set_Customers_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Customers_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Customers_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_Customers_Response()
		{
			expressions.Add((m) => m.Abn_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Customers_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Customers";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Customers/Activate]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// AuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*IN*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// уникальное значение логина, например Option82 
		/// <para/>
		/// Login
		/// </summary>
		public global::System.String Abn_Login { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Адрес для нотификации об активации
		/// <para/>
		/// Notification
		/// </summary>
		public global::System.String Notification { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// пароль
		/// <para/>
		/// Password
		/// </summary>
		public global::System.String Abn_Password { get; set; } /*IN*/
			/// <summary>
		/// Телефон для нотификации об активации
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String PhoneNumber { get; set; } /*IN*/
			/// <summary>
		/// Комментарий для активации
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Статус узла дерева после активаци
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeActivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.aut_NameAuthCode, (v) => this.aut_NameAuthCode = (global::System.String)v) /*--AuthCode--*/
			{
				Name = "aut_NameAuthCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Login, (v) => this.Abn_Login = (global::System.String)v) /*--Login--*/
			{
				Name = "Abn_Login",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Login,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Notification, (v) => this.Notification = (global::System.String)v) /*--Notification--*/
			{
				Name = "Notification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Notification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_Password, (v) => this.Abn_Password = (global::System.String)v) /*--Password--*/
			{
				Name = "Abn_Password",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Password,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PhoneNumber, (v) => this.PhoneNumber = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "PhoneNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PhoneNumber,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeActivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Customers/CalcCharges]
	[DocIgnore]
	public class ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request : ICallProcedureModel<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Тип начислений (зарезервировано)
		/// <para/>
		/// ChargeCode
		/// </summary>
		public global::System.String ChargeCode { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания периода для расчета начислений
		/// <para/>
		/// DateEnd
		/// </summary>
		[Required]
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала периода для расчета начислений
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Дата начисления, на которую необходимо посчитать сумму АП
		/// <para/>
		/// EffectiveDate
		/// </summary>
		[Required]
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// режим расчета суммы АП к начислению
		/// <para/>
		/// EmulateMode
		/// </summary>
		public global::System.Int32? EmulateMode { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		[Required]
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор номера (зарезервировано) 
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? Ext_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор группы устройств
		/// <para/>
		/// ID_GroupATS
		/// </summary>
		public global::System.Int32? ID_GroupATS { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsReCharge
		/// </summary>
		public global::System.Int32? IsReCharge { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор услуги (зарезервировано) 
		/// <para/>
		/// ServiceID
		/// </summary>
		public global::System.Int32? Srv_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор сессии: код системы(3 знака), код операции(2 знака) и идентификатор сессии(15 знаков). Используется функция fn_GetUniqueID
		/// <para/>
		/// Srs_SessionID
		/// </summary>
		public global::System.String Srs_SessionID { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Charges";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ChargeCode, (v) => this.ChargeCode = (global::System.String)v) /*--ChargeCode--*/
			{
				Name = "ChargeCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ChargeCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EmulateMode, (v) => this.EmulateMode = (global::System.Int32?)v) /*--EmulateMode--*/
			{
				Name = "EmulateMode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EmulateMode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ext_ID, (v) => this.Ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "Ext_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ID_GroupATS, (v) => this.ID_GroupATS = (global::System.Int32?)v) /*--ID_GroupATS--*/
			{
				Name = "ID_GroupATS",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ID_GroupATS,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsReCharge, (v) => this.IsReCharge = (global::System.Int32?)v) /*--IsReCharge--*/
			{
				Name = "IsReCharge",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsReCharge,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srv_ID, (v) => this.Srv_ID = (global::System.Int32?)v) /*--ServiceID--*/
			{
				Name = "Srv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srs_SessionID, (v) => this.Srs_SessionID = (global::System.String)v) /*--Srs_SessionID--*/
			{
				Name = "Srs_SessionID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_SessionID,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response : ICallProcedureModel<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Расчетная сумма АП подлежащая начислению, вкл. налоги
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? Amount { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор процесса расчета
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int32? Wev_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response()
		{
			expressions.Add((m) => m.Amount); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Wev_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Charges";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Amount, (v) => this.Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Amount",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int32?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Customers/ChangeName]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Имя
		/// <para/>
		/// FirstName
		/// </summary>
		public global::System.String Abn_FirstName { get; set; } /*IN*/
			/// <summary>
		/// Юридическое наименование
		/// <para/>
		/// FullName
		/// </summary>
		public global::System.String Abn_FullName { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Отчество
		/// <para/>
		/// MiddleName
		/// </summary>
		public global::System.String Abn_MiddleName { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Название или Фамилия
		/// <para/>
		/// Name
		/// </summary>
		public global::System.String Abn_LastName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Ассоциации 
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// ОКПО или Паспорт
		/// <para/>
		/// SearchName
		/// </summary>
		public global::System.String Abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// Сокращенное наименование
		/// <para/>
		/// ShortName
		/// </summary>
		public global::System.String Abn_ShortName { get; set; } /*IN*/
			/// <summary>
		/// Указание очистить значение, в случае передачи ПУСТО в значении
		/// <para/>
		/// ToClean
		/// </summary>
		public global::System.Int32? toClean { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeName";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_FirstName, (v) => this.Abn_FirstName = (global::System.String)v) /*--FirstName--*/
			{
				Name = "Abn_FirstName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FirstName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_FullName, (v) => this.Abn_FullName = (global::System.String)v) /*--FullName--*/
			{
				Name = "Abn_FullName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FullName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_MiddleName, (v) => this.Abn_MiddleName = (global::System.String)v) /*--MiddleName--*/
			{
				Name = "Abn_MiddleName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_MiddleName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_LastName, (v) => this.Abn_LastName = (global::System.String)v) /*--Name--*/
			{
				Name = "Abn_LastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_LastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_WorkPlace, (v) => this.Abn_WorkPlace = (global::System.String)v) /*--SearchName--*/
			{
				Name = "Abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ShortName, (v) => this.Abn_ShortName = (global::System.String)v) /*--ShortName--*/
			{
				Name = "Abn_ShortName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ShortName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.toClean, (v) => this.toClean = (global::System.Int32?)v) /*--ToClean--*/
			{
				Name = "toClean",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.toClean,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeName";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Customers/ChangeParent]
	[DocIgnore]
	public class ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request : ICallProcedureModel<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак получения акцепта пользователя перед выполнением операции
		/// <para/>
		/// ConfAccepted
		/// </summary>
		public global::System.Int32? ConfAccepted { get; set; } /*IN*/
			/// <summary>
		/// Сообщение для конечного пользователя, требующее его обязательного подтверждения
		/// <para/>
		/// ConfMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*INOUT*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор узла дерева
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор вышестоящего узла дерева, на который делается перенос
		/// <para/>
		/// ParentNode
		/// </summary>
		[Required]
		public global::System.Int32? Parent_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий 
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Статус узла дерева после перерегистрации
		/// <para/>
		/// TargetStatusID
		/// </summary>
		public global::System.Int32? Tnst_target_new { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request()
		{
			expressions.Add((m) => m.ConfMessage); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_ChangeParent";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfAccepted, (v) => this.ConfAccepted = (global::System.Int32?)v) /*--ConfAccepted--*/
			{
				Name = "ConfAccepted",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ConfAccepted,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Parent_ID, (v) => this.Parent_ID = (global::System.Int32?)v) /*--ParentNode--*/
			{
				Name = "Parent_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Parent_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_target_new, (v) => this.Tnst_target_new = (global::System.Int32?)v) /*--TargetStatusID--*/
			{
				Name = "Tnst_target_new",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_target_new,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response : ICallProcedureModel<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Сообщение для конечного пользователя, требующее его обязательного подтверждения
		/// <para/>
		/// ConfMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response()
		{
			expressions.Add((m) => m.ConfMessage); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_ChangeParent";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Customers/ChangeStatus]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// ConfirmationMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*INOUT*/
			/// <summary>
		/// Дата изменения статуса
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента, клиента или ассоциации
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения статуса
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Статус узла дерева
		/// <para/>
		/// StatusID
		/// </summary>
		[Required]
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак подтверждения операции со стороны пользователя
		/// <para/>
		/// UserAcceptance
		/// </summary>
		public global::System.Int32? ConfAccepted { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request()
		{
			expressions.Add((m) => m.ConfMessage); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeStatus";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfirmationMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ConfAccepted, (v) => this.ConfAccepted = (global::System.Int32?)v) /*--UserAcceptance--*/
			{
				Name = "ConfAccepted",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ConfAccepted,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Ответ АПИ с текстом предупреждения перед изменением статуса
		/// <para/>
		/// ConfirmationMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response()
		{
			expressions.Add((m) => m.ConfMessage); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeStatus";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfirmationMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Customers/Copy]
	[DocIgnore]
	public class ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request : ICallProcedureModel<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// AccountNumber
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int64? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор процесса расчета
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int64? Wev_ID { get; set; } /*INOUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Wev_ID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_Customers_Sync";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--AccountNumber--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int64?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int64?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int64
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response : ICallProcedureModel<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор события
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int64? Wev_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Wev_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_Customers_Sync";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int64?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int64
			};
		}
	}
#endregion
#region [Customers/CustomerExtentions]
	[DocIgnore]
	public class GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request : ICallProcedureModel<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageNumber
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_CustomerExtentions";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageNumber--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ID
		/// </summary>
		[Required]
		public global::System.Int32? ext_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		[Required]
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		[Required]
		public global::System.String ext_ExtNum { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор результирующей таблицы, например, pkt_ID для Packets...
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? ParentID { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [Customers/Deactivate]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата деактивации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Имя сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		[Required]
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Фильтр для отбора узлов по коду метки
		/// <para/>
		/// LabelCode
		/// </summary>
		public global::System.String Lbl_Code { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Адрес для нотификации о деактивации
		/// <para/>
		/// Notification
		/// </summary>
		public global::System.String Notification { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Телефон для нотификации о деактивации
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String PhoneNumber { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Фильтр для отбора узлов по текущему статусу узла дерева
		/// <para/>
		/// StatusCode
		/// </summary>
		public global::System.String Tnst_Code_crnt { get; set; } /*IN*/
			/// <summary>
		/// Значение статуса узла после выполнения операции
		/// <para/>
		/// TargetStatusCode
		/// </summary>
		public global::System.String Tnst_Code_trgt { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeDeactivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lbl_Code, (v) => this.Lbl_Code = (global::System.String)v) /*--LabelCode--*/
			{
				Name = "Lbl_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lbl_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Notification, (v) => this.Notification = (global::System.String)v) /*--Notification--*/
			{
				Name = "Notification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Notification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PhoneNumber, (v) => this.PhoneNumber = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "PhoneNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PhoneNumber,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_Code_crnt, (v) => this.Tnst_Code_crnt = (global::System.String)v) /*--StatusCode--*/
			{
				Name = "Tnst_Code_crnt",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_Code_crnt,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_Code_trgt, (v) => this.Tnst_Code_trgt = (global::System.String)v) /*--TargetStatusCode--*/
			{
				Name = "Tnst_Code_trgt",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_Code_trgt,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Кол-во обработанных записей 
		/// <para/>
		/// AffectedCount
		/// </summary>
		public global::System.Int32? AffectedCount { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор процесса 
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int32? Wev_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response()
		{
			expressions.Add((m) => m.AffectedCount); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Wev_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeDeactivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.AffectedCount, (v) => this.AffectedCount = (global::System.Int32?)v) /*--AffectedCount--*/
			{
				Name = "AffectedCount",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.AffectedCount,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int32?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Customers/Details]
	[DocIgnore]
	public class GET_p_ucp_get_CustomerByID_Customers_Details_Request : ICallProcedureModel<GET_p_ucp_get_CustomerByID_Customers_Details_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_CustomerByID_Customers_Details_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_CustomerByID_Customers_Details_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
#endregion

		#region ctor
		public GET_p_ucp_get_CustomerByID_Customers_Details_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_CustomerByID_Customers_Details_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_CustomerByID";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--CacheControlDate--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.DateTime
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_CustomerByID_Customers_Details_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_CustomerByID_Customers_Details_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Date_Personal
		/// </summary>
		[Required]
		public global::System.DateTime? abc_Date_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abn_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_CreateDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_CreateDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abn_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employe_Export_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employe_Export_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employee_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_FirstName
		/// </summary>
		[Required]
		public global::System.String abn_FirstName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Guid
		/// </summary>
		[Required]
		public global::System.Guid? abn_Guid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ID_Boss
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsExistAD { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsGuest
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsGuest { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastFM
		/// </summary>
		[Required]
		public global::System.String abn_LastFM { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Login
		/// </summary>
		[Required]
		public global::System.String abn_Login { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_MiddleName
		/// </summary>
		[Required]
		public global::System.String abn_MiddleName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedBy
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedFrom
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedFrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Left
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Left { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Right
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Right { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Password
		/// </summary>
		[Required]
		public global::System.String abn_Password { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_PositionCode
		/// </summary>
		[Required]
		public global::System.String abn_PositionCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ShowPhoneDirectory
		/// </summary>
		[Required]
		public global::System.Int32? abn_ShowPhoneDirectory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		[Required]
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace_Personal
		/// </summary>
		[Required]
		public global::System.String abn_WorkPlace_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_XmlData
		/// </summary>
		[Required]
		public global::System.String abn_XmlData { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// AbonentFullName
		/// </summary>
		[Required]
		public global::System.String AbonentFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_IsPersonal
		/// </summary>
		[Required]
		public global::System.Int32? acnt_IsPersonal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		[Required]
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number_Personal
		/// </summary>
		[Required]
		public global::System.String acnt_Number_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name
		/// </summary>
		[Required]
		public global::System.String Actpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name_Personal
		/// </summary>
		[Required]
		public global::System.String Actpd_Name_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// atnsb_DateEnd
		/// </summary>
		[Required]
		public global::System.DateTime? atnsb_DateEnd { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// atnsb_DateStart
		/// </summary>
		[Required]
		public global::System.DateTime? atnsb_DateStart { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? aut_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abb_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_Balance_Personal
		/// </summary>
		[Required]
		public global::System.Decimal? abb_Balance_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abb_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_ModifiedDate_Personal
		/// </summary>
		[Required]
		public global::System.DateTime? abb_ModifiedDate_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abc_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Balance_Personal
		/// </summary>
		[Required]
		public global::System.Decimal? abc_Balance_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abc_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Boss_Tnt_Type
		/// </summary>
		[Required]
		public global::System.String Boss_Tnt_Type { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossFullName
		/// </summary>
		[Required]
		public global::System.String BossFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_Id
		/// </summary>
		[Required]
		public global::System.Int32? com_Id { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// debt_Amount
		/// </summary>
		[Required]
		public global::System.Decimal? debt_Amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// debt_Date
		/// </summary>
		[Required]
		public global::System.DateTime? debt_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		[Required]
		public global::System.Int32? dep_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		[Required]
		public global::System.String ext_ExtNum { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? ext_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		[Required]
		public global::System.Int32? grp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_Name
		/// </summary>
		[Required]
		public global::System.String grp_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isActivated
		/// </summary>
		[Required]
		public global::System.Int32? isActivated { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditAllow
		/// </summary>
		[Required]
		public global::System.Int32? isEditAllow { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditWorkPlace
		/// </summary>
		[Required]
		public global::System.Int32? isEditWorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// lng_ID
		/// </summary>
		[Required]
		public global::System.Int32? lng_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// loc_Name
		/// </summary>
		[Required]
		public global::System.String loc_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Location_ID
		/// </summary>
		[Required]
		public global::System.Int32? Location_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ntw_ID
		/// </summary>
		[Required]
		public global::System.Int32? ntw_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pbx_networkName
		/// </summary>
		[Required]
		public global::System.String pbx_networkName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ProfileType
		/// </summary>
		[Required]
		public global::System.Int32? ProfileType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// SubsCount
		/// </summary>
		[Required]
		public global::System.Int32? SubsCount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnh_LastFM
		/// </summary>
		[Required]
		public global::System.String tnh_LastFM { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_AccountMandatory
		/// </summary>
		[Required]
		public global::System.Int32? tnt_AccountMandatory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TreeNodeType
		/// </summary>
		public global::System.String TreeNodeType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		[Required]
		public global::System.Int32? trf_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isRefusalChangeName
		/// </summary>
		[Required]
		public global::System.Int32? isRefusalChangeName { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [Customers/postponeInvoice]
	[DocIgnore]
	public class ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request : ICallProcedureModel<ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Новый срок оплаты инвойса
		/// <para/>
		/// DateLimit
		/// </summary>
		[Required]
		public global::System.DateTime? DateLimit { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*INOUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор клиента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменений
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request()
		{
			expressions.Add((m) => m.ErrFormat); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "sp_change_InvoiceTerms";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.DateLimit, (v) => this.DateLimit = (global::System.DateTime?)v) /*--DateLimit--*/
			{
				Name = "DateLimit",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateLimit,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Customers/SetLabels]
	[DocIgnore]
	public class ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request : ICallProcedureModel<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		[Required]
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Код метки
		/// <para/>
		/// LabelCode
		/// </summary>
		[Required]
		public global::System.String Lbl_Code { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// LinkedServer
		/// </summary>
		public global::System.String LinkedServer { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// SELECT запрос на отбор идентификаторов узлов дерева - должен учитыавать значение IDType
		/// <para/>
		/// SourceQuery
		/// </summary>
		public global::System.String SourceQuery { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_LabelApply";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lbl_Code, (v) => this.Lbl_Code = (global::System.String)v) /*--LabelCode--*/
			{
				Name = "Lbl_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lbl_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.LinkedServer, (v) => this.LinkedServer = (global::System.String)v) /*--LinkedServer--*/
			{
				Name = "LinkedServer",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.LinkedServer,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SourceQuery, (v) => this.SourceQuery = (global::System.String)v) /*--SourceQuery--*/
			{
				Name = "SourceQuery",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SourceQuery,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response : ICallProcedureModel<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_LabelApply";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [CustomerTypes]
	[DocIgnore]
	public class GET_p_ucp_get_CustomerTypes_Request : ICallProcedureModel<GET_p_ucp_get_CustomerTypes_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_CustomerTypes_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_CustomerTypes_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public GET_p_ucp_get_CustomerTypes_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_CustomerTypes_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_CustomerTypes";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_CustomerTypes_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_CustomerTypes_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? AccountTypeID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// AccountTypeName
		/// </summary>
		[Required]
		public global::System.String AccountTypeName { get; set; } /*OUTPUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// Idtype
		/// </summary>
		[Required]
		public global::System.Int32? Idtype { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [Discounts]
	[DocIgnore]
	public class SET_p_ucp_set_DiscountAbonentBind_Request : ICallProcedureModel<SET_p_ucp_set_DiscountAbonentBind_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_DiscountAbonentBind_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_DiscountAbonentBind_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата установки изменений (начала действия или окончания)
		/// <para/>
		/// DateSet
		/// </summary>
		public global::System.DateTime? DateSet { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор скидки
		/// <para/>
		/// DiscountID
		/// </summary>
		public global::System.Int32? dsc_ID { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменений
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Признак закрытия действия скидки с указанной даты DateSet
		/// <para/>
		/// isAnnul
		/// </summary>
		public global::System.Int32? isAnnul { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор клиента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор исторической связки клиента и скидки
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? dab_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_DiscountAbonentBind_Request()
		{
			expressions.Add((m) => m.dab_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_DiscountAbonentBind_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_DiscountAbonentBind";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.DateSet, (v) => this.DateSet = (global::System.DateTime?)v) /*--DateSet--*/
			{
				Name = "DateSet",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateSet,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.dsc_ID, (v) => this.dsc_ID = (global::System.Int32?)v) /*--DiscountID--*/
			{
				Name = "dsc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dsc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.isAnnul, (v) => this.isAnnul = (global::System.Int32?)v) /*--isAnnul--*/
			{
				Name = "isAnnul",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.isAnnul,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dab_ID, (v) => this.dab_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "dab_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.dab_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_DiscountAbonentBind_Response : ICallProcedureModel<SET_p_ucp_set_DiscountAbonentBind_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_DiscountAbonentBind_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_DiscountAbonentBind_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Уникальный идентификатор исторической связки клиента и скидки
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? dab_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_DiscountAbonentBind_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.dab_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_DiscountAbonentBind_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_DiscountAbonentBind";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.dab_ID, (v) => this.dab_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "dab_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.dab_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Environment]
	[DocIgnore]
	public class GET_p_ucp_get_Variables_Request : ICallProcedureModel<GET_p_ucp_get_Variables_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_Variables_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_Variables_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// var_Name
		/// </summary>
		public global::System.String var_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// var_Group
		/// </summary>
		public global::System.String var_Group { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_Variables_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_Variables_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_Variables";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.var_Name, (v) => this.var_Name = (global::System.String)v) /*--var_Name--*/
			{
				Name = "var_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.var_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.var_Group, (v) => this.var_Group = (global::System.String)v) /*--var_Group--*/
			{
				Name = "var_Group",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.var_Group,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_Variables_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_Variables_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// var_Description
		/// </summary>
		[Required]
		public global::System.String var_Description { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// var_Error
		/// </summary>
		[Required]
		public global::System.Int32? var_Error { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.String var_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// var_Value
		/// </summary>
		[Required]
		public global::System.String var_Value { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// var_ValueDatetime
		/// </summary>
		[Required]
		public global::System.DateTime? var_ValueDatetime { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// var_ValueDecimal
		/// </summary>
		[Required]
		public global::System.Decimal? var_ValueDecimal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// var_ValueInt
		/// </summary>
		[Required]
		public global::System.Int32? var_ValueInt { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ddat
		/// </summary>
		[Required]
		public global::System.Int32? ddat { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ddec
		/// </summary>
		[Required]
		public global::System.Int32? ddec { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dint
		/// </summary>
		[Required]
		public global::System.Int32? dint { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dstr
		/// </summary>
		[Required]
		public global::System.Int32? dstr { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// var_Group
		/// </summary>
		[Required]
		public global::System.String var_Group { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [Extentions]
	[DocIgnore]
	public class SET_p_ucp_set_SubscriberExtentions_Request : ICallProcedureModel<SET_p_ucp_set_SubscriberExtentions_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_SubscriberExtentions_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_SubscriberExtentions_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата окончания действия записи для ВН
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата последнего изменения статуса Extentions
		/// <para/>
		/// StatusModifiedDate
		/// </summary>
		public global::System.DateTime? ModifiedDateExst { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModifiedBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModifiedFrom { get; set; } /*IN*/
			/// <summary>
		/// Формат аттрибутов Extentions
		/// <para/>
		/// XmlDataFormat
		/// </summary>
		public global::System.String XmlDataFormat { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Extentions (Номера MSISDN)
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? Ext_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Внешний идентификатор MSISDN
		/// <para/>
		/// ExternalID
		/// </summary>
		public global::System.Int32? Ext_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Аттрибуты Extentions
		/// <para/>
		/// XmlData
		/// </summary>
		public global::System.String Ext_XmlData { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор категории Extentions
		/// <para/>
		/// CategoryID
		/// </summary>
		[Required]
		public global::System.Int32? Exct_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор класса Extentions
		/// <para/>
		/// ClassID
		/// </summary>
		[Required]
		public global::System.Int32? Excl_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор статуса номера
		/// <para/>
		/// StatusID
		/// </summary>
		[Required]
		public global::System.Int32? Exst_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор типа Extentions
		/// <para/>
		/// TypeID
		/// </summary>
		[Required]
		public global::System.Int32? Extp_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор точки подключения (SWITCHES)
		/// <para/>
		/// ConnectionPointID
		/// </summary>
		public global::System.Int32? Cpt_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор устройства (источника СDR)
		/// <para/>
		/// NumberAts
		/// </summary>
		public global::System.Int32? NumberAts { get; set; } /*IN*/
			/// <summary>
		/// Номер Extentions
		/// <para/>
		/// ExtentionNumber
		/// </summary>
		[Required]
		public global::System.String Ext_ExtNum { get; set; } /*IN*/
			/// <summary>
		/// Признак ""создан автоматически из cdr
		/// <para/>
		/// IsCreatedWithTariffication
		/// </summary>
		public global::System.Int32? Ext_IsCreatedWithTariffication { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Режим отладки (зарезервировано)
		/// <para/>
		/// DebugLevel
		/// </summary>
		public global::System.Int32? DebugLevel { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор исторической связки с абонентом
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Eab_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Признак, показывать ли в телефонном справочнике.
		/// <para/>
		/// ext_ShowPhoneDirectory
		/// </summary>
		public global::System.Int32? ext_ShowPhoneDirectory { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModifiedDate
		/// </summary>
		public global::System.DateTime? ModifiedDate { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_SubscriberExtentions_Request()
		{
			expressions.Add((m) => m.Ext_ID); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Eab_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_SubscriberExtentions_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_SubscriberExtentions";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ModifiedDateExst, (v) => this.ModifiedDateExst = (global::System.DateTime?)v) /*--StatusModifiedDate--*/
			{
				Name = "ModifiedDateExst",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedDateExst,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ModifiedBy, (v) => this.ModifiedBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModifiedBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModifiedFrom, (v) => this.ModifiedFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModifiedFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.XmlDataFormat, (v) => this.XmlDataFormat = (global::System.String)v) /*--XmlDataFormat--*/
			{
				Name = "XmlDataFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.XmlDataFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ext_ID, (v) => this.Ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "Ext_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ext_ExternalID, (v) => this.Ext_ExternalID = (global::System.Int32?)v) /*--ExternalID--*/
			{
				Name = "Ext_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ext_XmlData, (v) => this.Ext_XmlData = (global::System.String)v) /*--XmlData--*/
			{
				Name = "Ext_XmlData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_XmlData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Exct_ID, (v) => this.Exct_ID = (global::System.Int32?)v) /*--CategoryID--*/
			{
				Name = "Exct_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Exct_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Excl_ID, (v) => this.Excl_ID = (global::System.Int32?)v) /*--ClassID--*/
			{
				Name = "Excl_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Excl_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Exst_ID, (v) => this.Exst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Exst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Exst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Extp_ID, (v) => this.Extp_ID = (global::System.Int32?)v) /*--TypeID--*/
			{
				Name = "Extp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Extp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpt_ID, (v) => this.Cpt_ID = (global::System.Int32?)v) /*--ConnectionPointID--*/
			{
				Name = "Cpt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.NumberAts, (v) => this.NumberAts = (global::System.Int32?)v) /*--NumberAts--*/
			{
				Name = "NumberAts",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.NumberAts,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ext_ExtNum, (v) => this.Ext_ExtNum = (global::System.String)v) /*--ExtentionNumber--*/
			{
				Name = "Ext_ExtNum",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_ExtNum,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ext_IsCreatedWithTariffication, (v) => this.Ext_IsCreatedWithTariffication = (global::System.Int32?)v) /*--IsCreatedWithTariffication--*/
			{
				Name = "Ext_IsCreatedWithTariffication",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_IsCreatedWithTariffication,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DebugLevel, (v) => this.DebugLevel = (global::System.Int32?)v) /*--DebugLevel--*/
			{
				Name = "DebugLevel",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DebugLevel,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Eab_ID, (v) => this.Eab_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Eab_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Eab_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ext_ShowPhoneDirectory, (v) => this.ext_ShowPhoneDirectory = (global::System.Int32?)v) /*--ext_ShowPhoneDirectory--*/
			{
				Name = "ext_ShowPhoneDirectory",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ext_ShowPhoneDirectory,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModifiedDate, (v) => this.ModifiedDate = (global::System.DateTime?)v) /*--ModifiedDate--*/
			{
				Name = "ModifiedDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedDate,
				DBType = System.Data.DbType.DateTime
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_SubscriberExtentions_Response : ICallProcedureModel<SET_p_ucp_set_SubscriberExtentions_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_SubscriberExtentions_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_SubscriberExtentions_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор Extentions (Номера MSISDN)
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? Ext_ID { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор исторической связки с абонентом
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Eab_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_SubscriberExtentions_Response()
		{
			expressions.Add((m) => m.Ext_ID); // OUT
			expressions.Add((m) => m.Eab_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_SubscriberExtentions_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_SubscriberExtentions";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Ext_ID, (v) => this.Ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "Ext_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Eab_ID, (v) => this.Eab_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Eab_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Eab_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Gains]
	[DocIgnore]
	public class SET_p_ucp_set_AccountCredits_Request : ICallProcedureModel<SET_p_ucp_set_AccountCredits_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_AccountCredits_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_AccountCredits_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Код причины для идентификации параметров программы лояльности
		/// <para/>
		/// ReasonCode
		/// </summary>
		public global::System.String Accrr_Code { get; set; } /*IN*/
			/// <summary>
		/// Уникальный код программы лояльности
		/// <para/>
		/// ProgrammCode
		/// </summary>
		public global::System.String Ctpro_Code { get; set; } /*IN*/
			/// <summary>
		/// Сумма кредита в валюте по умолчанию, вкл. налоги
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? Accr_Amount { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания действия программы лояльности
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия программы лояльности
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Тип влияния на баланс суммы по программе лояльности
		/// <para/>
		/// TypeCode
		/// </summary>
		public global::System.String Crtp_Code { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор клиента (узла типа Customers)
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор связи Клиента и программы лояльности
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Accr_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Порог отключения
		/// <para/>
		/// Accr_Break
		/// </summary>
		public global::System.Decimal? Accr_Break { get; set; } /*IN*/
			/// <summary>
		/// Порог информирования
		/// <para/>
		/// Accr_Warning
		/// </summary>
		public global::System.Decimal? Accr_Warning { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_AccountCredits_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Accr_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_AccountCredits_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_AccountCredits";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Accrr_Code, (v) => this.Accrr_Code = (global::System.String)v) /*--ReasonCode--*/
			{
				Name = "Accrr_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accrr_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ctpro_Code, (v) => this.Ctpro_Code = (global::System.String)v) /*--ProgrammCode--*/
			{
				Name = "Ctpro_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ctpro_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Accr_Amount, (v) => this.Accr_Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Accr_Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accr_Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crtp_Code, (v) => this.Crtp_Code = (global::System.String)v) /*--TypeCode--*/
			{
				Name = "Crtp_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crtp_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Accr_ID, (v) => this.Accr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Accr_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Accr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Accr_Break, (v) => this.Accr_Break = (global::System.Decimal?)v) /*--Accr_Break--*/
			{
				Name = "Accr_Break",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accr_Break,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Accr_Warning, (v) => this.Accr_Warning = (global::System.Decimal?)v) /*--Accr_Warning--*/
			{
				Name = "Accr_Warning",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accr_Warning,
				DBType = System.Data.DbType.Decimal
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_AccountCredits_Response : ICallProcedureModel<SET_p_ucp_set_AccountCredits_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_AccountCredits_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_AccountCredits_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Уникальный идентификатор связи Клиента и программы лояльности
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Accr_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_AccountCredits_Response()
		{
			expressions.Add((m) => m.Accr_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_AccountCredits_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_AccountCredits";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Accr_ID, (v) => this.Accr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Accr_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Accr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Memberships]
	[DocIgnore]
	public class SET_p_ucp_set_CodeRegions_Memberships_Request : ICallProcedureModel<SET_p_ucp_set_CodeRegions_Memberships_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CodeRegions_Memberships_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CodeRegions_Memberships_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак добавлять номера абонента в Закрытую Группу или нет
		/// <para/>
		/// IncludeNumbers
		/// </summary>
		public global::System.Int32? IncludeNumbers { get; set; } /*IN*/
			/// <summary>
		/// Номер телефона абонента (А-номер)
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String Cds_FullCode { get; set; } /*IN*/
			/// <summary>
		/// Признак удаления
		/// <para/>
		/// IsRemoved
		/// </summary>
		public global::System.Int32? Cds_IsRemoved { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Закрытой абонентской группы
		/// <para/>
		/// GroupID
		/// </summary>
		public global::System.Int32? Crg_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания присутствия абонента в группе
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? Crgb_DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала присутствия абонента в группе
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? Crgb_DateStart { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор исторической записи присутствия абонента в группе
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Crgb_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Дополнительный код города
		/// <para/>
		/// Cds_CityAddCode
		/// </summary>
		public global::System.String Cds_CityAddCode { get; set; } /*IN*/
			/// <summary>
		/// Код города
		/// <para/>
		/// Cds_CityCode
		/// </summary>
		public global::System.String Cds_CityCode { get; set; } /*IN*/
			/// <summary>
		/// Код страны
		/// <para/>
		/// Cds_CountryCode
		/// </summary>
		public global::System.String Cds_CountryCode { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор кода направления. Связь с Codes
		/// <para/>
		/// Cds_ID
		/// </summary>
		public global::System.Int32? Cds_ID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Cds_Name
		/// </summary>
		public global::System.String Cds_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Crg_RegionNameEN
		/// </summary>
		public global::System.String Crg_RegionNameEN { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_CodeRegions_Memberships_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Crgb_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Cds_ID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CodeRegions_Memberships_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CodeRegions_Memberships";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IncludeNumbers, (v) => this.IncludeNumbers = (global::System.Int32?)v) /*--IncludeNumbers--*/
			{
				Name = "IncludeNumbers",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IncludeNumbers,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cds_FullCode, (v) => this.Cds_FullCode = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "Cds_FullCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_FullCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_IsRemoved, (v) => this.Cds_IsRemoved = (global::System.Int32?)v) /*--IsRemoved--*/
			{
				Name = "Cds_IsRemoved",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_IsRemoved,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crg_ID, (v) => this.Crg_ID = (global::System.Int32?)v) /*--GroupID--*/
			{
				Name = "Crg_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crgb_DateEnd, (v) => this.Crgb_DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "Crgb_DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crgb_DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Crgb_DateStart, (v) => this.Crgb_DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "Crgb_DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crgb_DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crgb_ID, (v) => this.Crgb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Crgb_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Crgb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_CityAddCode, (v) => this.Cds_CityAddCode = (global::System.String)v) /*--Cds_CityAddCode--*/
			{
				Name = "Cds_CityAddCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CityAddCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_CityCode, (v) => this.Cds_CityCode = (global::System.String)v) /*--Cds_CityCode--*/
			{
				Name = "Cds_CityCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CityCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_CountryCode, (v) => this.Cds_CountryCode = (global::System.String)v) /*--Cds_CountryCode--*/
			{
				Name = "Cds_CountryCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CountryCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_ID, (v) => this.Cds_ID = (global::System.Int32?)v) /*--Cds_ID--*/
			{
				Name = "Cds_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Cds_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cds_Name, (v) => this.Cds_Name = (global::System.String)v) /*--Cds_Name--*/
			{
				Name = "Cds_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crg_RegionNameEN, (v) => this.Crg_RegionNameEN = (global::System.String)v) /*--Crg_RegionNameEN--*/
			{
				Name = "Crg_RegionNameEN",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_RegionNameEN,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_CodeRegions_Memberships_Response : ICallProcedureModel<SET_p_ucp_set_CodeRegions_Memberships_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CodeRegions_Memberships_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CodeRegions_Memberships_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор исторической записи присутствия абонента в группе
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Crgb_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор кода направления. Связь с Codes
		/// <para/>
		/// Cds_ID
		/// </summary>
		public global::System.Int32? Cds_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_CodeRegions_Memberships_Response()
		{
			expressions.Add((m) => m.Crgb_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Cds_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CodeRegions_Memberships_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CodeRegions_Memberships";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Crgb_ID, (v) => this.Crgb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Crgb_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Crgb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_ID, (v) => this.Cds_ID = (global::System.Int32?)v) /*--Cds_ID--*/
			{
				Name = "Cds_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Cds_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Networks]
	[DocIgnore]
	public class GET_p_ucp_get_Networks_Request : ICallProcedureModel<GET_p_ucp_get_Networks_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_Networks_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_Networks_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор стандарта
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Ntw_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// NetworkName
		/// </summary>
		public global::System.String Ntwd_Name { get; set; } /*IN*/
			/// <summary>
		/// Номер страницы (server paging)
		/// <para/>
		/// PageIndex
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_Networks_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_Networks_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_Networks";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ntw_ID, (v) => this.Ntw_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Ntw_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ntw_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ntwd_Name, (v) => this.Ntwd_Name = (global::System.String)v) /*--NetworkName--*/
			{
				Name = "Ntwd_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ntwd_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageIndex--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_Networks_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_Networks_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// NameATS
		/// </summary>
		[Required]
		public global::System.String NameATS { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// NetworkExternalID
		/// </summary>
		[Required]
		public global::System.Int32? ntw_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// NetworkID
		/// </summary>
		[Required]
		public global::System.Int32? ntw_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// NetworkName
		/// </summary>
		[Required]
		public global::System.String ntwd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// NumberATS
		/// </summary>
		[Required]
		public global::System.Int32? NumberATS { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [Networks/ClearLogins]
	[DocIgnore]
	public class ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request : ICallProcedureModel<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор стандарта
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? ntw_id { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModifiedBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModifiedFrom { get; set; } /*IN*/
			/// <summary>
		/// Название атрибута таблицы Abonents в качестве нового значения логина
		/// <para/>
		/// NewLoginSource
		/// </summary>
		public global::System.String NewLoginSource { get; set; } /*IN*/
			/// <summary>
		/// Новое значение пароля
		/// <para/>
		/// NewPassword
		/// </summary>
		public global::System.String NewPassword { get; set; } /*IN*/
			/// <summary>
		/// Регулярное выражение отбора значений логина для очистки
		/// <para/>
		/// RegExpValue
		/// </summary>
		public global::System.String RegExpValue { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_ClearTreeNodeLogins";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ntw_id, (v) => this.ntw_id = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "ntw_id",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ntw_id,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModifiedBy, (v) => this.ModifiedBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModifiedBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModifiedFrom, (v) => this.ModifiedFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModifiedFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModifiedFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.NewLoginSource, (v) => this.NewLoginSource = (global::System.String)v) /*--NewLoginSource--*/
			{
				Name = "NewLoginSource",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.NewLoginSource,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.NewPassword, (v) => this.NewPassword = (global::System.String)v) /*--NewPassword--*/
			{
				Name = "NewPassword",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.NewPassword,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.RegExpValue, (v) => this.RegExpValue = (global::System.String)v) /*--RegExpValue--*/
			{
				Name = "RegExpValue",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.RegExpValue,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response : ICallProcedureModel<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Кол-во измененных абонентов
		/// <para/>
		/// AffectedCount
		/// </summary>
		public global::System.Int32? UpdatedAbnCount { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response()
		{
			expressions.Add((m) => m.UpdatedAbnCount); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_ClearTreeNodeLogins";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.UpdatedAbnCount, (v) => this.UpdatedAbnCount = (global::System.Int32?)v) /*--AffectedCount--*/
			{
				Name = "UpdatedAbnCount",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.UpdatedAbnCount,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [PaymentDocuments]
	[DocIgnore]
	public class SET_p_ucp_set_PayDocs_Request : ICallProcedureModel<SET_p_ucp_set_PayDocs_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_PayDocs_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_PayDocs_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата платежа из внешней системы (фактическая дата)
		/// <para/>
		/// PayDate
		/// </summary>
		public global::System.DateTime? Cpd_PayDate { get; set; } /*IN*/
			/// <summary>
		/// Дата реестра (для кассовых) или выписки (для безналичных платежных документов)банквоской
		/// <para/>
		/// ReestrDate
		/// </summary>
		public global::System.DateTime? Pre_DateReestr { get; set; } /*IN*/
			/// <summary>
		/// Дата аннулирования платежного документа
		/// <para/>
		/// AnnulDate
		/// </summary>
		public global::System.DateTime? Cpd_AnnulDate { get; set; } /*IN*/
			/// <summary>
		/// Дата проведения платежного документа во внешней системе (отсутствие значения говорит об отсутствии во внешней системе)
		/// <para/>
		/// ExportedDate
		/// </summary>
		public global::System.DateTime? Cpd_ExportedDate { get; set; } /*IN*/
			/// <summary>
		/// Признак необходимости разнесения платежного документа на платежи по лицевому счету (1- разнести, 0 - не разносить)
		/// <para/>
		/// Moved
		/// </summary>
		[Required]
		public global::System.Int32? Cpd_Moved { get; set; } /*IN*/
			/// <summary>
		/// Признак необходимости аннулирования платежного документа (1 - аннулировать, 0 - нет)
		/// <para/>
		/// Annul
		/// </summary>
		public global::System.Int32? Cpd_Annul { get; set; } /*IN*/
			/// <summary>
		/// Внешний ID для реестра
		/// <para/>
		/// ReestrID
		/// </summary>
		public global::System.Int32? Pre_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Внешний ID для банка
		/// <para/>
		/// BankID
		/// </summary>
		public global::System.Int32? Bnk_ID { get; set; } /*IN*/
			/// <summary>
		/// Внешний ID для кассы
		/// <para/>
		/// KassaID
		/// </summary>
		public global::System.Int32? Cof_ID { get; set; } /*IN*/
			/// <summary>
		/// Филиал
		/// <para/>
		/// LocationID
		/// </summary>
		public global::System.Int32? Loc_ID { get; set; } /*IN*/
			/// <summary>
		/// Класс платежа 
		/// <para/>
		/// PayClass
		/// </summary>
		public global::System.Int32? Cpc_ID { get; set; } /*IN*/
			/// <summary>
		/// Номер реестра (для кассовых) или банковской выписки (для безналичных платежных документов)
		/// <para/>
		/// ReestrNumber
		/// </summary>
		public global::System.String Pre_NumReestr { get; set; } /*IN*/
			/// <summary>
		/// Номер лицевого счета
		/// <para/>
		/// AccountNumber
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// Кем аннулирован платеж (имя пользователя из контекста приложения)
		/// <para/>
		/// AnnulBy
		/// </summary>
		public global::System.String Cpd_AnnulBy { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Платежного интерфейса 
		/// <para/>
		/// PayInterfaceID
		/// </summary>
		[Required]
		public global::System.Int32? Cpif_ID { get; set; } /*IN*/
			/// <summary>
		/// Код валюты платежного документа
		/// <para/>
		/// CurrencyCode
		/// </summary>
		[Required]
		public global::System.String Crn_CodeISO { get; set; } /*IN*/
			/// <summary>
		/// Комментарий к документу или причины аннулирования
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Сумма платежного документа
		/// <para/>
		/// Amount
		/// </summary>
		[Required]
		public global::System.Decimal? Cpd_Amount { get; set; } /*IN*/
			/// <summary>
		/// Дата проведения платежа в системе
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? Cpd_PayEffDate { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Номер абонента (MSISDN)
		/// <para/>
		/// ExtentionNumber
		/// </summary>
		public global::System.String Cpd_DesPhone { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор расчетного банковского счета (для безналичніх платежных документов)
		/// <para/>
		/// BankAccountID
		/// </summary>
		public global::System.Int32? Bac_ID { get; set; } /*IN*/
			/// <summary>
		/// Код диллера
		/// <para/>
		/// DealerId
		/// </summary>
		public global::System.Int32? Cpd_DealerId { get; set; } /*IN*/
			/// <summary>
		/// Номер платежного документа (номер чека или платежки)
		/// <para/>
		/// PayDocNumber
		/// </summary>
		public global::System.String Cpd_PayDocNumber { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Документа из внешней системы 
		/// <para/>
		/// ExportID
		/// </summary>
		public global::System.Int32? Cpd_ExportID { get; set; } /*IN*/
			/// <summary>
		/// Код внешней системы
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// cacheStatus
		/// </summary>
		public global::System.String cacheStatus { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор платежного документа в спец. формате (20 символов), включающем в себя код системы, генерирующий платежный документ
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String Cpd_ExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Уникальный идентификатор платежного документа в спец. формате (20 символов), включающем в себя код системы, генерирующий платежный документ
		/// <para/>
		/// ID
		/// </summary>
		public global::System.String ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_PayDocs_Request()
		{
			expressions.Add((m) => m.Cpd_ExternalID); // INOUT
			expressions.Add((m) => m.ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_PayDocs_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_PayDocs";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Cpd_PayDate, (v) => this.Cpd_PayDate = (global::System.DateTime?)v) /*--PayDate--*/
			{
				Name = "Cpd_PayDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_PayDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Pre_DateReestr, (v) => this.Pre_DateReestr = (global::System.DateTime?)v) /*--ReestrDate--*/
			{
				Name = "Pre_DateReestr",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pre_DateReestr,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Cpd_AnnulDate, (v) => this.Cpd_AnnulDate = (global::System.DateTime?)v) /*--AnnulDate--*/
			{
				Name = "Cpd_AnnulDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_AnnulDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Cpd_ExportedDate, (v) => this.Cpd_ExportedDate = (global::System.DateTime?)v) /*--ExportedDate--*/
			{
				Name = "Cpd_ExportedDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_ExportedDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Cpd_Moved, (v) => this.Cpd_Moved = (global::System.Int32?)v) /*--Moved--*/
			{
				Name = "Cpd_Moved",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_Moved,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpd_Annul, (v) => this.Cpd_Annul = (global::System.Int32?)v) /*--Annul--*/
			{
				Name = "Cpd_Annul",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_Annul,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pre_ExternalID, (v) => this.Pre_ExternalID = (global::System.Int32?)v) /*--ReestrID--*/
			{
				Name = "Pre_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pre_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Bnk_ID, (v) => this.Bnk_ID = (global::System.Int32?)v) /*--BankID--*/
			{
				Name = "Bnk_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bnk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cof_ID, (v) => this.Cof_ID = (global::System.Int32?)v) /*--KassaID--*/
			{
				Name = "Cof_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cof_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Loc_ID, (v) => this.Loc_ID = (global::System.Int32?)v) /*--LocationID--*/
			{
				Name = "Loc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Loc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpc_ID, (v) => this.Cpc_ID = (global::System.Int32?)v) /*--PayClass--*/
			{
				Name = "Cpc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pre_NumReestr, (v) => this.Pre_NumReestr = (global::System.String)v) /*--ReestrNumber--*/
			{
				Name = "Pre_NumReestr",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pre_NumReestr,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--AccountNumber--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpd_AnnulBy, (v) => this.Cpd_AnnulBy = (global::System.String)v) /*--AnnulBy--*/
			{
				Name = "Cpd_AnnulBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_AnnulBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpif_ID, (v) => this.Cpif_ID = (global::System.Int32?)v) /*--PayInterfaceID--*/
			{
				Name = "Cpif_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpif_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crn_CodeISO, (v) => this.Crn_CodeISO = (global::System.String)v) /*--CurrencyCode--*/
			{
				Name = "Crn_CodeISO",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crn_CodeISO,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpd_Amount, (v) => this.Cpd_Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Cpd_Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Cpd_PayEffDate, (v) => this.Cpd_PayEffDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "Cpd_PayEffDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_PayEffDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpd_DesPhone, (v) => this.Cpd_DesPhone = (global::System.String)v) /*--ExtentionNumber--*/
			{
				Name = "Cpd_DesPhone",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_DesPhone,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bac_ID, (v) => this.Bac_ID = (global::System.Int32?)v) /*--BankAccountID--*/
			{
				Name = "Bac_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpd_DealerId, (v) => this.Cpd_DealerId = (global::System.Int32?)v) /*--DealerId--*/
			{
				Name = "Cpd_DealerId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_DealerId,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cpd_PayDocNumber, (v) => this.Cpd_PayDocNumber = (global::System.String)v) /*--PayDocNumber--*/
			{
				Name = "Cpd_PayDocNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_PayDocNumber,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpd_ExportID, (v) => this.Cpd_ExportID = (global::System.Int32?)v) /*--ExportID--*/
			{
				Name = "Cpd_ExportID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cpd_ExportID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.cacheStatus, (v) => this.cacheStatus = (global::System.String)v) /*--cacheStatus--*/
			{
				Name = "cacheStatus",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cacheStatus,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cpd_ExternalID, (v) => this.Cpd_ExternalID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "Cpd_ExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Cpd_ExternalID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ID, (v) => this.ID = (global::System.String)v) /*--ID--*/
			{
				Name = "ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_PayDocs_Response : ICallProcedureModel<SET_p_ucp_set_PayDocs_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_PayDocs_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_PayDocs_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Уникальный идентификатор платежного документа в спец. формате (20 символов), включающем в себя код системы, генерирующий платежный документ
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String Cpd_ExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Уникальный идентификатор платежного документа в спец. формате (15 символов), включающем в себя код системы, генерирующий платежный документ
		/// <para/>
		/// ID
		/// </summary>
		public global::System.String ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_PayDocs_Response()
		{
			expressions.Add((m) => m.Cpd_ExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_PayDocs_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_PayDocs";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Cpd_ExternalID, (v) => this.Cpd_ExternalID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "Cpd_ExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Cpd_ExternalID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ID, (v) => this.ID = (global::System.String)v) /*--ID--*/
			{
				Name = "ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.ID,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [PaymentRegistry]
	[DocIgnore]
	public class GET_p_ucp_get_PayReestres_Request : ICallProcedureModel<GET_p_ucp_get_PayReestres_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_PayReestres_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_PayReestres_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? bac_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// bnk_ID
		/// </summary>
		public global::System.Int32? bnk_ID { get; set; } /*IN*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pre_ExternalID
		/// </summary>
		public global::System.Int32? pre_ExternalID { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_PayReestres_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_PayReestres_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_PayReestres";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.bac_ID, (v) => this.bac_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "bac_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.bac_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.bnk_ID, (v) => this.bnk_ID = (global::System.Int32?)v) /*--bnk_ID--*/
			{
				Name = "bnk_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.bnk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.pre_ExternalID, (v) => this.pre_ExternalID = (global::System.Int32?)v) /*--pre_ExternalID--*/
			{
				Name = "pre_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.pre_ExternalID,
				DBType = System.Data.DbType.Int32
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_PayReestres_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_PayReestres_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// pre_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? pre_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pre_DateReestr
		/// </summary>
		[Required]
		public global::System.DateTime? pre_DateReestr { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? pre_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pre_NumReestr
		/// </summary>
		[Required]
		public global::System.String pre_NumReestr { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// bac_ID
		/// </summary>
		public global::System.Int32? bac_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// bnk_ID
		/// </summary>
		[Required]
		public global::System.Int32? bnk_ID { get; set; } /*OUTPUT*/
#endregion
	}
	[DocIgnore]
	public class SET_p_ucp_set_PayReestres_Request : ICallProcedureModel<SET_p_ucp_set_PayReestres_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_PayReestres_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_PayReestres_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? bac_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// crn_CodeISO
		/// </summary>
		public global::System.String crn_CodeISO { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// pre_DateReestr
		/// </summary>
		public global::System.DateTime? pre_DateReestr { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// pre_ExternalID
		/// </summary>
		public global::System.Int32? pre_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? pre_ID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pre_NumReestr
		/// </summary>
		public global::System.String pre_NumReestr { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// bnk_ID
		/// </summary>
		public global::System.Int32? bnk_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_PayReestres_Request()
		{
			expressions.Add((m) => m.pre_ID); // INOUT
			expressions.Add((m) => m.bnk_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_PayReestres_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_PayReestres";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.bac_ID, (v) => this.bac_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "bac_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.bac_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.crn_CodeISO, (v) => this.crn_CodeISO = (global::System.String)v) /*--crn_CodeISO--*/
			{
				Name = "crn_CodeISO",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.crn_CodeISO,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.pre_DateReestr, (v) => this.pre_DateReestr = (global::System.DateTime?)v) /*--pre_DateReestr--*/
			{
				Name = "pre_DateReestr",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.pre_DateReestr,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.pre_ExternalID, (v) => this.pre_ExternalID = (global::System.Int32?)v) /*--pre_ExternalID--*/
			{
				Name = "pre_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.pre_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.pre_ID, (v) => this.pre_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "pre_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.pre_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.pre_NumReestr, (v) => this.pre_NumReestr = (global::System.String)v) /*--pre_NumReestr--*/
			{
				Name = "pre_NumReestr",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.pre_NumReestr,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.bnk_ID, (v) => this.bnk_ID = (global::System.Int32?)v) /*--bnk_ID--*/
			{
				Name = "bnk_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.bnk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_PayReestres_Response : ICallProcedureModel<SET_p_ucp_set_PayReestres_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_PayReestres_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_PayReestres_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? pre_ID { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// bnk_ID
		/// </summary>
		public global::System.Int32? bnk_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_PayReestres_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.pre_ID); // OUT
			expressions.Add((m) => m.bnk_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_PayReestres_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_PayReestres";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.pre_ID, (v) => this.pre_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "pre_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.pre_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.bnk_ID, (v) => this.bnk_ID = (global::System.Int32?)v) /*--bnk_ID--*/
			{
				Name = "bnk_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.bnk_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [PhoneNumbers]
	[DocIgnore]
	public class SET_p_ucp_set_CodeRegions_PhoneNumbers_Request : ICallProcedureModel<SET_p_ucp_set_CodeRegions_PhoneNumbers_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CodeRegions_PhoneNumbers_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CodeRegions_PhoneNumbers_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Номер телефона (Б-номер)
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String Cds_FullCode { get; set; } /*IN*/
			/// <summary>
		/// Признак удаления
		/// <para/>
		/// IsRemoved
		/// </summary>
		public global::System.Int32? Cds_IsRemoved { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания присутствия номера телефона в группе
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? Crgb_DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала присутствия номера телефона в группе
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? Crgb_DateStart { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор исторической записи присутствия номера телефона в группе
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Crgb_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор Закрытой абонентской группы
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Crg_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Дополнительный код города
		/// <para/>
		/// Cds_CityAddCode
		/// </summary>
		public global::System.String Cds_CityAddCode { get; set; } /*IN*/
			/// <summary>
		/// Код города
		/// <para/>
		/// Cds_CityCode
		/// </summary>
		public global::System.String Cds_CityCode { get; set; } /*IN*/
			/// <summary>
		/// Код страны
		/// <para/>
		/// Cds_CountryCode
		/// </summary>
		public global::System.String Cds_CountryCode { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор кода направления. Связь с Codes
		/// <para/>
		/// Cds_ID
		/// </summary>
		public global::System.Int32? Cds_ID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Cds_Name
		/// </summary>
		public global::System.String Cds_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Crg_RegionNameEN
		/// </summary>
		public global::System.String Crg_RegionNameEN { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_CodeRegions_PhoneNumbers_Request()
		{
			expressions.Add((m) => m.Crgb_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Cds_ID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CodeRegions_PhoneNumbers_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CodeRegions_PhoneNumbers";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_FullCode, (v) => this.Cds_FullCode = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "Cds_FullCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_FullCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_IsRemoved, (v) => this.Cds_IsRemoved = (global::System.Int32?)v) /*--IsRemoved--*/
			{
				Name = "Cds_IsRemoved",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_IsRemoved,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crgb_DateEnd, (v) => this.Crgb_DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "Crgb_DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crgb_DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Crgb_DateStart, (v) => this.Crgb_DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "Crgb_DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crgb_DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crgb_ID, (v) => this.Crgb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Crgb_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Crgb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crg_ID, (v) => this.Crg_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Crg_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_CityAddCode, (v) => this.Cds_CityAddCode = (global::System.String)v) /*--Cds_CityAddCode--*/
			{
				Name = "Cds_CityAddCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CityAddCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_CityCode, (v) => this.Cds_CityCode = (global::System.String)v) /*--Cds_CityCode--*/
			{
				Name = "Cds_CityCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CityCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_CountryCode, (v) => this.Cds_CountryCode = (global::System.String)v) /*--Cds_CountryCode--*/
			{
				Name = "Cds_CountryCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CountryCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_ID, (v) => this.Cds_ID = (global::System.Int32?)v) /*--Cds_ID--*/
			{
				Name = "Cds_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Cds_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cds_Name, (v) => this.Cds_Name = (global::System.String)v) /*--Cds_Name--*/
			{
				Name = "Cds_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crg_RegionNameEN, (v) => this.Crg_RegionNameEN = (global::System.String)v) /*--Crg_RegionNameEN--*/
			{
				Name = "Crg_RegionNameEN",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_RegionNameEN,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_CodeRegions_PhoneNumbers_Response : ICallProcedureModel<SET_p_ucp_set_CodeRegions_PhoneNumbers_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CodeRegions_PhoneNumbers_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CodeRegions_PhoneNumbers_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор исторической записи присутствия номера телефона в группе
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Crgb_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор кода направления. Связь с Codes
		/// <para/>
		/// Cds_ID
		/// </summary>
		public global::System.Int32? Cds_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_CodeRegions_PhoneNumbers_Response()
		{
			expressions.Add((m) => m.Crgb_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Cds_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CodeRegions_PhoneNumbers_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CodeRegions_PhoneNumbers";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Crgb_ID, (v) => this.Crgb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Crgb_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Crgb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_ID, (v) => this.Cds_ID = (global::System.Int32?)v) /*--Cds_ID--*/
			{
				Name = "Cds_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Cds_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [PortabilityNumbers]
	[DocIgnore]
	public class SET_p_ucp_set_CodeRegions_Request : ICallProcedureModel<SET_p_ucp_set_CodeRegions_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CodeRegions_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CodeRegions_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Номер телефона, переходящего в зону MNP
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String Cds_FullCode { get; set; } /*IN*/
			/// <summary>
		/// Признак удаления
		/// <para/>
		/// IsRemoved
		/// </summary>
		public global::System.Int32? Cds_IsRemoved { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия
		/// <para/>
		/// PortedDate
		/// </summary>
		public global::System.DateTime? Crgb_DateStart { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Зона MNP, принимающая номер телефона
		/// <para/>
		/// RecipientRC
		/// </summary>
		public global::System.String Crg_RegionNameEN { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор исторической записи связки номера и зоны
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Crgb_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Abn_ID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Дополнительный код города
		/// <para/>
		/// Cds_CityAddCode
		/// </summary>
		public global::System.String Cds_CityAddCode { get; set; } /*IN*/
			/// <summary>
		/// Код города
		/// <para/>
		/// Cds_CityCode
		/// </summary>
		public global::System.String Cds_CityCode { get; set; } /*IN*/
			/// <summary>
		/// Код страны
		/// <para/>
		/// Cds_CountryCode
		/// </summary>
		public global::System.String Cds_CountryCode { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор кода направления. Связь с Codes
		/// <para/>
		/// Cds_ID
		/// </summary>
		public global::System.Int32? Cds_ID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Cds_Name
		/// </summary>
		public global::System.String Cds_Name { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор внешней зоны. Связь с CodeRegionGroups
		/// <para/>
		/// Crg_ID
		/// </summary>
		public global::System.Int32? Crg_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата окончанимя действия записи
		/// <para/>
		/// Crgb_DateEnd
		/// </summary>
		public global::System.DateTime? Crgb_DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Имя сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Признак добавлять номера абонента в Закрытую Группу или нет
		/// <para/>
		/// IncludeNumbers
		/// </summary>
		public global::System.Int32? IncludeNumbers { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_CodeRegions_Request()
		{
			expressions.Add((m) => m.Crgb_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Cds_ID); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CodeRegions_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CodeRegions";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Cds_FullCode, (v) => this.Cds_FullCode = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "Cds_FullCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_FullCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_IsRemoved, (v) => this.Cds_IsRemoved = (global::System.Int32?)v) /*--IsRemoved--*/
			{
				Name = "Cds_IsRemoved",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_IsRemoved,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crgb_DateStart, (v) => this.Crgb_DateStart = (global::System.DateTime?)v) /*--PortedDate--*/
			{
				Name = "Crgb_DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crgb_DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crg_RegionNameEN, (v) => this.Crg_RegionNameEN = (global::System.String)v) /*--RecipientRC--*/
			{
				Name = "Crg_RegionNameEN",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_RegionNameEN,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crgb_ID, (v) => this.Crgb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Crgb_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Crgb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--Abn_ID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cds_CityAddCode, (v) => this.Cds_CityAddCode = (global::System.String)v) /*--Cds_CityAddCode--*/
			{
				Name = "Cds_CityAddCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CityAddCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_CityCode, (v) => this.Cds_CityCode = (global::System.String)v) /*--Cds_CityCode--*/
			{
				Name = "Cds_CityCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CityCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_CountryCode, (v) => this.Cds_CountryCode = (global::System.String)v) /*--Cds_CountryCode--*/
			{
				Name = "Cds_CountryCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_CountryCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_ID, (v) => this.Cds_ID = (global::System.Int32?)v) /*--Cds_ID--*/
			{
				Name = "Cds_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Cds_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Cds_Name, (v) => this.Cds_Name = (global::System.String)v) /*--Cds_Name--*/
			{
				Name = "Cds_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cds_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Crg_ID, (v) => this.Crg_ID = (global::System.Int32?)v) /*--Crg_ID--*/
			{
				Name = "Crg_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crg_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Crgb_DateEnd, (v) => this.Crgb_DateEnd = (global::System.DateTime?)v) /*--Crgb_DateEnd--*/
			{
				Name = "Crgb_DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Crgb_DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IncludeNumbers, (v) => this.IncludeNumbers = (global::System.Int32?)v) /*--IncludeNumbers--*/
			{
				Name = "IncludeNumbers",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IncludeNumbers,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_CodeRegions_Response : ICallProcedureModel<SET_p_ucp_set_CodeRegions_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_CodeRegions_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_CodeRegions_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор исторической записи связки номера и зоны
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Crgb_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор кода направления. Связь с Codes
		/// <para/>
		/// Cds_ID
		/// </summary>
		public global::System.Int32? Cds_ID { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_CodeRegions_Response()
		{
			expressions.Add((m) => m.Crgb_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Cds_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_CodeRegions_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_CodeRegions";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Crgb_ID, (v) => this.Crgb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Crgb_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Crgb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cds_ID, (v) => this.Cds_ID = (global::System.Int32?)v) /*--Cds_ID--*/
			{
				Name = "Cds_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Cds_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Profiles]
	[DocIgnore]
	public class SET_p_ucp_set_Profiles_Request : ICallProcedureModel<SET_p_ucp_set_Profiles_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Profiles_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Profiles_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Атрибуты узла дерева (используется с указанием формата)
		/// <para/>
		/// Attributes
		/// </summary>
		public global::System.String JsonData { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор причины создания версии аттрибутов
		/// <para/>
		/// IdentityType
		/// </summary>
		public global::System.Int32? vrr_ID { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор шаблона профиля
		/// <para/>
		/// TemplateID
		/// </summary>
		public global::System.Int32? tnv_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат данных аттрибутов профиля
		/// <para/>
		/// DataFormat
		/// </summary>
		public global::System.String DataFormat { get; set; } /*IN*/
			/// <summary>
		/// Код внешней системы - инициатора запроса
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор вышестоящего узла дерева
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор узла дерева
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? aatr_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_Profiles_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.aatr_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Profiles_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Profiles";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.JsonData, (v) => this.JsonData = (global::System.String)v) /*--Attributes--*/
			{
				Name = "JsonData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.JsonData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.vrr_ID, (v) => this.vrr_ID = (global::System.Int32?)v) /*--IdentityType--*/
			{
				Name = "vrr_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.vrr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.tnv_ID, (v) => this.tnv_ID = (global::System.Int32?)v) /*--TemplateID--*/
			{
				Name = "tnv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.tnv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DataFormat, (v) => this.DataFormat = (global::System.String)v) /*--DataFormat--*/
			{
				Name = "DataFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DataFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.aatr_ID, (v) => this.aatr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "aatr_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.aatr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_Profiles_Response : ICallProcedureModel<SET_p_ucp_set_Profiles_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Profiles_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Profiles_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор Атрибутов узла дерева
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? aatr_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_Profiles_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.aatr_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Profiles_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Profiles";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aatr_ID, (v) => this.aatr_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "aatr_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.aatr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [RatingData]
	[DocIgnore]
	public class SET_p_ucp_set_ServiceReservations_Request : ICallProcedureModel<SET_p_ucp_set_ServiceReservations_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_ServiceReservations_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_ServiceReservations_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// beginTimeStamp
		/// </summary>
		public global::System.DateTime? beginTimeStamp { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// CheckBalanceMode
		/// </summary>
		public global::System.Int32? CheckBalanceMode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// consumedUnit
		/// </summary>
		public global::System.Int32? consumedUnit { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// destinationIdData
		/// </summary>
		public global::System.String destinationIdData { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// destinationIdType
		/// </summary>
		public global::System.String destinationIdType { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		public global::System.String srsv_UniqueID { get; set; } /*INOUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationTimeStamp
		/// </summary>
		public global::System.DateTime? invocationTimeStamp { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*IN*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// mode
		/// </summary>
		public global::System.String Mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// nfConsumerIdentification
		/// </summary>
		[Required]
		public global::System.String nfConsumerIdentification { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// oneTimeEvent
		/// </summary>
		public global::System.String oneTimeEvent { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// oneTimeEventType
		/// </summary>
		public global::System.String oneTimeEventType { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ratingGroup
		/// </summary>
		public global::System.Int32? ratingGroup { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// requestedUnit
		/// </summary>
		public global::System.Int32? requestedUnit { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// requestSubType
		/// </summary>
		public global::System.String requestSubType { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceContextId
		/// </summary>
		public global::System.String serviceContextId { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceId
		/// </summary>
		public global::System.Int32? serviceId { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceRating
		/// </summary>
		[Required]
		public global::System.String serviceRating { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_ID
		/// </summary>
		public global::System.Int64? srsv_ID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_LinkID
		/// </summary>
		public global::System.Int64? srsv_LinkID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_Remark
		/// </summary>
		public global::System.String srsv_Remark { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// subscriptionId
		/// </summary>
		public global::System.String subscriptionId { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationSequenceNumber
		/// </summary>
		[Required]
		public global::System.Int32? invocationSequenceNumber { get; set; } /*INOUT*/
			/// <summary>
		/// Имя сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// location
		/// </summary>
		public global::System.String location { get; set; } /*INOUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_ServiceReservations_Request()
		{
			expressions.Add((m) => m.srsv_UniqueID); // INOUT
			expressions.Add((m) => m.invocationTimeStamp); // INOUT
			expressions.Add((m) => m.serviceRating); // INOUT
			expressions.Add((m) => m.srsv_ID); // INOUT
			expressions.Add((m) => m.srsv_LinkID); // INOUT
			expressions.Add((m) => m.invocationSequenceNumber); // INOUT
			expressions.Add((m) => m.location); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_ServiceReservations_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceReservations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.beginTimeStamp, (v) => this.beginTimeStamp = (global::System.DateTime?)v) /*--beginTimeStamp--*/
			{
				Name = "beginTimeStamp",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.beginTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.CheckBalanceMode, (v) => this.CheckBalanceMode = (global::System.Int32?)v) /*--CheckBalanceMode--*/
			{
				Name = "CheckBalanceMode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.CheckBalanceMode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.consumedUnit, (v) => this.consumedUnit = (global::System.Int32?)v) /*--consumedUnit--*/
			{
				Name = "consumedUnit",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.consumedUnit,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.destinationIdData, (v) => this.destinationIdData = (global::System.String)v) /*--destinationIdData--*/
			{
				Name = "destinationIdData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.destinationIdData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.destinationIdType, (v) => this.destinationIdType = (global::System.String)v) /*--destinationIdType--*/
			{
				Name = "destinationIdType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.destinationIdType,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_UniqueID, (v) => this.srsv_UniqueID = (global::System.String)v) /*--ID--*/
			{
				Name = "srsv_UniqueID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.invocationTimeStamp, (v) => this.invocationTimeStamp = (global::System.DateTime?)v) /*--invocationTimeStamp--*/
			{
				Name = "invocationTimeStamp",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.invocationTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Mode, (v) => this.Mode = (global::System.String)v) /*--mode--*/
			{
				Name = "Mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Mode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.nfConsumerIdentification, (v) => this.nfConsumerIdentification = (global::System.String)v) /*--nfConsumerIdentification--*/
			{
				Name = "nfConsumerIdentification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.nfConsumerIdentification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.oneTimeEvent, (v) => this.oneTimeEvent = (global::System.String)v) /*--oneTimeEvent--*/
			{
				Name = "oneTimeEvent",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.oneTimeEvent,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.oneTimeEventType, (v) => this.oneTimeEventType = (global::System.String)v) /*--oneTimeEventType--*/
			{
				Name = "oneTimeEventType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.oneTimeEventType,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ratingGroup, (v) => this.ratingGroup = (global::System.Int32?)v) /*--ratingGroup--*/
			{
				Name = "ratingGroup",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ratingGroup,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.requestedUnit, (v) => this.requestedUnit = (global::System.Int32?)v) /*--requestedUnit--*/
			{
				Name = "requestedUnit",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.requestedUnit,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.requestSubType, (v) => this.requestSubType = (global::System.String)v) /*--requestSubType--*/
			{
				Name = "requestSubType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.requestSubType,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.serviceContextId, (v) => this.serviceContextId = (global::System.String)v) /*--serviceContextId--*/
			{
				Name = "serviceContextId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.serviceContextId,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.serviceId, (v) => this.serviceId = (global::System.Int32?)v) /*--serviceId--*/
			{
				Name = "serviceId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.serviceId,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.serviceRating, (v) => this.serviceRating = (global::System.String)v) /*--serviceRating--*/
			{
				Name = "serviceRating",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.serviceRating,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_ID, (v) => this.srsv_ID = (global::System.Int64?)v) /*--srsv_ID--*/
			{
				Name = "srsv_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_LinkID, (v) => this.srsv_LinkID = (global::System.Int64?)v) /*--srsv_LinkID--*/
			{
				Name = "srsv_LinkID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_LinkID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_Remark, (v) => this.srsv_Remark = (global::System.String)v) /*--srsv_Remark--*/
			{
				Name = "srsv_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.srsv_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.subscriptionId, (v) => this.subscriptionId = (global::System.String)v) /*--subscriptionId--*/
			{
				Name = "subscriptionId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.subscriptionId,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.invocationSequenceNumber, (v) => this.invocationSequenceNumber = (global::System.Int32?)v) /*--invocationSequenceNumber--*/
			{
				Name = "invocationSequenceNumber",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.invocationSequenceNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.location, (v) => this.location = (global::System.String)v) /*--location--*/
			{
				Name = "location",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.location,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_ServiceReservations_Response : ICallProcedureModel<SET_p_ucp_set_ServiceReservations_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_ServiceReservations_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_ServiceReservations_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		public global::System.String srsv_UniqueID { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationTimeStamp
		/// </summary>
		public global::System.DateTime? invocationTimeStamp { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceRating
		/// </summary>
		[Required]
		public global::System.String serviceRating { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_ID
		/// </summary>
		public global::System.Int64? srsv_ID { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_LinkID
		/// </summary>
		public global::System.Int64? srsv_LinkID { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationSequenceNumber
		/// </summary>
		[Required]
		public global::System.Int32? invocationSequenceNumber { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// location
		/// </summary>
		public global::System.String location { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_ServiceReservations_Response()
		{
			expressions.Add((m) => m.srsv_UniqueID); // OUT
			expressions.Add((m) => m.invocationTimeStamp); // OUT
			expressions.Add((m) => m.serviceRating); // OUT
			expressions.Add((m) => m.srsv_ID); // OUT
			expressions.Add((m) => m.srsv_LinkID); // OUT
			expressions.Add((m) => m.invocationSequenceNumber); // OUT
			expressions.Add((m) => m.location); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_ServiceReservations_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceReservations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.srsv_UniqueID, (v) => this.srsv_UniqueID = (global::System.String)v) /*--ID--*/
			{
				Name = "srsv_UniqueID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.srsv_UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.invocationTimeStamp, (v) => this.invocationTimeStamp = (global::System.DateTime?)v) /*--invocationTimeStamp--*/
			{
				Name = "invocationTimeStamp",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.invocationTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.serviceRating, (v) => this.serviceRating = (global::System.String)v) /*--serviceRating--*/
			{
				Name = "serviceRating",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.serviceRating,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_ID, (v) => this.srsv_ID = (global::System.Int64?)v) /*--srsv_ID--*/
			{
				Name = "srsv_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.srsv_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_LinkID, (v) => this.srsv_LinkID = (global::System.Int64?)v) /*--srsv_LinkID--*/
			{
				Name = "srsv_LinkID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.srsv_LinkID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.invocationSequenceNumber, (v) => this.invocationSequenceNumber = (global::System.Int32?)v) /*--invocationSequenceNumber--*/
			{
				Name = "invocationSequenceNumber",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.invocationSequenceNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.location, (v) => this.location = (global::System.String)v) /*--location--*/
			{
				Name = "location",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.location,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [RatingData/Release]
	[DocIgnore]
	public class ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request : ICallProcedureModel<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// beginTimeStamp
		/// </summary>
		public global::System.DateTime? beginTimeStamp { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// CheckBalanceMode
		/// </summary>
		public global::System.Int32? CheckBalanceMode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// consumedUnit
		/// </summary>
		public global::System.Int32? consumedUnit { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// destinationIdData
		/// </summary>
		public global::System.String destinationIdData { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// destinationIdType
		/// </summary>
		public global::System.String destinationIdType { get; set; } /*IN*/
			/// <summary>
		/// Имя сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationSequenceNumber
		/// </summary>
		[Required]
		public global::System.Int32? invocationSequenceNumber { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationTimeStamp
		/// </summary>
		public global::System.DateTime? invocationTimeStamp { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*IN*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// mode
		/// </summary>
		public global::System.String Mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// nfConsumerIdentification
		/// </summary>
		[Required]
		public global::System.String nfConsumerIdentification { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.String srsv_UniqueID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ratingGroup
		/// </summary>
		public global::System.Int32? ratingGroup { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// requestedUnit
		/// </summary>
		public global::System.Int32? requestedUnit { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// requestSubType
		/// </summary>
		public global::System.String requestSubType { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceContextId
		/// </summary>
		public global::System.String serviceContextId { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceId
		/// </summary>
		public global::System.Int32? serviceId { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceRating
		/// </summary>
		[Required]
		public global::System.String serviceRating { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_ID
		/// </summary>
		public global::System.Int64? srsv_ID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_LinkID
		/// </summary>
		public global::System.Int64? srsv_LinkID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_Remark
		/// </summary>
		public global::System.String srsv_Remark { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// subscriptionId
		/// </summary>
		public global::System.String subscriptionId { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request()
		{
			expressions.Add((m) => m.invocationSequenceNumber); // INOUT
			expressions.Add((m) => m.invocationTimeStamp); // INOUT
			expressions.Add((m) => m.srsv_UniqueID); // INOUT
			expressions.Add((m) => m.serviceRating); // INOUT
			expressions.Add((m) => m.srsv_ID); // INOUT
			expressions.Add((m) => m.srsv_LinkID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceReservations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.beginTimeStamp, (v) => this.beginTimeStamp = (global::System.DateTime?)v) /*--beginTimeStamp--*/
			{
				Name = "beginTimeStamp",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.beginTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.CheckBalanceMode, (v) => this.CheckBalanceMode = (global::System.Int32?)v) /*--CheckBalanceMode--*/
			{
				Name = "CheckBalanceMode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.CheckBalanceMode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.consumedUnit, (v) => this.consumedUnit = (global::System.Int32?)v) /*--consumedUnit--*/
			{
				Name = "consumedUnit",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.consumedUnit,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.destinationIdData, (v) => this.destinationIdData = (global::System.String)v) /*--destinationIdData--*/
			{
				Name = "destinationIdData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.destinationIdData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.destinationIdType, (v) => this.destinationIdType = (global::System.String)v) /*--destinationIdType--*/
			{
				Name = "destinationIdType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.destinationIdType,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.invocationSequenceNumber, (v) => this.invocationSequenceNumber = (global::System.Int32?)v) /*--invocationSequenceNumber--*/
			{
				Name = "invocationSequenceNumber",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.invocationSequenceNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.invocationTimeStamp, (v) => this.invocationTimeStamp = (global::System.DateTime?)v) /*--invocationTimeStamp--*/
			{
				Name = "invocationTimeStamp",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.invocationTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Mode, (v) => this.Mode = (global::System.String)v) /*--mode--*/
			{
				Name = "Mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Mode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.nfConsumerIdentification, (v) => this.nfConsumerIdentification = (global::System.String)v) /*--nfConsumerIdentification--*/
			{
				Name = "nfConsumerIdentification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.nfConsumerIdentification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_UniqueID, (v) => this.srsv_UniqueID = (global::System.String)v) /*--ParentID--*/
			{
				Name = "srsv_UniqueID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ratingGroup, (v) => this.ratingGroup = (global::System.Int32?)v) /*--ratingGroup--*/
			{
				Name = "ratingGroup",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ratingGroup,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.requestedUnit, (v) => this.requestedUnit = (global::System.Int32?)v) /*--requestedUnit--*/
			{
				Name = "requestedUnit",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.requestedUnit,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.requestSubType, (v) => this.requestSubType = (global::System.String)v) /*--requestSubType--*/
			{
				Name = "requestSubType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.requestSubType,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.serviceContextId, (v) => this.serviceContextId = (global::System.String)v) /*--serviceContextId--*/
			{
				Name = "serviceContextId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.serviceContextId,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.serviceId, (v) => this.serviceId = (global::System.Int32?)v) /*--serviceId--*/
			{
				Name = "serviceId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.serviceId,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.serviceRating, (v) => this.serviceRating = (global::System.String)v) /*--serviceRating--*/
			{
				Name = "serviceRating",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.serviceRating,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_ID, (v) => this.srsv_ID = (global::System.Int64?)v) /*--srsv_ID--*/
			{
				Name = "srsv_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_LinkID, (v) => this.srsv_LinkID = (global::System.Int64?)v) /*--srsv_LinkID--*/
			{
				Name = "srsv_LinkID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_LinkID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_Remark, (v) => this.srsv_Remark = (global::System.String)v) /*--srsv_Remark--*/
			{
				Name = "srsv_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.srsv_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.subscriptionId, (v) => this.subscriptionId = (global::System.String)v) /*--subscriptionId--*/
			{
				Name = "subscriptionId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.subscriptionId,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response : ICallProcedureModel<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// invocationSequenceNumber
		/// </summary>
		[Required]
		public global::System.Int32? invocationSequenceNumber { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationTimeStamp
		/// </summary>
		public global::System.DateTime? invocationTimeStamp { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceRating
		/// </summary>
		[Required]
		public global::System.String serviceRating { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_ID
		/// </summary>
		public global::System.Int64? srsv_ID { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_LinkID
		/// </summary>
		public global::System.Int64? srsv_LinkID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response()
		{
			expressions.Add((m) => m.invocationSequenceNumber); // OUT
			expressions.Add((m) => m.invocationTimeStamp); // OUT
			expressions.Add((m) => m.serviceRating); // OUT
			expressions.Add((m) => m.srsv_ID); // OUT
			expressions.Add((m) => m.srsv_LinkID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceReservations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.invocationSequenceNumber, (v) => this.invocationSequenceNumber = (global::System.Int32?)v) /*--invocationSequenceNumber--*/
			{
				Name = "invocationSequenceNumber",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.invocationSequenceNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.invocationTimeStamp, (v) => this.invocationTimeStamp = (global::System.DateTime?)v) /*--invocationTimeStamp--*/
			{
				Name = "invocationTimeStamp",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.invocationTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.serviceRating, (v) => this.serviceRating = (global::System.String)v) /*--serviceRating--*/
			{
				Name = "serviceRating",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.serviceRating,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_ID, (v) => this.srsv_ID = (global::System.Int64?)v) /*--srsv_ID--*/
			{
				Name = "srsv_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.srsv_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_LinkID, (v) => this.srsv_LinkID = (global::System.Int64?)v) /*--srsv_LinkID--*/
			{
				Name = "srsv_LinkID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.srsv_LinkID,
				DBType = System.Data.DbType.Int64
			};
		}
	}
#endregion
#region [RatingData/Update]
	[DocIgnore]
	public class ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request : ICallProcedureModel<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// beginTimeStamp
		/// </summary>
		public global::System.DateTime? beginTimeStamp { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// CheckBalanceMode
		/// </summary>
		public global::System.Int32? CheckBalanceMode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// consumedUnit
		/// </summary>
		public global::System.Int32? consumedUnit { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// destinationIdData
		/// </summary>
		public global::System.String destinationIdData { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// destinationIdType
		/// </summary>
		public global::System.String destinationIdType { get; set; } /*IN*/
			/// <summary>
		/// Имя сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationSequenceNumber
		/// </summary>
		[Required]
		public global::System.Int32? invocationSequenceNumber { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationTimeStamp
		/// </summary>
		public global::System.DateTime? invocationTimeStamp { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// location
		/// </summary>
		public global::System.String location { get; set; } /*INOUT*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// mode
		/// </summary>
		public global::System.String Mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// nfConsumerIdentification
		/// </summary>
		[Required]
		public global::System.String nfConsumerIdentification { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// oneTimeEvent
		/// </summary>
		public global::System.String oneTimeEvent { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// oneTimeEventType
		/// </summary>
		public global::System.String oneTimeEventType { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.String srsv_UniqueID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ratingGroup
		/// </summary>
		public global::System.Int32? ratingGroup { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// requestedUnit
		/// </summary>
		public global::System.Int32? requestedUnit { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// requestSubType
		/// </summary>
		public global::System.String requestSubType { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceContextId
		/// </summary>
		public global::System.String serviceContextId { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceId
		/// </summary>
		public global::System.Int32? serviceId { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceRating
		/// </summary>
		[Required]
		public global::System.String serviceRating { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_ID
		/// </summary>
		public global::System.Int64? srsv_ID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_LinkID
		/// </summary>
		public global::System.Int64? srsv_LinkID { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_Remark
		/// </summary>
		public global::System.String srsv_Remark { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// subscriptionId
		/// </summary>
		public global::System.String subscriptionId { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request()
		{
			expressions.Add((m) => m.invocationSequenceNumber); // INOUT
			expressions.Add((m) => m.invocationTimeStamp); // INOUT
			expressions.Add((m) => m.location); // INOUT
			expressions.Add((m) => m.srsv_UniqueID); // INOUT
			expressions.Add((m) => m.serviceRating); // INOUT
			expressions.Add((m) => m.srsv_ID); // INOUT
			expressions.Add((m) => m.srsv_LinkID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceReservations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.beginTimeStamp, (v) => this.beginTimeStamp = (global::System.DateTime?)v) /*--beginTimeStamp--*/
			{
				Name = "beginTimeStamp",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.beginTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.CheckBalanceMode, (v) => this.CheckBalanceMode = (global::System.Int32?)v) /*--CheckBalanceMode--*/
			{
				Name = "CheckBalanceMode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.CheckBalanceMode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.consumedUnit, (v) => this.consumedUnit = (global::System.Int32?)v) /*--consumedUnit--*/
			{
				Name = "consumedUnit",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.consumedUnit,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.destinationIdData, (v) => this.destinationIdData = (global::System.String)v) /*--destinationIdData--*/
			{
				Name = "destinationIdData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.destinationIdData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.destinationIdType, (v) => this.destinationIdType = (global::System.String)v) /*--destinationIdType--*/
			{
				Name = "destinationIdType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.destinationIdType,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.invocationSequenceNumber, (v) => this.invocationSequenceNumber = (global::System.Int32?)v) /*--invocationSequenceNumber--*/
			{
				Name = "invocationSequenceNumber",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.invocationSequenceNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.invocationTimeStamp, (v) => this.invocationTimeStamp = (global::System.DateTime?)v) /*--invocationTimeStamp--*/
			{
				Name = "invocationTimeStamp",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.invocationTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.location, (v) => this.location = (global::System.String)v) /*--location--*/
			{
				Name = "location",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.location,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Mode, (v) => this.Mode = (global::System.String)v) /*--mode--*/
			{
				Name = "Mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Mode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.nfConsumerIdentification, (v) => this.nfConsumerIdentification = (global::System.String)v) /*--nfConsumerIdentification--*/
			{
				Name = "nfConsumerIdentification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.nfConsumerIdentification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.oneTimeEvent, (v) => this.oneTimeEvent = (global::System.String)v) /*--oneTimeEvent--*/
			{
				Name = "oneTimeEvent",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.oneTimeEvent,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.oneTimeEventType, (v) => this.oneTimeEventType = (global::System.String)v) /*--oneTimeEventType--*/
			{
				Name = "oneTimeEventType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.oneTimeEventType,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_UniqueID, (v) => this.srsv_UniqueID = (global::System.String)v) /*--ParentID--*/
			{
				Name = "srsv_UniqueID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ratingGroup, (v) => this.ratingGroup = (global::System.Int32?)v) /*--ratingGroup--*/
			{
				Name = "ratingGroup",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ratingGroup,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.requestedUnit, (v) => this.requestedUnit = (global::System.Int32?)v) /*--requestedUnit--*/
			{
				Name = "requestedUnit",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.requestedUnit,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.requestSubType, (v) => this.requestSubType = (global::System.String)v) /*--requestSubType--*/
			{
				Name = "requestSubType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.requestSubType,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.serviceContextId, (v) => this.serviceContextId = (global::System.String)v) /*--serviceContextId--*/
			{
				Name = "serviceContextId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.serviceContextId,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.serviceId, (v) => this.serviceId = (global::System.Int32?)v) /*--serviceId--*/
			{
				Name = "serviceId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.serviceId,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.serviceRating, (v) => this.serviceRating = (global::System.String)v) /*--serviceRating--*/
			{
				Name = "serviceRating",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.serviceRating,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_ID, (v) => this.srsv_ID = (global::System.Int64?)v) /*--srsv_ID--*/
			{
				Name = "srsv_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_LinkID, (v) => this.srsv_LinkID = (global::System.Int64?)v) /*--srsv_LinkID--*/
			{
				Name = "srsv_LinkID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.srsv_LinkID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_Remark, (v) => this.srsv_Remark = (global::System.String)v) /*--srsv_Remark--*/
			{
				Name = "srsv_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.srsv_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.subscriptionId, (v) => this.subscriptionId = (global::System.String)v) /*--subscriptionId--*/
			{
				Name = "subscriptionId",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.subscriptionId,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response : ICallProcedureModel<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// invocationSequenceNumber
		/// </summary>
		[Required]
		public global::System.Int32? invocationSequenceNumber { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// invocationTimeStamp
		/// </summary>
		public global::System.DateTime? invocationTimeStamp { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// location
		/// </summary>
		public global::System.String location { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// serviceRating
		/// </summary>
		[Required]
		public global::System.String serviceRating { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_ID
		/// </summary>
		public global::System.Int64? srsv_ID { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// srsv_LinkID
		/// </summary>
		public global::System.Int64? srsv_LinkID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response()
		{
			expressions.Add((m) => m.invocationSequenceNumber); // OUT
			expressions.Add((m) => m.invocationTimeStamp); // OUT
			expressions.Add((m) => m.location); // OUT
			expressions.Add((m) => m.serviceRating); // OUT
			expressions.Add((m) => m.srsv_ID); // OUT
			expressions.Add((m) => m.srsv_LinkID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceReservations";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.invocationSequenceNumber, (v) => this.invocationSequenceNumber = (global::System.Int32?)v) /*--invocationSequenceNumber--*/
			{
				Name = "invocationSequenceNumber",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.invocationSequenceNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.invocationTimeStamp, (v) => this.invocationTimeStamp = (global::System.DateTime?)v) /*--invocationTimeStamp--*/
			{
				Name = "invocationTimeStamp",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.invocationTimeStamp,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.location, (v) => this.location = (global::System.String)v) /*--location--*/
			{
				Name = "location",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.location,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.serviceRating, (v) => this.serviceRating = (global::System.String)v) /*--serviceRating--*/
			{
				Name = "serviceRating",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.serviceRating,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.srsv_ID, (v) => this.srsv_ID = (global::System.Int64?)v) /*--srsv_ID--*/
			{
				Name = "srsv_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.srsv_ID,
				DBType = System.Data.DbType.Int64
			};
			yield return new DynamicParameter(() => this.srsv_LinkID, (v) => this.srsv_LinkID = (global::System.Int64?)v) /*--srsv_LinkID--*/
			{
				Name = "srsv_LinkID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.srsv_LinkID,
				DBType = System.Data.DbType.Int64
			};
		}
	}
#endregion
#region [ServiceSubscriptions]
	[DocIgnore]
	public class SET_p_ucp_set_ServiceSubscriptions_Request : ICallProcedureModel<SET_p_ucp_set_ServiceSubscriptions_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_ServiceSubscriptions_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_ServiceSubscriptions_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Эффективная дата для изменения подписки на услугу, используется как DateSet для новых изменений подписки - количества, статуса или PriceRatio
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Дополнительные параметры для provisioning
		/// <para/>
		/// TaskJsonData
		/// </summary>
		public global::System.String Srs_JsonData { get; set; } /*IN*/
			/// <summary>
		/// Дата завершения подписки на услугу, время не требуется. Для разовых подписок параметр не передается или должен быть равен DateSet
		/// <para/>
		/// DateDrop
		/// </summary>
		public global::System.DateTime? Srs_DateDrop { get; set; } /*IN*/
			/// <summary>
		/// Явное указание суммы подписки - для переопределения цены пакета в случае использования FMC подписок (сумма списания на основании суммы платежа)
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? Amount { get; set; } /*IN*/
			/// <summary>
		/// Явное переопределение стоимости услуги через коеффициент - уменьшает или увеличивает сумму подписки на основании цены из Тарифного пакета.
		/// <para/>
		/// PriceRatio
		/// </summary>
		public global::System.Decimal? Srs_PriceRatio { get; set; } /*IN*/
			/// <summary>
		/// Явное указание кол-ва подписки - по умолчанию подписка создается с кол-вом =1. Используется в качестве мультпликатора для подписок на услугу более одного раза в отчетном периоде.
		/// <para/>
		/// Count
		/// </summary>
		public global::System.Int32? Srs_Count { get; set; } /*IN*/
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// PacketID
		/// </summary>
		public global::System.Int32? Pkt_ID { get; set; } /*IN*/
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// TaskID
		/// </summary>
		public global::System.Int32? Tsk_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Явное указание статуса услуги на подписке - используется для разовых подписок с целью изменения статусов услуги для подписок FMC.
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? Sst_ID { get; set; } /*IN*/
			/// <summary>
		/// Причина изменения параметров подписки
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Srs_Remark { get; set; } /*IN*/
			/// <summary>
		/// Дата завершения подписки на услугу, время не требуется
		/// <para/>
		/// DateSet
		/// </summary>
		public global::System.DateTime? Srs_DateSet { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор услуги - значения соответствуют SRLS_ID и PRCL_ID 
		/// <para/>
		/// ServiceCode
		/// </summary>
		[Required]
		public global::System.String Srv_Code { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// OverrideHistory
		/// </summary>
		public global::System.Int32? Sst_IsStatusHistory { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор подписки TemplateSubscriptions - обязательное поле для изменения записи
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Rtb_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор подписки на услугу - обьединяет множественные подписи одной услуги в разное время в одно целое.
		/// <para/>
		/// ID
		/// </summary>
		public global::System.String Srs_SessionID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор Extentions (Номера MSISDN)
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? Ext_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModDate
		/// </summary>
		public global::System.DateTime? ModDate { get; set; } /*IN*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// Mode
		/// </summary>
		public global::System.String Mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ServiceMode
		/// </summary>
		public global::System.String ServiceMode { get; set; } /*IN*/
			/// <summary>
		/// Признак первичной активации или изменения существующей подписки
		/// <para/>
		/// TariffBegin
		/// </summary>
		public global::System.Int32? TariffBegin { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_ServiceSubscriptions_Request()
		{
			expressions.Add((m) => m.Tsk_ID); // INOUT
			expressions.Add((m) => m.Srs_SessionID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_ServiceSubscriptions_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceSubscriptions";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Srs_JsonData, (v) => this.Srs_JsonData = (global::System.String)v) /*--TaskJsonData--*/
			{
				Name = "Srs_JsonData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_JsonData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Srs_DateDrop, (v) => this.Srs_DateDrop = (global::System.DateTime?)v) /*--DateDrop--*/
			{
				Name = "Srs_DateDrop",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_DateDrop,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Amount, (v) => this.Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Amount",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Srs_PriceRatio, (v) => this.Srs_PriceRatio = (global::System.Decimal?)v) /*--PriceRatio--*/
			{
				Name = "Srs_PriceRatio",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_PriceRatio,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Srs_Count, (v) => this.Srs_Count = (global::System.Int32?)v) /*--Count--*/
			{
				Name = "Srs_Count",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_Count,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pkt_ID, (v) => this.Pkt_ID = (global::System.Int32?)v) /*--PacketID--*/
			{
				Name = "Pkt_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pkt_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Tsk_ID, (v) => this.Tsk_ID = (global::System.Int32?)v) /*--TaskID--*/
			{
				Name = "Tsk_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Tsk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Sst_ID, (v) => this.Sst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Sst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srs_Remark, (v) => this.Srs_Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Srs_Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Srs_DateSet, (v) => this.Srs_DateSet = (global::System.DateTime?)v) /*--DateSet--*/
			{
				Name = "Srs_DateSet",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_DateSet,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Srv_Code, (v) => this.Srv_Code = (global::System.String)v) /*--ServiceCode--*/
			{
				Name = "Srv_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sst_IsStatusHistory, (v) => this.Sst_IsStatusHistory = (global::System.Int32?)v) /*--OverrideHistory--*/
			{
				Name = "Sst_IsStatusHistory",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sst_IsStatusHistory,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Rtb_ID, (v) => this.Rtb_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Rtb_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rtb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srs_SessionID, (v) => this.Srs_SessionID = (global::System.String)v) /*--ID--*/
			{
				Name = "Srs_SessionID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Srs_SessionID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ext_ID, (v) => this.Ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "Ext_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModDate, (v) => this.ModDate = (global::System.DateTime?)v) /*--ModDate--*/
			{
				Name = "ModDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Mode, (v) => this.Mode = (global::System.String)v) /*--Mode--*/
			{
				Name = "Mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Mode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ServiceMode, (v) => this.ServiceMode = (global::System.String)v) /*--ServiceMode--*/
			{
				Name = "ServiceMode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ServiceMode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.TariffBegin, (v) => this.TariffBegin = (global::System.Int32?)v) /*--TariffBegin--*/
			{
				Name = "TariffBegin",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TariffBegin,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_ServiceSubscriptions_Response : ICallProcedureModel<SET_p_ucp_set_ServiceSubscriptions_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_ServiceSubscriptions_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_ServiceSubscriptions_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор Tasks, если изменение статута услуги по данной подписки происходит в текущих сутках. Используется для изменения статуса в случе необходимости.
		/// <para/>
		/// TaskID
		/// </summary>
		public global::System.Int32? Tsk_ID { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор подписки на услугу - обьединяет множественные подписи одной услуги в разное время в одно целое.
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.String Srs_SessionID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_ServiceSubscriptions_Response()
		{
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Tsk_ID); // OUT
			expressions.Add((m) => m.Srs_SessionID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_ServiceSubscriptions_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceSubscriptions";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tsk_ID, (v) => this.Tsk_ID = (global::System.Int32?)v) /*--TaskID--*/
			{
				Name = "Tsk_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Tsk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srs_SessionID, (v) => this.Srs_SessionID = (global::System.String)v) /*--ID--*/
			{
				Name = "Srs_SessionID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Srs_SessionID,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Subscribers]
	[DocIgnore]
	public class GET_p_ucp_get_Subscribers_Request : ICallProcedureModel<GET_p_ucp_get_Subscribers_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_Subscribers_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_Subscribers_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// SortColumn
		/// </summary>
		public global::System.String SortColumn { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// SortDirection
		/// </summary>
		public global::System.String SortDirection { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Srv_ID
		/// </summary>
		public global::System.Int32? Srv_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Srv_Name
		/// </summary>
		public global::System.String Srv_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Sst_ID
		/// </summary>
		public global::System.Int32? Sst_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_Code
		/// </summary>
		public global::System.String tnst_Code { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		public global::System.Int32? trf_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		public global::System.String abn_Employee_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		public global::System.Int32? abn_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// LastModifiedDate
		/// </summary>
		public global::System.DateTime? LastModifiedDate { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Format
		/// </summary>
		public global::System.String Format { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Ассоциации или корня 
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		public global::System.Int32? abn_IsExistAD { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Acat_ID
		/// </summary>
		public global::System.Int32? Acat_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Accl_ID
		/// </summary>
		public global::System.Int32? Accl_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Acnt_Number
		/// </summary>
		public global::System.String Acnt_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actp_ID
		/// </summary>
		public global::System.Int32? Actp_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Adlsb_Code
		/// </summary>
		public global::System.Int32? Adlsb_Code { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Aptp_ID
		/// </summary>
		public global::System.Int32? Aptp_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NameAuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Bac_Number
		/// </summary>
		public global::System.String Bac_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// bll_Number
		/// </summary>
		public global::System.String bll_Number { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossLastName
		/// </summary>
		public global::System.String BossLastName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Cntr_Name
		/// </summary>
		public global::System.String Cntr_Name { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_ID
		/// </summary>
		public global::System.Int32? com_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		public global::System.Int32? dep_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Dls_ID
		/// </summary>
		public global::System.Int32? Dls_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		public global::System.String ext_ExtNum { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		public global::System.Int32? grp_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFieldsName
		/// </summary>
		public global::System.String jsonFieldsName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFilter
		/// </summary>
		public global::System.String jsonFilter { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// jsonFilterContain
		/// </summary>
		public global::System.Int32? jsonFilterContain { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Lng_ID
		/// </summary>
		public global::System.Int32? Lng_ID { get; set; } /*IN*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// mode
		/// </summary>
		public global::System.Int32? mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Ntw_ID
		/// </summary>
		public global::System.Int32? Ntw_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageNumber
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
			/// <summary>
		/// Тип профиля
		/// <para/>
		/// ProfileType
		/// </summary>
		public global::System.Int32? ProfileType { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Rgsc_ID
		/// </summary>
		public global::System.Int32? Rgsc_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ShowBalances
		/// </summary>
		public global::System.Int32? ShowBalances { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ShowEntities
		/// </summary>
		public global::System.String ShowEntities { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_Subscribers_Request()
		{
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_Subscribers_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_Subscribers";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.SortColumn, (v) => this.SortColumn = (global::System.String)v) /*--SortColumn--*/
			{
				Name = "SortColumn",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortColumn,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SortDirection, (v) => this.SortDirection = (global::System.String)v) /*--SortDirection--*/
			{
				Name = "SortDirection",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SortDirection,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Srv_ID, (v) => this.Srv_ID = (global::System.Int32?)v) /*--Srv_ID--*/
			{
				Name = "Srv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srv_Name, (v) => this.Srv_Name = (global::System.String)v) /*--Srv_Name--*/
			{
				Name = "Srv_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sst_ID, (v) => this.Sst_ID = (global::System.Int32?)v) /*--Sst_ID--*/
			{
				Name = "Sst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.tnst_Code, (v) => this.tnst_Code = (global::System.String)v) /*--tnst_Code--*/
			{
				Name = "tnst_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.tnst_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.trf_ID, (v) => this.trf_ID = (global::System.Int32?)v) /*--trf_ID--*/
			{
				Name = "trf_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.trf_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_Employee_ID, (v) => this.abn_Employee_ID = (global::System.String)v) /*--abn_Employee_ID--*/
			{
				Name = "abn_Employee_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_Employee_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ExternalID, (v) => this.abn_ExternalID = (global::System.Int32?)v) /*--abn_ExternalID--*/
			{
				Name = "abn_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.LastModifiedDate, (v) => this.LastModifiedDate = (global::System.DateTime?)v) /*--LastModifiedDate--*/
			{
				Name = "LastModifiedDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.LastModifiedDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Format, (v) => this.Format = (global::System.String)v) /*--Format--*/
			{
				Name = "Format",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Format,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ID_Boss, (v) => this.abn_ID_Boss = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID_Boss",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID_Boss,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_IsExistAD, (v) => this.abn_IsExistAD = (global::System.Int32?)v) /*--abn_IsExistAD--*/
			{
				Name = "abn_IsExistAD",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_IsExistAD,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.abn_LastName, (v) => this.abn_LastName = (global::System.String)v) /*--abn_LastName--*/
			{
				Name = "abn_LastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_LastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_WorkPlace, (v) => this.abn_WorkPlace = (global::System.String)v) /*--abn_WorkPlace--*/
			{
				Name = "abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Acat_ID, (v) => this.Acat_ID = (global::System.Int32?)v) /*--Acat_ID--*/
			{
				Name = "Acat_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acat_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Accl_ID, (v) => this.Accl_ID = (global::System.Int32?)v) /*--Accl_ID--*/
			{
				Name = "Accl_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Accl_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Acnt_Number, (v) => this.Acnt_Number = (global::System.String)v) /*--Acnt_Number--*/
			{
				Name = "Acnt_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Actp_ID, (v) => this.Actp_ID = (global::System.Int32?)v) /*--Actp_ID--*/
			{
				Name = "Actp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Actp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Adlsb_Code, (v) => this.Adlsb_Code = (global::System.Int32?)v) /*--Adlsb_Code--*/
			{
				Name = "Adlsb_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Adlsb_Code,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Aptp_ID, (v) => this.Aptp_ID = (global::System.Int32?)v) /*--Aptp_ID--*/
			{
				Name = "Aptp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Aptp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.aut_NameAuthCode, (v) => this.aut_NameAuthCode = (global::System.String)v) /*--aut_NameAuthCode--*/
			{
				Name = "aut_NameAuthCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Bac_Number, (v) => this.Bac_Number = (global::System.String)v) /*--Bac_Number--*/
			{
				Name = "Bac_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Bac_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.bll_Number, (v) => this.bll_Number = (global::System.String)v) /*--bll_Number--*/
			{
				Name = "bll_Number",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.bll_Number,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.BossLastName, (v) => this.BossLastName = (global::System.String)v) /*--BossLastName--*/
			{
				Name = "BossLastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.BossLastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Cntr_Name, (v) => this.Cntr_Name = (global::System.String)v) /*--Cntr_Name--*/
			{
				Name = "Cntr_Name",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Cntr_Name,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.com_ID, (v) => this.com_ID = (global::System.Int32?)v) /*--com_ID--*/
			{
				Name = "com_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.com_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.dep_ID, (v) => this.dep_ID = (global::System.Int32?)v) /*--dep_ID--*/
			{
				Name = "dep_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.dep_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Dls_ID, (v) => this.Dls_ID = (global::System.Int32?)v) /*--Dls_ID--*/
			{
				Name = "Dls_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Dls_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ext_ExtNum, (v) => this.ext_ExtNum = (global::System.String)v) /*--ext_ExtNum--*/
			{
				Name = "ext_ExtNum",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ext_ExtNum,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.grp_ID, (v) => this.grp_ID = (global::System.Int32?)v) /*--grp_ID--*/
			{
				Name = "grp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.grp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--CacheControlDate--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.jsonFieldsName, (v) => this.jsonFieldsName = (global::System.String)v) /*--jsonFieldsName--*/
			{
				Name = "jsonFieldsName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFieldsName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.jsonFilter, (v) => this.jsonFilter = (global::System.String)v) /*--jsonFilter--*/
			{
				Name = "jsonFilter",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFilter,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.jsonFilterContain, (v) => this.jsonFilterContain = (global::System.Int32?)v) /*--jsonFilterContain--*/
			{
				Name = "jsonFilterContain",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.jsonFilterContain,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lng_ID, (v) => this.Lng_ID = (global::System.Int32?)v) /*--Lng_ID--*/
			{
				Name = "Lng_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lng_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.mode, (v) => this.mode = (global::System.Int32?)v) /*--mode--*/
			{
				Name = "mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.mode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ntw_ID, (v) => this.Ntw_ID = (global::System.Int32?)v) /*--Ntw_ID--*/
			{
				Name = "Ntw_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ntw_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageNumber--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ProfileType, (v) => this.ProfileType = (global::System.Int32?)v) /*--ProfileType--*/
			{
				Name = "ProfileType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ProfileType,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Rgsc_ID, (v) => this.Rgsc_ID = (global::System.Int32?)v) /*--Rgsc_ID--*/
			{
				Name = "Rgsc_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rgsc_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ShowBalances, (v) => this.ShowBalances = (global::System.Int32?)v) /*--ShowBalances--*/
			{
				Name = "ShowBalances",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ShowBalances,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ShowEntities, (v) => this.ShowEntities = (global::System.String)v) /*--ShowEntities--*/
			{
				Name = "ShowEntities",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ShowEntities,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_Subscribers_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_Subscribers_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// abn_HasNotEmptyPrepaid
		/// </summary>
		[Required]
		public global::System.Int32? abn_HasNotEmptyPrepaid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abn_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_CreateDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_CreateDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abn_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employe_Export_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employe_Export_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		public global::System.String abn_Employee_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		public global::System.Int32? abn_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_FirstName
		/// </summary>
		[Required]
		public global::System.String abn_FirstName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Guid
		/// </summary>
		[Required]
		public global::System.Guid? abn_Guid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		public global::System.Int32? abn_IsExistAD { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsGuest
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsGuest { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Login
		/// </summary>
		[Required]
		public global::System.String abn_Login { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_MiddleName
		/// </summary>
		[Required]
		public global::System.String abn_MiddleName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedBy
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedFrom
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedFrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Left
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Left { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Right
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Right { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Password
		/// </summary>
		[Required]
		public global::System.String abn_Password { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_PositionCode
		/// </summary>
		[Required]
		public global::System.String abn_PositionCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ShowPhoneDirectory
		/// </summary>
		[Required]
		public global::System.Int32? abn_ShowPhoneDirectory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// AbonentFullName
		/// </summary>
		[Required]
		public global::System.String AbonentFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_IsPersonal
		/// </summary>
		[Required]
		public global::System.Int32? acnt_IsPersonal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number_Personal
		/// </summary>
		[Required]
		public global::System.String acnt_Number_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// actp_ID
		/// </summary>
		public global::System.Int32? actp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		public global::System.Int32? dep_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// actpd_Name
		/// </summary>
		[Required]
		public global::System.String actpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name_Personal
		/// </summary>
		[Required]
		public global::System.String Actpd_Name_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? aut_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NameAuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_NumberAts
		/// </summary>
		[Required]
		public global::System.Int32? aut_NumberAts { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossFullName
		/// </summary>
		[Required]
		public global::System.String BossFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cntr_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? cntr_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// cntr_Name
		/// </summary>
		public global::System.String cntr_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_Id
		/// </summary>
		public global::System.Int32? com_Id { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		public global::System.String ext_ExtNum { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? ext_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		public global::System.Int32? grp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_Name
		/// </summary>
		[Required]
		public global::System.String grp_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditAllow
		/// </summary>
		[Required]
		public global::System.Int32? isEditAllow { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// lng_ID
		/// </summary>
		public global::System.Int32? lng_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// loc_Name
		/// </summary>
		[Required]
		public global::System.String loc_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Location_ID
		/// </summary>
		[Required]
		public global::System.Int32? Location_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ntw_ID
		/// </summary>
		public global::System.Int32? ntw_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pbx_networkName
		/// </summary>
		[Required]
		public global::System.String pbx_networkName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ProfileType
		/// </summary>
		public global::System.Int32? ProfileType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// rptURL
		/// </summary>
		[Required]
		public global::System.String rptURL { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// SubsCount
		/// </summary>
		[Required]
		public global::System.Int32? SubsCount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_AccountMandatory
		/// </summary>
		[Required]
		public global::System.Int32? tnt_AccountMandatory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TreeNodeType
		/// </summary>
		[Required]
		public global::System.String TreeNodeType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		public global::System.Int32? trf_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditWorkPlace
		/// </summary>
		[Required]
		public global::System.Int32? isEditWorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_id_boss
		/// </summary>
		[Required]
		public global::System.Int32? dep_id_boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_Name_boss
		/// </summary>
		[Required]
		public global::System.String dep_Name_boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isRefusalChangeName
		/// </summary>
		[Required]
		public global::System.Int32? isRefusalChangeName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// max_ModDate
		/// </summary>
		public global::System.DateTime? max_ModDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор причины версии
		/// <para/>
		/// vrr_ID
		/// </summary>
		[Required]
		public global::System.Int32? vrr_ID { get; set; } /*OUTPUT*/
#endregion
	}
	[DocIgnore]
	public class SET_p_ucp_set_Subscribers_Request : ICallProcedureModel<SET_p_ucp_set_Subscribers_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Subscribers_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Subscribers_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Статус Абонента
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор стандарта абонента
		/// <para/>
		/// StandartID
		/// </summary>
		public global::System.Int32? Ntw_ID { get; set; } /*IN*/
			/// <summary>
		/// Полное юридическое наименование 
		/// <para/>
		/// FullName
		/// </summary>
		public global::System.String Abn_FullName { get; set; } /*IN*/
			/// <summary>
		/// Короткое наименование
		/// <para/>
		/// ShortName
		/// </summary>
		public global::System.String Abn_ShortName { get; set; } /*IN*/
			/// <summary>
		/// признак создать Приложение Договора для Внутреннего номера  
		/// <para/>
		/// AutoCreateContract
		/// </summary>
		public global::System.Int32? AutoCreateContract { get; set; } /*IN*/
			/// <summary>
		/// Краткое название для поиска
		/// <para/>
		/// Customer_SearchName
		/// </summary>
		public global::System.String Abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// Дата активации абонента
		/// <para/>
		/// CustomerDate
		/// </summary>
		public global::System.DateTime? Abn_Date { get; set; } /*IN*/
			/// <summary>
		/// Режим отладки (зарезервировано)
		/// <para/>
		/// DebugLevel
		/// </summary>
		public global::System.Int32? DebugLevel { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор для экспорта
		/// <para/>
		/// Export_ID
		/// </summary>
		public global::System.String Abn_Employe_Export_ID { get; set; } /*IN*/
			/// <summary>
		/// PositionCode для синхронизации иерархии узлов дерева
		/// <para/>
		/// PositionCode
		/// </summary>
		public global::System.String Abn_PositionCode { get; set; } /*IN*/
			/// <summary>
		/// Код диллера
		/// <para/>
		/// AgentCode
		/// </summary>
		public global::System.String Sag_Code { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор диллера
		/// <para/>
		/// AgentID
		/// </summary>
		public global::System.Int32? Sag_ID { get; set; } /*IN*/
			/// <summary>
		/// Код точки продаж
		/// <para/>
		/// SalesPointCode
		/// </summary>
		public global::System.String Pos_Code { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор точки продаж
		/// <para/>
		/// SalesPointID
		/// </summary>
		public global::System.Int32? Pos_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Признак ""создание узла дерева не завершено
		/// <para/>
		/// IsCreatedWithTariffication
		/// </summary>
		public global::System.Int32? Abn_IsCreatedWithTariffication { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Тип профиля
		/// <para/>
		/// ProfileType
		/// </summary>
		public global::System.Int32? ProfileType { get; set; } /*IN*/
			/// <summary>
		/// Уникальный номер узла дерева для синхронизации с внешней системой
		/// <para/>
		/// SyncId
		/// </summary>
		public global::System.String Abn_Employee_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор логина абонента
		/// <para/>
		/// SubscriberLogin
		/// </summary>
		public global::System.String Abn_Login { get; set; } /*IN*/
			/// <summary>
		/// Пароль абонента (если применимо)
		/// <para/>
		/// SubscriberPassword
		/// </summary>
		public global::System.String Abn_Password { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор Клиента (узла типа Customers)
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID_Boss { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_Subscribers_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Abn_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Subscribers_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Subscribers";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Ntw_ID, (v) => this.Ntw_ID = (global::System.Int32?)v) /*--StandartID--*/
			{
				Name = "Ntw_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ntw_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_FullName, (v) => this.Abn_FullName = (global::System.String)v) /*--FullName--*/
			{
				Name = "Abn_FullName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FullName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ShortName, (v) => this.Abn_ShortName = (global::System.String)v) /*--ShortName--*/
			{
				Name = "Abn_ShortName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ShortName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.AutoCreateContract, (v) => this.AutoCreateContract = (global::System.Int32?)v) /*--AutoCreateContract--*/
			{
				Name = "AutoCreateContract",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.AutoCreateContract,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_WorkPlace, (v) => this.Abn_WorkPlace = (global::System.String)v) /*--Customer_SearchName--*/
			{
				Name = "Abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Date, (v) => this.Abn_Date = (global::System.DateTime?)v) /*--CustomerDate--*/
			{
				Name = "Abn_Date",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Date,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DebugLevel, (v) => this.DebugLevel = (global::System.Int32?)v) /*--DebugLevel--*/
			{
				Name = "DebugLevel",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DebugLevel,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Abn_Employe_Export_ID, (v) => this.Abn_Employe_Export_ID = (global::System.String)v) /*--Export_ID--*/
			{
				Name = "Abn_Employe_Export_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Employe_Export_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_PositionCode, (v) => this.Abn_PositionCode = (global::System.String)v) /*--PositionCode--*/
			{
				Name = "Abn_PositionCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_PositionCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sag_Code, (v) => this.Sag_Code = (global::System.String)v) /*--AgentCode--*/
			{
				Name = "Sag_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sag_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Sag_ID, (v) => this.Sag_ID = (global::System.Int32?)v) /*--AgentID--*/
			{
				Name = "Sag_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Sag_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Pos_Code, (v) => this.Pos_Code = (global::System.String)v) /*--SalesPointCode--*/
			{
				Name = "Pos_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pos_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Pos_ID, (v) => this.Pos_ID = (global::System.Int32?)v) /*--SalesPointID--*/
			{
				Name = "Pos_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Pos_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_IsCreatedWithTariffication, (v) => this.Abn_IsCreatedWithTariffication = (global::System.Int32?)v) /*--IsCreatedWithTariffication--*/
			{
				Name = "Abn_IsCreatedWithTariffication",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_IsCreatedWithTariffication,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ProfileType, (v) => this.ProfileType = (global::System.Int32?)v) /*--ProfileType--*/
			{
				Name = "ProfileType",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ProfileType,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_Employee_ID, (v) => this.Abn_Employee_ID = (global::System.String)v) /*--SyncId--*/
			{
				Name = "Abn_Employee_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Employee_ID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Login, (v) => this.Abn_Login = (global::System.String)v) /*--SubscriberLogin--*/
			{
				Name = "Abn_Login",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Login,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Password, (v) => this.Abn_Password = (global::System.String)v) /*--SubscriberPassword--*/
			{
				Name = "Abn_Password",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Password,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID_Boss, (v) => this.Abn_ID_Boss = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID_Boss",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID_Boss,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_Subscribers_Response : ICallProcedureModel<SET_p_ucp_set_Subscribers_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_Subscribers_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_Subscribers_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_Subscribers_Response()
		{
			expressions.Add((m) => m.Abn_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_Subscribers_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Subscribers";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Subscribers/Activate]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// AuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*IN*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// уникальное значение логина, например Option82 
		/// <para/>
		/// Login
		/// </summary>
		public global::System.String Abn_Login { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Адрес для нотификации об активации
		/// <para/>
		/// Notification
		/// </summary>
		public global::System.String Notification { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// пароль
		/// <para/>
		/// Password
		/// </summary>
		public global::System.String Abn_Password { get; set; } /*IN*/
			/// <summary>
		/// Телефон для нотификации об активации
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String PhoneNumber { get; set; } /*IN*/
			/// <summary>
		/// Комментарий для активации
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Статус узла дерева после активаци
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeActivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.aut_NameAuthCode, (v) => this.aut_NameAuthCode = (global::System.String)v) /*--AuthCode--*/
			{
				Name = "aut_NameAuthCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Login, (v) => this.Abn_Login = (global::System.String)v) /*--Login--*/
			{
				Name = "Abn_Login",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Login,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Notification, (v) => this.Notification = (global::System.String)v) /*--Notification--*/
			{
				Name = "Notification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Notification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_Password, (v) => this.Abn_Password = (global::System.String)v) /*--Password--*/
			{
				Name = "Abn_Password",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Password,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PhoneNumber, (v) => this.PhoneNumber = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "PhoneNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PhoneNumber,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeActivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Subscribers/CalcCharges]
	[DocIgnore]
	public class ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request : ICallProcedureModel<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Тип начислений (зарезервировано)
		/// <para/>
		/// ChargeCode
		/// </summary>
		public global::System.String ChargeCode { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания периода для расчета начислений
		/// <para/>
		/// DateEnd
		/// </summary>
		[Required]
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала периода для расчета начислений
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Дата начисления, на которую необходимо посчитать сумму АП
		/// <para/>
		/// EffectiveDate
		/// </summary>
		[Required]
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// режим расчета суммы АП к начислению
		/// <para/>
		/// EmulateMode
		/// </summary>
		public global::System.Int32? EmulateMode { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		[Required]
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор номера (зарезервировано) 
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? Ext_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор группы устройств
		/// <para/>
		/// ID_GroupATS
		/// </summary>
		public global::System.Int32? ID_GroupATS { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsReCharge
		/// </summary>
		public global::System.Int32? IsReCharge { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор услуги (зарезервировано) 
		/// <para/>
		/// ServiceID
		/// </summary>
		public global::System.Int32? Srv_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор сессии: код системы(3 знака), код операции(2 знака) и идентификатор сессии(15 знаков). Используется функция fn_GetUniqueID
		/// <para/>
		/// Srs_SessionID
		/// </summary>
		public global::System.String Srs_SessionID { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request()
		{
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Charges";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ChargeCode, (v) => this.ChargeCode = (global::System.String)v) /*--ChargeCode--*/
			{
				Name = "ChargeCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ChargeCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EmulateMode, (v) => this.EmulateMode = (global::System.Int32?)v) /*--EmulateMode--*/
			{
				Name = "EmulateMode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EmulateMode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ext_ID, (v) => this.Ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "Ext_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ID_GroupATS, (v) => this.ID_GroupATS = (global::System.Int32?)v) /*--ID_GroupATS--*/
			{
				Name = "ID_GroupATS",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ID_GroupATS,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsReCharge, (v) => this.IsReCharge = (global::System.Int32?)v) /*--IsReCharge--*/
			{
				Name = "IsReCharge",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsReCharge,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srv_ID, (v) => this.Srv_ID = (global::System.Int32?)v) /*--ServiceID--*/
			{
				Name = "Srv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srs_SessionID, (v) => this.Srs_SessionID = (global::System.String)v) /*--Srs_SessionID--*/
			{
				Name = "Srs_SessionID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_SessionID,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response : ICallProcedureModel<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Расчетная сумма АП подлежащая начислению, вкл. налоги
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? Amount { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор процесса расчета
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int32? Wev_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response()
		{
			expressions.Add((m) => m.Amount); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Wev_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Charges";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Amount, (v) => this.Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Amount",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int32?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Subscribers/ChangeAccount]
	[DocIgnore]
	public class ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request : ICallProcedureModel<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор нового клиента (в качестве внреход абонентаешнего идентификатора), на который делается пе
		/// <para/>
		/// AccountID
		/// </summary>
		[Required]
		public global::System.Int32? Acnt_ID_New { get; set; } /*IN*/
			/// <summary>
		/// Код авторизации для нового Лицевого счета
		/// <para/>
		/// AuthCode
		/// </summary>
		public global::System.String aut_NameAuthCode { get; set; } /*IN*/
			/// <summary>
		/// Код авторизации для нового персонального Лицевого счета
		/// <para/>
		/// AuthCodePrivate
		/// </summary>
		public global::System.String aut_NameAuthCodePrivate { get; set; } /*IN*/
			/// <summary>
		/// Признак получения акцепта пользователя перед выполнением операции
		/// <para/>
		/// ConfAccepted
		/// </summary>
		public global::System.Int32? ConfAccepted { get; set; } /*IN*/
			/// <summary>
		/// Сообщение для конечного пользователя, требующее его обязательного подтверждения
		/// <para/>
		/// ConfMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*INOUT*/
			/// <summary>
		/// Дата изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий 
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Признак необходимости провести внеочередной биллинг перед сменой лицевого счета
		/// <para/>
		/// RunBilling
		/// </summary>
		public global::System.Int32? RunBilling { get; set; } /*IN*/
			/// <summary>
		/// Статус копии абонента, созданной при перерегистрации (для отложенного биллинга)
		/// <para/>
		/// StatusID
		/// </summary>
		public global::System.Int32? Tnst_target_old { get; set; } /*IN*/
			/// <summary>
		/// Логин абонента после смены Лицевого счета
		/// <para/>
		/// SubscriberLogin
		/// </summary>
		public global::System.String Abn_Login { get; set; } /*IN*/
			/// <summary>
		/// Пароль абонента после смены Лицевого счета
		/// <para/>
		/// SubscriberPassword
		/// </summary>
		public global::System.String Abn_Password { get; set; } /*IN*/
			/// <summary>
		/// Статус абонента после перерегистрации
		/// <para/>
		/// TargetStatusID
		/// </summary>
		public global::System.Int32? Tnst_target_new { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request()
		{
			expressions.Add((m) => m.ConfMessage); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "sp_change_Accounts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Acnt_ID_New, (v) => this.Acnt_ID_New = (global::System.Int32?)v) /*--AccountID--*/
			{
				Name = "Acnt_ID_New",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Acnt_ID_New,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.aut_NameAuthCode, (v) => this.aut_NameAuthCode = (global::System.String)v) /*--AuthCode--*/
			{
				Name = "aut_NameAuthCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.aut_NameAuthCodePrivate, (v) => this.aut_NameAuthCodePrivate = (global::System.String)v) /*--AuthCodePrivate--*/
			{
				Name = "aut_NameAuthCodePrivate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.aut_NameAuthCodePrivate,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ConfAccepted, (v) => this.ConfAccepted = (global::System.Int32?)v) /*--ConfAccepted--*/
			{
				Name = "ConfAccepted",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ConfAccepted,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.RunBilling, (v) => this.RunBilling = (global::System.Int32?)v) /*--RunBilling--*/
			{
				Name = "RunBilling",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.RunBilling,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Tnst_target_old, (v) => this.Tnst_target_old = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_target_old",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_target_old,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_Login, (v) => this.Abn_Login = (global::System.String)v) /*--SubscriberLogin--*/
			{
				Name = "Abn_Login",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Login,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_Password, (v) => this.Abn_Password = (global::System.String)v) /*--SubscriberPassword--*/
			{
				Name = "Abn_Password",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_Password,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_target_new, (v) => this.Tnst_target_new = (global::System.Int32?)v) /*--TargetStatusID--*/
			{
				Name = "Tnst_target_new",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_target_new,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response : ICallProcedureModel<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Сообщение для конечного пользователя, требующее его обязательного подтверждения
		/// <para/>
		/// ConfMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response()
		{
			expressions.Add((m) => m.ConfMessage); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "sp_change_Accounts";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Subscribers/ChangeName]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Имя
		/// <para/>
		/// FirstName
		/// </summary>
		public global::System.String Abn_FirstName { get; set; } /*IN*/
			/// <summary>
		/// Юридическое наименование
		/// <para/>
		/// FullName
		/// </summary>
		public global::System.String Abn_FullName { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Отчество
		/// <para/>
		/// MiddleName
		/// </summary>
		public global::System.String Abn_MiddleName { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Название или Фамилия
		/// <para/>
		/// Name
		/// </summary>
		public global::System.String Abn_LastName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Ассоциации 
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// ОКПО или Паспорт
		/// <para/>
		/// SearchName
		/// </summary>
		public global::System.String Abn_WorkPlace { get; set; } /*IN*/
			/// <summary>
		/// Сокращенное наименование
		/// <para/>
		/// ShortName
		/// </summary>
		public global::System.String Abn_ShortName { get; set; } /*IN*/
			/// <summary>
		/// Указание очистить значение, в случае передачи ПУСТО в значении
		/// <para/>
		/// ToClean
		/// </summary>
		public global::System.Int32? toClean { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeName";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_FirstName, (v) => this.Abn_FirstName = (global::System.String)v) /*--FirstName--*/
			{
				Name = "Abn_FirstName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FirstName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_FullName, (v) => this.Abn_FullName = (global::System.String)v) /*--FullName--*/
			{
				Name = "Abn_FullName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_FullName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_MiddleName, (v) => this.Abn_MiddleName = (global::System.String)v) /*--MiddleName--*/
			{
				Name = "Abn_MiddleName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_MiddleName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_LastName, (v) => this.Abn_LastName = (global::System.String)v) /*--Name--*/
			{
				Name = "Abn_LastName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_LastName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_WorkPlace, (v) => this.Abn_WorkPlace = (global::System.String)v) /*--SearchName--*/
			{
				Name = "Abn_WorkPlace",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_WorkPlace,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ShortName, (v) => this.Abn_ShortName = (global::System.String)v) /*--ShortName--*/
			{
				Name = "Abn_ShortName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ShortName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.toClean, (v) => this.toClean = (global::System.Int32?)v) /*--ToClean--*/
			{
				Name = "toClean",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.toClean,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeName";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Subscribers/ChangeStatus]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// ConfirmationMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*INOUT*/
			/// <summary>
		/// Дата изменения статуса
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента, клиента или ассоциации
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения статуса
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Статус узла дерева
		/// <para/>
		/// StatusID
		/// </summary>
		[Required]
		public global::System.Int32? Tnst_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак подтверждения операции со стороны пользователя
		/// <para/>
		/// UserAcceptance
		/// </summary>
		public global::System.Int32? ConfAccepted { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request()
		{
			expressions.Add((m) => m.ConfMessage); // INOUT
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeStatus";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfirmationMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_ID, (v) => this.Tnst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tnst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ConfAccepted, (v) => this.ConfAccepted = (global::System.Int32?)v) /*--UserAcceptance--*/
			{
				Name = "ConfAccepted",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ConfAccepted,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Ответ АПИ с текстом предупреждения перед изменением статуса
		/// <para/>
		/// ConfirmationMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response()
		{
			expressions.Add((m) => m.ConfMessage); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeChangeStatus";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfirmationMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Subscribers/Deactivate]
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата деактивации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Имя сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		[Required]
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Уникальный идентификатор транзакции для идемпотентности
		/// <para/>
		/// global_unique_id
		/// </summary>
		public global::System.String UniqueID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Фильтр для отбора узлов по коду метки
		/// <para/>
		/// LabelCode
		/// </summary>
		public global::System.String Lbl_Code { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Адрес для нотификации о деактивации
		/// <para/>
		/// Notification
		/// </summary>
		public global::System.String Notification { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор абонента
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Телефон для нотификации о деактивации
		/// <para/>
		/// PhoneNumber
		/// </summary>
		public global::System.String PhoneNumber { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Фильтр для отбора узлов по текущему статусу узла дерева
		/// <para/>
		/// StatusCode
		/// </summary>
		public global::System.String Tnst_Code_crnt { get; set; } /*IN*/
			/// <summary>
		/// Значение статуса узла после выполнения операции
		/// <para/>
		/// TargetStatusCode
		/// </summary>
		public global::System.String Tnst_Code_trgt { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeDeactivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.UniqueID, (v) => this.UniqueID = (global::System.String)v) /*--global_unique_id--*/
			{
				Name = "UniqueID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.UniqueID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lbl_Code, (v) => this.Lbl_Code = (global::System.String)v) /*--LabelCode--*/
			{
				Name = "Lbl_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lbl_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Notification, (v) => this.Notification = (global::System.String)v) /*--Notification--*/
			{
				Name = "Notification",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Notification,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PhoneNumber, (v) => this.PhoneNumber = (global::System.String)v) /*--PhoneNumber--*/
			{
				Name = "PhoneNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PhoneNumber,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_Code_crnt, (v) => this.Tnst_Code_crnt = (global::System.String)v) /*--StatusCode--*/
			{
				Name = "Tnst_Code_crnt",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_Code_crnt,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnst_Code_trgt, (v) => this.Tnst_Code_trgt = (global::System.String)v) /*--TargetStatusCode--*/
			{
				Name = "Tnst_Code_trgt",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnst_Code_trgt,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response : ICallProcedureModel<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Кол-во обработанных записей 
		/// <para/>
		/// AffectedCount
		/// </summary>
		public global::System.Int32? AffectedCount { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор процесса 
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int32? Wev_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response()
		{
			expressions.Add((m) => m.AffectedCount); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Wev_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_TreeNodeDeactivate";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.AffectedCount, (v) => this.AffectedCount = (global::System.Int32?)v) /*--AffectedCount--*/
			{
				Name = "AffectedCount",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.AffectedCount,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int32?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Subscribers/Details]
	[DocIgnore]
	public class GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request : ICallProcedureModel<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор Абонента
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request()
		{
			expressions.Add((m) => m.IfModifiedSinceDate); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_SubscriberByID";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IfModifiedSinceDate, (v) => this.IfModifiedSinceDate = (global::System.DateTime?)v) /*--CacheControlDate--*/
			{
				Name = "IfModifiedSinceDate",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IfModifiedSinceDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.abn_ID, (v) => this.abn_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Дата модификации для http-тега If-Modified-Since
		/// <para/>
		/// CacheControlDate
		/// </summary>
		public global::System.DateTime? IfModifiedSinceDate { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsGuest
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsGuest { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Date_Personal
		/// </summary>
		[Required]
		public global::System.DateTime? abc_Date_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abn_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_CreateDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_CreateDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abn_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employe_Export_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employe_Export_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Employee_ID
		/// </summary>
		[Required]
		public global::System.String abn_Employee_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_FirstName
		/// </summary>
		[Required]
		public global::System.String abn_FirstName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Guid
		/// </summary>
		[Required]
		public global::System.Guid? abn_Guid { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ID_Boss
		/// </summary>
		public global::System.Int32? abn_ID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_IsExistAD
		/// </summary>
		[Required]
		public global::System.Int32? abn_IsExistAD { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastFM
		/// </summary>
		[Required]
		public global::System.String abn_LastFM { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_LastName
		/// </summary>
		public global::System.String abn_LastName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Login
		/// </summary>
		[Required]
		public global::System.String abn_Login { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_MiddleName
		/// </summary>
		[Required]
		public global::System.String abn_MiddleName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedBy
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedBy { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abn_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ModifiedFrom
		/// </summary>
		[Required]
		public global::System.String abn_ModifiedFrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Left
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Left { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_NestedSets_Right
		/// </summary>
		[Required]
		public global::System.Int32? abn_NestedSets_Right { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_Password
		/// </summary>
		[Required]
		public global::System.String abn_Password { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_PositionCode
		/// </summary>
		[Required]
		public global::System.String abn_PositionCode { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_ShowPhoneDirectory
		/// </summary>
		[Required]
		public global::System.Int32? abn_ShowPhoneDirectory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace
		/// </summary>
		[Required]
		public global::System.String abn_WorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_WorkPlace_Personal
		/// </summary>
		[Required]
		public global::System.String abn_WorkPlace_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abn_XmlData
		/// </summary>
		[Required]
		public global::System.String abn_XmlData { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// AbonentFullName
		/// </summary>
		[Required]
		public global::System.String AbonentFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? acnt_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_IsPersonal
		/// </summary>
		[Required]
		public global::System.Int32? acnt_IsPersonal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number
		/// </summary>
		[Required]
		public global::System.String acnt_Number { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// acnt_Number_Personal
		/// </summary>
		[Required]
		public global::System.String acnt_Number_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name
		/// </summary>
		[Required]
		public global::System.String Actpd_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Actpd_Name_Personal
		/// </summary>
		[Required]
		public global::System.String Actpd_Name_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// atnsb_DateEnd
		/// </summary>
		[Required]
		public global::System.DateTime? atnsb_DateEnd { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// atnsb_DateStart
		/// </summary>
		[Required]
		public global::System.DateTime? atnsb_DateStart { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abb_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_Balance_Personal
		/// </summary>
		[Required]
		public global::System.Decimal? abb_Balance_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? abb_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abb_ModifiedDate_Personal
		/// </summary>
		[Required]
		public global::System.DateTime? abb_ModifiedDate_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Balance
		/// </summary>
		[Required]
		public global::System.Decimal? abc_Balance { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Balance_Personal
		/// </summary>
		[Required]
		public global::System.Decimal? abc_Balance_Personal { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// abc_Date
		/// </summary>
		[Required]
		public global::System.DateTime? abc_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// aut_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? aut_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Boss_Tnt_Type
		/// </summary>
		[Required]
		public global::System.String Boss_Tnt_Type { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// BossFullName
		/// </summary>
		[Required]
		public global::System.String BossFullName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// com_Id
		/// </summary>
		[Required]
		public global::System.Int32? com_Id { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// debt_Amount
		/// </summary>
		[Required]
		public global::System.Decimal? debt_Amount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// debt_Date
		/// </summary>
		[Required]
		public global::System.DateTime? debt_Date { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// dep_ID
		/// </summary>
		[Required]
		public global::System.Int32? dep_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ExtNum
		/// </summary>
		[Required]
		public global::System.String ext_ExtNum { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ext_ID_count
		/// </summary>
		[Required]
		public global::System.Int32? ext_ID_count { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_ID
		/// </summary>
		[Required]
		public global::System.Int32? grp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grp_Name
		/// </summary>
		[Required]
		public global::System.String grp_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isActivated
		/// </summary>
		[Required]
		public global::System.Int32? isActivated { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditAllow
		/// </summary>
		[Required]
		public global::System.Int32? isEditAllow { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isEditWorkPlace
		/// </summary>
		[Required]
		public global::System.Int32? isEditWorkPlace { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// lng_ID
		/// </summary>
		[Required]
		public global::System.Int32? lng_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// loc_Name
		/// </summary>
		[Required]
		public global::System.String loc_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Location_ID
		/// </summary>
		[Required]
		public global::System.Int32? Location_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ntw_ID
		/// </summary>
		[Required]
		public global::System.Int32? ntw_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// pbx_networkName
		/// </summary>
		[Required]
		public global::System.String pbx_networkName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ProfileType
		/// </summary>
		[Required]
		public global::System.Int32? ProfileType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// SubsCount
		/// </summary>
		[Required]
		public global::System.Int32? SubsCount { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnh_LastFM
		/// </summary>
		[Required]
		public global::System.String tnh_LastFM { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ExternalID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnst_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnst_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_AccountMandatory
		/// </summary>
		[Required]
		public global::System.Int32? tnt_AccountMandatory { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// tnt_ID
		/// </summary>
		[Required]
		public global::System.Int32? tnt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TreeNodeType
		/// </summary>
		public global::System.String TreeNodeType { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// trf_ID
		/// </summary>
		[Required]
		public global::System.Int32? trf_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// isRefusalChangeName
		/// </summary>
		[Required]
		public global::System.Int32? isRefusalChangeName { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [Subscribers/Recharge]
	[DocIgnore]
	public class ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request : ICallProcedureModel<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Явное указание суммы подписки - для переопределения цены пакета в случае использования FMC подписок (сумма списания на основании суммы платежа)
		/// <para/>
		/// AMOUNT
		/// </summary>
		public global::System.Decimal? Amount { get; set; } /*INOUT*/
			/// <summary>
		/// Тип начислений (зарезервировано)
		/// <para/>
		/// ChargeCode
		/// </summary>
		public global::System.String ChargeCode { get; set; } /*IN*/
			/// <summary>
		/// Дата окончания действия
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// режим расчета суммы АП к начислению
		/// <para/>
		/// EmulateMode
		/// </summary>
		public global::System.Int32? EmulateMode { get; set; } /*IN*/
			/// <summary>
		/// Имя сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Extentions (Номера MSISDN)
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? Ext_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор группы устройств
		/// <para/>
		/// ID_GroupATS
		/// </summary>
		public global::System.Int32? ID_GroupATS { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Признак провести пересчет в оффлайн режиме
		/// <para/>
		/// IsOnline
		/// </summary>
		public global::System.Int32? IsOnline { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// IsReCharge
		/// </summary>
		public global::System.Int32? IsReCharge { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Режим подключения Пакетов и услуг
		/// <para/>
		/// Mode
		/// </summary>
		public global::System.Int32? Mode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор устройства
		/// <para/>
		/// NumberATS
		/// </summary>
		public global::System.Int32? NumberATS { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор технической услуги ""выписка счета
		/// <para/>
		/// ServiceID
		/// </summary>
		public global::System.Int32? Srv_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор сессии: код системы(3 знака), код операции(2 знака) и идентификатор сессии(15 знаков). Используется функция fn_GetUniqueID
		/// <para/>
		/// Srs_SessionID
		/// </summary>
		public global::System.String Srs_SessionID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Wev_CurrrentState
		/// </summary>
		public global::System.String Wev_CurrrentState { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор процесса расчета
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int32? Wev_ID { get; set; } /*INOUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request()
		{
			expressions.Add((m) => m.Amount); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.Wev_ID); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Charges";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Amount, (v) => this.Amount = (global::System.Decimal?)v) /*--AMOUNT--*/
			{
				Name = "Amount",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.ChargeCode, (v) => this.ChargeCode = (global::System.String)v) /*--ChargeCode--*/
			{
				Name = "ChargeCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ChargeCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EmulateMode, (v) => this.EmulateMode = (global::System.Int32?)v) /*--EmulateMode--*/
			{
				Name = "EmulateMode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EmulateMode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ext_ID, (v) => this.Ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "Ext_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ID_GroupATS, (v) => this.ID_GroupATS = (global::System.Int32?)v) /*--ID_GroupATS--*/
			{
				Name = "ID_GroupATS",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ID_GroupATS,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsOnline, (v) => this.IsOnline = (global::System.Int32?)v) /*--IsOnline--*/
			{
				Name = "IsOnline",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsOnline,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsReCharge, (v) => this.IsReCharge = (global::System.Int32?)v) /*--IsReCharge--*/
			{
				Name = "IsReCharge",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsReCharge,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Mode, (v) => this.Mode = (global::System.Int32?)v) /*--Mode--*/
			{
				Name = "Mode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Mode,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.NumberATS, (v) => this.NumberATS = (global::System.Int32?)v) /*--NumberATS--*/
			{
				Name = "NumberATS",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.NumberATS,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srv_ID, (v) => this.Srv_ID = (global::System.Int32?)v) /*--ServiceID--*/
			{
				Name = "Srv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Srs_SessionID, (v) => this.Srs_SessionID = (global::System.String)v) /*--Srs_SessionID--*/
			{
				Name = "Srs_SessionID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Srs_SessionID,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_CurrrentState, (v) => this.Wev_CurrrentState = (global::System.String)v) /*--Wev_CurrrentState--*/
			{
				Name = "Wev_CurrrentState",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Wev_CurrrentState,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int32?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response : ICallProcedureModel<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// Amount
		/// </summary>
		public global::System.Decimal? Amount { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор события
		/// <para/>
		/// WorkEventID
		/// </summary>
		public global::System.Int32? Wev_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response()
		{
			expressions.Add((m) => m.Amount); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Wev_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_Charges";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Amount, (v) => this.Amount = (global::System.Decimal?)v) /*--Amount--*/
			{
				Name = "Amount",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Amount,
				DBType = System.Data.DbType.Decimal
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Wev_ID, (v) => this.Wev_ID = (global::System.Int32?)v) /*--WorkEventID--*/
			{
				Name = "Wev_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Wev_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
#region [Subscribers/SetLabels]
	[DocIgnore]
	public class ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request : ICallProcedureModel<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Название сущности для которой выполняется операция
		/// <para/>
		/// EntityName
		/// </summary>
		[Required]
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Код метки
		/// <para/>
		/// LabelCode
		/// </summary>
		[Required]
		public global::System.String Lbl_Code { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// LinkedServer
		/// </summary>
		public global::System.String LinkedServer { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// SELECT запрос на отбор идентификаторов узлов дерева - должен учитыавать значение IDType
		/// <para/>
		/// SourceQuery
		/// </summary>
		public global::System.String SourceQuery { get; set; } /*IN*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_LabelApply";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lbl_Code, (v) => this.Lbl_Code = (global::System.String)v) /*--LabelCode--*/
			{
				Name = "Lbl_Code",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lbl_Code,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.LinkedServer, (v) => this.LinkedServer = (global::System.String)v) /*--LinkedServer--*/
			{
				Name = "LinkedServer",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.LinkedServer,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.SourceQuery, (v) => this.SourceQuery = (global::System.String)v) /*--SourceQuery--*/
			{
				Name = "SourceQuery",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.SourceQuery,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response : ICallProcedureModel<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response> // Standard Call Model
	{
		private List<Expression<Func<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response, object>>> expressions = 
			new List<Expression<Func<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_act_LabelApply";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [Tasks]
	[DocIgnore]
	public class SET_p_ucp_set_ServiceTask_Request : ICallProcedureModel<SET_p_ucp_set_ServiceTask_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_ServiceTask_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_ServiceTask_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Дата и время выполнения задачи
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? Tsk_DateStart { get; set; } /*IN*/
			/// <summary>
		/// Начало периода, для отбора данных для задачи
		/// <para/>
		/// PeriodBegin
		/// </summary>
		public global::System.DateTime? Tsk_PeriodBegin { get; set; } /*INOUT*/
			/// <summary>
		/// Окончание периода, для отбора данных для задачи
		/// <para/>
		/// PeriodEnd
		/// </summary>
		public global::System.DateTime? Tsk_PeriodEnd { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор группы устройств (однородных услуг)
		/// <para/>
		/// DeviceGroupID
		/// </summary>
		public global::System.Int32? ID_GroupATS { get; set; } /*IN*/
			/// <summary>
		/// ID группы подзадач (для выполнения пакета действий)
		/// <para/>
		/// ListGroupID
		/// </summary>
		public global::System.Int32? Lig_ID { get; set; } /*IN*/
			/// <summary>
		/// Дополнительные аттрибуты для задачи - используется для передачи значений параметров в провижининг
		/// <para/>
		/// JsonData
		/// </summary>
		public global::System.String Tsk_JsonData { get; set; } /*IN*/
			/// <summary>
		/// Формат данных аттрибутов задачи
		/// <para/>
		/// DataFormat
		/// </summary>
		public global::System.String DataFormat { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор статуса задачи
		/// <para/>
		/// StatusID
		/// </summary>
		[Required]
		public global::System.Int32? Tsst_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения к задаче
		/// <para/>
		/// Message
		/// </summary>
		[Required]
		public global::System.String Tsk_StateMessage { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// cacheStatus
		/// </summary>
		public global::System.String cacheStatus { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор задачи
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Tsk_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Имя хоста, с которого запущена сессия активного процесса (sysprocesses)
		/// <para/>
		/// HostName
		/// </summary>
		public global::System.String HostName { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Tsk_IsReady
		/// </summary>
		public global::System.Int32? Tsk_IsReady { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_ServiceTask_Request()
		{
			expressions.Add((m) => m.Tsk_PeriodBegin); // INOUT
			expressions.Add((m) => m.Tsk_PeriodEnd); // INOUT
			expressions.Add((m) => m.Tsk_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_ServiceTask_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceTask";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Tsk_DateStart, (v) => this.Tsk_DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "Tsk_DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tsk_DateStart,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Tsk_PeriodBegin, (v) => this.Tsk_PeriodBegin = (global::System.DateTime?)v) /*--PeriodBegin--*/
			{
				Name = "Tsk_PeriodBegin",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Tsk_PeriodBegin,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Tsk_PeriodEnd, (v) => this.Tsk_PeriodEnd = (global::System.DateTime?)v) /*--PeriodEnd--*/
			{
				Name = "Tsk_PeriodEnd",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Tsk_PeriodEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ID_GroupATS, (v) => this.ID_GroupATS = (global::System.Int32?)v) /*--DeviceGroupID--*/
			{
				Name = "ID_GroupATS",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ID_GroupATS,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lig_ID, (v) => this.Lig_ID = (global::System.Int32?)v) /*--ListGroupID--*/
			{
				Name = "Lig_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lig_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Tsk_JsonData, (v) => this.Tsk_JsonData = (global::System.String)v) /*--JsonData--*/
			{
				Name = "Tsk_JsonData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tsk_JsonData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.DataFormat, (v) => this.DataFormat = (global::System.String)v) /*--DataFormat--*/
			{
				Name = "DataFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DataFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tsst_ID, (v) => this.Tsst_ID = (global::System.Int32?)v) /*--StatusID--*/
			{
				Name = "Tsst_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tsst_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Tsk_StateMessage, (v) => this.Tsk_StateMessage = (global::System.String)v) /*--Message--*/
			{
				Name = "Tsk_StateMessage",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tsk_StateMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.cacheStatus, (v) => this.cacheStatus = (global::System.String)v) /*--cacheStatus--*/
			{
				Name = "cacheStatus",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.cacheStatus,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tsk_ID, (v) => this.Tsk_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Tsk_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Tsk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.HostName, (v) => this.HostName = (global::System.String)v) /*--HostName--*/
			{
				Name = "HostName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.HostName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tsk_IsReady, (v) => this.Tsk_IsReady = (global::System.Int32?)v) /*--Tsk_IsReady--*/
			{
				Name = "Tsk_IsReady",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tsk_IsReady,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_ServiceTask_Response : ICallProcedureModel<SET_p_ucp_set_ServiceTask_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_ServiceTask_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_ServiceTask_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Начало периода
		/// <para/>
		/// PeriodBegin
		/// </summary>
		public global::System.DateTime? Tsk_PeriodBegin { get; set; } /*OUT*/
			/// <summary>
		/// Окончание периода
		/// <para/>
		/// PeriodEnd
		/// </summary>
		public global::System.DateTime? Tsk_PeriodEnd { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор задачи
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? Tsk_ID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_ServiceTask_Response()
		{
			expressions.Add((m) => m.Tsk_PeriodBegin); // OUT
			expressions.Add((m) => m.Tsk_PeriodEnd); // OUT
			expressions.Add((m) => m.Tsk_ID); // OUT
			expressions.Add((m) => m.Lang); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_ServiceTask_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_ServiceTask";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Tsk_PeriodBegin, (v) => this.Tsk_PeriodBegin = (global::System.DateTime?)v) /*--PeriodBegin--*/
			{
				Name = "Tsk_PeriodBegin",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Tsk_PeriodBegin,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Tsk_PeriodEnd, (v) => this.Tsk_PeriodEnd = (global::System.DateTime?)v) /*--PeriodEnd--*/
			{
				Name = "Tsk_PeriodEnd",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Tsk_PeriodEnd,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.Tsk_ID, (v) => this.Tsk_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Tsk_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Tsk_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [TemplateSubscriptions]
	[DocIgnore]
	public class GET_p_ucp_get_TemplateSubscriptions_Request : ICallProcedureModel<GET_p_ucp_get_TemplateSubscriptions_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_TemplateSubscriptions_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_TemplateSubscriptions_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// No description
		/// <para/>
		/// TreeNodeID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Agreements
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Agr_ID { get; set; } /*IN*/
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Extentions (Номера MSISDN)
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? Ext_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// PageNumber
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ShowBasicTP
		/// </summary>
		public global::System.Int32? ShowBasicTP { get; set; } /*IN*/
			/// <summary>
		/// Наименование тарифного плана
		/// <para/>
		/// TariffName
		/// </summary>
		public global::System.String TariffName { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_TemplateSubscriptions_Request()
		{
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_TemplateSubscriptions_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_TemplateSubscriptions";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--TreeNodeID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Agr_ID, (v) => this.Agr_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Agr_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Agr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Ext_ID, (v) => this.Ext_ID = (global::System.Int32?)v) /*--ExtentionID--*/
			{
				Name = "Ext_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Ext_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--PageNumber--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ShowBasicTP, (v) => this.ShowBasicTP = (global::System.Int32?)v) /*--ShowBasicTP--*/
			{
				Name = "ShowBasicTP",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ShowBasicTP,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.TariffName, (v) => this.TariffName = (global::System.String)v) /*--TariffName--*/
			{
				Name = "TariffName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TariffName,
				DBType = System.Data.DbType.String
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_TemplateSubscriptions_Response // Response Get Model
	{
		#region [Response Model Props]
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_TemplateSubscriptions_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// No description
		/// <para/>
		/// SubscriberID
		/// </summary>
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// AgreementID
		/// </summary>
		public global::System.Int64? agr_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ExtentionID
		/// </summary>
		public global::System.Int32? ext_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TarifPlanName
		/// </summary>
		[Required]
		public global::System.String grt_Name { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PolicyID
		/// </summary>
		[Required]
		public global::System.Int32? ptp_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PolicyName
		/// </summary>
		[Required]
		public global::System.String ptp_UserGroupName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// RepresentationID
		/// </summary>
		[Required]
		public global::System.Int32? rpr_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// DateEnd
		/// </summary>
		[Required]
		public global::System.DateTime? rtb_DateDrop { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// DateStart
		/// </summary>
		[Required]
		public global::System.DateTime? rtb_DateSet { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? rtb_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TariffDescription
		/// </summary>
		[Required]
		public global::System.String TariffDescription { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// TariffName
		/// </summary>
		[Required]
		public global::System.String TariffName { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PriceRatio
		/// </summary>
		[Required]
		public global::System.Decimal? tgb_PriceRatio { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Total
		/// </summary>
		[Required]
		public global::System.Int32? Total { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PacketExternalID
		/// </summary>
		[Required]
		public global::System.Int32? tp_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// PacketParentID
		/// </summary>
		[Required]
		public global::System.Int32? tp_ID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// grt_ExternalId
		/// </summary>
		public global::System.Int32? grt_ExternalId { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор группы тарифных планов
		/// <para/>
		/// grt_ID
		/// </summary>
		[Required]
		public global::System.Int32? grt_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор тарифного плана/template. Связь с TariffPlan
		/// <para/>
		/// IdTariffPlan
		/// </summary>
		[Required]
		public global::System.Int32? IdTariffPlan { get; set; } /*OUTPUT*/
			/// <summary>
		/// Наименование группы тарифных планов (локальное)
		/// <para/>
		/// tpgnd_Name
		/// </summary>
		public global::System.String tpgnd_Name { get; set; } /*OUTPUT*/
#endregion
	}
	[DocIgnore]
	public class SET_p_ucp_set_AgreementTemplates_Request : ICallProcedureModel<SET_p_ucp_set_AgreementTemplates_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_AgreementTemplates_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_AgreementTemplates_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// дата активации
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? EffectiveDate { get; set; } /*IN*/
			/// <summary>
		/// Дополнительные параметры для provisioning (для каждой услуги отдельно)
		/// <para/>
		/// TasksJsonData
		/// </summary>
		public global::System.String TasksJsonData { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Тарифного Пакета
		/// <para/>
		/// TemplateID
		/// </summary>
		public global::System.Int32? Tp_ID { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Дата окончания действия Тарифного Пакета
		/// <para/>
		/// DateEnd
		/// </summary>
		public global::System.DateTime? DateEnd { get; set; } /*IN*/
			/// <summary>
		/// Дата начала действия Тарифного Пакета
		/// <para/>
		/// DateStart
		/// </summary>
		public global::System.DateTime? DateStart { get; set; } /*IN*/
			/// <summary>
		/// Признак проверить наличие полной суммы АП для списания при подключении пакета
		/// <para/>
		/// CheckBallance
		/// </summary>
		public global::System.Int32? IsCheckBallance { get; set; } /*IN*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Зарезервировано для Response
		/// <para/>
		/// Entities
		/// </summary>
		public global::System.String Entities { get; set; } /*INOUT*/
			/// <summary>
		/// Признак первичной активации или изменения существующей подписки
		/// <para/>
		/// TariffBegin
		/// </summary>
		public global::System.Int32? TariffBegin { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Agreements
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Agr_ID { get; set; } /*IN*/
			/// <summary>
		/// Уникальный Идентификатор подписки на Тарифный Пакет
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Rtb_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ActivateServices
		/// </summary>
		public global::System.String ActivateServices { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Agr_ID_Old
		/// </summary>
		public global::System.Int32? Agr_ID_Old { get; set; } /*IN*/
			/// <summary>
		/// Зарезервировано
		/// <para/>
		/// ConfirmationMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*INOUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// Rtb_ID_Old
		/// </summary>
		public global::System.Int32? Rtb_ID_Old { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// ServiceMode
		/// </summary>
		public global::System.String ServiceMode { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Services
		/// </summary>
		public global::System.String Services { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// Tp_ID_New
		/// </summary>
		public global::System.Int32? Tp_ID_New { get; set; } /*IN*/
			/// <summary>
		/// Признак подтверждения операции со стороны пользователя
		/// <para/>
		/// UserAcceptance
		/// </summary>
		public global::System.Int32? ConfAccepted { get; set; } /*IN*/
#endregion

		#region ctor
		public SET_p_ucp_set_AgreementTemplates_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Entities); // INOUT
			expressions.Add((m) => m.Rtb_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
			expressions.Add((m) => m.ConfMessage); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_AgreementTemplates_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_AgreementTemplates";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.EffectiveDate, (v) => this.EffectiveDate = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "EffectiveDate",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EffectiveDate,
				DBType = System.Data.DbType.DateTime
			};
			yield return new DynamicParameter(() => this.TasksJsonData, (v) => this.TasksJsonData = (global::System.String)v) /*--TasksJsonData--*/
			{
				Name = "TasksJsonData",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TasksJsonData,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tp_ID, (v) => this.Tp_ID = (global::System.Int32?)v) /*--TemplateID--*/
			{
				Name = "Tp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.DateEnd, (v) => this.DateEnd = (global::System.DateTime?)v) /*--DateEnd--*/
			{
				Name = "DateEnd",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateEnd,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.DateStart, (v) => this.DateStart = (global::System.DateTime?)v) /*--DateStart--*/
			{
				Name = "DateStart",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.DateStart,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.IsCheckBallance, (v) => this.IsCheckBallance = (global::System.Int32?)v) /*--CheckBallance--*/
			{
				Name = "IsCheckBallance",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.IsCheckBallance,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Entities, (v) => this.Entities = (global::System.String)v) /*--Entities--*/
			{
				Name = "Entities",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Entities,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.TariffBegin, (v) => this.TariffBegin = (global::System.Int32?)v) /*--TariffBegin--*/
			{
				Name = "TariffBegin",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.TariffBegin,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Agr_ID, (v) => this.Agr_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Agr_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Agr_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Rtb_ID, (v) => this.Rtb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Rtb_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Rtb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ActivateServices, (v) => this.ActivateServices = (global::System.String)v) /*--ActivateServices--*/
			{
				Name = "ActivateServices",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ActivateServices,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Agr_ID_Old, (v) => this.Agr_ID_Old = (global::System.Int32?)v) /*--Agr_ID_Old--*/
			{
				Name = "Agr_ID_Old",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Agr_ID_Old,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfirmationMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Rtb_ID_Old, (v) => this.Rtb_ID_Old = (global::System.Int32?)v) /*--Rtb_ID_Old--*/
			{
				Name = "Rtb_ID_Old",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Rtb_ID_Old,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ServiceMode, (v) => this.ServiceMode = (global::System.String)v) /*--ServiceMode--*/
			{
				Name = "ServiceMode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ServiceMode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Services, (v) => this.Services = (global::System.String)v) /*--Services--*/
			{
				Name = "Services",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Services,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tp_ID_New, (v) => this.Tp_ID_New = (global::System.Int32?)v) /*--Tp_ID_New--*/
			{
				Name = "Tp_ID_New",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tp_ID_New,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ConfAccepted, (v) => this.ConfAccepted = (global::System.Int32?)v) /*--UserAcceptance--*/
			{
				Name = "ConfAccepted",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ConfAccepted,
				DBType = System.Data.DbType.Int32
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_AgreementTemplates_Response : ICallProcedureModel<SET_p_ucp_set_AgreementTemplates_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_AgreementTemplates_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_AgreementTemplates_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Уникальный Идентификатор подписки на Тарифный Пакет
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Rtb_ID { get; set; } /*OUT*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// Lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Список сущностей, созданных в результате выполнения операции
		/// <para/>
		/// Entities
		/// </summary>
		public global::System.String Entities { get; set; } /*OUT*/
			/// <summary>
		/// No description
		/// <para/>
		/// ConfirmationMessage
		/// </summary>
		public global::System.String ConfMessage { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_AgreementTemplates_Response()
		{
			expressions.Add((m) => m.Rtb_ID); // OUT
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Entities); // OUT
			expressions.Add((m) => m.ConfMessage); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_AgreementTemplates_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_AgreementTemplates";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Rtb_ID, (v) => this.Rtb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Rtb_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Rtb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--Lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Entities, (v) => this.Entities = (global::System.String)v) /*--Entities--*/
			{
				Name = "Entities",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Entities,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ConfMessage, (v) => this.ConfMessage = (global::System.String)v) /*--ConfirmationMessage--*/
			{
				Name = "ConfMessage",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.ConfMessage,
				DBType = System.Data.DbType.String
			};
		}
	}
#endregion
#region [TreeNodeHistory]
	[DocIgnore]
	public class GET_p_ucp_get_TreeNodeHistory_Request : ICallProcedureModel<GET_p_ucp_get_TreeNodeHistory_Request> // Standard Call Model
	{
		private List<Expression<Func<GET_p_ucp_get_TreeNodeHistory_Request, object>>> expressions = 
			new List<Expression<Func<GET_p_ucp_get_TreeNodeHistory_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Идентификатор вышестоящего узла дерева
		/// <para/>
		/// ParentID
		/// </summary>
		[Required]
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// No description
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Дата применения изменений
		/// <para/>
		/// EffectiveDate
		/// </summary>
		public global::System.DateTime? Date { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		[Required]
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
			/// <summary>
		/// Номер страницы (server paging)
		/// <para/>
		/// pageIndex
		/// </summary>
		public global::System.Int32? PageNumber { get; set; } /*IN*/
			/// <summary>
		/// Кол-во записей на странице (server paging)
		/// <para/>
		/// PageSize
		/// </summary>
		public global::System.Int32? PageSize { get; set; } /*IN*/
#endregion

		#region ctor
		public GET_p_ucp_get_TreeNodeHistory_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<GET_p_ucp_get_TreeNodeHistory_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_get_TreeNodeHistory";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Date, (v) => this.Date = (global::System.DateTime?)v) /*--EffectiveDate--*/
			{
				Name = "Date",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Date,
				DBType = System.Data.DbType.Date
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.PageNumber, (v) => this.PageNumber = (global::System.Int32?)v) /*--pageIndex--*/
			{
				Name = "PageNumber",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageNumber,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.PageSize, (v) => this.PageSize = (global::System.Int32?)v) /*--PageSize--*/
			{
				Name = "PageSize",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.PageSize,
				DBType = System.Data.DbType.Int32
			};
		}
	}

	[DocIgnore]
	public class GET_p_ucp_get_TreeNodeHistory_Response // Response Get Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		[Required]
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion
	}
	[DocIgnore]
	public class GET_p_ucp_get_TreeNodeHistory_Response_OUTPUT // Response Output Model
	{
		#region [Response Model Props]
			/// <summary>
		/// Внешний ID узла дерева
		/// <para/>
		/// TreeNodeExternalID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ExternalID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Внешний идентификатор вышестоящего узла дерева
		/// <para/>
		/// TreeNodeParentExternalID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ExternalID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ID
		/// </summary>
		[Required]
		public global::System.Int32? tnh_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// ID узла дерева
		/// <para/>
		/// TreeNodeID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID { get; set; } /*OUTPUT*/
			/// <summary>
		/// Идентификатор вышестоящего узла дерева
		/// <para/>
		/// TreeNodeParentID
		/// </summary>
		[Required]
		public global::System.Int32? abn_ID_Boss { get; set; } /*OUTPUT*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		[Required]
		public global::System.String tnh_ModifiedFrom { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата изменения записи
		/// <para/>
		/// ModifiedDate
		/// </summary>
		[Required]
		public global::System.DateTime? tnh_ModifiedDate { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата начала действия записи
		/// <para/>
		/// DateStart
		/// </summary>
		[Required]
		public global::System.DateTime? tnh_DateStart { get; set; } /*OUTPUT*/
			/// <summary>
		/// Дата окончания действия записи
		/// <para/>
		/// DateEnd
		/// </summary>
		[Required]
		public global::System.DateTime? DateEnd { get; set; } /*OUTPUT*/
			/// <summary>
		/// Комментарий изменения
		/// <para/>
		/// Remark
		/// </summary>
		[Required]
		public global::System.String tnh_Remark { get; set; } /*OUTPUT*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		[Required]
		public global::System.String tnh_ModifiedBy { get; set; } /*OUTPUT*/
#endregion
	}
#endregion
#region [TreeNodeProperties]
	[DocIgnore]
	public class SET_p_ucp_set_TreeNodeProperty_Request : ICallProcedureModel<SET_p_ucp_set_TreeNodeProperty_Request> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_TreeNodeProperty_Request, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_TreeNodeProperty_Request, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак удаления дополнительного атрибута
		/// <para/>
		/// Annul
		/// </summary>
		public global::System.Int32? Annul { get; set; } /*IN*/
			/// <summary>
		/// Пользователь данного изменения
		/// <para/>
		/// ModifiedBy
		/// </summary>
		public global::System.String ModBy { get; set; } /*IN*/
			/// <summary>
		/// Источник данного изменения
		/// <para/>
		/// ModifiedFrom
		/// </summary>
		public global::System.String ModFrom { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор дополнительного атрибута
		/// <para/>
		/// PropertyID
		/// </summary>
		public global::System.Int32? Prp_ID { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор Значения Справочника для дополнительного атрибута
		/// <para/>
		/// PropertyValueID
		/// </summary>
		public global::System.Int32? Prpv_ID { get; set; } /*IN*/
			/// <summary>
		/// Комментарий
		/// <para/>
		/// Remark
		/// </summary>
		public global::System.String Remark { get; set; } /*IN*/
			/// <summary>
		/// Внешний идентификатор дополнительного атрибута
		/// <para/>
		/// ExternalID
		/// </summary>
		public global::System.Int32? Tnpb_ExternalID { get; set; } /*IN*/
			/// <summary>
		/// Расширенное значение атрибута (дата, число или текст - не справочник) 
		/// <para/>
		/// Value
		/// </summary>
		public global::System.String Value { get; set; } /*IN*/
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*INOUT*/
			/// <summary>
		/// Код внешней системы - инициатора запроса
		/// <para/>
		/// System
		/// </summary>
		public global::System.String ExternalSystemCode { get; set; } /*IN*/
			/// <summary>
		/// Название сущности REST, для которой выполняется POST операция
		/// <para/>
		/// EntityName
		/// </summary>
		public global::System.String EntityName { get; set; } /*IN*/
			/// <summary>
		/// Идентификатор записи на ЛС для правки дополнительного атрибута
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Tnpb_ID { get; set; } /*INOUT*/
			/// <summary>
		/// Идентификатор лицевого счета (соответствует CustomerID)
		/// <para/>
		/// ParentID
		/// </summary>
		public global::System.Int32? Abn_ID { get; set; } /*IN*/
			/// <summary>
		/// Формат вывода ошибки
		/// <para/>
		/// ErrFormat
		/// </summary>
		public global::System.String ErrFormat { get; set; } /*IN*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*INOUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_TreeNodeProperty_Request()
		{
			expressions.Add((m) => m.IsExternalID); // INOUT
			expressions.Add((m) => m.Tnpb_ID); // INOUT
			expressions.Add((m) => m.Lang); // INOUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_TreeNodeProperty_Request, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_TreeNodeProperty";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.Annul, (v) => this.Annul = (global::System.Int32?)v) /*--Annul--*/
			{
				Name = "Annul",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Annul,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ModBy, (v) => this.ModBy = (global::System.String)v) /*--ModifiedBy--*/
			{
				Name = "ModBy",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModBy,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.ModFrom, (v) => this.ModFrom = (global::System.String)v) /*--ModifiedFrom--*/
			{
				Name = "ModFrom",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ModFrom,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Prp_ID, (v) => this.Prp_ID = (global::System.Int32?)v) /*--PropertyID--*/
			{
				Name = "Prp_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Prp_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Prpv_ID, (v) => this.Prpv_ID = (global::System.Int32?)v) /*--PropertyValueID--*/
			{
				Name = "Prpv_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Prpv_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Remark, (v) => this.Remark = (global::System.String)v) /*--Remark--*/
			{
				Name = "Remark",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Remark,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnpb_ExternalID, (v) => this.Tnpb_ExternalID = (global::System.Int32?)v) /*--ExternalID--*/
			{
				Name = "Tnpb_ExternalID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Tnpb_ExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Value, (v) => this.Value = (global::System.String)v) /*--Value--*/
			{
				Name = "Value",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Value,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ExternalSystemCode, (v) => this.ExternalSystemCode = (global::System.String)v) /*--System--*/
			{
				Name = "ExternalSystemCode",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ExternalSystemCode,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.EntityName, (v) => this.EntityName = (global::System.String)v) /*--EntityName--*/
			{
				Name = "EntityName",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.EntityName,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnpb_ID, (v) => this.Tnpb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Tnpb_ID",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Tnpb_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Abn_ID, (v) => this.Abn_ID = (global::System.Int32?)v) /*--ParentID--*/
			{
				Name = "Abn_ID",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.Abn_ID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.ErrFormat, (v) => this.ErrFormat = (global::System.String)v) /*--ErrFormat--*/
			{
				Name = "ErrFormat",
				Direction = System.Data.ParameterDirection.Input,
				Value = this.ErrFormat,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.InputOutput,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
		}
	}
	[DocIgnore]
	public class SET_p_ucp_set_TreeNodeProperty_Response : ICallProcedureModel<SET_p_ucp_set_TreeNodeProperty_Response> // Standard Call Model
	{
		private List<Expression<Func<SET_p_ucp_set_TreeNodeProperty_Response, object>>> expressions = 
			new List<Expression<Func<SET_p_ucp_set_TreeNodeProperty_Response, object>>>();

		#region [CallModel Props]
			/// <summary>
		/// Признак передачи внешнего значения ID
		/// <para/>
		/// IDType
		/// </summary>
		public global::System.Int32? IsExternalID { get; set; } /*OUT*/
			/// <summary>
		/// Указание языка для набора multi-language данных 
		/// <para/>
		/// lang
		/// </summary>
		[Required]
		public global::System.String Lang { get; set; } /*OUT*/
			/// <summary>
		/// Идентификатор записи на ЛС для правки дополнительного атрибута
		/// <para/>
		/// ID
		/// </summary>
		public global::System.Int32? Tnpb_ID { get; set; } /*OUT*/
#endregion

		#region ctor
		public SET_p_ucp_set_TreeNodeProperty_Response()
		{
			expressions.Add((m) => m.IsExternalID); // OUT
			expressions.Add((m) => m.Lang); // OUT
			expressions.Add((m) => m.Tnpb_ID); // OUT
		}
		#endregion

		public IEnumerable<Expression<Func<SET_p_ucp_set_TreeNodeProperty_Response, object>>> Expressions()
		{ 
			return expressions;
		}

		public string StoredProcedureName() 
		{ 
			return "p_ucp_set_TreeNodeProperty";
		}

		public IEnumerable<DynamicParameter> DynamicParameters()
		{
						yield return new DynamicParameter(() => this.IsExternalID, (v) => this.IsExternalID = (global::System.Int32?)v) /*--IDType--*/
			{
				Name = "IsExternalID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.IsExternalID,
				DBType = System.Data.DbType.Int32
			};
			yield return new DynamicParameter(() => this.Lang, (v) => this.Lang = (global::System.String)v) /*--lang--*/
			{
				Name = "Lang",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Lang,
				DBType = System.Data.DbType.String
			};
			yield return new DynamicParameter(() => this.Tnpb_ID, (v) => this.Tnpb_ID = (global::System.Int32?)v) /*--ID--*/
			{
				Name = "Tnpb_ID",
				Direction = System.Data.ParameterDirection.Output,
				Value = this.Tnpb_ID,
				DBType = System.Data.DbType.Int32
			};
		}
	}
#endregion
}
