using System.Collections.Generic;
using CS321_W3D1_BookAPI.Models;

namespace CS321_W3D1_BookAPI.Services
{
    public interface IBookService
    {
        // CRUDL - create (add), read (get), update, delete (remove), list

        // create
        Book Add(Book book); 
        // read
        Book Get(int id);
        // update
        Book Update(Book book); 
        // delete
        void Remove(Book book);
        // list
        IEnumerable<Book> GetAll();
    }
}
