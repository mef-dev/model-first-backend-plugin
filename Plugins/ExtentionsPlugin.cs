using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use ExtentionsRequest
/// <see cref="Bss.Entities.ExtentionsRequest"/>
/// <seealso cref="Bss.Entities.Extentions_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("extentions", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "extentions")]
 [ExportMetadata("EntityName", "extentions")]
 public class ExtentionsPlugin : EntityPlugin<ExtentionsRequest,
        SET_p_ucp_set_SubscriberExtentions_Request,
        SET_p_ucp_set_SubscriberExtentions_Response,
        Extentions_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}