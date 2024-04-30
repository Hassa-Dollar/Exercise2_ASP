namespace Exercise2_ASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
               name: "default",
               pattern: "",
               defaults: new { controller = "Welcome", action = "WelcomeDefault" });

            app.MapControllerRoute(
                name: "Utilisateur",
                pattern: "{controller}/{action}/{nom?}/{prenom?}");

            app.Run();
        }
    }
}