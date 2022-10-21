using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use TreeNodePropertiesRequest
/// <see cref="Bss.Entities.TreeNodePropertiesRequest"/>
/// <seealso cref="Bss.Entities.TreeNodeProperties_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("treenodeproperties", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "treenodeproperties")]
 [ExportMetadata("EntityName", "treenodeproperties")]
 public class TreeNodePropertiesPlugin : EntityPlugin<TreeNodePropertiesRequest,
        SET_p_ucp_set_TreeNodeProperty_Request,
        SET_p_ucp_set_TreeNodeProperty_Response,
        TreeNodeProperties_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}