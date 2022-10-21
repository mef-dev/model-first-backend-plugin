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
 [Export("bankstatementtransactions", typeof(IBackendPlugin))]
 [ExportMetadata("Description", "bankstatementtransactions")]
 [ExportMetadata("EntityName", "bankstatementtransactions")]
 public class BankStatementTransactionsPlugin : EntityPlugin<EmptyEntityModel,
        EmptyCallProcedureModel,
        EmptyCallProcedureModel,
        EmptyEntityModel,
        BankStatementTransactions_Request_GET,
        GET_p_ucp_get_BankStatements_Request,
        GET_p_ucp_get_BankStatements_Response,
        BankStatementTransactions_Response_GET,
        GET_p_ucp_get_BankStatements_Response_OUTPUT,
        BankStatementTransactions_Response_GET_OUTPUT>
        {
               }
}