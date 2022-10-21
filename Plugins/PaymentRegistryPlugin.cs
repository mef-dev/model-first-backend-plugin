using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use PaymentRegistryRequest
/// <see cref="Bss.Entities.PaymentRegistryRequest"/>
/// <seealso cref="Bss.Entities.PaymentRegistry_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("paymentregistry", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "paymentregistry")]
 [ExportMetadata("EntityName", "paymentregistry")]
 public class PaymentRegistryPlugin : EntityPlugin<PaymentRegistryRequest,
        SET_p_ucp_set_PayReestres_Request,
        SET_p_ucp_set_PayReestres_Response,
        PaymentRegistry_Response_SET,
        PaymentRegistry_Request_GET,
        GET_p_ucp_get_PayReestres_Request,
        GET_p_ucp_get_PayReestres_Response,
        PaymentRegistry_Response_GET,
        GET_p_ucp_get_PayReestres_Response_OUTPUT,
        PaymentRegistry_Response_GET_OUTPUT>
        {
               }
}