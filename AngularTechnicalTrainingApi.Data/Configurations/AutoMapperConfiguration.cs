using AngularTechnicalTrainingApi.Domain.Models;
using AngularTechnicalTrainingApi.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Data.Configurations
{
    public class AutoMapperConfiguration: Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Asset, AssetDTO>().ReverseMap();
            CreateMap<AssetType, AssetTypeDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<NewAssetDTO, Asset>().ReverseMap();
        }
    }
}
