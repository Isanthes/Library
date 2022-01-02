 using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Antoine de Saint-Exupéry");
            Book b1 = new Book("Micul Print",1943,75.99,author);
            Console.WriteLine("Book {0} , price {1} RON, by {2}, published in {3}",b1.GetName(),b1.GetPrice(),b1.GetAuthor(),b1.GetYear());
        }
    }
}
