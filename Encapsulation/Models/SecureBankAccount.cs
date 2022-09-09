using System;
namespace Encapsulation.Models
{
    public class SecureBankAccount
    {
        private readonly string _accountNumber;
        private const int REWARD_AMOUNT = 50;
        private int _accountBalance;

        public SecureBankAccount(string accountNumber)
        {
            _accountNumber = accountNumber;
            _accountBalance = 0;
        }

        public string DepositAmount(int amount)
        {
            _accountBalance += amount;
            AddReward();
            return $"You successfully deposited 30 to your account, balance is {_accountBalance} " +
                                                        $"congragulations you got a reward of 50!!!";
        }

        public string DisplayAccountBalanceDetails()
        {
            Console.WriteLine($"Your account balance is {_accountBalance}");
            return $"Your account balance is {_accountBalance}";
        }

        public void DebitAmount(int amount)
        {
            _accountBalance -= amount;
        }

        private void AddReward()
        {
            _accountBalance += REWARD_AMOUNT;
        }
    }
}

