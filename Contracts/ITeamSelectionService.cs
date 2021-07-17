using Models;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITeamSelectionService
    {
        Task<SelectedTeam> SelectTalentedPlayersAsync(SelectionCriteria selectionCriteria);
    }
}
