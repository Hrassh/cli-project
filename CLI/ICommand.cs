namespace CliProject.CLI;

public interface ICommand
{
    string Name { get; }
    void Execute(string[] args);
}
