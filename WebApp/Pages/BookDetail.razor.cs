using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WebApp.Models;

namespace WebApp.Pages
{
    public partial class BookDetail
    {
        private BookListViewModel listViewModel;
        [Parameter]
        public int bookId { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (bookId != 0)
            {
                listViewModel = await BookService.GetBookById(bookId);
            }
        }
    }
}
