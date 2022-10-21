using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use RatingDataRequest
/// <see cref="Bss.Entities.RatingDataRequest"/>
/// <seealso cref="Bss.Entities.RatingData_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("ratingdata", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "ratingdata")]
 [ExportMetadata("EntityName", "ratingdata")]
 [ExportMetadata("Actions", new[] {"Release","Update"})]
 public class RatingDataPlugin : EntityPlugin<RatingDataRequest,
        SET_p_ucp_set_ServiceReservations_Request,
        SET_p_ucp_set_ServiceReservations_Response,
        RatingData_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}