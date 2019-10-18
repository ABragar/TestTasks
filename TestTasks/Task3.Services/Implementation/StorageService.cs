using System.Collections.Generic;
using Task3.DAL.Entities;
using Task3.DAL.Interfaces;
using Task3.Services.Interfaces;
using static System.Console;


public class StorageService : IStorageService
{
    private readonly IUnitOfWork unitOfWork;

    public StorageService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }
    public void SaveItem(Item item)
    {
        unitOfWork.ItemRepository.Create(item);
    }

    public IEnumerable<Item> GetItems()
    {
        var items = unitOfWork.ItemRepository.GetAll();
        WriteLine("Item list");
        foreach (var item in items)
        {
            WriteLine(item);
        }
        return items;
    }

    public Item GetItem(int id)
    {
        WriteLine($"Return Item ID = {id}");
        return unitOfWork.ItemRepository.Get(id);
    }
}

