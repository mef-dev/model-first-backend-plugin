using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use EmptyEntityModel
/// <see cref="Bss.Entities.EmptyEntityModel"/>
/// <seealso cref="Bss.Entities.EmptyEntityModel"/>
/// </summary>
    [DocIgnore]
 [Export("customertypes", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "customertypes")]
 [ExportMetadata("EntityName", "customertypes")]
 public class CustomerTypesPlugin : EntityPlugin<EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        CustomerTypes_Request_GET,
        GET_p_ucp_get_CustomerTypes_Request,
        GET_p_ucp_get_CustomerTypes_Response,
        CustomerTypes_Response_GET,
        GET_p_ucp_get_CustomerTypes_Response_OUTPUT,
        CustomerTypes_Response_GET_OUTPUT>
        {
               }
}