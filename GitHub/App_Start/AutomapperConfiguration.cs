using AutoMapper;
using GigHub.Dtos;
using GitHub.Models;

namespace GitHub.App_Start
{
    public static class AutomapperConfiguration
    {
        public static void Initialize()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<ApplicationUser, UserDto>();
                c.CreateMap<Gig, GigDto>();
                c.CreateMap<Notification, NotificationDto>();
            });
        }
    }
}