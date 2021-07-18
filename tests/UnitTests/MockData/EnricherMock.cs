using Models;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UnitTests.MockData
{
    internal class EnricherParameterMock : IEnumerable<object[]>
    {
        readonly List<object[]> _data = new()
        {
            new object[]
            {
                 new List<Player>
                 {
                    new Player 
                    {
                        PlayerId = 61,
                        PlayerName = "Corey Mingame",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 23,
                        PlayerRuns = 3214,
                        PlayerWickets = 150,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 53,
                        PlayerName = "Fiona Lello",
                        PlayerCountry = "Aland Islands",
                        PlayerType = "bowler",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 20,
                        PlayerRuns = 7500,
                        PlayerWickets = 219,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 30,
                        PlayerName = "Arnoldo Salasar",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.8M,
                        PlayerBmi = 23,
                        PlayerRuns = 5270,
                        PlayerWickets = 180,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 62,
                        PlayerName = "Dov Goldis",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 12,
                        PlayerRuns = 5000,
                        PlayerWickets = 235,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 24,
                        PlayerName = "Wiatt Cattow",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 12,
                        PlayerRuns = 8000,
                        PlayerWickets = 400,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 18,
                        PlayerName = "Anette Gockelen",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 6M,
                        PlayerBmi = 16,
                        PlayerRuns = 8321,
                        PlayerWickets = 46,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 2,
                        PlayerName = "Janice Kelsow",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.5M,
                        PlayerBmi = 13,
                        PlayerRuns = 7500,
                        PlayerWickets = 1,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 45,
                        PlayerName = "Brittney Drinkhall",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.5M,
                        PlayerBmi = 18,
                        PlayerRuns = 7500,
                        PlayerWickets = 180,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 6,
                        PlayerName = "Nerty Mushawe",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.8M,
                        PlayerBmi = 16,
                        PlayerRuns = 7500,
                        PlayerWickets = 46,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 12,
                        PlayerName = "Terra Setterthwait",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 16,
                        PlayerRuns = 8321,
                        PlayerWickets = 55,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 17,
                        PlayerName = "Wilhelm Morch",
                        PlayerCountry = "Albania",
                        PlayerType = "keeper",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 23,
                        PlayerRuns = 8654,
                        PlayerWickets = 235,
                        PlayerStumpings = 235
                    }
                 }
            }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal static class EnricherResponseMock
    {
        internal static SelectedTeam Mock()
        {
            return new SelectedTeam
            {
                Bowlers = new List<Player>
                {
                    new Player 
                    {
                        PlayerId = 61,
                        PlayerName = "Corey Mingame",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 23,
                        PlayerRuns = 3214,
                        PlayerWickets = 150,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 53,
                        PlayerName = "Fiona Lello",
                        PlayerCountry = "Aland Islands",
                        PlayerType = "bowler",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 20,
                        PlayerRuns = 7500,
                        PlayerWickets = 219,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 30,
                        PlayerName = "Arnoldo Salasar",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.8M,
                        PlayerBmi = 23,
                        PlayerRuns = 5270,
                        PlayerWickets = 180,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 62,
                        PlayerName = "Dov Goldis",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 12,
                        PlayerRuns = 5000,
                        PlayerWickets = 235,
                        PlayerStumpings = 0
                    },
                    new Player 
                    {
                        PlayerId = 24,
                        PlayerName = "Wiatt Cattow",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 12,
                        PlayerRuns = 8000,
                        PlayerWickets = 400,
                        PlayerStumpings = 0
                    }
                },
                Batsmen = new List<Player>
                {
                    new Player
                    {
                        PlayerId = 18,
                        PlayerName = "Anette Gockelen",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 6M,
                        PlayerBmi = 16,
                        PlayerRuns = 8321,
                        PlayerWickets = 46,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 2,
                        PlayerName = "Janice Kelsow",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.5M,
                        PlayerBmi = 13,
                        PlayerRuns = 7500,
                        PlayerWickets = 1,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 45,
                        PlayerName = "Brittney Drinkhall",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.5M,
                        PlayerBmi = 18,
                        PlayerRuns = 7500,
                        PlayerWickets = 180,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 6,
                        PlayerName = "Nerty Mushawe",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.8M,
                        PlayerBmi = 16,
                        PlayerRuns = 7500,
                        PlayerWickets = 46,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 12,
                        PlayerName = "Terra Setterthwait",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 16,
                        PlayerRuns = 8321,
                        PlayerWickets = 55,
                        PlayerStumpings = 0
                    }
                },
                Keepers = new List<Player>
                {
                    new Player
                    {
                        PlayerId = 17,
                        PlayerName = "Wilhelm Morch",
                        PlayerCountry = "Albania",
                        PlayerType = "keeper",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 23,
                        PlayerRuns = 8654,
                        PlayerWickets = 235,
                        PlayerStumpings = 235
                    }
                }
            };
        }
    }

    internal static class QualifiedPlayers
    {
        internal static IEnumerable<Player> Mock()
        {
          return   new List<Player>
                 {
                    new Player
                    {
                        PlayerId = 61,
                        PlayerName = "Corey Mingame",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 23,
                        PlayerRuns = 3214,
                        PlayerWickets = 150,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 53,
                        PlayerName = "Fiona Lello",
                        PlayerCountry = "Aland Islands",
                        PlayerType = "bowler",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 20,
                        PlayerRuns = 7500,
                        PlayerWickets = 219,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 30,
                        PlayerName = "Arnoldo Salasar",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.8M,
                        PlayerBmi = 23,
                        PlayerRuns = 5270,
                        PlayerWickets = 180,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 62,
                        PlayerName = "Dov Goldis",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 12,
                        PlayerRuns = 5000,
                        PlayerWickets = 235,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 24,
                        PlayerName = "Wiatt Cattow",
                        PlayerCountry = "Albania",
                        PlayerType = "bowler",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 12,
                        PlayerRuns = 8000,
                        PlayerWickets = 400,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 18,
                        PlayerName = "Anette Gockelen",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 6M,
                        PlayerBmi = 16,
                        PlayerRuns = 8321,
                        PlayerWickets = 46,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 2,
                        PlayerName = "Janice Kelsow",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.5M,
                        PlayerBmi = 13,
                        PlayerRuns = 7500,
                        PlayerWickets = 1,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 45,
                        PlayerName = "Brittney Drinkhall",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.5M,
                        PlayerBmi = 18,
                        PlayerRuns = 7500,
                        PlayerWickets = 180,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 6,
                        PlayerName = "Nerty Mushawe",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.8M,
                        PlayerBmi = 16,
                        PlayerRuns = 7500,
                        PlayerWickets = 46,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 12,
                        PlayerName = "Terra Setterthwait",
                        PlayerCountry = "Albania",
                        PlayerType = "batsman",
                        PlayerHeight = 5.9M,
                        PlayerBmi = 16,
                        PlayerRuns = 8321,
                        PlayerWickets = 55,
                        PlayerStumpings = 0
                    },
                    new Player
                    {
                        PlayerId = 17,
                        PlayerName = "Wilhelm Morch",
                        PlayerCountry = "Albania",
                        PlayerType = "keeper",
                        PlayerHeight = 5.7M,
                        PlayerBmi = 23,
                        PlayerRuns = 8654,
                        PlayerWickets = 235,
                        PlayerStumpings = 235
                    }
                 };

        }

    }
}

