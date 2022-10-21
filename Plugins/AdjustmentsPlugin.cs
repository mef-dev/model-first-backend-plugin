using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use AdjustmentsRequest
/// <see cref="Bss.Entities.AdjustmentsRequest"/>
/// <seealso cref="Bss.Entities.Adjustments_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("adjustments", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "adjustments")]
 [ExportMetadata("EntityName", "adjustments")]
 public class AdjustmentsPlugin : EntityPlugin<AdjustmentsRequest,
        SET_p_ucp_set_AccountAdjustments_Request,
        SET_p_ucp_set_AccountAdjustments_Response,
        Adjustments_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}