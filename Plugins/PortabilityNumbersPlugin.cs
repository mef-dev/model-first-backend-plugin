using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use PortabilityNumbersRequest
/// <see cref="Bss.Entities.PortabilityNumbersRequest"/>
/// <seealso cref="Bss.Entities.PortabilityNumbers_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("portabilitynumbers", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "portabilitynumbers")]
 [ExportMetadata("EntityName", "portabilitynumbers")]
 public class PortabilityNumbersPlugin : EntityPlugin<PortabilityNumbersRequest,
        SET_p_ucp_set_CodeRegions_Request,
        SET_p_ucp_set_CodeRegions_Response,
        PortabilityNumbers_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}