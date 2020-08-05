using ATM_Dispenser.Interfaces;
using System;

namespace ATM_Dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use Case: User would like to withdraw X Amount from an ATM.
            //Given the denominations in the ATM are[2000, 500, 200, 100]
            //1.Validate it can dispense the amount entered by user.
            //2.Dispense the amount, such that the minimum number of bills are used.
            //   Ex - 4800 = 2000 * 2, 500 * 1, 200 * 1, 100 * 1

            Console.WriteLine("ATM - Dispenser");
            Console.WriteLine("Please enter the amount to withdraw from ATM");
            int amount = Convert.ToInt32(Console.ReadLine());
            IAtmFacade atmFacade = new AtmFacade();
            atmFacade.GetMoney(amount);
            Console.WriteLine("Thank you Visit again...!!!");
        }
    }
}
