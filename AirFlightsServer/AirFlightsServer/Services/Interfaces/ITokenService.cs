using System.Threading.Tasks;

namespace AirFlightsServer.Services.Interfaces;

public interface ITokenService
{
    /// <summary/>
    Task<string> GenerateTokenAsync(string username, int durationMin);

    /// <summary/>
    bool IsValidToken(string token, string role);

    /// <summary/>
    int GetExpirationTimeFromJwtInMinutes(string token);
}