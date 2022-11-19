using AutoMapper;
using RepositoryPatternHW.Domain.Entities;
using RepositoryPatternHW.ServiceLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternHW.ServiceLayer.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AnimationMovie, AnimationDto>().ReverseMap();
        }
    }
}
