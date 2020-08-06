using ATM_Dispenser.Interfaces;
using System;
using System.Collections.Generic;

namespace ATM_Dispenser
{
    public class AtmFacade : IAtmFacade
    {
        private readonly IValidator validator;
        private readonly IDispenser dispensor;
        public AtmFacade()
        {
            validator = new Validator();
            dispensor = new Dispenser();
        }

        public void GetMoney(int amount)
        {
            bool isValidAmountEntered = validator.IsValidAmount(amount);
            if (!isValidAmountEntered)
            {
                Dictionary<int, int> amountInNotes = dispensor.DispenseMoney(amount);
                foreach (KeyValuePair<int, int> note in amountInNotes)
                {
                    Console.WriteLine("Numebr of notes of Rupees {0} is {1}", note.Key, note.Value);
                }
            }
            else
            {
                Console.WriteLine("Please enter the Valid amount to dispense");
            }
        }
    }
}
