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
    public class ExistUserByNationalCodeHandler : IRequestHandler<ExistUserByNationalCodeQuery, bool>
    {
        private readonly IUserRepository _userRepository;
        public ExistUserByNationalCodeHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(ExistUserByNationalCodeQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_userRepository.GetAll(a=>a.NationalCode==request.NationalCode).Any());
        }
    }
}
