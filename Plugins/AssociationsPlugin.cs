using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use AssociationsRequest
/// <see cref="Bss.Entities.AssociationsRequest"/>
/// <seealso cref="Bss.Entities.Associations_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("associations", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "associations")]
 [ExportMetadata("EntityName", "associations")]
 [ExportMetadata("Actions", new[] {"Activate","ChangeName","ChangeParent","ChangeStatus","Deactivate","SetLabels"})]
 [ExportMetadata("Views", new[] {"Details"})]
 public class AssociationsPlugin : EntityPlugin<AssociationsRequest,
        SET_p_ucp_set_Associations_Request,
        SET_p_ucp_set_Associations_Response,
        Associations_Response_SET,
        Associations_Request_GET,
        GET_p_ucp_get_Associations_Request,
        GET_p_ucp_get_Associations_Response,
        Associations_Response_GET,
        GET_p_ucp_get_Associations_Response_OUTPUT,
        Associations_Response_GET_OUTPUT>
        {
               }
}