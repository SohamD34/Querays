using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Querays.databases;
using Querays.Services;

namespace Querays.Pages
{
    public class BooksModel : PageModel
    {
        private readonly ILogger<BooksModel> _logger;
        public JsonFileBookService BooksService;
        public IEnumerable<Book> Books { get; private set; }
        public BooksModel(
            ILogger<BooksModel> logger,
            JsonFileBookService bookService
            )
        {
            _logger = logger;
            BooksService = bookService;
        }

        public void OnGet()
        {
            Books = BooksService.GetProducts();
        }
    }
}
