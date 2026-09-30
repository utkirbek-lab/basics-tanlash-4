using System;

namespace Tanlash4;

public static class Program
{
    public static void Main()
    {
        // 1-vazifa. Aqlli robot
        Console.Write("Buyruq kiriting: ");
        string command = Console.ReadLine() ?? "";

        string robotAction = command switch
        {
            "yur" => "Robot yuryapti!",
            "sakra" => "Robot sakrayapti!"
        };
        Console.WriteLine(robotAction);

        // 2-vazifa. Sehrli do'kon
        Console.Write("Mahsulot nomini kiriting: ");
        string product = Console.ReadLine() ?? "";
        if (product == "olma")
        {
            Console.WriteLine("Narxi: 500 so'm");
        }
        if (product == "banan")
        {
            Console.WriteLine("Narxi: 12000 so'm");
        }

        // 3-vazifa. Trafik yoritgich
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Rang kiriting: ");
            string color = Console.ReadLine() ?? "";
            if (color == "qizil")
            {
                Console.WriteLine("To'xtang!");
            }
            else
            {
                Console.WriteLine("Yuring!");
            }
        }
    }
}
