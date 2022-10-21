using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use GainsRequest
/// <see cref="Bss.Entities.GainsRequest"/>
/// <seealso cref="Bss.Entities.Gains_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("gains", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "gains")]
 [ExportMetadata("EntityName", "gains")]
 public class GainsPlugin : EntityPlugin<GainsRequest,
        SET_p_ucp_set_AccountCredits_Request,
        SET_p_ucp_set_AccountCredits_Response,
        Gains_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}