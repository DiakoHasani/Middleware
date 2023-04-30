using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    [Table("TblTransaction")]
    public class TransactionEntity : BaseEntity
    {
        public long Befor { get; set; } = 0;
        public long Amount { get; set; } = 0;
        public long After { get; set; } = 0;
        public int UserId { get; set; }
        public TransactionType TransactionType { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual UserEntity User { get; set; }
    }
}
