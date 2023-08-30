namespace ConsoleApp1
{
    class Library
    {
        private List<Book> AllBooks { get; set; }

        public Library()
        {
            AllBooks = new List<Book>();
        }

        public void AddBooks(Book book)
        {
            AllBooks.Add(book);
        }

        public void ShowAllBooks()
        {
            foreach (Book book in AllBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
