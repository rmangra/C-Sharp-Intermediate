using System;

namespace DbConnection
{
    class OracleConnection : DbConnection
    {

        public override void Open(String value)
        {
            Console.WriteLine("Oracle - Opening Connection... ");
            Console.ReadLine();
            this.ConnectionString = value;
        }
        public override void Open()
        {
            Console.WriteLine("Oracle - Opening Connection... ");
            Console.ReadLine();
        }
        public override void Close()
        {
            Console.WriteLine("Oracle - Closing Connection... ");
            Console.ReadLine();

        }

        public OracleConnection(String connectionstring, TimeSpan timeout) : base(connectionstring, timeout)
        {

        }
    }
}
