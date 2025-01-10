namespace _21._12;

public class Backpack
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Manufacturer { get; set; }
    public string Fabric { get; set; }
    public double Weight { get; set; }
    public double Volume { get; set; }

    // Вміст рюкзака
    private List<Item> contents = new List<Item>();
    public IReadOnlyList<Item> Contents => contents.AsReadOnly();

    // Подія для додавання об'єкта
    public event EventHandler<Item> ItemAdded;

    // Метод для додавання об'єкта
    public void AddItem(Item item)
    {
        double usedVolume = GetUsedVolume();
        if (usedVolume + item.Volume > Volume)
        {
            throw new InvalidOperationException("Перевищено обсяг рюкзака!");
        }

        contents.Add(item);

        // Виклик події
        ItemAdded?.Invoke(this, item);
    }

    // Метод для отримання зайнятого обсягу
    public double GetUsedVolume()
    {
        double usedVolume = 0;
        foreach (var item in contents)
        {
            usedVolume += item.Volume;
        }
        return usedVolume;
    }
}

