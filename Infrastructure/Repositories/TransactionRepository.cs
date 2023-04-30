using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class TransactionRepository : BaseRepository<TransactionEntity>, ITransactionRepository
    {
        public TransactionRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
    public interface ITransactionRepository : IBaseRepository<TransactionEntity>
    {
    }
}
