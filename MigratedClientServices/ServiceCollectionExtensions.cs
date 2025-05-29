using Microsoft.Extensions.Options;
using MigratedClientServices.Data;
using NATS.Net;

namespace MigratedClientServices;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection SetupNats(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<NatsOptions>(configuration.GetSection(NatsOptions.SectionName));

        services.AddSingleton<NatsClient>(provider =>
        {
            var options = provider.GetRequiredService<IOptions<NatsOptions>>().Value;
            return new NatsClient(options.NatsUrl);
        });
        return services;
    }
    
    public static IServiceCollection SetupClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IClient, ClientAPI>();
        return services;
    }
}