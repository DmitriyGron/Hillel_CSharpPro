using System;

namespace HW_004_4
{
    internal class CreditCard
    {
        public int CVC { get; set; }
        public decimal Balance { get; set; }

        public CreditCard(int cvc, decimal balance)
        {
            CVC = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            if (card.Balance < amount)
                throw new InvalidOperationException("Insufficient funds.");
            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard a, CreditCard b) => a.CVC == b.CVC;
        public static bool operator !=(CreditCard a, CreditCard b) => !(a.CVC == b.CVC);
        public static bool operator >(CreditCard a, CreditCard b) => a.Balance > b.Balance;
        public static bool operator <(CreditCard a, CreditCard b) => a.Balance < b.Balance;

        public override bool Equals(object obj)
        {
            if (obj is CreditCard other)
            {
                return this.CVC == other.CVC && this.Balance == other.Balance;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return CVC.GetHashCode();
        }

        public override string ToString()
        {
            return $"CVC: {CVC}, Balance: {Balance}";

        }
    }
}
