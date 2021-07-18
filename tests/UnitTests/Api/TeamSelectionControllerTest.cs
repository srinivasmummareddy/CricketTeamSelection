using Api.Controllers;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Models;
using Moq;
using Shouldly;
using System;
using System.Threading.Tasks;
using UnitTests.MockData;
using Xunit;

namespace UnitTests.Api
{
    public class TeamSelectionControllerTest
    {
        private readonly Mock<ITeamSelectionService> _mockTeamSelectionService;

        public TeamSelectionControllerTest()
        {
            _mockTeamSelectionService = new Mock<ITeamSelectionService>();
            _mockTeamSelectionService.Setup(x => x.SelectTalentedPlayersAsync(It.IsAny<SelectionCriteria>())).ReturnsAsync                                                      (EnricherResponseMock.Mock());
        }

        [Fact]
        public void Constructor_Should_Throw_Error_When_Null_Argument_Passed()
        {
            Should.Throw<ArgumentNullException>(() => new TeamSelectionController(null));
        }

        [Fact]
        public async Task Controller_Should_Return_200()
        {
            var controller = new TeamSelectionController(_mockTeamSelectionService.Object);
            var response = await controller.CreateTeam(null);

            ((ObjectResult)response.Result).StatusCode.ShouldNotBeNull();

            var statusCode = ((ObjectResult)response.Result).StatusCode;
            statusCode.ShouldBe(200);
        }



    }
}
