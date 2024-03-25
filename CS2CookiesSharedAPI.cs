using CounterStrikeSharp.API.Core;
using MySqlConnector;

namespace shared
{
    public interface ICS2CookiesShared
    {
        public Task<ICookie?> FindClientCookie(string key);
        public Task<ICookie> RegClientCookie(string key);
        public MySqlConnection GetConnection();
    }

    public interface ICookie
    {
        public Task<string?> Get(CCSPlayerController player);
        public void Set(CCSPlayerController player, string value);
    }

}