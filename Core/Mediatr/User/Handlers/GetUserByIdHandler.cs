using AutoMapper;
using Core.Mediatr.User.Queries;
using Core.Models.DTO.User;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mediatr.User.Handlers
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetUserByIdHandler(IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<UserModel>(await _userRepository.GetByIdAsync(request.Id));
        }
    }
}
