using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use TemplateSubscriptionsRequest
/// <see cref="Bss.Entities.TemplateSubscriptionsRequest"/>
/// <seealso cref="Bss.Entities.TemplateSubscriptions_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("templatesubscriptions", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "templatesubscriptions")]
 [ExportMetadata("EntityName", "templatesubscriptions")]
 public class TemplateSubscriptionsPlugin : EntityPlugin<TemplateSubscriptionsRequest,
        SET_p_ucp_set_AgreementTemplates_Request,
        SET_p_ucp_set_AgreementTemplates_Response,
        TemplateSubscriptions_Response_SET,
        TemplateSubscriptions_Request_GET,
        GET_p_ucp_get_TemplateSubscriptions_Request,
        GET_p_ucp_get_TemplateSubscriptions_Response,
        TemplateSubscriptions_Response_GET,
        GET_p_ucp_get_TemplateSubscriptions_Response_OUTPUT,
        TemplateSubscriptions_Response_GET_OUTPUT>
        {
               }
}