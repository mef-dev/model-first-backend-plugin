////////////////////////////////////////////////////////
// Прокси класс для связывания разных моделей с сущностями
////////////////////////////////////////////////////////

using System.Collections.Generic;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
//////////////////////////////////////////////////////////////////////////////
//                            Binders
//////////////////////////////////////////////////////////////////////////////
	[DocIgnore]
    public static class EntityBinders
    {
#region [Accounts]
public static Accounts_EntityBindContainer Accounts = new Accounts_EntityBindContainer();
#endregion
#region [AccountTaxes]
public static AccountTaxes_EntityBindContainer AccountTaxes = new AccountTaxes_EntityBindContainer();
#endregion
#region [Addresses]
public static Addresses_EntityBindContainer Addresses = new Addresses_EntityBindContainer();
#endregion
#region [Adjustments]
public static Adjustments_EntityBindContainer Adjustments = new Adjustments_EntityBindContainer();
#endregion
#region [Agreements]
public static Agreements_EntityBindContainer Agreements = new Agreements_EntityBindContainer();
#endregion
#region [Associations]
public static Associations_EntityBindContainer Associations = new Associations_EntityBindContainer();
#endregion
#region [AuthCodes]
public static AuthCodes_EntityBindContainer AuthCodes = new AuthCodes_EntityBindContainer();
#endregion
#region [BankAccounts]
public static BankAccounts_EntityBindContainer BankAccounts = new BankAccounts_EntityBindContainer();
#endregion
#region [BankDetails]
public static BankDetails_EntityBindContainer BankDetails = new BankDetails_EntityBindContainer();
#endregion
#region [BankStatements]
public static BankStatements_EntityBindContainer BankStatements = new BankStatements_EntityBindContainer();
#endregion
#region [BankStatementTransactions]
public static BankStatementTransactions_EntityBindContainer BankStatementTransactions = new BankStatementTransactions_EntityBindContainer();
#endregion
#region [BillingTasks]
public static BillingTasks_EntityBindContainer BillingTasks = new BillingTasks_EntityBindContainer();
#endregion
#region [CallCredits]
public static CallCredits_EntityBindContainer CallCredits = new CallCredits_EntityBindContainer();
#endregion
#region [CallUserGroups]
public static CallUserGroups_EntityBindContainer CallUserGroups = new CallUserGroups_EntityBindContainer();
#endregion
#region [Contracts]
public static Contracts_EntityBindContainer Contracts = new Contracts_EntityBindContainer();
#endregion
#region [CustomerPayments]
public static CustomerPayments_EntityBindContainer CustomerPayments = new CustomerPayments_EntityBindContainer();
#endregion
#region [Customers]
public static Customers_EntityBindContainer Customers = new Customers_EntityBindContainer();
#endregion
#region [CustomerTypes]
public static CustomerTypes_EntityBindContainer CustomerTypes = new CustomerTypes_EntityBindContainer();
#endregion
#region [Discounts]
public static Discounts_EntityBindContainer Discounts = new Discounts_EntityBindContainer();
#endregion
#region [Environment]
public static Environment_EntityBindContainer Environment = new Environment_EntityBindContainer();
#endregion
#region [Extentions]
public static Extentions_EntityBindContainer Extentions = new Extentions_EntityBindContainer();
#endregion
#region [Gains]
public static Gains_EntityBindContainer Gains = new Gains_EntityBindContainer();
#endregion
#region [Memberships]
public static Memberships_EntityBindContainer Memberships = new Memberships_EntityBindContainer();
#endregion
#region [Networks]
public static Networks_EntityBindContainer Networks = new Networks_EntityBindContainer();
#endregion
#region [PaymentDocuments]
public static PaymentDocuments_EntityBindContainer PaymentDocuments = new PaymentDocuments_EntityBindContainer();
#endregion
#region [PaymentRegistry]
public static PaymentRegistry_EntityBindContainer PaymentRegistry = new PaymentRegistry_EntityBindContainer();
#endregion
#region [PhoneNumbers]
public static PhoneNumbers_EntityBindContainer PhoneNumbers = new PhoneNumbers_EntityBindContainer();
#endregion
#region [PortabilityNumbers]
public static PortabilityNumbers_EntityBindContainer PortabilityNumbers = new PortabilityNumbers_EntityBindContainer();
#endregion
#region [Profiles]
public static Profiles_EntityBindContainer Profiles = new Profiles_EntityBindContainer();
#endregion
#region [RatingData]
public static RatingData_EntityBindContainer RatingData = new RatingData_EntityBindContainer();
#endregion
#region [ServiceSubscriptions]
public static ServiceSubscriptions_EntityBindContainer ServiceSubscriptions = new ServiceSubscriptions_EntityBindContainer();
#endregion
#region [Subscribers]
public static Subscribers_EntityBindContainer Subscribers = new Subscribers_EntityBindContainer();
#endregion
#region [Tasks]
public static Tasks_EntityBindContainer Tasks = new Tasks_EntityBindContainer();
#endregion
#region [TemplateSubscriptions]
public static TemplateSubscriptions_EntityBindContainer TemplateSubscriptions = new TemplateSubscriptions_EntityBindContainer();
#endregion
#region [TreeNodeHistory]
public static TreeNodeHistory_EntityBindContainer TreeNodeHistory = new TreeNodeHistory_EntityBindContainer();
#endregion
#region [TreeNodeProperties]
public static TreeNodeProperties_EntityBindContainer TreeNodeProperties = new TreeNodeProperties_EntityBindContainer();
#endregion
	}
//////////////////////////////////////////////////////////////////////////////
//                            DERIVED CLASSES
//////////////////////////////////////////////////////////////////////////////
#region [Derived classes]
#region [Accounts]
        /// <summary>
        /// Accounts
        /// </summary>
		[DocIgnore]
        public class Accounts_EntityBindContainer : EntityBindContainer
        {
			public Accounts_EntityBindContainer():base("Accounts")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Accounts_Request_SET),
					typeof(SET_p_ucp_set_Accounts_Request),
					typeof(SET_p_ucp_set_Accounts_Response),
					typeof(Accounts_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(Accounts_Request_GET),
							typeof(GET_p_ucp_get_Accounts_Request),
							typeof(GET_p_ucp_get_Accounts_Response),
							typeof(Accounts_Response_GET),
							typeof(GET_p_ucp_get_Accounts_Response_OUTPUT),
							typeof(Accounts_Response_GET_OUTPUT))
                    },
                    {
                        "customeraccounts",
                        new CallGetProcedureBindContainer(
							typeof(Accounts_CustomerAccounts_Request_GET),
							typeof(GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Request),
							typeof(GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response),
							typeof(Accounts_CustomerAccounts_Response_GET),
							typeof(GET_p_ucp_get_CustomerAccounts_Accounts_CustomerAccounts_Response_OUTPUT),
							typeof(Accounts_CustomerAccounts_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [AccountTaxes]
        /// <summary>
        /// AccountTaxes
        /// </summary>
		[DocIgnore]
        public class AccountTaxes_EntityBindContainer : EntityBindContainer
        {
			public AccountTaxes_EntityBindContainer():base("AccountTaxes")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(AccountTaxes_Request_SET),
					typeof(SET_p_ucp_set_AccountTaxes_Request),
					typeof(SET_p_ucp_set_AccountTaxes_Response),
					typeof(AccountTaxes_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Addresses]
        /// <summary>
        /// Addresses
        /// </summary>
		[DocIgnore]
        public class Addresses_EntityBindContainer : EntityBindContainer
        {
			public Addresses_EntityBindContainer():base("Addresses")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Addresses_Request_SET),
					typeof(SET_p_ucp_set_TreeNodeAddresses_Request),
					typeof(SET_p_ucp_set_TreeNodeAddresses_Response),
					typeof(Addresses_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{
					{
                    "sync",
                    new CallProcedureBindContainer(
						typeof(Addresses_Sync_Request_ACTION),
						typeof(ACTION_sp_RunSyncAddressDict_Addresses_Sync_Request),
						typeof(ACTION_sp_RunSyncAddressDict_Addresses_Sync_Response),
						typeof(Addresses_Sync_Response_ACTION))
					},

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Adjustments]
        /// <summary>
        /// Adjustments
        /// </summary>
		[DocIgnore]
        public class Adjustments_EntityBindContainer : EntityBindContainer
        {
			public Adjustments_EntityBindContainer():base("Adjustments")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Adjustments_Request_SET),
					typeof(SET_p_ucp_set_AccountAdjustments_Request),
					typeof(SET_p_ucp_set_AccountAdjustments_Response),
					typeof(Adjustments_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Agreements]
        /// <summary>
        /// Agreements
        /// </summary>
		[DocIgnore]
        public class Agreements_EntityBindContainer : EntityBindContainer
        {
			public Agreements_EntityBindContainer():base("Agreements")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Agreements_Request_SET),
					typeof(SET_p_ucp_set_SubscriberAgreements_Request),
					typeof(SET_p_ucp_set_SubscriberAgreements_Response),
					typeof(Agreements_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{
					{
                    "changetariffs",
                    new CallProcedureBindContainer(
						typeof(Agreements_ChangeTariffs_Request_ACTION),
						typeof(ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Request),
						typeof(ACTION_p_ucp_act_SubscriberAgreements_Agreements_ChangeTariffs_Response),
						typeof(Agreements_ChangeTariffs_Response_ACTION))
					},

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Associations]
        /// <summary>
        /// Associations
        /// </summary>
		[DocIgnore]
        public class Associations_EntityBindContainer : EntityBindContainer
        {
			public Associations_EntityBindContainer():base("Associations")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Associations_Request_SET),
					typeof(SET_p_ucp_set_Associations_Request),
					typeof(SET_p_ucp_set_Associations_Response),
					typeof(Associations_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{
					{
                    "activate",
                    new CallProcedureBindContainer(
						typeof(Associations_Activate_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Request),
						typeof(ACTION_p_ucp_act_TreeNodeActivate_Associations_Activate_Response),
						typeof(Associations_Activate_Response_ACTION))
					},
					{
                    "changename",
                    new CallProcedureBindContainer(
						typeof(Associations_ChangeName_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Request),
						typeof(ACTION_p_ucp_act_TreeNodeChangeName_Associations_ChangeName_Response),
						typeof(Associations_ChangeName_Response_ACTION))
					},
					{
                    "changeparent",
                    new CallProcedureBindContainer(
						typeof(Associations_ChangeParent_Request_ACTION),
						typeof(ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Request),
						typeof(ACTION_p_ucp_ChangeParent_Associations_ChangeParent_Response),
						typeof(Associations_ChangeParent_Response_ACTION))
					},
					{
                    "changestatus",
                    new CallProcedureBindContainer(
						typeof(Associations_ChangeStatus_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Request),
						typeof(ACTION_p_ucp_act_TreeNodeChangeStatus_Associations_ChangeStatus_Response),
						typeof(Associations_ChangeStatus_Response_ACTION))
					},
					{
                    "deactivate",
                    new CallProcedureBindContainer(
						typeof(Associations_Deactivate_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Request),
						typeof(ACTION_p_ucp_act_TreeNodeDeactivate_Associations_Deactivate_Response),
						typeof(Associations_Deactivate_Response_ACTION))
					},
					{
                    "setlabels",
                    new CallProcedureBindContainer(
						typeof(Associations_SetLabels_Request_ACTION),
						typeof(ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Request),
						typeof(ACTION_p_ucp_act_LabelApply_Associations_SetLabels_Response),
						typeof(Associations_SetLabels_Response_ACTION))
					},

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(Associations_Request_GET),
							typeof(GET_p_ucp_get_Associations_Request),
							typeof(GET_p_ucp_get_Associations_Response),
							typeof(Associations_Response_GET),
							typeof(GET_p_ucp_get_Associations_Response_OUTPUT),
							typeof(Associations_Response_GET_OUTPUT))
                    },
                    {
                        "details",
                        new CallGetProcedureBindContainer(
							typeof(Associations_Details_Request_GET),
							typeof(GET_p_ucp_get_AssociationByID_Associations_Details_Request),
							typeof(GET_p_ucp_get_AssociationByID_Associations_Details_Response),
							typeof(Associations_Details_Response_GET),
							typeof(GET_p_ucp_get_AssociationByID_Associations_Details_Response_OUTPUT),
							typeof(Associations_Details_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [AuthCodes]
        /// <summary>
        /// AuthCodes
        /// </summary>
		[DocIgnore]
        public class AuthCodes_EntityBindContainer : EntityBindContainer
        {
			public AuthCodes_EntityBindContainer():base("AuthCodes")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(AuthCodes_Request_SET),
					typeof(SET_p_ucp_set_TreeNodeAuthCodes_Request),
					typeof(SET_p_ucp_set_TreeNodeAuthCodes_Response),
					typeof(AuthCodes_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [BankAccounts]
        /// <summary>
        /// BankAccounts
        /// </summary>
		[DocIgnore]
        public class BankAccounts_EntityBindContainer : EntityBindContainer
        {
			public BankAccounts_EntityBindContainer():base("BankAccounts")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(EmptyEntityModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyEntityModel));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(BankAccounts_Request_GET),
							typeof(GET_p_ucp_get_BankAccounts_Request),
							typeof(GET_p_ucp_get_BankAccounts_Response),
							typeof(BankAccounts_Response_GET),
							typeof(GET_p_ucp_get_BankAccounts_Response_OUTPUT),
							typeof(BankAccounts_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [BankDetails]
        /// <summary>
        /// BankDetails
        /// </summary>
		[DocIgnore]
        public class BankDetails_EntityBindContainer : EntityBindContainer
        {
			public BankDetails_EntityBindContainer():base("BankDetails")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(BankDetails_Request_SET),
					typeof(SET_p_ucp_set_BankDetails_Request),
					typeof(SET_p_ucp_set_BankDetails_Response),
					typeof(BankDetails_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [BankStatements]
        /// <summary>
        /// BankStatements
        /// </summary>
		[DocIgnore]
        public class BankStatements_EntityBindContainer : EntityBindContainer
        {
			public BankStatements_EntityBindContainer():base("BankStatements")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(BankStatements_Request_SET),
					typeof(SET_p_ucp_set_BatchPayDocRecords_Request),
					typeof(SET_p_ucp_set_BatchPayDocRecords_Response),
					typeof(BankStatements_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{
					{
                    "changepaymentsstatus",
                    new CallProcedureBindContainer(
						typeof(BankStatements_ChangePaymentsStatus_Request_ACTION),
						typeof(ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Request),
						typeof(ACTION_p_ucp_act_ChangePayDocRecordStatus_BankStatements_ChangePaymentsStatus_Response),
						typeof(BankStatements_ChangePaymentsStatus_Response_ACTION))
					},
					{
                    "checknosavepayments",
                    new CallProcedureBindContainer(
						typeof(BankStatements_CheckNoSavePayments_Request_ACTION),
						typeof(ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Request),
						typeof(ACTION_p_ucp_act_CheckNoSavePayDocRecords_BankStatements_CheckNoSavePayments_Response),
						typeof(BankStatements_CheckNoSavePayments_Response_ACTION))
					},
					{
                    "clearbatch",
                    new CallProcedureBindContainer(
						typeof(BankStatements_ClearBatch_Request_ACTION),
						typeof(ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Request),
						typeof(ACTION_p_ucp_del_BatchPayDocRecords_BankStatements_ClearBatch_Response),
						typeof(BankStatements_ClearBatch_Response_ACTION))
					},

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(BankStatements_Request_GET),
							typeof(GET_p_ucp_get_BatchPayDocRecords_Request),
							typeof(GET_p_ucp_get_BatchPayDocRecords_Response),
							typeof(BankStatements_Response_GET),
							typeof(GET_p_ucp_get_BatchPayDocRecords_Response_OUTPUT),
							typeof(BankStatements_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [BankStatementTransactions]
        /// <summary>
        /// BankStatementTransactions
        /// </summary>
		[DocIgnore]
        public class BankStatementTransactions_EntityBindContainer : EntityBindContainer
        {
			public BankStatementTransactions_EntityBindContainer():base("BankStatementTransactions")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(EmptyEntityModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyEntityModel));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(BankStatementTransactions_Request_GET),
							typeof(GET_p_ucp_get_BankStatements_Request),
							typeof(GET_p_ucp_get_BankStatements_Response),
							typeof(BankStatementTransactions_Response_GET),
							typeof(GET_p_ucp_get_BankStatements_Response_OUTPUT),
							typeof(BankStatementTransactions_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [BillingTasks]
        /// <summary>
        /// BillingTasks
        /// </summary>
		[DocIgnore]
        public class BillingTasks_EntityBindContainer : EntityBindContainer
        {
			public BillingTasks_EntityBindContainer():base("BillingTasks")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(BillingTasks_Request_SET),
					typeof(SET_sp_set_BillingTasks_Request),
					typeof(SET_sp_set_BillingTasks_Response),
					typeof(BillingTasks_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [CallCredits]
        /// <summary>
        /// CallCredits
        /// </summary>
		[DocIgnore]
        public class CallCredits_EntityBindContainer : EntityBindContainer
        {
			public CallCredits_EntityBindContainer():base("CallCredits")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(CallCredits_Request_SET),
					typeof(SET_p_ucp_set_DiscountValue4Subscriber_Request),
					typeof(SET_p_ucp_set_DiscountValue4Subscriber_Response),
					typeof(CallCredits_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [CallUserGroups]
        /// <summary>
        /// CallUserGroups
        /// </summary>
		[DocIgnore]
        public class CallUserGroups_EntityBindContainer : EntityBindContainer
        {
			public CallUserGroups_EntityBindContainer():base("CallUserGroups")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(CallUserGroups_Request_SET),
					typeof(SET_p_ucp_set_CodeRegionGroups_Request),
					typeof(SET_p_ucp_set_CodeRegionGroups_Response),
					typeof(CallUserGroups_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Contracts]
        /// <summary>
        /// Contracts
        /// </summary>
		[DocIgnore]
        public class Contracts_EntityBindContainer : EntityBindContainer
        {
			public Contracts_EntityBindContainer():base("Contracts")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Contracts_Request_SET),
					typeof(SET_p_ucp_set_Contracts_Request),
					typeof(SET_p_ucp_set_Contracts_Response),
					typeof(Contracts_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [CustomerPayments]
        /// <summary>
        /// CustomerPayments
        /// </summary>
		[DocIgnore]
        public class CustomerPayments_EntityBindContainer : EntityBindContainer
        {
			public CustomerPayments_EntityBindContainer():base("CustomerPayments")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(CustomerPayments_Request_SET),
					typeof(SET_p_ucp_set_CustomerPayments_Request),
					typeof(SET_p_ucp_set_CustomerPayments_Response),
					typeof(CustomerPayments_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(CustomerPayments_Request_GET),
							typeof(GET_p_ucp_get_CustomerPayments_Request),
							typeof(GET_p_ucp_get_CustomerPayments_Response),
							typeof(CustomerPayments_Response_GET),
							typeof(GET_p_ucp_get_CustomerPayments_Response_OUTPUT),
							typeof(CustomerPayments_Response_GET_OUTPUT))
                    },
                    {
                        "allocatedpayments",
                        new CallGetProcedureBindContainer(
							typeof(CustomerPayments_AllocatedPayments_Request_GET),
							typeof(GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Request),
							typeof(GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response),
							typeof(CustomerPayments_AllocatedPayments_Response_GET),
							typeof(GET_p_ucp_get_AllocatedPayments_CustomerPayments_AllocatedPayments_Response_OUTPUT),
							typeof(CustomerPayments_AllocatedPayments_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [Customers]
        /// <summary>
        /// Customers
        /// </summary>
		[DocIgnore]
        public class Customers_EntityBindContainer : EntityBindContainer
        {
			public Customers_EntityBindContainer():base("Customers")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Customers_Request_SET),
					typeof(SET_p_ucp_set_Customers_Request),
					typeof(SET_p_ucp_set_Customers_Response),
					typeof(Customers_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{
					{
                    "activate",
                    new CallProcedureBindContainer(
						typeof(Customers_Activate_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Request),
						typeof(ACTION_p_ucp_act_TreeNodeActivate_Customers_Activate_Response),
						typeof(Customers_Activate_Response_ACTION))
					},
					{
                    "calccharges",
                    new CallProcedureBindContainer(
						typeof(Customers_CalcCharges_Request_ACTION),
						typeof(ACTION_p_ucp_set_Charges_Customers_CalcCharges_Request),
						typeof(ACTION_p_ucp_set_Charges_Customers_CalcCharges_Response),
						typeof(Customers_CalcCharges_Response_ACTION))
					},
					{
                    "changename",
                    new CallProcedureBindContainer(
						typeof(Customers_ChangeName_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Request),
						typeof(ACTION_p_ucp_act_TreeNodeChangeName_Customers_ChangeName_Response),
						typeof(Customers_ChangeName_Response_ACTION))
					},
					{
                    "changeparent",
                    new CallProcedureBindContainer(
						typeof(Customers_ChangeParent_Request_ACTION),
						typeof(ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Request),
						typeof(ACTION_p_ucp_ChangeParent_Customers_ChangeParent_Response),
						typeof(Customers_ChangeParent_Response_ACTION))
					},
					{
                    "changestatus",
                    new CallProcedureBindContainer(
						typeof(Customers_ChangeStatus_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Request),
						typeof(ACTION_p_ucp_act_TreeNodeChangeStatus_Customers_ChangeStatus_Response),
						typeof(Customers_ChangeStatus_Response_ACTION))
					},
					{
                    "copy",
                    new CallProcedureBindContainer(
						typeof(Customers_Copy_Request_ACTION),
						typeof(ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Request),
						typeof(ACTION_p_ucp_act_Customers_Sync_Customers_Copy_Response),
						typeof(Customers_Copy_Response_ACTION))
					},
					{
                    "deactivate",
                    new CallProcedureBindContainer(
						typeof(Customers_Deactivate_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Request),
						typeof(ACTION_p_ucp_act_TreeNodeDeactivate_Customers_Deactivate_Response),
						typeof(Customers_Deactivate_Response_ACTION))
					},
					{
                    "postponeinvoice",
                    new CallProcedureBindContainer(
						typeof(Customers_postponeInvoice_Request_ACTION),
						typeof(ACTION_sp_change_InvoiceTerms_Customers_postponeInvoice_Request),
						typeof(EmptyCallProcedureModel),
						typeof(EmptyEntityModel))
					},
					{
                    "setlabels",
                    new CallProcedureBindContainer(
						typeof(Customers_SetLabels_Request_ACTION),
						typeof(ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Request),
						typeof(ACTION_p_ucp_act_LabelApply_Customers_SetLabels_Response),
						typeof(Customers_SetLabels_Response_ACTION))
					},

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(Customers_Request_GET),
							typeof(GET_p_ucp_get_Customers_Request),
							typeof(GET_p_ucp_get_Customers_Response),
							typeof(Customers_Response_GET),
							typeof(GET_p_ucp_get_Customers_Response_OUTPUT),
							typeof(Customers_Response_GET_OUTPUT))
                    },
                    {
                        "customerextentions",
                        new CallGetProcedureBindContainer(
							typeof(Customers_CustomerExtentions_Request_GET),
							typeof(GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Request),
							typeof(GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response),
							typeof(Customers_CustomerExtentions_Response_GET),
							typeof(GET_p_ucp_get_CustomerExtentions_Customers_CustomerExtentions_Response_OUTPUT),
							typeof(Customers_CustomerExtentions_Response_GET_OUTPUT))
                    },
                    {
                        "details",
                        new CallGetProcedureBindContainer(
							typeof(Customers_Details_Request_GET),
							typeof(GET_p_ucp_get_CustomerByID_Customers_Details_Request),
							typeof(GET_p_ucp_get_CustomerByID_Customers_Details_Response),
							typeof(Customers_Details_Response_GET),
							typeof(GET_p_ucp_get_CustomerByID_Customers_Details_Response_OUTPUT),
							typeof(Customers_Details_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [CustomerTypes]
        /// <summary>
        /// CustomerTypes
        /// </summary>
		[DocIgnore]
        public class CustomerTypes_EntityBindContainer : EntityBindContainer
        {
			public CustomerTypes_EntityBindContainer():base("CustomerTypes")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(EmptyEntityModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyEntityModel));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(CustomerTypes_Request_GET),
							typeof(GET_p_ucp_get_CustomerTypes_Request),
							typeof(GET_p_ucp_get_CustomerTypes_Response),
							typeof(CustomerTypes_Response_GET),
							typeof(GET_p_ucp_get_CustomerTypes_Response_OUTPUT),
							typeof(CustomerTypes_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [Discounts]
        /// <summary>
        /// Discounts
        /// </summary>
		[DocIgnore]
        public class Discounts_EntityBindContainer : EntityBindContainer
        {
			public Discounts_EntityBindContainer():base("Discounts")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Discounts_Request_SET),
					typeof(SET_p_ucp_set_DiscountAbonentBind_Request),
					typeof(SET_p_ucp_set_DiscountAbonentBind_Response),
					typeof(Discounts_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Environment]
        /// <summary>
        /// Environment
        /// </summary>
		[DocIgnore]
        public class Environment_EntityBindContainer : EntityBindContainer
        {
			public Environment_EntityBindContainer():base("Environment")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(EmptyEntityModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyEntityModel));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(Environment_Request_GET),
							typeof(GET_p_ucp_get_Variables_Request),
							typeof(GET_p_ucp_get_Variables_Response),
							typeof(Environment_Response_GET),
							typeof(GET_p_ucp_get_Variables_Response_OUTPUT),
							typeof(Environment_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [Extentions]
        /// <summary>
        /// Extentions
        /// </summary>
		[DocIgnore]
        public class Extentions_EntityBindContainer : EntityBindContainer
        {
			public Extentions_EntityBindContainer():base("Extentions")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Extentions_Request_SET),
					typeof(SET_p_ucp_set_SubscriberExtentions_Request),
					typeof(SET_p_ucp_set_SubscriberExtentions_Response),
					typeof(Extentions_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Gains]
        /// <summary>
        /// Gains
        /// </summary>
		[DocIgnore]
        public class Gains_EntityBindContainer : EntityBindContainer
        {
			public Gains_EntityBindContainer():base("Gains")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Gains_Request_SET),
					typeof(SET_p_ucp_set_AccountCredits_Request),
					typeof(SET_p_ucp_set_AccountCredits_Response),
					typeof(Gains_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Memberships]
        /// <summary>
        /// Memberships
        /// </summary>
		[DocIgnore]
        public class Memberships_EntityBindContainer : EntityBindContainer
        {
			public Memberships_EntityBindContainer():base("Memberships")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Memberships_Request_SET),
					typeof(SET_p_ucp_set_CodeRegions_Memberships_Request),
					typeof(SET_p_ucp_set_CodeRegions_Memberships_Response),
					typeof(Memberships_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Networks]
        /// <summary>
        /// Networks
        /// </summary>
		[DocIgnore]
        public class Networks_EntityBindContainer : EntityBindContainer
        {
			public Networks_EntityBindContainer():base("Networks")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(EmptyEntityModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyEntityModel));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{
					{
                    "clearlogins",
                    new CallProcedureBindContainer(
						typeof(Networks_ClearLogins_Request_ACTION),
						typeof(ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Request),
						typeof(ACTION_p_ucp_act_ClearTreeNodeLogins_Networks_ClearLogins_Response),
						typeof(Networks_ClearLogins_Response_ACTION))
					},

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(Networks_Request_GET),
							typeof(GET_p_ucp_get_Networks_Request),
							typeof(GET_p_ucp_get_Networks_Response),
							typeof(Networks_Response_GET),
							typeof(GET_p_ucp_get_Networks_Response_OUTPUT),
							typeof(Networks_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [PaymentDocuments]
        /// <summary>
        /// PaymentDocuments
        /// </summary>
		[DocIgnore]
        public class PaymentDocuments_EntityBindContainer : EntityBindContainer
        {
			public PaymentDocuments_EntityBindContainer():base("PaymentDocuments")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(PaymentDocuments_Request_SET),
					typeof(SET_p_ucp_set_PayDocs_Request),
					typeof(SET_p_ucp_set_PayDocs_Response),
					typeof(PaymentDocuments_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [PaymentRegistry]
        /// <summary>
        /// PaymentRegistry
        /// </summary>
		[DocIgnore]
        public class PaymentRegistry_EntityBindContainer : EntityBindContainer
        {
			public PaymentRegistry_EntityBindContainer():base("PaymentRegistry")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(PaymentRegistry_Request_SET),
					typeof(SET_p_ucp_set_PayReestres_Request),
					typeof(SET_p_ucp_set_PayReestres_Response),
					typeof(PaymentRegistry_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(PaymentRegistry_Request_GET),
							typeof(GET_p_ucp_get_PayReestres_Request),
							typeof(GET_p_ucp_get_PayReestres_Response),
							typeof(PaymentRegistry_Response_GET),
							typeof(GET_p_ucp_get_PayReestres_Response_OUTPUT),
							typeof(PaymentRegistry_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [PhoneNumbers]
        /// <summary>
        /// PhoneNumbers
        /// </summary>
		[DocIgnore]
        public class PhoneNumbers_EntityBindContainer : EntityBindContainer
        {
			public PhoneNumbers_EntityBindContainer():base("PhoneNumbers")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(PhoneNumbers_Request_SET),
					typeof(SET_p_ucp_set_CodeRegions_PhoneNumbers_Request),
					typeof(SET_p_ucp_set_CodeRegions_PhoneNumbers_Response),
					typeof(PhoneNumbers_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [PortabilityNumbers]
        /// <summary>
        /// PortabilityNumbers
        /// </summary>
		[DocIgnore]
        public class PortabilityNumbers_EntityBindContainer : EntityBindContainer
        {
			public PortabilityNumbers_EntityBindContainer():base("PortabilityNumbers")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(PortabilityNumbers_Request_SET),
					typeof(SET_p_ucp_set_CodeRegions_Request),
					typeof(SET_p_ucp_set_CodeRegions_Response),
					typeof(PortabilityNumbers_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Profiles]
        /// <summary>
        /// Profiles
        /// </summary>
		[DocIgnore]
        public class Profiles_EntityBindContainer : EntityBindContainer
        {
			public Profiles_EntityBindContainer():base("Profiles")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Profiles_Request_SET),
					typeof(SET_p_ucp_set_Profiles_Request),
					typeof(SET_p_ucp_set_Profiles_Response),
					typeof(Profiles_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [RatingData]
        /// <summary>
        /// RatingData
        /// </summary>
		[DocIgnore]
        public class RatingData_EntityBindContainer : EntityBindContainer
        {
			public RatingData_EntityBindContainer():base("RatingData")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(RatingData_Request_SET),
					typeof(SET_p_ucp_set_ServiceReservations_Request),
					typeof(SET_p_ucp_set_ServiceReservations_Response),
					typeof(RatingData_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{
					{
                    "release",
                    new CallProcedureBindContainer(
						typeof(RatingData_Release_Request_ACTION),
						typeof(ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Request),
						typeof(ACTION_p_ucp_set_ServiceReservations_RatingData_Release_Response),
						typeof(RatingData_Release_Response_ACTION))
					},
					{
                    "update",
                    new CallProcedureBindContainer(
						typeof(RatingData_Update_Request_ACTION),
						typeof(ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Request),
						typeof(ACTION_p_ucp_set_ServiceReservations_RatingData_Update_Response),
						typeof(RatingData_Update_Response_ACTION))
					},

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [ServiceSubscriptions]
        /// <summary>
        /// ServiceSubscriptions
        /// </summary>
		[DocIgnore]
        public class ServiceSubscriptions_EntityBindContainer : EntityBindContainer
        {
			public ServiceSubscriptions_EntityBindContainer():base("ServiceSubscriptions")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(ServiceSubscriptions_Request_SET),
					typeof(SET_p_ucp_set_ServiceSubscriptions_Request),
					typeof(SET_p_ucp_set_ServiceSubscriptions_Response),
					typeof(ServiceSubscriptions_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [Subscribers]
        /// <summary>
        /// Subscribers
        /// </summary>
		[DocIgnore]
        public class Subscribers_EntityBindContainer : EntityBindContainer
        {
			public Subscribers_EntityBindContainer():base("Subscribers")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Subscribers_Request_SET),
					typeof(SET_p_ucp_set_Subscribers_Request),
					typeof(SET_p_ucp_set_Subscribers_Response),
					typeof(Subscribers_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{
					{
                    "activate",
                    new CallProcedureBindContainer(
						typeof(Subscribers_Activate_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Request),
						typeof(ACTION_p_ucp_act_TreeNodeActivate_Subscribers_Activate_Response),
						typeof(Subscribers_Activate_Response_ACTION))
					},
					{
                    "calccharges",
                    new CallProcedureBindContainer(
						typeof(Subscribers_CalcCharges_Request_ACTION),
						typeof(ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Request),
						typeof(ACTION_p_ucp_set_Charges_Subscribers_CalcCharges_Response),
						typeof(Subscribers_CalcCharges_Response_ACTION))
					},
					{
                    "changeaccount",
                    new CallProcedureBindContainer(
						typeof(Subscribers_ChangeAccount_Request_ACTION),
						typeof(ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Request),
						typeof(ACTION_sp_change_Accounts_Subscribers_ChangeAccount_Response),
						typeof(Subscribers_ChangeAccount_Response_ACTION))
					},
					{
                    "changename",
                    new CallProcedureBindContainer(
						typeof(Subscribers_ChangeName_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Request),
						typeof(ACTION_p_ucp_act_TreeNodeChangeName_Subscribers_ChangeName_Response),
						typeof(Subscribers_ChangeName_Response_ACTION))
					},
					{
                    "changestatus",
                    new CallProcedureBindContainer(
						typeof(Subscribers_ChangeStatus_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Request),
						typeof(ACTION_p_ucp_act_TreeNodeChangeStatus_Subscribers_ChangeStatus_Response),
						typeof(Subscribers_ChangeStatus_Response_ACTION))
					},
					{
                    "deactivate",
                    new CallProcedureBindContainer(
						typeof(Subscribers_Deactivate_Request_ACTION),
						typeof(ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Request),
						typeof(ACTION_p_ucp_act_TreeNodeDeactivate_Subscribers_Deactivate_Response),
						typeof(Subscribers_Deactivate_Response_ACTION))
					},
					{
                    "recharge",
                    new CallProcedureBindContainer(
						typeof(Subscribers_Recharge_Request_ACTION),
						typeof(ACTION_p_ucp_set_Charges_Subscribers_Recharge_Request),
						typeof(ACTION_p_ucp_set_Charges_Subscribers_Recharge_Response),
						typeof(Subscribers_Recharge_Response_ACTION))
					},
					{
                    "setlabels",
                    new CallProcedureBindContainer(
						typeof(Subscribers_SetLabels_Request_ACTION),
						typeof(ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Request),
						typeof(ACTION_p_ucp_act_LabelApply_Subscribers_SetLabels_Response),
						typeof(Subscribers_SetLabels_Response_ACTION))
					},

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(Subscribers_Request_GET),
							typeof(GET_p_ucp_get_Subscribers_Request),
							typeof(GET_p_ucp_get_Subscribers_Response),
							typeof(Subscribers_Response_GET),
							typeof(GET_p_ucp_get_Subscribers_Response_OUTPUT),
							typeof(Subscribers_Response_GET_OUTPUT))
                    },
                    {
                        "details",
                        new CallGetProcedureBindContainer(
							typeof(Subscribers_Details_Request_GET),
							typeof(GET_p_ucp_get_SubscriberByID_Subscribers_Details_Request),
							typeof(GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response),
							typeof(Subscribers_Details_Response_GET),
							typeof(GET_p_ucp_get_SubscriberByID_Subscribers_Details_Response_OUTPUT),
							typeof(Subscribers_Details_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [Tasks]
        /// <summary>
        /// Tasks
        /// </summary>
		[DocIgnore]
        public class Tasks_EntityBindContainer : EntityBindContainer
        {
			public Tasks_EntityBindContainer():base("Tasks")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(Tasks_Request_SET),
					typeof(SET_p_ucp_set_ServiceTask_Request),
					typeof(SET_p_ucp_set_ServiceTask_Response),
					typeof(Tasks_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#region [TemplateSubscriptions]
        /// <summary>
        /// TemplateSubscriptions
        /// </summary>
		[DocIgnore]
        public class TemplateSubscriptions_EntityBindContainer : EntityBindContainer
        {
			public TemplateSubscriptions_EntityBindContainer():base("TemplateSubscriptions")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(TemplateSubscriptions_Request_SET),
					typeof(SET_p_ucp_set_AgreementTemplates_Request),
					typeof(SET_p_ucp_set_AgreementTemplates_Response),
					typeof(TemplateSubscriptions_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(TemplateSubscriptions_Request_GET),
							typeof(GET_p_ucp_get_TemplateSubscriptions_Request),
							typeof(GET_p_ucp_get_TemplateSubscriptions_Response),
							typeof(TemplateSubscriptions_Response_GET),
							typeof(GET_p_ucp_get_TemplateSubscriptions_Response_OUTPUT),
							typeof(TemplateSubscriptions_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [TreeNodeHistory]
        /// <summary>
        /// TreeNodeHistory
        /// </summary>
		[DocIgnore]
        public class TreeNodeHistory_EntityBindContainer : EntityBindContainer
        {
			public TreeNodeHistory_EntityBindContainer():base("TreeNodeHistory")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(EmptyEntityModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyCallProcedureModel),
					typeof(EmptyEntityModel));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                    {
                        "default",
                        new CallGetProcedureBindContainer(
							typeof(TreeNodeHistory_Request_GET),
							typeof(GET_p_ucp_get_TreeNodeHistory_Request),
							typeof(GET_p_ucp_get_TreeNodeHistory_Response),
							typeof(TreeNodeHistory_Response_GET),
							typeof(GET_p_ucp_get_TreeNodeHistory_Response_OUTPUT),
							typeof(TreeNodeHistory_Response_GET_OUTPUT))
                    },
                };
}
		}
#endregion
#region [TreeNodeProperties]
        /// <summary>
        /// TreeNodeProperties
        /// </summary>
		[DocIgnore]
        public class TreeNodeProperties_EntityBindContainer : EntityBindContainer
        {
			public TreeNodeProperties_EntityBindContainer():base("TreeNodeProperties")
			{
				SetBindContainer = new CallProcedureBindContainer(typeof(TreeNodeProperties_Request_SET),
					typeof(SET_p_ucp_set_TreeNodeProperty_Request),
					typeof(SET_p_ucp_set_TreeNodeProperty_Response),
					typeof(TreeNodeProperties_Response_SET));
				ActionBindContainers = new Dictionary<string, CallProcedureBindContainer>()
				{

				};
				GetViewBindContainers = new Dictionary<string, CallGetProcedureBindContainer>()
                {
                };
}
		}
#endregion
#endregion
    [DocIgnore]
	public static class EntityService
	{
		private static Dictionary<string, EntityBindContainer> binders =
			new Dictionary<string, EntityBindContainer>()
			{
				{"accounts", EntityBinders.Accounts},
				{"accounttaxes", EntityBinders.AccountTaxes},
				{"addresses", EntityBinders.Addresses},
				{"adjustments", EntityBinders.Adjustments},
				{"agreements", EntityBinders.Agreements},
				{"associations", EntityBinders.Associations},
				{"authcodes", EntityBinders.AuthCodes},
				{"bankaccounts", EntityBinders.BankAccounts},
				{"bankdetails", EntityBinders.BankDetails},
				{"bankstatements", EntityBinders.BankStatements},
				{"bankstatementtransactions", EntityBinders.BankStatementTransactions},
				{"billingtasks", EntityBinders.BillingTasks},
				{"callcredits", EntityBinders.CallCredits},
				{"callusergroups", EntityBinders.CallUserGroups},
				{"contracts", EntityBinders.Contracts},
				{"customerpayments", EntityBinders.CustomerPayments},
				{"customers", EntityBinders.Customers},
				{"customertypes", EntityBinders.CustomerTypes},
				{"discounts", EntityBinders.Discounts},
				{"environment", EntityBinders.Environment},
				{"extentions", EntityBinders.Extentions},
				{"gains", EntityBinders.Gains},
				{"memberships", EntityBinders.Memberships},
				{"networks", EntityBinders.Networks},
				{"paymentdocuments", EntityBinders.PaymentDocuments},
				{"paymentregistry", EntityBinders.PaymentRegistry},
				{"phonenumbers", EntityBinders.PhoneNumbers},
				{"portabilitynumbers", EntityBinders.PortabilityNumbers},
				{"profiles", EntityBinders.Profiles},
				{"ratingdata", EntityBinders.RatingData},
				{"servicesubscriptions", EntityBinders.ServiceSubscriptions},
				{"subscribers", EntityBinders.Subscribers},
				{"tasks", EntityBinders.Tasks},
				{"templatesubscriptions", EntityBinders.TemplateSubscriptions},
				{"treenodehistory", EntityBinders.TreeNodeHistory},
				{"treenodeproperties", EntityBinders.TreeNodeProperties},
			};

		public static Dictionary<string, EntityBindContainer> BindersDictionary
		{
			get
			{
				return binders;
			}
		}
	}
}

