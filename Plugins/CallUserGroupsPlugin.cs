using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use CallUserGroupsRequest
/// <see cref="Bss.Entities.CallUserGroupsRequest"/>
/// <seealso cref="Bss.Entities.CallUserGroups_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("callusergroups", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "callusergroups")]
 [ExportMetadata("EntityName", "callusergroups")]
 public class CallUserGroupsPlugin : EntityPlugin<CallUserGroupsRequest,
        SET_p_ucp_set_CodeRegionGroups_Request,
        SET_p_ucp_set_CodeRegionGroups_Response,
        CallUserGroups_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}