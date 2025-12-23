using CliProject.CLI;

namespace CliProject.Commands;

public class HelpCommand : ICommand
{
    public string Name => "help";

    public void Execute(string[] args)
    {
        Console.WriteLine("Commands:");
        Console.WriteLine(" help   - show this help");
        Console.WriteLine(" list   - list items");
        Console.WriteLine(" create - create new item");
        Console.WriteLine(" exit   - exit app");
    }
}
