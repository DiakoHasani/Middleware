using AutoMapper;
using Common.Helpers;
using Core.Mediatr.User.Commands;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mediatr.User.Handlers
{
    public class PostUserHandler : IRequestHandler<PostUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PostUserHandler> _logger;
        public PostUserHandler(IUserRepository userRepository,
            IMapper mapper,
            ILogger<PostUserHandler> logger)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> Handle(PostUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _userRepository.Add(_mapper.Map<UserEntity>(request.Model));
                return await _userRepository.SaveChangeAsync() > 0;
            }
            catch (Exception ex)
            {
                _logger.LogException(ex);
                return false;
            }
        }
    }
}
