using System.Collections.Generic;
using System.Linq;
using Contracts;
using Core.Exceptions;
using Models;

namespace Core
{
    public class SelectedTeamValidationService : ISelectedTeamValidationService
    {
        public void ValidateTheSelectedTeam(IEnumerable<Player> selectedTeam)
        {
            if (!selectedTeam.Any()) throw new InvalidTeamSelectionException("Players are not available");

            int getPlayerCountByType(string playerType) => selectedTeam.Where(x => x.PlayerType == playerType).Count();

            var batsmansCount = getPlayerCountByType(Constants.Batsman);
            var bowlersCount = getPlayerCountByType(Constants.Bowler);
            var keeperCount = getPlayerCountByType(Constants.Keeper);

            if (batsmansCount < 5)
            {
                throw new InvalidTeamSelectionException($"Only {batsmansCount} batsmen are available");
            }
            if (bowlersCount < 5)
            {
                throw new InvalidTeamSelectionException($"Only {bowlersCount} bowler(s) are available");
            }
            if (keeperCount < 1)
            {
                throw new InvalidTeamSelectionException($"Keepers are not available");
            }
        }
    }
}
