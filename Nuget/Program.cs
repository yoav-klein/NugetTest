using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace Nuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Employee();
            bob.Name = "Bob";
            bob.Id = "300076247";
            bob.Position = "Manager";
            bob.Salary = 15000;

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(bob);
            Console.WriteLine(json);
        }
    }
}
