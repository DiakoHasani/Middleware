using Core.Models.DTO.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mediatr.User.Queries
{
    public class GetUserByIdQuery : IRequest<UserModel>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
