using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class SelectionCriteria
    {
        [JsonProperty("playerHeight")]
        [Required]
        public float PlayerHeight { get; set; }

        [JsonProperty("playerBMI")]
        [Required]
        public float PlayerBmi { get; set; }

        [JsonProperty("playerRuns")]
        [Required]
        public int PlayerRuns { get; set; }

        [JsonProperty("playerWickets")]
        [Required]
        public int PlayerWickets { get; set; }

        [JsonProperty("playerStumpings")]
        [Required]
        public int PlayerStumpings { get; set; }
    }
}
