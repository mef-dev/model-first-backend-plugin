using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use AddressesRequest
/// <see cref="Bss.Entities.AddressesRequest"/>
/// <seealso cref="Bss.Entities.Addresses_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("addresses", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "addresses")]
 [ExportMetadata("EntityName", "addresses")]
 [ExportMetadata("Actions", new[] {"Sync"})]
 public class AddressesPlugin : EntityPlugin<AddressesRequest,
        SET_p_ucp_set_TreeNodeAddresses_Request,
        SET_p_ucp_set_TreeNodeAddresses_Response,
        Addresses_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}