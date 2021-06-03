using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Services
{
    public interface IBookService
    {
        Task<BookListViewModel[]> GetBooks();
        Task Add(BookListViewModel bookListViewModel);
        Task Save(BookListViewModel bookListViewModel);
        Task<BookListViewModel> GetBookById(int bookId);
    }
}
