using System;
using System.Data.SqlClient;
using System.Data;


namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                using (SqlConnection conn = new SqlConnection(""))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "";
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {

                    }

                }
            }
            catch(Exception ex)
            {
                Console.Write(ex);
                Console.Read();
            }
        }
    }
}
