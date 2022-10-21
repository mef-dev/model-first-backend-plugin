using System.Composition;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
namespace Bss.Entities{
    /// <summary>
/// Implementation of IBackendPlugin for use BankStatementsRequest
/// <see cref="Bss.Entities.BankStatementsRequest"/>
/// <seealso cref="Bss.Entities.BankStatements_Request_SET"/>
/// </summary>
    [DocIgnore]
 [Export("bankstatements", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "bankstatements")]
 [ExportMetadata("EntityName", "bankstatements")]
 [ExportMetadata("Actions", new[] {"ChangePaymentsStatus","CheckNoSavePayments","ClearBatch"})]
 public class BankStatementsPlugin : EntityPlugin<BankStatementsRequest,
        SET_p_ucp_set_BatchPayDocRecords_Request,
        SET_p_ucp_set_BatchPayDocRecords_Response,
        BankStatements_Response_SET,
        BankStatements_Request_GET,
        GET_p_ucp_get_BatchPayDocRecords_Request,
        GET_p_ucp_get_BatchPayDocRecords_Response,
        BankStatements_Response_GET,
        GET_p_ucp_get_BatchPayDocRecords_Response_OUTPUT,
        BankStatements_Response_GET_OUTPUT>
        {
               }
}