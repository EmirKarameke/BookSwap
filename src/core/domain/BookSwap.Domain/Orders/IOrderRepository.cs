using BookSwap.Common.Repositories;

namespace BookSwap.Domain.Orders;

public interface IOrderRepository : IRepositoryBase<Order,Guid>
{
}
