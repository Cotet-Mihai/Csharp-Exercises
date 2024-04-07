using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return 3.213f;
        }
        else if (balance < 1000)
        {
            return 0.5f;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            return 1.621f;
        }
        else 
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        decimal interestRate = (decimal) InterestRate(balance);

        return balance * interestRate/100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            year++;
        }

        return year;
    }
}
