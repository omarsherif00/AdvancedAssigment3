using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssigment3
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {

            return B.Title;
        }

        public static string[] GetAuthors(Book B)
        {
            return B.Authors;
        }

        public static string GetPrice(Book B)
        {

            return B.Price.ToString("C");
        }


        public static BookDelegate GetISBN = delegate (Book B)
        {
            return B.ISBN;
        };

        public static BookDelegate GetPublishedDate = (Book B) => B.PublishedDate.ToShortDateString();


    }
}
