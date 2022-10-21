using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use AccountsRequest
/// <see cref="Bss.Entities.AccountsRequest"/>
/// <seealso cref="Bss.Entities.Accounts_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("accounts", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "accounts")]
 [ExportMetadata("EntityName", "accounts")]
 [ExportMetadata("Views", new[] {"CustomerAccounts"})]
 public class AccountsPlugin : EntityPlugin<AccountsRequest,
        SET_p_ucp_set_Accounts_Request,
        SET_p_ucp_set_Accounts_Response,
        Accounts_Response_SET,
        Accounts_Request_GET,
        GET_p_ucp_get_Accounts_Request,
        GET_p_ucp_get_Accounts_Response,
        Accounts_Response_GET,
        GET_p_ucp_get_Accounts_Response_OUTPUT,
        Accounts_Response_GET_OUTPUT>
        {
               }
}