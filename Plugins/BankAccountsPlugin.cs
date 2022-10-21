using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use EmptyEntityModel
/// <see cref="Bss.Entities.EmptyEntityModel"/>
/// <seealso cref="Bss.Entities.EmptyEntityModel"/>
/// </summary>
    [DocIgnore]
 [Export("bankaccounts", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "bankaccounts")]
 [ExportMetadata("EntityName", "bankaccounts")]
 public class BankAccountsPlugin : EntityPlugin<EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        BankAccounts_Request_GET,
        GET_p_ucp_get_BankAccounts_Request,
        GET_p_ucp_get_BankAccounts_Response,
        BankAccounts_Response_GET,
        GET_p_ucp_get_BankAccounts_Response_OUTPUT,
        BankAccounts_Response_GET_OUTPUT>
        {
               }
}