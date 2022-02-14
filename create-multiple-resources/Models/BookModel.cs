namespace create_multiple_resources.Models
{
    public record BookRequest(string Name, string Isbn);

    public record BookModel(int Id, string Name, string Isbn);

    public record MultipleBooksBase(string Status);

    public record MultipleBooksErrorModel(string Status, string Message) : MultipleBooksBase(Status);

    public record MultipleBooksModel(string Status, BookModel Message) : MultipleBooksBase(Status);
}