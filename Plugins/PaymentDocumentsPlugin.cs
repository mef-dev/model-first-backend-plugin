using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use PaymentDocumentsRequest
/// <see cref="Bss.Entities.PaymentDocumentsRequest"/>
/// <seealso cref="Bss.Entities.PaymentDocuments_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("paymentdocuments", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "paymentdocuments")]
 [ExportMetadata("EntityName", "paymentdocuments")]
 public class PaymentDocumentsPlugin : EntityPlugin<PaymentDocumentsRequest,
        SET_p_ucp_set_PayDocs_Request,
        SET_p_ucp_set_PayDocs_Response,
        PaymentDocuments_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}