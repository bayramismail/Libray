using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApp.Core.Results;
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

        public async Task<DataResult<BookListViewModel[]>> GetBooks()
        {
            var result =
                await _httpClient.GetFromJsonAsync<DataResult<BookListViewModel[]>>(
                    _httpClient.BaseAddress+"api/Books/getAll");
            return result;


        }

        public async Task Add(BookListViewModel bookListViewModel)
        {
            await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress+"api​/Books​/add", bookListViewModel);
        }

        public Task Save(BookListViewModel bookListViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<BookListViewModel> GetBookById(int bookId)
        {
            return await _httpClient.GetFromJsonAsync<BookListViewModel>(_httpClient.BaseAddress+"/api/Books/getById?bookId="+bookId);
        }
    }
}
