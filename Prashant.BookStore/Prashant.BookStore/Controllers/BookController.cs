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
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }
        //public BookModel GetBooks(int id)
        //{
        //    //return $"book no: ={id}";
        //    return _bookRepository.GetBookById(id);
        //}
        public ViewResult GetBooks(int id)
        {
            var bookdata = _bookRepository.GetBookById(id);
            return View(bookdata);
        }
        public List<BookModel> SearchBook(string bookname, string author)
        {
            return _bookRepository.SearchBook(bookname, author);
        }
    }
}
