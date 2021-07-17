using Newtonsoft.Json;

namespace Models
{
    public class SelectionCriteria
    {
        [JsonProperty("playerHeight")]
        public float PlayerHeight { get; set; }

        [JsonProperty("playerBMI")]
        public float PlayerBmi { get; set; }

        [JsonProperty("playerRuns")]
        public int PlayerRuns { get; set; }

        [JsonProperty("playerWickets")]
        public int PlayerWickets { get; set; }

        [JsonProperty("playerStumpings")]
        public int PlayerStumpings { get; set; }
    }
}
