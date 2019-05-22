using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCourseClient.Models;

namespace BlazorCourseClient.Api
{
    public interface IHockeyApi
    {
        Task<List<Team>> GetTeams();
        Task<List<LogoDto>> GetLogos();
    }
}