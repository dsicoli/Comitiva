using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ConsoleApp1.Model;
using PeopleMatches.InputDataClasses;
using FileHelpers;
using System.Collections.Generic;

namespace PeopleMatchesTests
{
    [TestClass]
    public class ImportDataFromCSVTests
    {
        [TestMethod]
        public void Customer_WtihInputStrings_StoredStrings()
        {
            //Arrange
            var customer = new Customer();
            //Act
            customer.Name = "Pino";
            customer.Age = "16";
            customer.Sex = "Male";
            customer.BirthCity = "Genova";
            //Assert
            Assert.AreEqual(customer.Name,"Pino");
            Assert.AreEqual(customer.Age , "16");
            Assert.AreEqual(customer.BirthCity, "Genova");
        }

        [TestMethod]
        public void ImportDataFromCSV_WithInputString_OutputStringIsCustomerArray()
        {
            //Arrange
            Customer[] customers = new Customer[]
                {
                    new Customer() { Name = "Pino", Age = "16", Sex = "male", BirthCity = "Genova"},
                    new Customer() { Name = "Anna", Age = "36", Sex = "female", BirthCity = "Alba"},
                    new Customer() { Name = "Giovanni", Age = "56", Sex = "male", BirthCity = "Amantea"}
                };

            FileHelperEngine<Customer> fileHelperCust = new FileHelperEngine<Customer>();
            var mockReadFile = new Mock<ImportDataFromCSV>();
            mockReadFile
                .Setup(o => o.CopyCSVFile("TestFile.csv"))
                .Returns(customers);

            //Act
            ImportDataFromCSV import = new ImportDataFromCSV();
            
            Customer[] customersResult =  mockReadFile.Object.CopyCSVFile("TestFile.csv");

            //Assert
            Assert.AreEqual(customersResult[0].Name, "Pino");
            Assert.AreEqual(customersResult[1].Name, "Anna");
            Assert.AreEqual(customersResult[2].Name, "Giovanni");
        }
    }
}
