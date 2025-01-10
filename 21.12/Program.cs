﻿namespace _21._12;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            // Створення рюкзака
            Backpack backpack = new Backpack
            {
                Color = "Чорний",
                Brand = "Adidas",
                Manufacturer = "Україна",
                Fabric = "Нейлон",
                Weight = 1.2,
                Volume = 30.0 // Обсяг в літрах
            };

            // Реєстрація анонімного обробника події
            backpack.ItemAdded += (sender, item) =>
            {
                Console.WriteLine($"Додано об'єкт: {item.Name}, обсяг: {item.Volume} л");
            };

            try
            {
                // Додавання об'єктів
                backpack.AddItem(new Item("Книга", 5.0));
                backpack.AddItem(new Item("Ноутбук", 15.0));
                backpack.AddItem(new Item("Пляшка води", 2.0));

                // Спроба перевищення обсягу
                backpack.AddItem(new Item("Туристичний набір", 10.0));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            // Показ зайнятого обсягу
            Console.WriteLine($"Зайнятий обсяг: {backpack.GetUsedVolume()} л із {backpack.Volume} л");
        }
    }
