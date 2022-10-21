using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use TasksRequest
/// <see cref="Bss.Entities.TasksRequest"/>
/// <seealso cref="Bss.Entities.Tasks_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("tasks", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "tasks")]
 [ExportMetadata("EntityName", "tasks")]
 public class TasksPlugin : EntityPlugin<TasksRequest,
        SET_p_ucp_set_ServiceTask_Request,
        SET_p_ucp_set_ServiceTask_Response,
        Tasks_Response_SET,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyEntityModel>
        {
               }
}