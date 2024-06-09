using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace SqlQueryTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            TestSqlQuery test = new TestSqlQuery();
            test.TestMethod();
           
        }
        public class TestSqlQuery
        {
            public void TestMethod()
            {
                //Console.WriteLine("Insert query....");
                //string cs = "Data Source=C:/Users/Admin/Desktop/NewTitan.tit";
                //string stm = "SELECT SQLITE_VERSION()";
                //var con = new SQLiteConnection(cs);
                //try
                //{

                //    con.Open();
                //    var cmd = new SQLiteCommand(stm, con);

                //    cmd.CommandText = "INSERT INTO `02_pad_cshape_types`(pad_cshape_type_name) VALUES(@pad_cshape_type_name)";
                //    cmd.Parameters.AddWithValue("@pad_cshape_type_name", "Bala");
                //    cmd.Prepare();
                //    cmd.ExecuteNonQuery();
                //    Console.WriteLine("Inserted successfully.");
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception: " + ex.Message);
                //}
                //finally
                //{
                //    con.Close();
                //}
            }
        }
    }
}