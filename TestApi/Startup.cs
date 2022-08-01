using DataStore.EF;
using Microsoft.EntityFrameworkCore;

namespace TestApi
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;

        public Startup(IWebHostEnvironment env)
        {
            this._env = env;
        }

        public void ConfigureServices(WebApplication app, IWebHostEnvironment environment)
        {
            throw new NotImplementedException();
        }

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        

        public void ConfigureServices(IServiceCollection services)
        {
            if (_env.IsDevelopment())
            {
                services.AddDbContext<DbContext>(options =>
                {
                    options.UseInMemoryDatabase("Bugs");
                });
            }
           
            services.AddControllers();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env, BugsContext context)
        {
            /*if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }*/

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Create the in-memory database
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

            }


            /* app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            */
        }
    }
}
