using ISU_Website;
using System.Data.Entity;
using ISU_Website.Birds;
using RestSharp;
using System.Text.Json;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

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

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Site}/{action=Index}/{id?}");

app.Run();

//Creates a data object containing api response and a copy of the database in Bird.cs
namespace ISU_Website.Birds
{
    public class Run
    {
        public static BirdsDBContext data = new();
        public static JsonElement[]? json = default;

        public Run()
        {
            //applies api response to json;
            RestResponse response = Startup.client.ExecuteAsync(Startup.request).Result;
            json = JsonSerializer.Deserialize<JsonElement[]>(response.Content);
        }
    }
}