using AutoMapper;
using Contactista.DataAccess.DTO;
using Contactista.Domain;

namespace Contactista.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
