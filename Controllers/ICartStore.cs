

using System.Threading.Tasks;

namespace StoreManager.Controllers
{
    public interface ICartStore
    {
        Task InitializeAsync();

        Task AddItemAsync(string userId, string productId, int quantity);
        Task EmptyCartAsync(string userId);

        //Task<Hipstershop.Cart> GetCartAsync(string userId);

        bool Ping();
    }
}