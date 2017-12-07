using System;

namespace DbCommand
{
    abstract class DbConnection
    {
        private String _connectionstring;
        public String ConnectionString
        {
            get { return _connectionstring; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new InvalidConnectStringException("Invalid Connection String");
                _connectionstring = value;
            }
        }
        private TimeSpan _timeout;
        public TimeSpan Timeout
        {
            get { return _timeout; }
            set { _timeout = value; }
        }
        public DbConnection(String connectionstring, TimeSpan timeout)
        {
            if (String.IsNullOrEmpty(connectionstring))
                throw new InvalidConnectStringException("Invalid Connection String");
            _connectionstring = connectionstring;
            _timeout = timeout;
        }

        public abstract void Open(String connectionstring);
        public abstract void Open();
        public abstract void Close();
    }

    [Serializable()]
    public class InvalidConnectStringException : System.Exception
    {
        public InvalidConnectStringException() : base() { }
        public InvalidConnectStringException(string message) : base(message) { }
        public InvalidConnectStringException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidConnectStringException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}