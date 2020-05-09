using System;
using System.Collections.Generic;
using System.Text;
using WorkflowCore.Interface;
using WorkflowCore_Demo.Steps;

namespace WorkflowCore_Demo
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public string Id => "HelloWordId";

        public int Version => 1;

        public void Build(IWorkflowBuilder<object> builder)
        {
            builder.StartWith<HelloWord>()
                .Then<ActiveWord>()
                .Then<GoodbyeWord>();
        }
    }
}
