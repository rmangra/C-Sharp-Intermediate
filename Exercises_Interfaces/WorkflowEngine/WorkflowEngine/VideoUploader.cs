using System;

namespace WorkflowEngine
{
    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a Video...");
        }
    }
}