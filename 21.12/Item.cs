namespace _21._12;

public class Item
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public Item(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }
}