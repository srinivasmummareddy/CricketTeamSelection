using Models;
using System.Collections.Generic;

namespace Contracts
{
    public interface ITeamEnricherService
    {
        SelectedTeam EnrichTeam(IEnumerable<Player> players); 
    }
}
