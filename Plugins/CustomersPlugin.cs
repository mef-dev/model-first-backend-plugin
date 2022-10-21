using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use CustomersRequest
/// <see cref="Bss.Entities.CustomersRequest"/>
/// <seealso cref="Bss.Entities.Customers_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("customers", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "customers")]
 [ExportMetadata("EntityName", "customers")]
 [ExportMetadata("Actions", new[] {"Activate","CalcCharges","ChangeName","ChangeParent","ChangeStatus","Copy","Deactivate","postponeInvoice","SetLabels"})]
 [ExportMetadata("Views", new[] {"CustomerExtentions","Details"})]
 public class CustomersPlugin : EntityPlugin<CustomersRequest,
        SET_p_ucp_set_Customers_Request,
        SET_p_ucp_set_Customers_Response,
        Customers_Response_SET,
        Customers_Request_GET,
        GET_p_ucp_get_Customers_Request,
        GET_p_ucp_get_Customers_Response,
        Customers_Response_GET,
        GET_p_ucp_get_Customers_Response_OUTPUT,
        Customers_Response_GET_OUTPUT>
        {
               }
}