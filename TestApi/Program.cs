using TestApi;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

// calling ConfigureServices method
startup.ConfigureServices(builder.Services);
// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();
// calling Configure method
startup.Configure(app, builder.Environment);


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
