using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class Dtos
    {
        [Fact]
        public void DoingThem()
        {
            AddCustomer(new CustomerCreate { First = "Bob", Last = "Smith", Email = "bob@aol.com", MI = "K", Phone = "555-1212" });
            
        }

        public void AddCustomer(CustomerCreate customerToAdd)
        {
            // do something with that customer.
        }

        public class CustomerCreate
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string MI { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }
    }
}
