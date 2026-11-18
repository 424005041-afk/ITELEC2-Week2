
class Book
{
    public string Title { get; }
    public string Author { get; }
    public bool IsAvailable { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public bool Borrow()
    {
        if (!IsAvailable)
        {
            return false;
        }

        IsAvailable = false;
        return true;
    }

    public bool ReturnBook()
    {
        if (IsAvailable)
        {
            return false;
        }

        IsAvailable = true;
        return true;
    }
}
