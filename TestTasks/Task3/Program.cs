using Microsoft.Extensions.DependencyInjection;
using Task3.DAL;
using Task3.DAL.Interfaces;
using Task3.Services.Implementation;
using Task3.Services.Interfaces;
using static System.Console;

namespace Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
           BuildServiceCollection(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetService<IWorkFlowService>().Run();

            ReadKey();
        }

        /// <summary>
        /// configure service collection
        /// </summary>
        /// <returns></returns>
        private static void BuildServiceCollection(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IWorkFlowService, WorkFlowService>();
            serviceCollection.AddTransient<IInputItemService, InputItemService>();
            serviceCollection.AddTransient<IStorageService, StorageService>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}