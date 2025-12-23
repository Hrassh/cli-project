using CliProject.Modes;

namespace CliProject.CLI;

public class CliFacade
{
    private readonly Dictionary<string, ICommand> _commands = new();

    public void UseStrategy(ICommandStrategy strategy)
    {
        foreach (var cmd in strategy.RegisterCommands())
        {
            _commands[cmd.Name] = cmd;
        }
    }

    public void ExecCommand(string raw)
    {
        var parts = raw.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0) return;

        var name = parts[0];

        if (_commands.TryGetValue(name, out var command))
        {
            command.Execute(parts.Skip(1).ToArray());
        }
        else
        {
            Console.WriteLine("Unknown command. Type 'help'.");
        }
    }
}
