using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODLClientApp.Models
{
    public class JWT
    {

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
