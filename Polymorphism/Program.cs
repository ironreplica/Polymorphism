// See https://aka.ms/new-console-template for more information
Main();
static void Main()
{
    Book newBook = new Book();
    DVD newDvd = new DVD();
    Magazine newMagazine = new Magazine();

    newBook.GetInfo();
    newDvd.GetInfo();
    newMagazine.GetInfo();
}
class LibraryItem
{
    protected string title = "Default Title";
    protected string author = "Insert name";
    public LibraryItem(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Title: {title}, Author: {author}");
    }
}
class Book : LibraryItem
{
    private int pageCount;
    public Book() : base("Moby Dick", "Herman Melville")
    {
        this.pageCount = 256;
    }
    public override void GetInfo()
    {
        Console.WriteLine($"Page Count: {pageCount}");
    }
}

class DVD : LibraryItem
{
    private float durationInMinutes;
    public DVD() : base("Alien", "Dan O'Bannon")
    {
        this.durationInMinutes = 116f;
    }
    public override void GetInfo()
    {
        Console.WriteLine($"Duration in minutes: {durationInMinutes}");
    }
}

class Magazine : LibraryItem
{
    private int issueNumber;
    public Magazine() : base("Thrasher Magazine", "Michael Burnett")
    {
        this.issueNumber = 103;
    }
    public override void GetInfo()
    {
        Console.WriteLine($"Issue Number: {issueNumber}");
    }
}