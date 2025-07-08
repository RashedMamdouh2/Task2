using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Book
    {

        public  string ISBN { get; set; }
        public  string Title { get; set; }
        public  double Price { get; set; }
        public  DateTime PublishedYear { get; set; }
    }
    public class PapperBook : Book
    {
        
    }
    public class EBook : Book
    {
        
    }
    public class DemoBook : Book
    {
        
    }
    public class Inventory
    {
        public List<Book> Books { get; set; }
        public void AddBook() { 
        
        
        }
        public void RemoveOutdatedBooks() { 
        
        
        }
        public void BuyABook() { 
        
        
        }
    }
}
