using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use SubscribersRequest
/// <see cref="Bss.Entities.SubscribersRequest"/>
/// <seealso cref="Bss.Entities.Subscribers_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("subscribers", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "subscribers")]
 [ExportMetadata("EntityName", "subscribers")]
 [ExportMetadata("Actions", new[] {"Activate","CalcCharges","ChangeAccount","ChangeName","ChangeStatus","Deactivate","Recharge","SetLabels"})]
 [ExportMetadata("Views", new[] {"Details"})]
 public class SubscribersPlugin : EntityPlugin<SubscribersRequest,
        SET_p_ucp_set_Subscribers_Request,
        SET_p_ucp_set_Subscribers_Response,
        Subscribers_Response_SET,
        Subscribers_Request_GET,
        GET_p_ucp_get_Subscribers_Request,
        GET_p_ucp_get_Subscribers_Response,
        Subscribers_Response_GET,
        GET_p_ucp_get_Subscribers_Response_OUTPUT,
        Subscribers_Response_GET_OUTPUT>
        {
               }
}