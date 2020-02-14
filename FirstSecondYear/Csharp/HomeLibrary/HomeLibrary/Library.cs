using System;

namespace HomeLibrary
{
    class Library
    {
        private int bookCount;
        private Book[] books;

        public int BookCount
        {
            get { return bookCount; }
            private set { bookCount = value; }
        }
        public Book this[int i]
        {
            get
            {
                if (i < bookCount && i >= 0)
                    return books[i];
                else
                    throw new Exception("There is no item on this number.");
            }
            set
            {
                if (i < bookCount && i >= 0)
                    books[i] = value;
                else
                    throw new Exception("There is no such index.");
            }
        }

        public Library(Book[] books)
        {
            this.books = books;
            bookCount = books.Length;
        }

        public void AddBook(Book book)
        {
            Book[] tmp_books = new Book[bookCount + 1];
            for (int i = 0; i < bookCount; i++)
            {
                tmp_books[i] = books[i];
            }
            tmp_books[bookCount] = book;
            books = tmp_books;
            bookCount++;
        }
        public void RemuveBook(Book book)
        {
            Book[] tmp_books = new Book[bookCount - 1];
            int remIndx = -1;
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i] == book)
                {
                    remIndx = i;
                    break;
                }
            }
            if (remIndx == -1)
                throw new Exception("This book is`t in the library.");
            for (int i = 0; i < remIndx; i++)
            {
                tmp_books[i] = books[i];
            }
            for (int i = remIndx; i < bookCount - 1; i++)
            {
                tmp_books[i] = books[i + 1];
            }
            books = tmp_books;
            bookCount--;
        }

        public void FindByName(string name)
        {
            int numberOfMatches = 0;
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Name == name)
                {
                    Console.WriteLine(books[i]);
                    numberOfMatches++;
                }
            }
            if (numberOfMatches == 0)
                Console.WriteLine("No books with name " + name + " found.");
        }
        public void FindByAuctor(string auctor)
        {
            int numberOfMatches = 0;
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Auctor == auctor)
                {
                    Console.WriteLine(books[i]);
                    numberOfMatches++;
                }
            }
            if (numberOfMatches == 0)
                Console.WriteLine(auctor + " books not found.");
        }
        public void FindByYear(int year)
        {
            int numberOfMatches = 0;
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Year == year)
                {
                    Console.WriteLine(books[i]);
                    numberOfMatches++;
                }
            }
            if (numberOfMatches == 0)
                Console.WriteLine("No books found in "+ year + ".");
        }
        public void FindByGenus(string genus)
        {
            int numberOfMatches = 0;
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Genus == genus)
                {
                    Console.WriteLine(books[i]);
                    numberOfMatches++;
                }
            }
            if (numberOfMatches == 0)
                Console.WriteLine("No books found for " + genus + " genre.");
        }

        public void Print()
        {
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
    }

    class Book
    {
        private string name;
        private string auctor;
        private int year;
        private string genus;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Auctor
        {
            get { return auctor; }
            set { auctor = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Genus
        {
            get { return genus; }
            set { genus = value; }
        }

        public Book()
        {
            name = "";
            auctor = "";
            year = 0;
            genus = "";
        }
        public Book(string name, string auctor, int year, string genus)
        {
            this.name = name;
            this.auctor = auctor;
            this.year = year;
            this.genus = genus;
        }

        public static bool operator ==(Book book1, Book book2)
        {
            if (book1.name == book2.name ||
                book1.auctor == book2.auctor ||
                book1.year == book2.year ||
                book1.genus == book2.genus)
                return true;
            else return false;
        }
        public static bool operator !=(Book book1, Book book2)
        {
            return !(book1 == book2);
        }
        public override string ToString()
        {
            return auctor + " " + '"' + name + '"' + " " + year + " " + genus;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Book book = (Book)obj;
            return (this == book);
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}