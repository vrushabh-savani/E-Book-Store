using BookStore.Models.ViewModels;

namespace BookStore.Repository
{
    public class BaseRepository
    {
       protected readonly myBookStoreContext _context = new myBookStoreContext();
    }
}
