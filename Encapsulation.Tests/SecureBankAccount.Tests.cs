using FluentAssertions;
using NUnit.Framework;
using Encapsulation.Models;

    
namespace Encapsulation.Tests
{
    public class SecureBankAccountTests
    {
        const string MY_ACCOUNT_NUMBER = "ABCDEFG123";
        
        private int _deposite_30 = 30;

        private SecureBankAccount _mySecureBankAccount;

        private const string Expected_Output_Deopting_30 = "You successfully deposited 30 to your account, balance is 80" +
                                                           " congragulations you got a reward of 50!!!";
        private const string Expected_Output_Your_Balance_is_80 = $"Your account balance is 80";
        


        [SetUp]
        public void Setup()
        {
            _mySecureBankAccount = new SecureBankAccount(MY_ACCOUNT_NUMBER);
        }

        [Test]
        public void Depositing_30()
        {
            _mySecureBankAccount.DepositAmount(_deposite_30).Should().Be(Expected_Output_Deopting_30);
        }

        [Test]
        public void Your_Balance_is_80()
        {
            _mySecureBankAccount.DepositAmount(_deposite_30);
            _mySecureBankAccount.DisplayAccountBalanceDetails().Should().Be(Expected_Output_Your_Balance_is_80);
        }



    }
}