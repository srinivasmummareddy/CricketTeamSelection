using Core;
using Models;
using Newtonsoft.Json;
using Shouldly;
using System.Collections.Generic;
using UnitTests.MockData;
using Xunit;

namespace UnitTests.Core
{
    public class TeamEnricherServiceTest
    {
        [Theory]
        [ClassData(typeof(EnricherParameterMock))]
        public void Selected_Players_Should_Be_Enriched_Based_On_Player_Type(IEnumerable<Player> players)
        {
            var expectedTeam = EnricherResponseMock.Mock();
            var enricherService = new TeamEnricherService();
            var enrichedTeam = enricherService.EnrichTeam(players);
            Assert.Equal(JsonConvert.SerializeObject(expectedTeam), JsonConvert.SerializeObject(enrichedTeam));
        }
    }
}
