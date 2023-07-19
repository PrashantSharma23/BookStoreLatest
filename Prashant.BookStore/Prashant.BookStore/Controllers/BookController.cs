using Microsoft.AspNetCore.Mvc;
using Prashant.BookStore.Models;
using Prashant.BookStore.Repository;

namespace Prashant.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
        public BookModel GetBooks(int id)
        {
            //return $"book no: ={id}";
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBook(string bookname, string author)
        {
            return _bookRepository.SearchBook(bookname, author);
        }
    }
}
