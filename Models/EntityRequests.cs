////////////////////////////////////////////////////////
// Прокси класс моделей вызовов хранимых процедур. Альфа версия - с 
// expressions для Output параметров в Dapper
// Сгенерирован из файла C:\Users\keiqsa\Projects\model-first-backend-plugin\models.xml 10/21/2022 12:54:28
////////////////////////////////////////////////////////

using System.Composition;
using Newtonsoft.Json;
using UCP.Common.Plugin;

namespace Bss.Entities
{
#region [Accounts]
        /// <summary>
        /// accounts
        /// </summary>
        [Export("accounts", typeof(BaseEntity))]
        [JsonObject(Title = "accounts", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AccountsRequest : Accounts_Request_SET
        {
        }
#endregion
#region [Accounts/CustomerAccounts]
#endregion
#region [AccountTaxes]
        /// <summary>
        /// accounttaxes
        /// </summary>
        [Export("accounttaxes", typeof(BaseEntity))]
        [JsonObject(Title = "accounttaxes", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AccountTaxesRequest : AccountTaxes_Request_SET
        {
        }
#endregion
#region [Addresses]
        /// <summary>
        /// addresses
        /// </summary>
        [Export("addresses", typeof(BaseEntity))]
        [JsonObject(Title = "addresses", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AddressesRequest : Addresses_Request_SET
        {
        }
#endregion
#region [Addresses/Sync]
        /// <summary>
        /// addresses/sync
        /// </summary>
        [Export("addresses/sync", typeof(BaseEntity))]
        [JsonObject(Title = "addresses/sync", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AddressesSyncRequest : Addresses_Sync_Request_ACTION
        {
        }
#endregion
#region [Adjustments]
        /// <summary>
        /// adjustments
        /// </summary>
        [Export("adjustments", typeof(BaseEntity))]
        [JsonObject(Title = "adjustments", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AdjustmentsRequest : Adjustments_Request_SET
        {
        }
#endregion
#region [Agreements]
        /// <summary>
        /// agreements
        /// </summary>
        [Export("agreements", typeof(BaseEntity))]
        [JsonObject(Title = "agreements", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AgreementsRequest : Agreements_Request_SET
        {
        }
#endregion
#region [Agreements/ChangeTariffs]
        /// <summary>
        /// agreements/changetariffs
        /// </summary>
        [Export("agreements/changetariffs", typeof(BaseEntity))]
        [JsonObject(Title = "agreements/changetariffs", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AgreementsChangeTariffsRequest : Agreements_ChangeTariffs_Request_ACTION
        {
        }
#endregion
#region [Associations]
        /// <summary>
        /// associations
        /// </summary>
        [Export("associations", typeof(BaseEntity))]
        [JsonObject(Title = "associations", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AssociationsRequest : Associations_Request_SET
        {
        }
#endregion
#region [Associations/Activate]
        /// <summary>
        /// associations/activate
        /// </summary>
        [Export("associations/activate", typeof(BaseEntity))]
        [JsonObject(Title = "associations/activate", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AssociationsActivateRequest : Associations_Activate_Request_ACTION
        {
        }
#endregion
#region [Associations/ChangeName]
        /// <summary>
        /// associations/changename
        /// </summary>
        [Export("associations/changename", typeof(BaseEntity))]
        [JsonObject(Title = "associations/changename", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AssociationsChangeNameRequest : Associations_ChangeName_Request_ACTION
        {
        }
#endregion
#region [Associations/ChangeParent]
        /// <summary>
        /// associations/changeparent
        /// </summary>
        [Export("associations/changeparent", typeof(BaseEntity))]
        [JsonObject(Title = "associations/changeparent", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AssociationsChangeParentRequest : Associations_ChangeParent_Request_ACTION
        {
        }
#endregion
#region [Associations/ChangeStatus]
        /// <summary>
        /// associations/changestatus
        /// </summary>
        [Export("associations/changestatus", typeof(BaseEntity))]
        [JsonObject(Title = "associations/changestatus", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AssociationsChangeStatusRequest : Associations_ChangeStatus_Request_ACTION
        {
        }
#endregion
#region [Associations/Deactivate]
        /// <summary>
        /// associations/deactivate
        /// </summary>
        [Export("associations/deactivate", typeof(BaseEntity))]
        [JsonObject(Title = "associations/deactivate", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AssociationsDeactivateRequest : Associations_Deactivate_Request_ACTION
        {
        }
#endregion
#region [Associations/Details]
#endregion
#region [Associations/SetLabels]
        /// <summary>
        /// associations/setlabels
        /// </summary>
        [Export("associations/setlabels", typeof(BaseEntity))]
        [JsonObject(Title = "associations/setlabels", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AssociationsSetLabelsRequest : Associations_SetLabels_Request_ACTION
        {
        }
#endregion
#region [AuthCodes]
        /// <summary>
        /// authcodes
        /// </summary>
        [Export("authcodes", typeof(BaseEntity))]
        [JsonObject(Title = "authcodes", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class AuthCodesRequest : AuthCodes_Request_SET
        {
        }
#endregion
#region [BankAccounts]
#endregion
#region [BankDetails]
        /// <summary>
        /// bankdetails
        /// </summary>
        [Export("bankdetails", typeof(BaseEntity))]
        [JsonObject(Title = "bankdetails", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class BankDetailsRequest : BankDetails_Request_SET
        {
        }
#endregion
#region [BankStatements]
        /// <summary>
        /// bankstatements
        /// </summary>
        [Export("bankstatements", typeof(BaseEntity))]
        [JsonObject(Title = "bankstatements", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class BankStatementsRequest : BankStatements_Request_SET
        {
        }
#endregion
#region [BankStatements/ChangePaymentsStatus]
        /// <summary>
        /// bankstatements/changepaymentsstatus
        /// </summary>
        [Export("bankstatements/changepaymentsstatus", typeof(BaseEntity))]
        [JsonObject(Title = "bankstatements/changepaymentsstatus", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class BankStatementsChangePaymentsStatusRequest : BankStatements_ChangePaymentsStatus_Request_ACTION
        {
        }
#endregion
#region [BankStatements/CheckNoSavePayments]
        /// <summary>
        /// bankstatements/checknosavepayments
        /// </summary>
        [Export("bankstatements/checknosavepayments", typeof(BaseEntity))]
        [JsonObject(Title = "bankstatements/checknosavepayments", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class BankStatementsCheckNoSavePaymentsRequest : BankStatements_CheckNoSavePayments_Request_ACTION
        {
        }
#endregion
#region [BankStatements/ClearBatch]
        /// <summary>
        /// bankstatements/clearbatch
        /// </summary>
        [Export("bankstatements/clearbatch", typeof(BaseEntity))]
        [JsonObject(Title = "bankstatements/clearbatch", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class BankStatementsClearBatchRequest : BankStatements_ClearBatch_Request_ACTION
        {
        }
#endregion
#region [BankStatementTransactions]
#endregion
#region [BillingTasks]
        /// <summary>
        /// billingtasks
        /// </summary>
        [Export("billingtasks", typeof(BaseEntity))]
        [JsonObject(Title = "billingtasks", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class BillingTasksRequest : BillingTasks_Request_SET
        {
        }
#endregion
#region [CallCredits]
        /// <summary>
        /// callcredits
        /// </summary>
        [Export("callcredits", typeof(BaseEntity))]
        [JsonObject(Title = "callcredits", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CallCreditsRequest : CallCredits_Request_SET
        {
        }
#endregion
#region [CallUserGroups]
        /// <summary>
        /// callusergroups
        /// </summary>
        [Export("callusergroups", typeof(BaseEntity))]
        [JsonObject(Title = "callusergroups", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CallUserGroupsRequest : CallUserGroups_Request_SET
        {
        }
#endregion
#region [Contracts]
        /// <summary>
        /// contracts
        /// </summary>
        [Export("contracts", typeof(BaseEntity))]
        [JsonObject(Title = "contracts", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class ContractsRequest : Contracts_Request_SET
        {
        }
#endregion
#region [CustomerPayments]
        /// <summary>
        /// customerpayments
        /// </summary>
        [Export("customerpayments", typeof(BaseEntity))]
        [JsonObject(Title = "customerpayments", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomerPaymentsRequest : CustomerPayments_Request_SET
        {
        }
#endregion
#region [CustomerPayments/AllocatedPayments]
#endregion
#region [Customers]
        /// <summary>
        /// customers
        /// </summary>
        [Export("customers", typeof(BaseEntity))]
        [JsonObject(Title = "customers", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersRequest : Customers_Request_SET
        {
        }
#endregion
#region [Customers/Activate]
        /// <summary>
        /// customers/activate
        /// </summary>
        [Export("customers/activate", typeof(BaseEntity))]
        [JsonObject(Title = "customers/activate", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersActivateRequest : Customers_Activate_Request_ACTION
        {
        }
#endregion
#region [Customers/CalcCharges]
        /// <summary>
        /// customers/calccharges
        /// </summary>
        [Export("customers/calccharges", typeof(BaseEntity))]
        [JsonObject(Title = "customers/calccharges", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersCalcChargesRequest : Customers_CalcCharges_Request_ACTION
        {
        }
#endregion
#region [Customers/ChangeName]
        /// <summary>
        /// customers/changename
        /// </summary>
        [Export("customers/changename", typeof(BaseEntity))]
        [JsonObject(Title = "customers/changename", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersChangeNameRequest : Customers_ChangeName_Request_ACTION
        {
        }
#endregion
#region [Customers/ChangeParent]
        /// <summary>
        /// customers/changeparent
        /// </summary>
        [Export("customers/changeparent", typeof(BaseEntity))]
        [JsonObject(Title = "customers/changeparent", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersChangeParentRequest : Customers_ChangeParent_Request_ACTION
        {
        }
#endregion
#region [Customers/ChangeStatus]
        /// <summary>
        /// customers/changestatus
        /// </summary>
        [Export("customers/changestatus", typeof(BaseEntity))]
        [JsonObject(Title = "customers/changestatus", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersChangeStatusRequest : Customers_ChangeStatus_Request_ACTION
        {
        }
#endregion
#region [Customers/Copy]
        /// <summary>
        /// customers/copy
        /// </summary>
        [Export("customers/copy", typeof(BaseEntity))]
        [JsonObject(Title = "customers/copy", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersCopyRequest : Customers_Copy_Request_ACTION
        {
        }
#endregion
#region [Customers/CustomerExtentions]
#endregion
#region [Customers/Deactivate]
        /// <summary>
        /// customers/deactivate
        /// </summary>
        [Export("customers/deactivate", typeof(BaseEntity))]
        [JsonObject(Title = "customers/deactivate", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersDeactivateRequest : Customers_Deactivate_Request_ACTION
        {
        }
#endregion
#region [Customers/Details]
#endregion
#region [Customers/postponeInvoice]
        /// <summary>
        /// customers/postponeinvoice
        /// </summary>
        [Export("customers/postponeinvoice", typeof(BaseEntity))]
        [JsonObject(Title = "customers/postponeinvoice", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomerspostponeInvoiceRequest : Customers_postponeInvoice_Request_ACTION
        {
        }
#endregion
#region [Customers/SetLabels]
        /// <summary>
        /// customers/setlabels
        /// </summary>
        [Export("customers/setlabels", typeof(BaseEntity))]
        [JsonObject(Title = "customers/setlabels", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class CustomersSetLabelsRequest : Customers_SetLabels_Request_ACTION
        {
        }
#endregion
#region [CustomerTypes]
#endregion
#region [Discounts]
        /// <summary>
        /// discounts
        /// </summary>
        [Export("discounts", typeof(BaseEntity))]
        [JsonObject(Title = "discounts", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class DiscountsRequest : Discounts_Request_SET
        {
        }
#endregion
#region [Environment]
#endregion
#region [Extentions]
        /// <summary>
        /// extentions
        /// </summary>
        [Export("extentions", typeof(BaseEntity))]
        [JsonObject(Title = "extentions", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class ExtentionsRequest : Extentions_Request_SET
        {
        }
#endregion
#region [Gains]
        /// <summary>
        /// gains
        /// </summary>
        [Export("gains", typeof(BaseEntity))]
        [JsonObject(Title = "gains", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class GainsRequest : Gains_Request_SET
        {
        }
#endregion
#region [Memberships]
        /// <summary>
        /// memberships
        /// </summary>
        [Export("memberships", typeof(BaseEntity))]
        [JsonObject(Title = "memberships", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class MembershipsRequest : Memberships_Request_SET
        {
        }
#endregion
#region [Networks]
#endregion
#region [Networks/ClearLogins]
        /// <summary>
        /// networks/clearlogins
        /// </summary>
        [Export("networks/clearlogins", typeof(BaseEntity))]
        [JsonObject(Title = "networks/clearlogins", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class NetworksClearLoginsRequest : Networks_ClearLogins_Request_ACTION
        {
        }
#endregion
#region [PaymentDocuments]
        /// <summary>
        /// paymentdocuments
        /// </summary>
        [Export("paymentdocuments", typeof(BaseEntity))]
        [JsonObject(Title = "paymentdocuments", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class PaymentDocumentsRequest : PaymentDocuments_Request_SET
        {
        }
#endregion
#region [PaymentRegistry]
        /// <summary>
        /// paymentregistry
        /// </summary>
        [Export("paymentregistry", typeof(BaseEntity))]
        [JsonObject(Title = "paymentregistry", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class PaymentRegistryRequest : PaymentRegistry_Request_SET
        {
        }
#endregion
#region [PhoneNumbers]
        /// <summary>
        /// phonenumbers
        /// </summary>
        [Export("phonenumbers", typeof(BaseEntity))]
        [JsonObject(Title = "phonenumbers", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class PhoneNumbersRequest : PhoneNumbers_Request_SET
        {
        }
#endregion
#region [PortabilityNumbers]
        /// <summary>
        /// portabilitynumbers
        /// </summary>
        [Export("portabilitynumbers", typeof(BaseEntity))]
        [JsonObject(Title = "portabilitynumbers", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class PortabilityNumbersRequest : PortabilityNumbers_Request_SET
        {
        }
#endregion
#region [Profiles]
        /// <summary>
        /// profiles
        /// </summary>
        [Export("profiles", typeof(BaseEntity))]
        [JsonObject(Title = "profiles", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class ProfilesRequest : Profiles_Request_SET
        {
        }
#endregion
#region [RatingData]
        /// <summary>
        /// ratingdata
        /// </summary>
        [Export("ratingdata", typeof(BaseEntity))]
        [JsonObject(Title = "ratingdata", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class RatingDataRequest : RatingData_Request_SET
        {
        }
#endregion
#region [RatingData/Release]
        /// <summary>
        /// ratingdata/release
        /// </summary>
        [Export("ratingdata/release", typeof(BaseEntity))]
        [JsonObject(Title = "ratingdata/release", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class RatingDataReleaseRequest : RatingData_Release_Request_ACTION
        {
        }
#endregion
#region [RatingData/Update]
        /// <summary>
        /// ratingdata/update
        /// </summary>
        [Export("ratingdata/update", typeof(BaseEntity))]
        [JsonObject(Title = "ratingdata/update", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class RatingDataUpdateRequest : RatingData_Update_Request_ACTION
        {
        }
#endregion
#region [ServiceSubscriptions]
        /// <summary>
        /// servicesubscriptions
        /// </summary>
        [Export("servicesubscriptions", typeof(BaseEntity))]
        [JsonObject(Title = "servicesubscriptions", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class ServiceSubscriptionsRequest : ServiceSubscriptions_Request_SET
        {
        }
#endregion
#region [Subscribers]
        /// <summary>
        /// subscribers
        /// </summary>
        [Export("subscribers", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersRequest : Subscribers_Request_SET
        {
        }
#endregion
#region [Subscribers/Activate]
        /// <summary>
        /// subscribers/activate
        /// </summary>
        [Export("subscribers/activate", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers/activate", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersActivateRequest : Subscribers_Activate_Request_ACTION
        {
        }
#endregion
#region [Subscribers/CalcCharges]
        /// <summary>
        /// subscribers/calccharges
        /// </summary>
        [Export("subscribers/calccharges", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers/calccharges", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersCalcChargesRequest : Subscribers_CalcCharges_Request_ACTION
        {
        }
#endregion
#region [Subscribers/ChangeAccount]
        /// <summary>
        /// subscribers/changeaccount
        /// </summary>
        [Export("subscribers/changeaccount", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers/changeaccount", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersChangeAccountRequest : Subscribers_ChangeAccount_Request_ACTION
        {
        }
#endregion
#region [Subscribers/ChangeName]
        /// <summary>
        /// subscribers/changename
        /// </summary>
        [Export("subscribers/changename", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers/changename", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersChangeNameRequest : Subscribers_ChangeName_Request_ACTION
        {
        }
#endregion
#region [Subscribers/ChangeStatus]
        /// <summary>
        /// subscribers/changestatus
        /// </summary>
        [Export("subscribers/changestatus", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers/changestatus", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersChangeStatusRequest : Subscribers_ChangeStatus_Request_ACTION
        {
        }
#endregion
#region [Subscribers/Deactivate]
        /// <summary>
        /// subscribers/deactivate
        /// </summary>
        [Export("subscribers/deactivate", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers/deactivate", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersDeactivateRequest : Subscribers_Deactivate_Request_ACTION
        {
        }
#endregion
#region [Subscribers/Details]
#endregion
#region [Subscribers/Recharge]
        /// <summary>
        /// subscribers/recharge
        /// </summary>
        [Export("subscribers/recharge", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers/recharge", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersRechargeRequest : Subscribers_Recharge_Request_ACTION
        {
        }
#endregion
#region [Subscribers/SetLabels]
        /// <summary>
        /// subscribers/setlabels
        /// </summary>
        [Export("subscribers/setlabels", typeof(BaseEntity))]
        [JsonObject(Title = "subscribers/setlabels", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class SubscribersSetLabelsRequest : Subscribers_SetLabels_Request_ACTION
        {
        }
#endregion
#region [Tasks]
        /// <summary>
        /// tasks
        /// </summary>
        [Export("tasks", typeof(BaseEntity))]
        [JsonObject(Title = "tasks", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class TasksRequest : Tasks_Request_SET
        {
        }
#endregion
#region [TemplateSubscriptions]
        /// <summary>
        /// templatesubscriptions
        /// </summary>
        [Export("templatesubscriptions", typeof(BaseEntity))]
        [JsonObject(Title = "templatesubscriptions", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class TemplateSubscriptionsRequest : TemplateSubscriptions_Request_SET
        {
        }
#endregion
#region [TreeNodeHistory]
#endregion
#region [TreeNodeProperties]
        /// <summary>
        /// treenodeproperties
        /// </summary>
        [Export("treenodeproperties", typeof(BaseEntity))]
        [JsonObject(Title = "treenodeproperties", IsReference = true, ItemIsReference = true, ItemNullValueHandling =NullValueHandling.Ignore)]
        public partial class TreeNodePropertiesRequest : TreeNodeProperties_Request_SET
        {
        }
#endregion
}
