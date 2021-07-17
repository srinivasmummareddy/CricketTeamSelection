using Contracts;
using Models;
using System;
using System.Threading.Tasks;

namespace Core
{
    public class TeamSelectionService : ITeamSelectionService
    {
        private readonly IPlayersRepository _playersRepository;
        private readonly ISelectedTeamValidationService _selectedTeamValidationService;
        private readonly ITeamEnricherService _teamEnricherService;

        public TeamSelectionService(IPlayersRepository playersRepository,
            ISelectedTeamValidationService selectedTeamValidationService,
            ITeamEnricherService teamEnricherService)
        {
            _playersRepository = playersRepository ?? throw new ArgumentNullException(nameof(IPlayersRepository));
            _selectedTeamValidationService = selectedTeamValidationService ?? throw new ArgumentNullException(nameof(ISelectedTeamValidationService));
            _teamEnricherService = teamEnricherService ?? throw new ArgumentNullException(nameof(ITeamEnricherService));
        }

        public async Task<SelectedTeam> SelectTalentedPlayersAsync(SelectionCriteria selectionCriteria)
        {
            if (selectionCriteria is null)
                throw new ArgumentNullException(nameof(selectionCriteria));

            var players = await _playersRepository.GetAllSelectedPlayersAsync(selectionCriteria);

            _selectedTeamValidationService.ValidateTheSelectedTeam(players);

            var selectedTeam = _teamEnricherService.EnrichTeam(players);

            return selectedTeam;
        }
    }
}
