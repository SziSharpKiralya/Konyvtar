using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar
{
    internal class Book
    {
        private string title;
        private string author;
        private int pageCount;
        private int releaseYear;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }

        public Book(string title, string author, int pageCount, int releaseYear)
        {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.releaseYear = releaseYear;
        }

        public void EditBookData()
        {
            Console.Write("Title:");
            title = Console.ReadLine().ToString();
            Console.Write("Author:");
            author = Console.ReadLine().ToString();
            Console.Write("Page count:");
            pageCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("ReleaseYear:");
            releaseYear = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({ReleaseYear}), {PageCount} pages";
        }
    }
}
