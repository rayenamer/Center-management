using AutoMapper;
using Domain.Dtos;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Mapper
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            #region Map Batiment
            CreateMap<Batiment, BatimentDto>()
                .ForMember(m => m.Libellé_centre, i => i.MapFrom(src => src.Centre.Libellé_centre))
                .ReverseMap();
            #endregion
                      
  


        }
    }
}

