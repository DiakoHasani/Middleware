using Core.Mediatr.User.Queries;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mediatr.User.Handlers
{
    public class ExistUserByUserNameHandler : IRequestHandler<ExistUserByUserNameQuery, bool>
    {
        private readonly IUserRepository _userRepository;
        public ExistUserByUserNameHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(ExistUserByUserNameQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_userRepository.GetAll(a => a.UserName == request.UserName).Any());
        }
    }
}
