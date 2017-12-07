using System;

namespace DbConnection
{
    class SqlConnection : DbConnection
    {
        public override void Open(String value)
        {
            Console.WriteLine("Sql - Opening Connection... ");
            Console.ReadLine();
            this.ConnectionString = value;
        }

        public override void Open()
        {
            Console.WriteLine("Sql - Opening Connection... ");
            Console.ReadLine();
        }

        public override void Close()
        {
            Console.WriteLine("Sql - Closing Connection... ");
            Console.ReadLine();

        }

        public SqlConnection(String connectionstring, TimeSpan timeout) : base(connectionstring, timeout)
        {

        }
    }
}
