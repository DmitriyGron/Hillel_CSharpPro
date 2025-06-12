using System;

namespace HW_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Alice", 50000);
            Employee employee2 = new Employee("Bob", 60000);

            Console.WriteLine("Employee 1: " + employee1.Name + ", Salary: " + employee1.Salary);
            Console.WriteLine("Employee 2: " + employee2.Name + ", Salary: " + employee2.Salary + "\n");

            Console.WriteLine("Adding 5000 to Employee 1's salary...");
            employee1 += 5000;
            Console.WriteLine("Employee 1: " + employee1.Name + ", Salary: " + employee1.Salary + "\n");

            Console.WriteLine("Subtracting 2000 from Employee 2's salary...");
            employee2 -= 2000;
            Console.WriteLine("Employee 2: " + employee2.Name + ", Salary: " + employee2.Salary + "\n");

            Console.WriteLine("Employee 1 == Employee 2: " + (employee1 == employee2));
            Console.WriteLine("Employee 1 != Employee 2: " + (employee1 != employee2));
            Console.WriteLine("Employee 1 > Employee 2: " + (employee1 > employee2));
            Console.WriteLine("Employee 1 < Employee 2: " + (employee1 < employee2));
            Console.WriteLine("Equals: " + employee1.Equals(employee2));
            Console.WriteLine("HashCode Employee 1: " + employee1.GetHashCode());
            Console.WriteLine("HashCode Employee 2: " + employee2.GetHashCode());

        }
    }
}
