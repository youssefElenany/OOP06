using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS06
{
    abstract class Discount
    {
        public string Name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }

    class PercentageDiscount : Discount
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage) => _percentage = percentage;

        public override decimal CalculateDiscount(decimal price, int quantity) => price * quantity * (_percentage / 100);
    }

    class FlatDiscount : Discount
    {
        private readonly decimal _amount;
        public FlatDiscount(decimal amount) => _amount = amount;

        public override decimal CalculateDiscount(decimal price, int quantity) => _amount * Math.Min(quantity, 1);
    }

    class BuyOneGetOneDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity) => (price / 2) * (quantity / 2);
    }
    abstract class User
    {
        public string Name { get; set; }
        public abstract Discount GetDiscount();
    }

    class RegularUser : User
    {
        public override Discount GetDiscount() => new PercentageDiscount(5) { Name = "Regular Discount" };
    }

    class PremiumUser : User
    {
        public override Discount GetDiscount() => new FlatDiscount(100) { Name = "Premium Discount" };
    }

    class GuestUser : User
    {
        public override Discount GetDiscount() => null;
    }


}
