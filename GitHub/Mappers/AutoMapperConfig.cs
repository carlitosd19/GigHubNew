using AutoMapper;
using GigHub.Dtos;
using GitHub.Models;

namespace GitHub.Mappers
{
    public static class AutoMapperConfig
    {
        public static void InitializeAutomapper()
        {
            Mapper.Initialize(cfg => { cfg.CreateMap<ApplicationUser, UserDto>(); });
            Mapper.Initialize(cfg => { cfg.CreateMap<Gig, GigDto>(); });
            Mapper.Initialize(cfg => { cfg.CreateMap<Notification, NotificationDto>(); });
        }
    }
}