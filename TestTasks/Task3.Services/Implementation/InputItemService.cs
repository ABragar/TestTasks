using System;
using Task3.DAL.Entities;
using Task3.Services.Interfaces;
using static System.Console;

public class InputItemService : IInputItemService
{
    public Item GetItem()
    {
        var newItem = new Item();
        while (true)
        {
            WriteLine($"Please input new Item Id (int)");
            var input = ReadLine();
            if (Int32.TryParse(input, out int result))
            {
                newItem.Id = result;
                break;
            }

            WriteLine("Incorrect input");
        }
        WriteLine($"Please input new Item Name ");
        newItem.Name = ReadLine();
        return newItem;
     

    }
}

