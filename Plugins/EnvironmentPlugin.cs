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
 [Export("environment", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "environment")]
 [ExportMetadata("EntityName", "environment")]
 public class EnvironmentPlugin : EntityPlugin<EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        Environment_Request_GET,
        GET_p_ucp_get_Variables_Request,
        GET_p_ucp_get_Variables_Response,
        Environment_Response_GET,
        GET_p_ucp_get_Variables_Response_OUTPUT,
        Environment_Response_GET_OUTPUT>
        {
               }
}