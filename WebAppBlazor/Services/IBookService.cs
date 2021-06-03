using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBlazor.Models;

namespace WebAppBlazor.Services
{
    public interface IBookService
    {
        Task<BookListViewModel[]> GetBooks();
        Task Add(BookListViewModel bookListView);
        Task Save(BookListViewModel bookListViewModel);
        Task<BookListViewModel> GetBookById(int bookId);
    }
}
