using Contracts;
using Core;
using Infrastructure.Repositories;
using Models;
using Moq;
using Newtonsoft.Json;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitTests.MockData;
using Xunit;

namespace UnitTests.Core
{
    public class TeamSelectionServiceTest
    {
        private readonly Mock<IPlayersRepository> _mockPlayersRepository;
        private readonly Mock<ISelectedTeamValidationService> _mockSelectedTeamValidationService;
        private readonly Mock<ITeamEnricherService> _mockTeamEnricherService;
        public TeamSelectionServiceTest()
        {
            _mockPlayersRepository = new Mock<IPlayersRepository>();
            _mockSelectedTeamValidationService = new Mock<ISelectedTeamValidationService>();
            _mockTeamEnricherService = new Mock<ITeamEnricherService>();
            _mockPlayersRepository.Setup(x => x.GetAllSelectedPlayersAsync(It.IsAny<SelectionCriteria>())).ReturnsAsync(QualifiedPlayers.Mock());
            _mockSelectedTeamValidationService.Setup(x => x.ValidateTheSelectedTeam(It.IsAny<IEnumerable<Player>>())).Verifiable();
            _mockTeamEnricherService.Setup(x => x.EnrichTeam(It.IsAny<IEnumerable<Player>>())).Returns(EnricherResponseMock.Mock());
        }


        [Fact]
        public void Constructor_Should_Throw_Error_When_Null_Argument_Passed()
        {
            Should.Throw<ArgumentNullException>(() => new TeamSelectionService
            (null, new SelectedTeamValidationService(), new TeamEnricherService()));

            Should.Throw<ArgumentNullException>(() => new TeamSelectionService
            (new PlayersRepository(null), null, new TeamEnricherService()));

            Should.Throw<ArgumentNullException>(() => new TeamSelectionService
            (new PlayersRepository(null), new SelectedTeamValidationService(),null));
        }

        [Fact]
        public void Selection_Service_Should_Throw_Argument_Null_Exception()
        {
            var selectionService = new TeamSelectionService(_mockPlayersRepository.Object, _mockSelectedTeamValidationService.Object, _mockTeamEnricherService.Object);
            Should.ThrowAsync<ArgumentNullException>(async () => await selectionService.SelectTalentedPlayersAsync(null));
        }


        [Fact]
        public async Task  All_Method_Calls_Should_Be_Verified()
        {
            var expectedTeam = EnricherResponseMock.Mock();
            var selectionService = new TeamSelectionService(_mockPlayersRepository.Object, _mockSelectedTeamValidationService.Object,                                   _mockTeamEnricherService.Object);
            var selectedTeam = await selectionService.SelectTalentedPlayersAsync(new SelectionCriteria());

            _mockPlayersRepository.Verify(x => x.GetAllSelectedPlayersAsync(It.IsAny<SelectionCriteria>()));
            _mockSelectedTeamValidationService.Verify(x => x.ValidateTheSelectedTeam(It.IsAny<IEnumerable<Player>>()));
            _mockTeamEnricherService.Verify(x => x.EnrichTeam(It.IsAny<IEnumerable<Player>>()));

            Assert.Equal(JsonConvert.SerializeObject(expectedTeam), JsonConvert.SerializeObject(selectedTeam));
        }

    }
}
