using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use PhoneNumbersRequest
/// <see cref="Bss.Entities.PhoneNumbersRequest"/>
/// <seealso cref="Bss.Entities.PhoneNumbers_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("phonenumbers", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "phonenumbers")]
 [ExportMetadata("EntityName", "phonenumbers")]
 public class PhoneNumbersPlugin : EntityPlugin<PhoneNumbersRequest,
        SET_p_ucp_set_CodeRegions_PhoneNumbers_Request,
        SET_p_ucp_set_CodeRegions_PhoneNumbers_Response,
        PhoneNumbers_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}