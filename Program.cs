using System;

namespace Tanlash4;

public static class Program
{
    public static void Main()
    {
        // ============================================================
        // 1-vazifa. Aqlli robot (switch expression + ternary operator)
        // ============================================================
        Console.WriteLine("=== 1-vazifa. Aqlli robot ===");
        Console.Write("Buyruq kiriting (yur, tushun, sakra, o'giril): ");
        string command = Normalize(Console.ReadLine());

        string robotAction = command switch
        {
            "yur" => "Robot yuryapti!",
            "tushun" => "Robot tushunyapti!",
            "sakra" or "sakrash" => "Robot sakrayapti!",
            "o'giril" or "o'girilish" => "Robot o'girilyapti!",
            _ => "Noma'lum buyruq"
        };

        Console.WriteLine(command.Length == 0 ? "Buyruq kiritilmadi" : robotAction);
        Console.WriteLine();

        // ============================================================
        // 2-vazifa. Sehrli do'kon (if, else mantiqiy shartlari)
        // ============================================================
        Console.WriteLine("=== 2-vazifa. Sehrli do'kon ===");
        Console.Write("Mahsulot nomini kiriting (olma, banan, anor, gilos): ");
        string product = Normalize(Console.ReadLine());

        if (product == "olma")
        {
            Console.WriteLine("Narxi: 5000 so'm");
        }
        else if (product == "banan")
        {
            Console.WriteLine("Narxi: 12000 so'm");
        }
        else if (product == "anor")
        {
            Console.WriteLine("Narxi: 15000 so'm");
        }
        else if (product == "gilos")
        {
            Console.WriteLine("Narxi: 20000 so'm");
        }
        else
        {
            Console.WriteLine("Kechirasiz, bu mahsulot yo'q");
        }

        Console.WriteLine();

        // ============================================================
        // 3-vazifa. Trafik yoritgich (ternary operator + && / ||)
        // ============================================================
        Console.WriteLine("=== 3-vazifa. Trafik yoritgich ===");
        Console.WriteLine("Rang kiriting (qizil, sariq, yashil). Chiqish uchun bo'sh qator kiriting.");

        string previousColor = string.Empty;

        while (true)
        {
            Console.Write("Rang kiriting: ");
            string? line = Console.ReadLine();

            if (line == null || line.Trim().Length == 0)
            {
                break;
            }

            string color = Normalize(line);
            bool isKnown = color == "qizil" || color == "sariq" || color == "yashil";

            string message = previousColor == "yashil" && color == "yashil"
                ? "Tez yurmayman!"
                : color == "qizil"
                    ? "To'xtang!"
                    : color == "sariq"
                        ? "Tayyorlaning!"
                        : color == "yashil"
                            ? "Yuring!"
                            : "Noma'lum rang!";

            Console.WriteLine(message);

            previousColor = isKnown ? color : string.Empty;
        }

        Console.WriteLine("Dastur yakunlandi.");
    }

    // Kiritilgan matnni tozalaydi: bo'sh joylar, qo'shtirnoqlar va turli apostroflar.
    private static string Normalize(string? input)
    {
        if (input == null)
        {
            return string.Empty;
        }

        return input.Trim()
            .Trim('"', '“', '”')
            .Replace('ʻ', '\'')
            .Replace('‘', '\'')
            .Replace('’', '\'')
            .Replace('`', '\'')
            .ToLower();
    }
}
