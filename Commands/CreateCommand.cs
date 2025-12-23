using CliProject.CLI;
using CliProject.Models;

namespace CliProject.Commands;

public class CreateCommand : ICommand
{
    public string Name => "create";

    public void Execute(string[] args)
    {
        Console.Write("Enter name: ");
        var name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid name.");
            return;
        }

        Item.Storage.Add(new Item
        {
            Id = Item.Storage.Count + 1,
            Name = name
        });

        Console.WriteLine("Item created.");
    }
}
