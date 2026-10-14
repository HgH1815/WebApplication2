using AutoMapper;
using WebApplication2.Models;

namespace WebApplication2.Mapping
{
    public class FriendProfile : Profile
    {
        public FriendProfile()
        {
            CreateMap<Friend, FriendViewModel>();
            CreateMap<FriendViewModel, Friend>();
        }
    }
}