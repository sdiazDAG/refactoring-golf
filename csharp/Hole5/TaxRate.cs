using System;

namespace Hole5
{
    public class TaxRate
    {
        private readonly int percent;

        private TaxRate(int percent)
        {
            this.percent = percent;
        }

        public static TaxRate Of(int percent)
        {
            return new TaxRate(percent);
        }

        public Money Apply(Money first, Money total)
        {
            Double amount = total.value * (percent / 100d);
            Money tax = Money.Create(Convert.ToInt32(amount), first.currency);
            return tax;
        }
    }
}