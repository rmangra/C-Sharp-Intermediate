using System;

namespace DbCommand
{
    class DbCommand
    {
        private String _command;
        private DbConnection _connection;
        public DbCommand(String command, DbConnection connection)
        {
            if (String.IsNullOrEmpty(command))
                throw new InvalidCommandException("Invalid Command String");
            _command = command;
            _connection = connection;
        }

        public void Execute()
        {
            _connection.Open();
            this.Run();
            _connection.Close();
        }

        private void Run()
        {
            Console.WriteLine("Executing  " + _command);
        }
    }

    [Serializable()]
    public class InvalidCommandException : System.Exception
    {
        public InvalidCommandException() : base() { }
        public InvalidCommandException(string message) : base(message) { }
        public InvalidCommandException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidCommandException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}