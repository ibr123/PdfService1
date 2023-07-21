using Microsoft.Extensions.Configuration;

namespace Core.Extensions
{
    internal class Configurations
    {
        internal static IConfigurationRoot GetIConfigurationRoot()
        {
            string configPath = Path.Combine(Directory.GetCurrentDirectory(), "pdfservicedata.json");
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile(configPath)
                .Build();

            return config;
        }
    }
}
