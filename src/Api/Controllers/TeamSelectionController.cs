using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamSelectionController : ControllerBase
    {
        private readonly ITeamSelectionService _teamSelectionService;
        public TeamSelectionController(ITeamSelectionService teamSelectionService)
        {
            _teamSelectionService = teamSelectionService ?? throw new ArgumentNullException(nameof(ITeamSelectionService));
        }

        /// <summary>
        /// Compose team based on selection criteria
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// 	{
        ///    		"playerHeight": 5.4,
        ///    		"playerBMI": 24,
        ///    		"playerRuns": 7000,
        ///    		"playerWickets": 100,
        ///    		"playerStumpings": 100
        ///  	}
        /// </remarks>
        /// <param name="selectionCriteriaDto"></param>
        /// <returns>Selected team contains 5 batsmen, 5 bowlers and a keeper</returns>
        /// <response code="200">Returns the newly created team</response>
        /// <response code="400">If the item null</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult<SelectedTeam>> CreateTeam([FromBody] SelectionCriteria selectionCriteriaDto)
        {
            var selectedTeam = await _teamSelectionService.SelectTalentedPlayersAsync(selectionCriteriaDto);
            return Ok(selectedTeam);
        }
    }
}
