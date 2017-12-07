using System;

namespace DbCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            /* For testing sqlconnection error */
            // var sql = new SqlConnection(null, TimeSpan.Zero);   /* expect error */

            // var sql = new SqlConnection("localhost 3200", TimeSpan.Zero);
            // sql.Open();
            // sql.Close();

            // var oracle = new OracleConnection("localhost 3200", TimeSpan.Zero);
            // oracle.Open();
            // oracle.Close();

            /* For testing dbcommand */
            var dbcommand = new DbCommand("Select COUNT (*) from table Customers", new SqlConnection("localhost 3200", TimeSpan.Zero));
            dbcommand.Execute();
            dbcommand = new DbCommand("Select COUNT (*) from table Orders", new OracleConnection("localhost 3200", TimeSpan.Zero));
            dbcommand.Execute();
        }
    }
}
