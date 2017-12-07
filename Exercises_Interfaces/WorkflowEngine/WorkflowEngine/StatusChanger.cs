using System;

namespace WorkflowEngine
{
    class StatusChanger : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Update Video status to processing...");
        }
    }
}