using AutoMapper;
using ContactBookApplication.Entities;
using ContactBookApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Models.UserLoginDto, User>();
            CreateMap<User, Models.UserLoginDto>();
            CreateMap<Models.RegisterUserDto, User>()
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.FirstName}")
                    )
                .ForMember(
                    dest => dest.SecondName,
                    opt => opt.MapFrom(src => $"{src.SecondName}")
                    )
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => $"{src.Email}")
                    )
                .ForMember(
                    dest => dest.UserName,
                    opt => opt.MapFrom(src => $"{src.Email}")
                    )
                .ForMember(
                    dest => dest.PasswordHash,
                    opt => opt.MapFrom(src => $"{src.ConfirmedPassword}")
                    );

        }
    }
}
