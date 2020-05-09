using System;
using System.Collections.Generic;
using System.Text;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore_Demo.Steps
{
    public class ActiveWord : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("I am activing in the World");

            return ExecutionResult.Next();
        }
    }
}
