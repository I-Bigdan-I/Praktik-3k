using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";

        try
        {
            // 1. Запись строки в файл (если файл существует — перезаписывается)
            string contentToWrite = "Привет, мир! Это тестовая запись.";
            File.WriteAllText(filePath, contentToWrite);
            Console.WriteLine($"✅ Файл '{filePath}' успешно записан.");

            // 2. Чтение всего содержимого файла
            if (File.Exists(filePath))
            {
                string readContent = File.ReadAllText(filePath);
                Console.WriteLine($"📄 Содержимое файла:\n{readContent}");
            }

            // 3. Дозапись в конец файла (не перезаписывая)
            string additionalText = "\nДобавленная строка.";
            File.AppendAllText(filePath, additionalText);
            Console.WriteLine($"✏️ Дописали в файл.");

            // 4. Чтение построчно
            Console.WriteLine("\n📑 Чтение по строкам:");
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine($"- {line}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Ошибка: {ex.Message}");
        }
    }
}
