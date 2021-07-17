using Contracts;
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

        [HttpPost]
        public async Task<ActionResult<SelectedTeam>> CreateTeam([FromBody] SelectionCriteria selectionCriteriaDto)
        {
            var selectedTeam = await _teamSelectionService.SelectTalentedPlayersAsync(selectionCriteriaDto);
            return Ok(selectedTeam);
        }
    }
}
