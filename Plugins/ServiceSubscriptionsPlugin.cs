using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use ServiceSubscriptionsRequest
/// <see cref="Bss.Entities.ServiceSubscriptionsRequest"/>
/// <seealso cref="Bss.Entities.ServiceSubscriptions_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("servicesubscriptions", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "servicesubscriptions")]
 [ExportMetadata("EntityName", "servicesubscriptions")]
 public class ServiceSubscriptionsPlugin : EntityPlugin<ServiceSubscriptionsRequest,
        SET_p_ucp_set_ServiceSubscriptions_Request,
        SET_p_ucp_set_ServiceSubscriptions_Response,
        ServiceSubscriptions_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}