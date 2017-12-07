using System;

namespace WorkflowEngine
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.Add(new VideoUploader());
            workflow.Add(new WebServiceCaller());
            workflow.Add(new EmailSender());
            workflow.Add(new StatusChanger());

            var engine = new WorkFlowEngine();
            engine.Run(workflow);
            Console.ReadLine();
        }
    }
}
