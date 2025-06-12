using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004
{
    internal class Employee
    {
        public string Name;
        public decimal Salary;

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public static Employee operator +(Employee a, decimal amount)
        {
            a.Salary += amount;
            return a;
        }

        public static Employee operator -(Employee a, decimal amount)
        {
            a.Salary -= amount;
            return a;
        }

        public static bool operator ==(Employee a, Employee b)
        {
            return a.Salary == b.Salary;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return a.Salary != b.Salary;
        }

        public static bool operator >(Employee a, Employee b)
        {
            return a.Salary > b.Salary;
        }
        public static bool operator <(Employee a, Employee b)
        {
            return a.Salary < b.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Salary == other.Salary;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary:C}";
        }
    }
}
