using System;

namespace WorkflowEngine
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            foreach (ITask I in workflow.GetTasks())
            {
                try
                {
                    I.Execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }
    }
}