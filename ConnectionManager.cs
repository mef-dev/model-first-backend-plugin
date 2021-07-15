using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Natec.Entities
{
    internal class ConnectionManager
    {
        public static SqlConnection BuildSqlConnection(string connectionString, string preSlqCommand)
        {
            SqlConnection result = new SqlConnection(connectionString);
            StateChangeEventHandler sceh = null;
            if (!string.IsNullOrEmpty(preSlqCommand))
            {
                sceh = CreateStateChangeEventHandler(preSlqCommand);
                result.StateChange += sceh;
            }

            result.Disposed += CreateConnectionDisposedEventHandler(sceh);
            return result;
        }

        private static StateChangeEventHandler CreateStateChangeEventHandler(string preSlqCommand)
        {
            return (sender, args) =>
            {
                if (args.OriginalState == ConnectionState.Closed
                && args.CurrentState == ConnectionState.Open
                && !string.IsNullOrEmpty(preSlqCommand))
                    try
                    {
                        using (SqlCommand _Command = ((SqlConnection)sender).CreateCommand())
                        {
                            _Command.CommandType = CommandType.Text;
                            _Command.CommandText = preSlqCommand;
                            _Command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception e)
                    {
                        Trace.TraceError($"Error while executing connection pre-command : {e.Message}");
                    }
            };
        }

        private static EventHandler CreateConnectionDisposedEventHandler(StateChangeEventHandler sceh)
        {
            EventHandler result = null;
            result = (sender, e) =>
            {
                SqlConnection sqlConnection = sender as SqlConnection;
                if (sqlConnection != null)
                {
                    if(sceh != null)
                        sqlConnection.StateChange -= sceh;
                    sqlConnection.Disposed -= result;
                    Trace.TraceInformation("Sql connection is disposed");
                }
            };
            return result;
        }
    }
}
