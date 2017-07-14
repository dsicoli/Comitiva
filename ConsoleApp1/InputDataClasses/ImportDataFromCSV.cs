using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using FileHelpers;

namespace PeopleMatches.InputDataClasses
{
    public class ImportDataFromCSV
    { 
        public virtual Customer[] CopyCSVFile(string inputFile)
        {
            FileHelperEngine<Customer> file = new FileHelperEngine<Customer>();
            List<Customer> customerList = new List<Customer>(file.ReadFile(inputFile));
            return customerList.ToArray<Customer>();
        }
    }
}
