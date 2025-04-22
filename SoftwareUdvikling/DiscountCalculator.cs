using System;

namespace SoftwareUdvikling
{
    public class DiscountCalculator
    {
        public double CalculateFinalPrice(double price, int customerYears, bool isPremiumMember)
        {
            if (price < 0)
                throw new ArgumentException("Price cannot be negative");

            double discount = 0;

            if (customerYears > 5)
            {
                discount += 0.1; // 10% loyalitetsrabat
            }

            if (isPremiumMember)
            {
                discount += 0.05; // 5% for premium kunder
            }

            if (price > 1000)
            {
                discount += 0.05; // 5% stor-købsrabat
            }

            if (discount > 0.2)
            {
                discount = 0.2; // Max rabat er 20%
            }

            double finalPrice = price * (1 - discount);
            return finalPrice;
        }
    }
}