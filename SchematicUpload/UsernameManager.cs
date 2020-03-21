using System;
using System.Net;
using System.Net.Http;
using System.Resources;
using System.Text.Json;

namespace SchematicUpload
{
    public class UsernameManager
    {
        Config.Config _config;

        public UsernameManager(Config.Config config)
        {
            this._config = config;
        }

        public Guid GetGuidForName(string name)
        {
            using (var client = new HttpClient())
            {
                var url = _config.mojang_request_url + name;
                Console.WriteLine(url);
                var httpResponseMessage = client.GetAsync(url).Result;

                if (httpResponseMessage.StatusCode != HttpStatusCode.OK)
                {
                    return Guid.Empty;
                }

                var responseObject =  JsonSerializer.Deserialize<MojangResponse>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                return Guid.Parse(responseObject.id);
            }
        }
    }

    internal class MojangResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool legacy { get; set; } = false;
        public bool demo { get; set; } = false;
    }
}
