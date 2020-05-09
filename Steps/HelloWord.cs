using System;
using System.Collections.Generic;
using System.Text;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore_Demo.Steps
{
    public class HelloWord : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("HelloWord");

            return ExecutionResult.Next();
        }
    }
}
