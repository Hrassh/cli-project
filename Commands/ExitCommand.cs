using CliProject.CLI;

namespace CliProject.Commands;

public class ExitCommand : ICommand
{
    public string Name => "exit";

    public void Execute(string[] args)
    {
        Console.WriteLine("Bye!");
        Environment.Exit(0);
    }
}
