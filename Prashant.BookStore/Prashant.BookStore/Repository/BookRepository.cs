using Prashant.BookStore.Models;

namespace Prashant.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().FirstOrDefault(x => x.Id == id);
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title == title && x.Author == author).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id=1,Title="MVC",Author="John",Description="MVC Book"},
                new BookModel() {Id=2,Title="C#",Author="Smith",Description="C# Book"},
                new BookModel() {Id=3,Title="JAVA",Author="Lee",Description="JAVA Book"},
                new BookModel() {Id=4,Title="Php",Author="sumit",Description="PHP Book"},
                new BookModel() {Id=5,Title="Python",Author="rohit",Description="Python Book"},



            };
        }
    }
}
