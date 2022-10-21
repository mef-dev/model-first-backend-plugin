using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use BillingTasksRequest
/// <see cref="Bss.Entities.BillingTasksRequest"/>
/// <seealso cref="Bss.Entities.BillingTasks_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("billingtasks", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "billingtasks")]
 [ExportMetadata("EntityName", "billingtasks")]
 public class BillingTasksPlugin : EntityPlugin<BillingTasksRequest,
        SET_sp_set_BillingTasks_Request,
        SET_sp_set_BillingTasks_Response,
        BillingTasks_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}