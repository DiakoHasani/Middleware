using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mediatr.User.Queries
{
    public class ExistUserByNationalCodeQuery : IRequest<bool>
    {
        public ExistUserByNationalCodeQuery(string nationalCode)
        {
            NationalCode = nationalCode;
        }
        public string NationalCode { get; set; }
    }
}
