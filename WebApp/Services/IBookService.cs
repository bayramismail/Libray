using System.Threading.Tasks;
using WebApp.Core.Results;
using WebApp.Models;

namespace WebApp.Services
{
    public interface IBookService
    {
        Task<DataResult<BookListViewModel[]>> GetBooks();
        Task Add(BookListViewModel bookListViewModel);
        Task Save(BookListViewModel bookListViewModel);
        Task<BookListViewModel> GetBookById(int bookId);
    }
}
