using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use AgreementsRequest
/// <see cref="Bss.Entities.AgreementsRequest"/>
/// <seealso cref="Bss.Entities.Agreements_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("agreements", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "agreements")]
 [ExportMetadata("EntityName", "agreements")]
 [ExportMetadata("Actions", new[] {"ChangeTariffs"})]
 public class AgreementsPlugin : EntityPlugin<AgreementsRequest,
        SET_p_ucp_set_SubscriberAgreements_Request,
        SET_p_ucp_set_SubscriberAgreements_Response,
        Agreements_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}