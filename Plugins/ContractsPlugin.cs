using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use ContractsRequest
/// <see cref="Bss.Entities.ContractsRequest"/>
/// <seealso cref="Bss.Entities.Contracts_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("contracts", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "contracts")]
 [ExportMetadata("EntityName", "contracts")]
 public class ContractsPlugin : EntityPlugin<ContractsRequest,
        SET_p_ucp_set_Contracts_Request,
        SET_p_ucp_set_Contracts_Response,
        Contracts_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}