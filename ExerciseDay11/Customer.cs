using System;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDay11
{
    [Serializable]

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Customer() { }

        public Customer(int id, string name, DateTime dob)
        {
            Id = id;
            Name = name;
            DateOfBirth = dob;
        }
    }
}
