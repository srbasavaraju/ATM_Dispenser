﻿using System.Collections.Generic;

namespace ATM_Dispenser.Interfaces
{
    public interface IDispenser
    {
        Dictionary<int, int> DispenseMoney(int amount);
    }
}
