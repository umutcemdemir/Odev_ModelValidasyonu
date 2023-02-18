using Microsoft.EntityFrameworkCore;
using ModelValidasyonu.DbOperations;
using System.Reflection;

namespace ModelValidasyonu.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddDbContext<BookStoreDbContext>(options
                => options.UseInMemoryDatabase(databaseName: "BookStoreDb"));


            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
