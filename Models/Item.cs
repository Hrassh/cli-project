namespace CliProject.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public static List<Item> Storage { get; } = new();
}
