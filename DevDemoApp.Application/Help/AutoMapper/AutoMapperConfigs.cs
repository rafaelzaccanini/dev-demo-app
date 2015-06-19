using AutoMapper;
using DevDemoApp.Domain;
using System.Collections.Generic;

namespace DevDemoApp.Application.AutoMapper
{
    public class AutoMapperConfigs
    {
        public static void Make()
        {
            Mapper.CreateMap<UserGroup, UserGroupDTO>();

            Mapper.CreateMap<User, UserDTO>()
                  .ForMember(dest => dest.UserGroup, opts => opts.MapFrom(src => src.UserGroup));
        }
    }
}
