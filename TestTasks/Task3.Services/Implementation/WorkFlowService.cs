using Task3.Services.Interfaces;
using static System.Console;

namespace Task3.Services.Implementation
{
    public class WorkFlowService : IWorkFlowService
    {
        private readonly IInputItemService input;
        private readonly IStorageService dbService;

        public WorkFlowService(IInputItemService input, IStorageService dbService)
        {
            this.input = input;
            this.dbService = dbService;
        }
        public void Run()
        {
            WriteLine($"Processing workflow ...");
            dbService.GetItems();
            var flag = true;
            while (flag)
            {
                WriteLine($"Getting new Item ...");
                var item = input.GetItem();

                WriteLine("Saving item...");
                dbService.SaveItem(item);

                dbService.GetItems();

                WriteLine("Press any key to continue, press q/Q to quit.");
                var keyPressedValue = ReadKey();

                if(keyPressedValue.KeyChar=='q' || keyPressedValue.KeyChar == 'Q')
                {
                    flag = false;
                }
            }
        }
    }
}

