using BlazorCourseClient.Contracts;
using BlazorCourseClient.Models;

namespace BlazorCourseClient.Mappers
{
    public class HockeyProfile : Profile
    {
        public HockeyProfile()
        {
            CreateMap<TeamDto, Team>();
        }
    }
}