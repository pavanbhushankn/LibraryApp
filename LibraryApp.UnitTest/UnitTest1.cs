using LibraryApp.Controllers;
using LibraryApp.Data.DbService;
using LibraryApp.Data.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp.UnitTest
{
    public class Tests
    {
        ILibraryService libService;
       

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckBooksReturnsNonNegativeCount()

        {
            //Arrange
            libService = new LibraryService();
            List<Book> books = new List<Book>();

            //Act
            int counts = libService.GetAllBooks().Count;

            //Assert
            Assert.AreEqual(true, counts>=0);
            
            
        }
    }
}