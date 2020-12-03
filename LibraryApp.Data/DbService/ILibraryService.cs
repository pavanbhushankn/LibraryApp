using LibraryApp.Data.Models;
using System.Collections.Generic;

namespace LibraryApp.Data.DbService
{
    public interface ILibraryService
    {
        List<Book> GetAllBooks();
        int CreateBooks(Book book);
    }
}