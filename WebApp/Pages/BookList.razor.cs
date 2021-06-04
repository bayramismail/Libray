using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using WebApp.Core.Results;
using WebApp.Models;

namespace WebApp.Pages
{
    public partial class BookList
    {
        private BookListViewModel[] books;
        private DataResult<BookListViewModel[]> result;
        private string select;

        protected override async Task OnInitializedAsync()
        {
            result = await bookService.GetBooks();
            if (result.Success)
            {
                books = result.Data;
                toastService.ShowSuccess(result.Data.Length+" Adet Kitap Listelendi");
            }
            else
            {
                toastService.ShowError(result.Message,"Book List");
            }
        }

        private void tableAscDesc(string name, MouseEventArgs args)
        {
            select = name;

        }

        private void bookDetail(int bookId)
        {
            NavigationManager.NavigateTo("bookDetail/" + bookId);
        }

        private string tableClass(string name)
        {
            if (select == null)
            {
                select = name;
            }
            if (select == name)
            {
                return "sort asc";
            }
            return "sort";
        }
    }
}
