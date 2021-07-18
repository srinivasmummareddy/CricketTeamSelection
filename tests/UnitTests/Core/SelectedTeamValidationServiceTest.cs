using Core;
using Core.Exceptions;
using Models;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Extensions;
using Xunit;

namespace UnitTests.Core
{
    public class SelectedTeamValidationServiceTest
    {
        #region Mock data
        public static IEnumerable<object[]> BatsmenData()
        {
            yield return new object[]
            {
                new List<Player>
                {
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    }
                }
            };
        }

        public static IEnumerable<object[]> BowlerData()
        {
            yield return new object[]
            {
                new List<Player>
                {
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    }
                }
            };
        }

        public static IEnumerable<object[]> KeeperData()
        {
            yield return new object[]
            {
                new List<Player>
                {
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    }
                }
            };
        }

        public static IEnumerable<object[]> ValidPlayersData()
        {
            yield return new object[]
            {
                new List<Player>
                {
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Batsman
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Bowler
                    },
                    new Player
                    {
                        PlayerType = Constants.Keeper
                    }
                }
            };
        }
        #endregion

        [Fact]
        public void Should_Throw_InvalidTeamSelectionException_When_Players_Empty()
        {
            var selectedTeamValidationService = new SelectedTeamValidationService();
            Should.Throw<InvalidTeamSelectionException>(() => selectedTeamValidationService.ValidateTheSelectedTeam(Enumerable.Empty<Player>())).MessageShouldBe("Players are not available");
        }

        [Theory]
        [MemberData(nameof(BatsmenData))]
        public void Should_Throw_InvalidTeamSelectionException_When_Players_Batsmen_Are_Less(IEnumerable<Player> players)
        {
            var selectedTeamValidationService = new SelectedTeamValidationService();
            Should.Throw<InvalidTeamSelectionException>(() => selectedTeamValidationService.ValidateTheSelectedTeam(players)).MessageShouldBe("Only 3 batsmen are available");
        }

        [Theory]
        [MemberData(nameof(BowlerData))]
        public void Should_Throw_InvalidTeamSelectionException_When_Players_Bowlers_Are_Less(IEnumerable<Player> players)
        {
            var selectedTeamValidationService = new SelectedTeamValidationService();
            Should.Throw<InvalidTeamSelectionException>(() => selectedTeamValidationService.ValidateTheSelectedTeam(players)).MessageShouldBe("Only 1 bowler(s) are available");
        }

        [Theory]
        [MemberData(nameof(KeeperData))]
        public void Should_Throw_InvalidTeamSelectionException_When_Players_HasNoKeepers(IEnumerable<Player> players)
        {
            var selectedTeamValidationService = new SelectedTeamValidationService();
            Should.Throw<InvalidTeamSelectionException>(() => selectedTeamValidationService.ValidateTheSelectedTeam(players)).MessageShouldBe("Keepers are not available");
        }

        [Theory]
        [MemberData(nameof(ValidPlayersData))]
        public void Should_NotThrow_InvalidTeamSelectionException_When_Players_HasValidData(IEnumerable<Player> players)
        {
            var selectedTeamValidationService = new SelectedTeamValidationService();
            Should.NotThrow(() => selectedTeamValidationService.ValidateTheSelectedTeam(players));
        }
    }
}
