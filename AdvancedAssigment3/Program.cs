namespace AdvancedAssigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>();



            Console.WriteLine("Enter the number of books : ");

            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Enter the book {i + 1} Details: ");

                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();

                Console.Write("Publication Date : ");
                DateTime.TryParse(Console.ReadLine(), out DateTime pubDate);

                Console.Write("Price: ");
                decimal.TryParse(Console.ReadLine(), out decimal price);

                Console.Write("Number of Authors: ");
                int.TryParse(Console.ReadLine(), out int authorCount);

                string[] authors = new string[authorCount];
                for (int j = 0; j < authorCount; j++)
                {
                    Console.Write($"Author {j + 1} Name: ");
                    authors[j] = Console.ReadLine();
                }

                library.Add(new Book(title, authors, isbn, pubDate, price));
            }


            Console.WriteLine("\n Books Details: ");

            Engine.ProcessBooks(library, new BookDelegate(BookFunctions.GetTitle));

            Engine.ProcessBooks(library, BookFunctions.GetISBN);

            Engine.ProcessBooks(library, BookFunctions.GetPublishedDate);
        }
    }
}
