using ATM_Dispenser.Constants;
using ATM_Dispenser.Interfaces;
using System.Collections.Generic;

namespace ATM_Dispenser
{
    public class Dispenser : IDispenser
    {
        public Dictionary<int, int> DispenseMoney(int amount)
        {
            Dictionary<int, int> dispensedMoney = new Dictionary<int, int>();
            foreach (int note in AmountTypes.types)
            {
                if (amount / note >= 1)
                {
                    dispensedMoney.Add(note, amount / note);
                    amount = amount - ((amount / note) * note);
                }
            }
            return dispensedMoney;
        }
    }
}
