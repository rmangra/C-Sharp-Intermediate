using System;

namespace WorkflowEngine
{
    class WebServiceCaller : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling a Web Service...");
        }
    }
}
