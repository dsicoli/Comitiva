using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using ConsoleApp1.Model;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var engine = new FileHelperEngine<Customer>();

            //// To Read Use:
            //IList<Customer> result = engine.ReadFile("InputDataCustomers.txt").ToList<Customer>();
            //// result is now an array of Customer

            //// To Write Use:
            //engine.WriteFile("OutputDataCustomers.txt", result);
            
            //foreach (Customer cust in result)
            //{
            //    Console.WriteLine("Customer Info:");
            //    Console.WriteLine(cust.Name + " - " +
            //    cust.AddedDate.ToString("dd/MM/yy"));
            //}

            ReadKey();
        }
    }
}
