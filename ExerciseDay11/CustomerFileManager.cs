using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDay11
{
    public class CustomerFileManager
    {
        public static void WriteCustomerToFile(Customer customer)
        {
            string fileName = $"{customer.Name}_{customer.DateOfBirth:yyyyMMdd}.dat";
            string filePath = Path.Combine(CustomerDirectory.CustomerFolderPath, fileName);
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, customer);
                Console.WriteLine("Customer details saved successfully");
            }
        }
        public static Customer ReadCustomerFromFile(string fileName)
        {
            string filePath = Path.Combine(CustomerDirectory.CustomerFolderPath, fileName); 
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                return (Customer)formatter.Deserialize(stream);
            }
        }
    }
}
