using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mediatr.User.Queries
{
    public class ExistUserByUserNameQuery : IRequest<bool>
    {
        public ExistUserByUserNameQuery(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }
    }
}
