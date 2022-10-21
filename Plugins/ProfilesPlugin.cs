using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use ProfilesRequest
/// <see cref="Bss.Entities.ProfilesRequest"/>
/// <seealso cref="Bss.Entities.Profiles_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("profiles", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "profiles")]
 [ExportMetadata("EntityName", "profiles")]
 public class ProfilesPlugin : EntityPlugin<ProfilesRequest,
        SET_p_ucp_set_Profiles_Request,
        SET_p_ucp_set_Profiles_Response,
        Profiles_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}