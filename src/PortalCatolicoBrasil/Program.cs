<<<<<<< HEAD
using PortalCatolicoBrasil.Interfaces;
=======
using Microsoft.EntityFrameworkCore;
using PortalCatolicoBrasil.Interfaces;
using PortalCatolicoBrasil.Models;
>>>>>>> dc9fda35176c673ccf55f90f1df00d5f12eb0564
using PortalCatolicoBrasil.Service;

namespace PortalCatolicoBrasil
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            builder.Services.AddHttpClient<ILiturgiaService, LiturgiaService>();
<<<<<<< HEAD
=======
            builder.Services.AddDbContext<EventosDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDbContext<AppDbContext> (options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
>>>>>>> dc9fda35176c673ccf55f90f1df00d5f12eb0564

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
