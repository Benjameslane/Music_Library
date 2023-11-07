using System.Runtime.CompilerServices;

namespace MusicLibraryWebAPI.Extensions
{
    public static class ServiceExtensions
    {
      
        public static void ConfigureCorrs(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
    }
}
