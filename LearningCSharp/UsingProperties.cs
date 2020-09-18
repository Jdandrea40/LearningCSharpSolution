using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class UsingProperties
    {
        [Fact]
        public void DefiningAndUsingProperties()
        {
            var customer = new BankCustomer() { Name = "Joe", AccountNumber = 123 };
            customer.SetPhone("555-1212");

            Assert.Equal("Joe", customer.Name);
            Assert.Equal("555-1212", customer.GetPhoneNumber());
            
        }
    }

    public class BankCustomer
    {
        private int _accountNumber; // "Backing Field"
       
        private string _phoneNumber;


        public string Name { get; set; } // Auto Property - create a backing field and implement the get/set for me. loser.
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public void SetPhone(string newValue)
        {
            _phoneNumber = newValue;
        }


        public int AccountNumber  // Property
        {
            get { return _accountNumber; } // "Getter"
            set { _accountNumber = value; } // "Setter"
        }

        public string GetInfo()
        {
            return $"Name: {Name} has the account number of {AccountNumber}";
        }
    }
}
