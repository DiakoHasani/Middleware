using AutoMapper;
using Core.Models.DTO.User;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapper
{
    internal class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();

            CreateMap<PostUserModel, UserEntity>();
            CreateMap<UserEntity, PostUserModel>();
        }
    }
}
