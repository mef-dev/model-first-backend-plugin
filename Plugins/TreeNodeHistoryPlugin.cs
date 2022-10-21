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
 [Export("treenodehistory", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "treenodehistory")]
 [ExportMetadata("EntityName", "treenodehistory")]
 public class TreeNodeHistoryPlugin : EntityPlugin<EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        TreeNodeHistory_Request_GET,
        GET_p_ucp_get_TreeNodeHistory_Request,
        GET_p_ucp_get_TreeNodeHistory_Response,
        TreeNodeHistory_Response_GET,
        GET_p_ucp_get_TreeNodeHistory_Response_OUTPUT,
        TreeNodeHistory_Response_GET_OUTPUT>
        {
               }
}