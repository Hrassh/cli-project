using CliProject.CLI;

namespace CliProject.Modes;

public interface ICommandStrategy
{
    IEnumerable<ICommand> RegisterCommands();
}
