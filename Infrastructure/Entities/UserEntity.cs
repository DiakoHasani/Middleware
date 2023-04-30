using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    [Table("TblUser")]
    public class UserEntity : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = "";

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = "";

        [Required]
        [MaxLength(10)]
        public string NationalCode { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; } = "";

        [Required]
        [MaxLength(2000)]
        public string Password { get; set; } = "";

        public virtual ICollection<TransactionEntity> Transactions { get; set; }
    }
}
