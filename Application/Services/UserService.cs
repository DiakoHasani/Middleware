using Application.CacheServices;
using Common.Helpers;
using Common.Utilities;
using Core.Mediatr.User.Commands;
using Core.Mediatr.User.Queries;
using Core.Models.DTO.User;
using Core.Models.General;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class UserService : IUserService
    {
        private readonly IMediator _mediator;
        private readonly IUserCache _userCache;
        public UserService(IMediator mediator,
            IUserCache userCache)
        {
            _mediator = mediator;
            _userCache = userCache;
        }
        public async Task<MessageModel> AddUser(PostUserModel model)
        {
            model.UserName = model.UserName.GetEnglishNumber();
            model.Password = model.Password.GetEnglishNumber();
            model.NationalCode = model.NationalCode.GetEnglishNumber();

            if (await _mediator.Send(new ExistUserByUserNameQuery(model.UserName)))
            {
                return new MessageModel
                {
                    Message = "username is already exist"
                };
            }

            if (await _mediator.Send(new ExistUserByNationalCodeQuery(model.NationalCode)))
            {
                return new MessageModel
                {
                    Message = "nationalcode is already exist"
                };
            }

            model.Password = PasswordUtility.Encrypt(model.Password);

            var resultAdd = await _mediator.Send(new PostUserCommand(model));

            if (!resultAdd)
            {
                return new MessageModel
                {
                    Message = "error in add user to database"
                };
            }

            return new MessageModel
            {
                Result = true,
                Message = "successful added user"
            };
        }

        public async Task<UserModel> GetUserById(int id)
        {
            return await _userCache.Get(id);
        }
    }
    public interface IUserService
    {
        Task<MessageModel> AddUser(PostUserModel model);
        Task<UserModel> GetUserById(int id);
    }
}
