using Anyar.DataAccesLayer;
using Microsoft.EntityFrameworkCore;

namespace Anyar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AnyarContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute("areas","{area:exists}/{controller=Employee}/{action=Index}/{id?}");
            app.MapControllerRoute("Default" ,"{controller=Home}/{action=Index}/{id?}" );

            app.Run();
        }
    }
}
