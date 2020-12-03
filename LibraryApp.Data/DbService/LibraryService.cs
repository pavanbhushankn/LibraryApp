using LibraryApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace LibraryApp.Data.DbService
{
    /// <summary>
    /// Using simple SQLiteDB for database operations
    /// </summary>
    public class LibraryService : ILibraryService
    {
        string cs = "Data Source=./library.db;;FailIfMissing=True";
        SQLiteConnection con;

        public LibraryService()
        {

        }
        /// <summary>
        /// Create book entry
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int CreateBooks(Book book)
        {
            int res = 0;
            try
            {
                con = new SQLiteConnection(cs, true);
                con.Open();
                string query = "INSERT INTO Book (Name,Author,IsAvailable) VALUES('" + book.Name + "' ,'" + book.Author + "' ,'" + book.IsAvailable + "')";

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                res = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
            return res;

        }

        /// <summary>
        /// Get all books
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {
            List<Book> boards = new List<Book>();

            try
            {
                con = new SQLiteConnection(cs, true);
                con.Open();
                Console.WriteLine("Connected...");

                SQLiteCommand cmd = new SQLiteCommand("SELECT Id,Name, Author,IsAvailable FROM Book; ", con);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    boards.Add(new Book { Id = Convert.ToInt32(rdr["Id"]), Name = Convert.ToString(rdr["Name"]), Author = Convert.ToString(rdr["Author"]), IsAvailable = rdr["IsAvailable"] != DBNull.Value ? Convert.ToBoolean(rdr["IsAvailable"]) : false });

                    Console.WriteLine("-------------------------");
                }


                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
            return boards;

        }

    }
}
