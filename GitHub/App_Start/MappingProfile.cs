namespace GitHub.App_Start
{
    using AutoMapper;
    using GigHub.Dtos;
    using GitHub.Models;

    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
            Mapper.CreateMap<Gig, GigDto>();
            Mapper.CreateMap<Notification, NotificationDto>();
        }
    }
}