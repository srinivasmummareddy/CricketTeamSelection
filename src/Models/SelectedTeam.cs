using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models
{
    public class SelectedTeam
    {
        [JsonProperty("bowlers")]
        public IList<Player> Bowlers { get; set; }

        [JsonProperty("batsmen")]
        public IList<Player> Batsmen { get; set; }

        [JsonProperty("keepers")]
        public IList<Player> Keepers { get; set; }
    }
}
