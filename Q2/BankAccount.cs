using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class BankAccount
{
    public int AccountNumber;
    public double Balance = 1000;

    public void Deposit(double amount)
    {
        Balance = Balance + amount;
    }
}
