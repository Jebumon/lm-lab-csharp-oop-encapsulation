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

        public string DepositAmount(int amount)
        {
            AccountBalance += amount;
            AddReward();
            return $"You successfully deposited 30 to your account, balance is {AccountBalance} " +
                                                        $"congragulations you got a reward of 50!!!";
        }

        public string GetAccountBalanceDetails() 
        {
            Console.WriteLine($"Your account balance is {AccountBalance}");
            return $"Your account balance is {AccountBalance}";
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
