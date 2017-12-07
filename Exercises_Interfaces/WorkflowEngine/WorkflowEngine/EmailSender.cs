using System;

namespace WorkflowEngine
{
    class EmailSender : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an Email...");
        }
    }
}