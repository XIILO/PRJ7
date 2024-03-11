using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace StorageManager
{
    internal class DatabaseConnector
    {
        string ConnectionString = @"Data Source=SIILO;Initial Catalog=StorageManagement;Integrated Security=True";

        public DataTable ActionProc(string ProcName, SqlParameter[] Parameters)
        {
            using (SqlConnection Connector = new SqlConnection(ConnectionString))
            {
                Connector.Open();
                DataTable Table = new DataTable();

                using (SqlCommand Commander = new SqlCommand(ProcName, Connector) { CommandType = CommandType.StoredProcedure })
                {
                    if (Parameters != null)
                    {
                        Commander.Parameters.AddRange(Parameters);
                    }
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Commander))
                    {
                        Adapter.Fill(Table);
                    }

                }
                return Table;
            }
        }


        public bool VerifyProcedure(string procedureName, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(procedureName, connection) { CommandType = CommandType.StoredProcedure })
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    object result = command.ExecuteScalar();
                    return result is not null && (int)result == 1;
                }
            }
        }



    }
}
