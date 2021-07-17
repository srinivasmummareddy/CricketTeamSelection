using Models;
using System.Collections.Generic;

namespace Contracts
{
    public interface ISelectedTeamValidationService
    {
        void ValidateTheSelectedTeam(IEnumerable<Player> selectedTeam);

    }
}
