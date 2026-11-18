
Book book1 = new Book("Harry Potter", "J.K. Rowling");
Book book2 = new Book("The Alchemist", "Paulo Coelho");

Console.WriteLine("LIBRARY MANAGEMENT SYSTEM");
Console.WriteLine("-------------------------");

Console.WriteLine("Book 1: " + book1.Title);
Console.WriteLine("Borrow: " + book1.Borrow());

Console.WriteLine("Borrow again: " + book1.Borrow());

Console.WriteLine("Return book: " + book1.ReturnBook());

Console.WriteLine("Book 2: " + book2.Title);
Console.WriteLine("Borrow: " + book2.Borrow());

Console.WriteLine("Book 1 Available: " + book1.IsAvailable);
Console.WriteLine("Book 2 Available: " + book2.IsAvailable);
