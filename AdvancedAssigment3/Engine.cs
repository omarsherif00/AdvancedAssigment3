using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssigment3
{
    public class Engine
    {
        public static void ProcessBooks(List<Book> bList, BookDelegate fptr)
        {

            foreach (Book b in bList)
            {
                Console.WriteLine(fptr(b));
            }


        }

        public static void ProcessBooks(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (var b in books)
                Console.WriteLine(fPtr(b));
        }
    }
}
