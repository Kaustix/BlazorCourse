namespace BlazorCourseClient.Mappers
{
    public static class MapperProvider
    {
        public static IMapper CreateMapper() => new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<HockeyProfile>();
        }).CreateMapper();
    }
}