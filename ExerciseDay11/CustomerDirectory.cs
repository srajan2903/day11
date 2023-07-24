using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDay11
{
    public static class CustomerDirectory
    {
        public static string CustomerFolderPath { get; } = @"C:\Exercise\Day11";
        public static void CreateCustomerFolder() 
        {
            if(!Directory.Exists(CustomerFolderPath))
            {
                Directory.CreateDirectory(CustomerFolderPath);
                Console.WriteLine("customer folder created successfully");
            }
            else
            {
                Console.WriteLine("Customer folder already exist");
            }
        }

    }
}
