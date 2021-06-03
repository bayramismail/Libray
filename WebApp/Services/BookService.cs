using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Services
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
            
            return await _httpClient.GetFromJsonAsync<BookListViewModel[]>("https://localhost:44354/api/Books/getAll");
        }

        public async Task Add(BookListViewModel bookListViewModel)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:44354/api​/Books​/add", bookListViewModel);
        }

        public Task Save(BookListViewModel bookListViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<BookListViewModel> GetBookById(int bookId)
        {
            return await _httpClient.GetFromJsonAsync<BookListViewModel>("https://localhost:44354/api/Books/getById");
        }
    }
}
