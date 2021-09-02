using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pixemsoft_BookStore.Model.Repositroy
{
    public class BookRepository
    {
        public List<BookModel> getallBooks()
        {
            return datasource();
        }
        public BookModel GetbookbyID(int ID)
        {
            return datasource().Where(x => x.id == ID).FirstOrDefault();
        }
        public List<BookModel> searchbook(string title, string author)
        {
            return datasource().Where(x => x.Title == title || x.Author == author).ToList();
        }
        private List<BookModel> datasource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ id=1,Title="MVC",Author="Javed"},
                 new BookModel(){ id=2,Title="Englis",Author="Ali"},
                  new BookModel(){ id=3,Title="Math",Author="hader"},
                   new BookModel(){ id=4,Title="Computer",Author="fahad"},
                    new BookModel(){ id=5,Title="Java",Author="khan"},
            };
        
        }
    }
}
