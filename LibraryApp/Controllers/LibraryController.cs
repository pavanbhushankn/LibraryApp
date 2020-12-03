using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Data.DbService;
using LibraryApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LibraryApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
       /// <summary>
       /// Fields
       /// </summary>
        private ILibraryService _libService;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="libService"></param>
        public LibraryController( ILibraryService libService)
        {
            _libService = libService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {

            return _libService.GetAllBooks();
        }

        /// <summary>
        /// Create books
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost]
        public int CreateBook(Book book)
        {
            return _libService.CreateBooks(book);
        }
    }
}
