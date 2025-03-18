using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=ARSEN;Initial Catalog=VegetableFruits;Integrated Security=True";


            using (SqlConnection sql_connect = new SqlConnection(connectionString))
            {
                try
                {
                    sql_connect.Open();
                    Console.WriteLine("Поддключение к базе данных успешко.");
                    Console.WriteLine($"Сервер: {sql_connect.DataSource}");
                    Console.WriteLine($"База данных: {sql_connect.Database}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                }
                finally
                {
                    sql_connect.Close();
                    Console.WriteLine("Подключение закрыто.");
                }
            }
            Console.ReadLine();
        }
    }
}
