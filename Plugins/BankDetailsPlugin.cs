using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use BankDetailsRequest
/// <see cref="Bss.Entities.BankDetailsRequest"/>
/// <seealso cref="Bss.Entities.BankDetails_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("bankdetails", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "bankdetails")]
 [ExportMetadata("EntityName", "bankdetails")]
 public class BankDetailsPlugin : EntityPlugin<BankDetailsRequest,
        SET_p_ucp_set_BankDetails_Request,
        SET_p_ucp_set_BankDetails_Response,
        BankDetails_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}