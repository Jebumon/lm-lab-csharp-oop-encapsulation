using System;
namespace Encapsulation.Models
{
    public class DodgyBankAccount
    {

        public string AccountNumber;
        public int AccountBalance;
        public int RewardAmount = 50;

        public DodgyBankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            AccountBalance = 0;
        }

        public void DepositAmount(int amount)
        {
            AccountBalance += amount;
            AddReward();
        }

        public void GetAccountBalanceDetails() 
        {
            Console.WriteLine($"Your account balance is {AccountBalance}");
        }

        public void DebitAmount(int amount)
        {
            AccountBalance -= amount;
        }

        public void AddReward()
        {
            AccountBalance += RewardAmount;
        }
    }
}
