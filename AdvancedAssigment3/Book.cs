using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssigment3
{
    public delegate string BookDelegate(Book b);
    public class Book
    {
   
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public decimal Price { get; set; }




        public Book(string title, string[] authors, string isbn, DateTime publishedDate, decimal price)
        {
            Title = title;
            Authors = authors;
            ISBN = isbn;
            PublishedDate = publishedDate;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Title} by {Authors}, ISBN: {ISBN}, Published Date: {PublishedDate}";
        }

    }
}
