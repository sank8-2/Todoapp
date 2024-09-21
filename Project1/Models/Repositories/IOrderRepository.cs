namespace Project1.Models.Repositories
{
    public interface IOrderRepository
    {
        Task<Order?> GetOrderDetailsAsync(int? orderId);
        Task<IEnumerable<Order>> GetAllOrdersWithDetailsAsync();
    }
}
