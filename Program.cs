using Microsoft.Extensions.DependencyInjection;
using System;
using WorkflowCore.Interface;

namespace WorkflowCore_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();

            // start the workflow host
            var host = serviceProvider.GetService<IWorkflowHost>();
            host.RegisterWorkflow<HelloWorldWorkflow>();
            host.Start();

            // Workflow 的Id值（开始工作）
            host.StartWorkflow("HelloWordId");

            Console.ReadLine();
            host.Stop();
        }

        private static IServiceProvider ConfigureServices()
        {
            //setup dependency injection
            IServiceCollection services = new ServiceCollection();

            // AddLogging 需要引用NuGet包 Microsoft.Extensions.Logging
            services.AddLogging();
            services.AddWorkflow();

            //services.AddWorkflow(x => x.UseMongoDB(@"mongodb://localhost:27017", "workflow"));
            services.AddTransient<GoodbyeWorld>();

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
