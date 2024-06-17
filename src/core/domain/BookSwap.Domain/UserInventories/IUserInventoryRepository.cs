using BookSwap.Common.Repositories;

namespace BookSwap.Domain.UserInventories;

public interface IUserInventoryRepository : IRepositoryBase<UserInventory,Guid>
{
}
