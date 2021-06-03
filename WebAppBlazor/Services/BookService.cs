using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebAppBlazor.Models;

namespace WebAppBlazor.Services
{
    public class BookService:IBookService
    {
        private HttpClient _httpClient;

        public BookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BookListViewModel[]> GetBooks()
        {
            
            return await _httpClient.GetFromJsonAsync<BookListViewModel[]>("http://bayram.somee.com/api/bookTypes/getall");
        }

        public Task Add(BookListViewModel bookListView)
        {
            throw new NotImplementedException();
        }

        public Task Save(BookListViewModel bookListViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<BookListViewModel> GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
