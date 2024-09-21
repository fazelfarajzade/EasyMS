using AutoMapper;
using EasyMS.API.ApiModels.Aauthentication;
using EasyMS.API.Models;

namespace EasyMS.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LoginModel, Account>();
    }
    }
}
