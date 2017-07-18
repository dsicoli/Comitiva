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
        private FileHelperEngine<Customer> _fileHelperEngineCustomer;
        public string fileName;

        public ImportDataFromCSV()
        {
            _fileHelperEngineCustomer = new FileHelperEngine<Customer>();
        }
        public ImportDataFromCSV(string fileName)
        {
            this.fileName = fileName;
            _fileHelperEngineCustomer = new FileHelperEngine<Customer>();
        }
        public ImportDataFromCSV(FileHelperEngine<Customer> fileHelperEngineCustomer)
        {
            _fileHelperEngineCustomer = fileHelperEngineCustomer;
        }
        
        public virtual Customer[] CopyCSVFile(string inputFile)
        {
            List<Customer> customerList = new List<Customer>(_fileHelperEngineCustomer.ReadFile(inputFile));
            fileName = inputFile;
            return customerList.ToArray<Customer>();
        }
    }
}
