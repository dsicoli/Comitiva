using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace ConsoleApp1.Model
{
    [DelimitedRecord(",")]
    public class Customer
    {
        //public int CustId;

        //public string Name;

        //public decimal Balance;

        //[FieldConverter(ConverterKind.Date, "dd-MM-yyyy")]
        //public DateTime AddedDate;

        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string BirthCity { get; set; }
    }
}
