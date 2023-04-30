using Core.Models.DTO.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mediatr.User.Commands
{
    public class PostUserCommand : IRequest<bool>
    {
        public PostUserCommand(PostUserModel model)
        {
            Model = model;
        }
        public PostUserModel Model { get; set; }
    }
}
