using CliProject.CLI;
using CliProject.Commands;

namespace CliProject.Modes;

public class CatalogMode : ICommandStrategy
{
    public IEnumerable<ICommand> RegisterCommands()
    {
        return new ICommand[]
        {
            new HelpCommand(),
            new ListCommand(),
            new CreateCommand(),
            new ExitCommand()
        };
    }
}
