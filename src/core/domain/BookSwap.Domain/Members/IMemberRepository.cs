using BookSwap.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.Domain.Users;

public interface IMemberRepository : IRepositoryBase<Member,Guid>
{
}
