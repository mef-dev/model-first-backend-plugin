using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use MembershipsRequest
/// <see cref="Bss.Entities.MembershipsRequest"/>
/// <seealso cref="Bss.Entities.Memberships_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("memberships", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "memberships")]
 [ExportMetadata("EntityName", "memberships")]
 public class MembershipsPlugin : EntityPlugin<MembershipsRequest,
        SET_p_ucp_set_CodeRegions_Memberships_Request,
        SET_p_ucp_set_CodeRegions_Memberships_Response,
        Memberships_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}