using CliProject.CLI;
using CliProject.Modes;

namespace CliProject;

class Program
{
    static void Main(string[] args)
    {
        var cli = new CliFacade();

        cli.UseStrategy(new CatalogMode());

        Console.WriteLine("CLI started. Type 'help'.");

        while (true)
        {
            Console.Write("> ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                continue;

            cli.ExecCommand(input);
        }
    }
}
