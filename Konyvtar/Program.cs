namespace Konyvtar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözlünk a könyvtárban!");

            Book[] books = new Book[]
            {
                new Book ("A kis herceg","Antoine de Saint-Exupéry",96,1943),
                new Book ("Az aranyember","Jókai Mór",400,1869),
                new Book ("Az ember tragédiája","Madách Imre",200,1861),
            };

            Console.WriteLine(GetBookByTitle(books, "Az aranyember"));
            books[0].EditBookData();
            Console.WriteLine(books[0]);
        }
        static Book GetBookByTitle(Book[] books, string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }

            return null;
        }
    }
}
