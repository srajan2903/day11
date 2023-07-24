using CustomerFileManager.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class CustomerFileManagerTests
    {
        [TestInitialize]
        public void Initialize()
        {
            ExerciseDay11.CustomerDirectory.CreateCustomerFolder();
        }

        [TestMethod]
        public void TestWriteAndReadCustomer()
        {
            // Arrange
            ExerciseDay11.Customer customer = new ExerciseDay11.Customer(1, "John", new DateTime(2001, 5, 15));

            // Act
            ExerciseDay11.CustomerFileManager.WriteCustomerToFile(customer);
            ExerciseDay11.Customer retrievedCustomer = ExerciseDay11.CustomerFileManager.ReadCustomerFromFile("John_20010515.dat");

            // Assert
            Assert.AreEqual(customer.Id, retrievedCustomer.Id);
            Assert.AreEqual(customer.Name, retrievedCustomer.Name);
            Assert.AreEqual(customer.DateOfBirth, retrievedCustomer.DateOfBirth);
        }
    }
}