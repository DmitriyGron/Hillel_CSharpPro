using System;

namespace HW_004_3
{
    internal class City
    {
        public string NameOfCity { get; set; }
        public decimal numberOfInhabitants { get; set; }

        public City(string NameOfCity, decimal numberOfInhabitants)
        {
            this.NameOfCity = NameOfCity;
            this.numberOfInhabitants = numberOfInhabitants;
        }

        public static City operator +(City a, decimal amount)
        {
            a.numberOfInhabitants += amount;
            return a;
        }

        public static City operator -(City a, decimal amount)
        {
            a.numberOfInhabitants -= amount;
            return a;
        }

        public static bool operator ==(City a, City b) => a.numberOfInhabitants == b.numberOfInhabitants;
        public static bool operator !=(City a, City b) => a.numberOfInhabitants != b.numberOfInhabitants;
        public static bool operator >(City a, City b) => a.numberOfInhabitants > b.numberOfInhabitants;
        public static bool operator <(City a, City b) => a.numberOfInhabitants < b.numberOfInhabitants;

        public override bool Equals(object obj)
        {
            if (obj is City other)
            {
                return this.numberOfInhabitants == other.numberOfInhabitants;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return numberOfInhabitants.GetHashCode();
        }

        public override string ToString()
        {
            return $"City: {NameOfCity}, Number of Inhabitants: {numberOfInhabitants}";
        }
    }
}
