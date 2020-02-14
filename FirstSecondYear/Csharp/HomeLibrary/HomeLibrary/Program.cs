using System;

namespace HomeLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book { Name = "Mr. Penumbra's 24Hour Bookstore", Auctor = "Robin Sloan", Year = 2013, Genus = "Adventure" },
                new Book { Name = "White fang", Auctor = "Jack London", Year = 1906, Genus = "Adventure" },
                new Book { Name = "The call of Cthulhu", Auctor = "Howard Lovecraft", Year = 1928, Genus = "Horor" },
                new Book { Name = "Dagon", Auctor = "Howard Lovecraft", Year = 1919, Genus = "Horor" },
                new Book { Name = "The black cat", Auctor = "Edgar Allan Poe", Year = 1843, Genus = "Horor" }
            };

            Library library = new Library(books);

            Console.WriteLine("All library:");
            library.Print();
            library.AddBook(new Book { Name = "The gold bug", Auctor = "Edgar Allan Poe", Year = 1843, Genus = "Detective" });
            Console.WriteLine("\nUpdated library:");
            library.Print();
            library.RemuveBook(new Book { Name = "Mr. Penumbra's 24Hour Bookstore", Auctor = "Robin Sloan", Year = 2013, Genus = "Adventure" });
            Console.WriteLine("\nUpdated library:");
            library.Print();

            Console.WriteLine("\nSearch for books:");
            library.FindByName("The gold bug");
            library.FindByYear(1950);
            library.FindByAuctor("Lina Kostenko");
            library.FindByGenus("Drama");

            Console.WriteLine("\nThe second book is on the list:");
            Console.WriteLine(library[1]);

            Console.ReadKey();
        }
    }
}
