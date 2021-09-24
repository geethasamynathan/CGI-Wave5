using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CGI_MongowithAPI.Models;
using CGI_MongowithAPI.Services;




namespace CGI_MongowithAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService bookService;
        public BooksController(BookService service)
        {
            bookService = service;
        }

        [HttpGet]
        public List<Book> Get() =>
            bookService.Get();

        [HttpGet("{id:length(24)}",Name="GetBook")] 
        public Book GetBook(string id)
        {
            var book = bookService.Get(id);
            
            return book;
        }
        [HttpPost]
        public Book Create(Book book)
        {
            bookService.Create(book);
            return book;
           // return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }
        [HttpPut("{id:length(24)}")]
        public void Update(string id, Book mbook)
        {
            bookService.Update(id,mbook);

        }
        [HttpDelete("{id:length(24)}")]
        public void Delete(string id)
        {
            bookService.Remove(id);
        }
    }
}
