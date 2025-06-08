using System;
using System.Globalization;

namespace HW_002_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sound;


            MusicaInstrument cello = new Cello("Cello", "String instrument with a deep sound", "Originated in the 16th century in Italy.");
            cello.Show();
            cello.Desc();
            cello.History();
            Console.Write("Enter sound of this instrument: ");
            sound = Console.ReadLine() ?? "Default sound";
            cello.Sound(sound);

            Console.WriteLine(new string('-', 44));

            MusicaInstrument trombone = new Trombone("Trombone", "String instrument with a deep sound", "Originated in the 19th century in Uzbekistan.");
            trombone.Show();
            trombone.Desc();
            trombone.History();
            Console.Write("Enter sound of this instrument: ");
            sound = Console.ReadLine() ?? "Default sound";
            trombone.Sound(sound);

            Console.WriteLine(new string('-', 44));

            MusicaInstrument Ukulele = new Ukulele("Ukulele", "String instrument with a deep sound", "Originated in the 11th century in Ukraine.");
            Ukulele.Show();
            Ukulele.Desc();
            Ukulele.History();
            Console.Write("Enter sound of this instrument: ");
            sound = Console.ReadLine() ?? "Default sound";
            Ukulele.Sound(sound);

            Console.WriteLine(new string('-', 44));

            MusicaInstrument violin = new Violin("Violin", "String instrument with a deep sound", "Originated in the 12th century in USA.");
            violin.Show();
            violin.Desc();
            violin.History();
            Console.Write("Enter sound of this instrument: ");
            sound = Console.ReadLine() ?? "Default sound";
            violin.Sound(sound);
        }
    }
}
