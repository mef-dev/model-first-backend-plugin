using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use AccountTaxesRequest
/// <see cref="Bss.Entities.AccountTaxesRequest"/>
/// <seealso cref="Bss.Entities.AccountTaxes_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("accounttaxes", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "accounttaxes")]
 [ExportMetadata("EntityName", "accounttaxes")]
 public class AccountTaxesPlugin : EntityPlugin<AccountTaxesRequest,
        SET_p_ucp_set_AccountTaxes_Request,
        SET_p_ucp_set_AccountTaxes_Response,
        AccountTaxes_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}