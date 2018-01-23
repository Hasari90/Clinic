using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_HJ
{
    public class DataBase
    {
        public string ConnectionString { get; set; }

        public DataBase(string connectionString) => ConnectionString = connectionString;
        public void Connect()
        {
            OleDbConnection odconn = new OleDbConnection(ConnectionString);
        }
        public void InsertRow(string insertSQL)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand command = new OleDbCommand(insertSQL);

                command.Connection = connection;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Zapytnie Insert wykonało się pomyślnie");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void SelectRow(string selectSQL)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand command = new OleDbCommand(selectSQL);
                OleDbDataReader reader;
                command.Connection = connection;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            Console.Write(" " + reader[i].ToString());
                        Console.WriteLine();
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public DataTable dataTableSelect(string selectSQL)
        {
            DataTable dt = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand command = new OleDbCommand(selectSQL);
                OleDbDataAdapter adpter = new OleDbDataAdapter(command);
                command.Connection = connection;

                try
                {
                    connection.Open();
                    adpter.Fill(dt);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dt;
        }

        public void UpdateRow(string updateSQL)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand command = new OleDbCommand(updateSQL);

                command.Connection = connection;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Zapytnie Update wykonało się pomyślnie");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void DeleteRow(string deleteSQL)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand command = new OleDbCommand(deleteSQL);

                command.Connection = connection;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Zapytnie Delete wykonało się pomyślnie");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
