using System;
using AirFlightsDashboard.States;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SDK;

namespace AirFlightsDashboard;

/// <summary />
public static class DependencyInjection
{
    /// <summary />
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddCascadingAuthenticationState();

        services.AddAuthorizationCore();

        services.AddBlazoredSessionStorage();
        services.AddBlazoredLocalStorage();

        services.AddAuthorizationCore();

        services.AddScoped<AuthenticationStateProvider, AirFLightsAuthenticationStateProvider>();

        var authProvider = services.BuildServiceProvider().GetService<AuthenticationStateProvider>();
        AuthBearerTokenFactory.SetBearerTokenGetterFunc((authProvider as AirFLightsAuthenticationStateProvider)!.GetBearerTokenAsync);

        var apiUrl = new Uri(config.GetSection("Api:BaseUrl").Value);
        services.AddAirFlightsApiClient(apiUrl);

        services.AddScoped<SnackbarState>();
        services.AddScoped<LoadingState>();

        return services;
    }
}