using System;
using System.Collections.Generic;

namespace StackDesign
{
    class Stack
    {
        private readonly List<object> _list = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidStackException("Cannot add a null object");
            _list.Add(obj);
        }
        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidStackException("No elements in stack");
            var index = _list.Count - 1;
            var element = _list[index];
            _list.RemoveAt(index);
            return element;

        }
        public object Peek()
        {
            if (_list.Count == 0)
                throw new InvalidStackException("No elements in stack");
            var index = _list.Count - 1;
            var element = _list[index];
            return element;
        }
        public void Clear()
        {
            _list.Clear();
        }
    }
    /*
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions
     */

    [Serializable()]
    public class InvalidStackException : System.Exception
    {
        public InvalidStackException() : base() { }
        public InvalidStackException(string message) : base(message) { }
        public InvalidStackException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidStackException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }


}