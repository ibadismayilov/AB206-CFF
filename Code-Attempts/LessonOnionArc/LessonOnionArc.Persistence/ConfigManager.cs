using Microsoft.Extensions.Configuration;

namespace LessonOnionArc.Persistence;
public static class ConfigManager
{
    public static ConfigurationManager Config
    {
        get
        {
            ConfigurationManager cnfg = new();
            cnfg.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "LessonOnionArc.API"));
            cnfg.AddJsonFile("appsettings.json");
            return cnfg;
        }
    }

    public static string ConnectionString
    {
        get
        {
            return Config.GetConnectionString("Default");
        }
    }
}
