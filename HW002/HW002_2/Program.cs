using System;

namespace HW002_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Violin", "A musical instrument that plays strings.",
                "The violin was created in Italy in the 16th century.", "Violin sound");

            Trombone trombone = new Trombone("Trombone", "A brass wind instrument that has a slide mechanism for changing pitch.",
                            "The trombone appeared in Europe in the 15th century and became popular in classical music.", "Trombone sound");

            Ukulele ukulele = new Ukulele("Ukulele", "A stringed instrument similar to a guitar but smaller.",
                            "The ukulele was created in Hawaii in the 19th century.", "Ukulele sound");

            Cello cello = new Cello("Cello", "A large stringed instrument played while sitting.",
                            "The cello was created in Italy in the 17th century.", "Sound of cello");


            violin.Sound();
            violin.Show();
            violin.Desc();
            violin.History();

            Console.WriteLine();

            trombone.Sound();
            trombone.Show();
            trombone.Desc();
            trombone.History();

            Console.WriteLine();

            ukulele.Sound();
            ukulele.Show();
            ukulele.Desc();
            ukulele.History();

            Console.WriteLine();

            cello.Sound();
            cello.Show();
            cello.Desc();
            cello.History();
        }
    }
}
