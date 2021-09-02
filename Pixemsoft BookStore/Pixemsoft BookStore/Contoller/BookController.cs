using Microsoft.AspNetCore.Mvc;
using Pixemsoft_BookStore.Model;
using Pixemsoft_BookStore.Model.Repositroy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pixemsoft_BookStore.Contoller
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookrepository=null;
        public BookController()
        {
            _bookrepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data= _bookrepository.getallBooks();
            return View();
        }
        public BookModel getabooks(int id)
        {
            return _bookrepository.GetbookbyID(id);
        }
        public List<BookModel> searchbook(string bokname, string authothername)
        {
            return _bookrepository.searchbook(bokname, authothername);
        }
    }
}
