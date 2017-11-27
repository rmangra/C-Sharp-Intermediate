using System;

namespace Stopwatch
{
    /*
     * https://msdn.microsoft.com/en-us/library/ff650316.aspx
     */

    public class StopWatch
    {
        private static volatile StopWatch instance;
        private static object syncRoot = new Object();
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;

        private StopWatch()
        {
            
        }

        public static StopWatch Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new StopWatch();
                    }
                }

                return instance;
            }
        }

        public void Start()
        {
            if (_running)
                throw new InvalidStopWatchException("Stopwatch is already running");
            _startTime = DateTime.Now;
            _running = true;

        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidStopWatchException("Stopwatch is not running");
            _endTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }

    /*
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions
     */

    [Serializable()]
    public class InvalidStopWatchException : System.Exception
    {
        public InvalidStopWatchException() : base() { }
        public InvalidStopWatchException(string message) : base(message) { }
        public InvalidStopWatchException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidStopWatchException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}