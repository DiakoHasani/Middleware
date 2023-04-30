using Core.Mediatr.User.Queries;
using Core.Models.DTO.User;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CacheServices
{
    internal class UserCache : IUserCache
    {
        private const string Key = "User_";

        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions _options;
        private readonly IMediator _mediator;
        public UserCache(IMemoryCache memoryCache,
            IMediator mediator)
        {
            _memoryCache = memoryCache;
            _mediator = mediator;
            _options = new MemoryCacheEntryOptions
            {
                SlidingExpiration = TimeSpan.FromMinutes(10),
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20)
            };
        }

        public void Add(UserModel userModel)
        {
            try
            {
                _memoryCache.Set($"{Key}{userModel.Id}", userModel, _options);
            }
            catch (Exception) { }
        }

        public async Task<UserModel> Get(int userId)
        {
            try
            {
                UserModel user;
                if (!_memoryCache.TryGetValue($"{Key}{userId}", out user))
                {
                    user = await _mediator.Send(new GetUserByIdQuery(userId));
                    if (user is null)
                        return null;
                    Add(user);
                }
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
    public interface IUserCache
    {
        void Add(UserModel userModel);
        Task<UserModel> Get(int userId);
    }
}
