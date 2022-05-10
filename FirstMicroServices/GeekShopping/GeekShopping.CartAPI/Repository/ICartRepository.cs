using GeekShopping.CartAPI.Data.ValueObjects;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartVO> FindCartByUserId(string userId);
        Task<CartVO> SaveOrUpdateCart(CartVO cart);
        Task<bool> RemoveFromCart(long carDetailsId);
        Task<bool> ApplyCoupon(long userId, string couponCode);
        Task<bool> RemovesCoupon(long userId);
        Task<bool> ClearCart(string userId);
    }
}
