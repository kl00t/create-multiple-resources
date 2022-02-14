using create_multiple_resources.Models;

namespace create_multiple_resources.Services
{
    public interface IBookService
    {
        IEnumerable<MultipleBooksBase> CreateBooks(IEnumerable<BookRequest> bookRequests);
    }
}