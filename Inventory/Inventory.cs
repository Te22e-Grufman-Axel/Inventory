
public class Inventory
{
    public List<Item> Items = new List<Item>();

    public void Display()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {Items[i].Name}");
        }
    }
}
