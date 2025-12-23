using CliProject.CLI;
using CliProject.Models;

namespace CliProject.Commands;

public class ListCommand : ICommand
{
    public string Name => "list";

    public void Execute(string[] args)
    {
        if (Item.Storage.Count == 0)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        foreach (var item in Item.Storage)
        {
            Console.WriteLine($"{item.Id}: {item.Name}");
        }
    }
}
