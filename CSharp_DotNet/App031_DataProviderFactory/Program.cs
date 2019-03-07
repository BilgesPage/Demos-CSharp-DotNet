using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;

namespace App031_DataProviderFactory
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Read Inventory with DbProviderFactory
                string dataProvider = ConfigurationSettings.AppSettings.Get("myprovider");
                DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

                using (DbConnection connection = factory.CreateConnection())
                {
                
                    if (connection == null) Console.WriteLine("Connection is null");
                    else
                    {
                        Console.WriteLine($"Connection Type: {connection.GetType().Name}");

                        connection.ConnectionString = ConfigurationSettings.AppSettings.Get("connectionString");

                        connection.Open();

                        // Make command object
                        DbCommand command = connection.CreateCommand();
                        command.Connection = connection;
                        command.CommandText = "Select * FROM Inventory";

                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"Car Id: {reader["CarId"]}, Car Color: {reader["Color"]}");
                            }
                        }
                    }
                }
            #endregion


            #region Execute Stored Procedure
                SqlConnection sqlConn = new SqlConnection();
                string connectionString = ConfigurationSettings.AppSettings.Get("connectionString");
                sqlConn.ConnectionString = connectionString;
                using (SqlCommand command = new SqlCommand("GetPetName", sqlConn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input Param
                    SqlParameter param = new SqlParameter {
                        ParameterName = "@carId",
                        SqlDbType= SqlDbType.Int,
                        Value = 1,
                        Direction = ParameterDirection.Input
                    };

                    // Output Param

                    SqlParameter param2 = new SqlParameter
                    {
                        ParameterName = "@petName",
                        SqlDbType = SqlDbType.Char,
                        Size = 10,
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(param);
                    command.Parameters.Add(param2);

                    sqlConn.Open();

                    // Execute SP
                    command.ExecuteNonQuery();

                    // Retrieve Output Param
                    string carPetName = command.Parameters["@petName"].Value.ToString();

                    Console.WriteLine(carPetName);
                    sqlConn.Close();
                    }
                #endregion


                Console.ReadLine();
        }
    }
}
