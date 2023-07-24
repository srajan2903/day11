using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace TestProject1
{
    [TestClass]
    public class CustomerFileManagerTests
    {
        public object CustomerFileManager { get; private set; }

        [TestMethod]
        public void TestWriteAndReadCustomer()
        {
            Customer customer = new Customer(1, "John", new DateTime(2001, 5, 15));
            CustomerFileManager.WriteCustomerToFile(customer);
            Customer retrivedCustomer = CustomerFileManager.ReadCustomerFromFile("John_19900515.dat");
            Assert.AreEqual(customer.Id, retrievedCustomer.Id);
            Assert.AreEqual(customer.Name, retrievedCustomer.Name);
            Assert.AreEqual(customer.DateOfBirth, retrievedCustomer.DateOfBirth);



        }
    }
}