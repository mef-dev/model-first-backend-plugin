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
 [Export("networks", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "networks")]
 [ExportMetadata("EntityName", "networks")]
 [ExportMetadata("Actions", new[] {"ClearLogins"})]
 public class NetworksPlugin : EntityPlugin<EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        Networks_Request_GET,
        GET_p_ucp_get_Networks_Request,
        GET_p_ucp_get_Networks_Response,
        Networks_Response_GET,
        GET_p_ucp_get_Networks_Response_OUTPUT,
        Networks_Response_GET_OUTPUT>
        {
               }
}