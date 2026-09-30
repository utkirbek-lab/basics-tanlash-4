using System;

namespace Tanlash4;

public static class Program
{
    public static void Main()
    {
        // 1-vazifa. Aqlli robot
        Console.Write("Buyruq kiriting: ");
        string command = Console.ReadLine()

        if (command == "yur")
            Console.WriteLine("Robot yuryapti!");
        if (command == "sakra")
            Console.WriteLine("Robot sakrayapti!");

        // 2-vazifa. Sehrli do'kon
        Console.Write("Mahsulot nomini kiriting: ");
        string product = Console.ReadLine();
        if (product == "olma")
            Console.WriteLine("Narxi: 5000 so'm");

        // 3-vazifa. Trafik yoritgich
        Console.Write("Rang kiriting: ");
        string color = Console.ReadLine();
        if (color == "yashil")
            Console.WriteLine("Yuring!");
    }
}
