using ATM_Dispenser.Interfaces;
using System.Collections.Generic;
using ATM_Dispenser.Constants;

namespace ATM_Dispenser
{
    public class Validator : IValidator
    {
        public bool IsValidAmount(int amount)
        {
            foreach (int note in AmountTypes.types)
            {
                if(isDivisable(amount, note))
                {
                    return false;   
                }
            }
            return true;
        }

        private bool isDivisable(int amount, int note)
        {
            return (amount % note) == 0;
        }
    }
}
