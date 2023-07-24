using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace CustomerFileManager.Tests
{
    [TestClass]
    public class CustomerFileMnagerTests
    {
        [TestMethod]
        public void TestWriteAndReadCustomer()
        {
            Customer customer = new Customer(1, "John", new DateTime(1990, 5, 15));
            CustomerFileManager.WriteCustomerToFile(customer);

          
            
            Customer retrievedCustomer = CustomerFileManager.ReadCustomerFromFile("John_19900515.dat");
            Assert.AreEqual(customer.Id, retrievedCustomer.Id);
            Assert.AreEqual(customer.Name, retrievedCustomer.Name);
            Assert.AreEqual(customer.DateOfBirth, retrievedCustomer.DateOfBirth);


        }
    }
}