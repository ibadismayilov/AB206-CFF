namespace HotelMvc;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        var app = builder.Build();  
        app.UseStaticFiles();

        app.MapControllerRoute(
            name: "Default",
            pattern: "{Controller=Human}/{Action=Index}"
        );
        
        app.Run();
    }
}
