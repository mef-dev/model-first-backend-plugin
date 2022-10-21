using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use CustomerPaymentsRequest
/// <see cref="Bss.Entities.CustomerPaymentsRequest"/>
/// <seealso cref="Bss.Entities.CustomerPayments_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("customerpayments", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "customerpayments")]
 [ExportMetadata("EntityName", "customerpayments")]
 [ExportMetadata("Views", new[] {"AllocatedPayments"})]
 public class CustomerPaymentsPlugin : EntityPlugin<CustomerPaymentsRequest,
        SET_p_ucp_set_CustomerPayments_Request,
        SET_p_ucp_set_CustomerPayments_Response,
        CustomerPayments_Response_SET,
        CustomerPayments_Request_GET,
        GET_p_ucp_get_CustomerPayments_Request,
        GET_p_ucp_get_CustomerPayments_Response,
        CustomerPayments_Response_GET,
        GET_p_ucp_get_CustomerPayments_Response_OUTPUT,
        CustomerPayments_Response_GET_OUTPUT>
        {
               }
}