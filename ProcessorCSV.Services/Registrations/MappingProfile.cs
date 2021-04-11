using AutoMapper;
using ProcessorCSV.DAL.Entities;
using ProcessorCSV.Services.Models;

namespace ProcessorCSV.Services.Registrations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DocumentItem, DocumentItemModel>();
        }
    }
}
