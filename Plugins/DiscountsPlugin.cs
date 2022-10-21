using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use DiscountsRequest
/// <see cref="Bss.Entities.DiscountsRequest"/>
/// <seealso cref="Bss.Entities.Discounts_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("discounts", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "discounts")]
 [ExportMetadata("EntityName", "discounts")]
 public class DiscountsPlugin : EntityPlugin<DiscountsRequest,
        SET_p_ucp_set_DiscountAbonentBind_Request,
        SET_p_ucp_set_DiscountAbonentBind_Response,
        Discounts_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}