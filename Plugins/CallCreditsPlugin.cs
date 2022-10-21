using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use CallCreditsRequest
/// <see cref="Bss.Entities.CallCreditsRequest"/>
/// <seealso cref="Bss.Entities.CallCredits_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("callcredits", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "callcredits")]
 [ExportMetadata("EntityName", "callcredits")]
 public class CallCreditsPlugin : EntityPlugin<CallCreditsRequest,
        SET_p_ucp_set_DiscountValue4Subscriber_Request,
        SET_p_ucp_set_DiscountValue4Subscriber_Response,
        CallCredits_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}