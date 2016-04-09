using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class dbclass

    {
        public static SqlConnection GetConnection()
        {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hasnain\Documents\db.mdf;Integrated Security=True;Connect Timeout=30;";
          
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connStr);
            return connection;
        }

        public static int InsertTransaction( String word)
        {
            int return_code = 0;
            string transactionDate = DateTime.Now.ToShortDateString() + ' ' + DateTime.Now.ToShortTimeString();
            string insertStatement = "INSERT INTO words " +
                " (word) " 
                +" VALUES ("
                +"'"+word+"'"+")";

           

            SqlConnection connection = dbclass.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
           

            Console.WriteLine(insertStatement);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return_code = 1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
            return return_code;
        }

        public static List<String> GetTransactions()
        {
            List<String> List = new List<String>();
            SqlConnection connection = dbclass.GetConnection();
            string selectStatement = "SELECT  (word) from words ";
            Console.WriteLine(selectStatement);
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
               
                while (reader.Read())
                {
                 String i = reader["word"].ToString();
                 List.Add(i);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
            return List;
        }

    }
}
