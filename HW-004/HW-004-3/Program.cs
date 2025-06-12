using System;

namespace HW_004_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city1 = new City("CityA", 1000000);
            City city2 = new City("CityB", 2000000);

            Console.WriteLine("City 1: " + city1.NameOfCity + ", Population: " + city1.numberOfInhabitants);
            Console.WriteLine("City 2: " + city2.NameOfCity + ", Population: " + city2.numberOfInhabitants + "\n");

            Console.WriteLine("Adding 280000 to City 1's population...");
            city1 += 280000;
            Console.WriteLine("City 1: " + city1.NameOfCity + ", Population: " + city1.numberOfInhabitants + "\n");

            Console.WriteLine("Subtracting 460000 from City 2's population...");
            city2 -= 460000;
            Console.WriteLine("City 2: " + city2.NameOfCity + ", Population: " + city2.numberOfInhabitants + "\n");
            Console.WriteLine("City 1 == City 2: " + (city1 == city2));
            Console.WriteLine("City 1 != City 2: " + (city1 != city2));
            Console.WriteLine("City 1 > City 2: " + (city1 > city2));
            Console.WriteLine("City 1 < City 2: " + (city1 < city2));
            Console.WriteLine("Equals: " + city1.Equals(city2));
            Console.WriteLine("City 1 hash code: " + city1.GetHashCode());
            Console.WriteLine("City 2 hash code: " + city2.GetHashCode() + "\n");
            Console.WriteLine("City 1: " + city1.ToString());
            Console.WriteLine("City 2: " + city2.ToString());
        }
    }
}
