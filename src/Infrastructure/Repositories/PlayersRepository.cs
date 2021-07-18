using Contracts;
using Dapper;
using Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PlayersRepository : Repository<Player>, IPlayersRepository
    {
        public PlayersRepository(IDbConnection connection) : base(connection) { }

        public async Task<IEnumerable<Player>> GetAllSelectedPlayersAsync(SelectionCriteria selectionCriteria)
        {
            using IDbConnection connection = Open();

            var parameters = new DynamicParameters();
            parameters.Add(Constants.Height, selectionCriteria.PlayerHeight);
            parameters.Add(Constants.Bmi, selectionCriteria.PlayerBmi);
            parameters.Add(Constants.Runs, selectionCriteria.PlayerRuns);
            parameters.Add(Constants.Wickets, selectionCriteria.PlayerWickets);
            parameters.Add(Constants.Stumpings, selectionCriteria.PlayerStumpings);

            var functionName = "\"CricketSelection\".selectedteam";
            return await connection.QueryAsync<Player>(functionName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
