using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
    }
}
