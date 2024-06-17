using BookSwap.Common.Repositories;

namespace BookSwap.Domain.Reservations;

public interface IReservationRepository : IRepositoryBase<Reservation,Guid>
{
}
