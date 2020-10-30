using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace connectACCESS
{
    namespace Conectar_con_Acces
    {
        class Program
        {
            static void Main(string[] args)
            {
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\SISINFO\Vuelos.mdb";
                string queryString = "Select Id, Code,Description FROM Airport";
                OleDbConnection connection = new OleDbConnection(connectionString);
                
                OleDbCommand command = new OleDbCommand(queryString, connection);
                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}",reader[0],reader[1]);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Press Any Key to Finish");
                Console.Read();
            }
            public int InsertProduct()
            {
                RowsAffected = 0;

                string sql = "INSERT INTO AIRPORT(ID,Code,Description,Category,IsMilitary)";
                sql += "VALUES('8','CBB','Cochabamba','1','0')";

                try
                {
                    using (SqlConnection coon = new SqlConnection(AppSettings.ConnectionString))
                    {
                        cnn.Open();
                        using (SqlCommand cmd=new SqlCommand(sql,cnn))
                        {
                            cmd.CommandType = CommandType.Text;

                            RowsAffected = cmd.ExecuteNonQuery();

                            ResultText = "Rows Affected: " + RowsAffected.ToString();
                        }
                    }
                }
            }
        }
    }
}
