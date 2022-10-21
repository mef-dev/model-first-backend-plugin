using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use AuthCodesRequest
/// <see cref="Bss.Entities.AuthCodesRequest"/>
/// <seealso cref="Bss.Entities.AuthCodes_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("authcodes", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "authcodes")]
 [ExportMetadata("EntityName", "authcodes")]
 public class AuthCodesPlugin : EntityPlugin<AuthCodesRequest,
        SET_p_ucp_set_TreeNodeAuthCodes_Request,
        SET_p_ucp_set_TreeNodeAuthCodes_Response,
        AuthCodes_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}