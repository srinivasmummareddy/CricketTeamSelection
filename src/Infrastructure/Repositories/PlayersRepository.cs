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
            parameters.Add(Constants.Height, 5.4f);
            parameters.Add(Constants.Bmi, 24f);
            parameters.Add(Constants.Runs, 7000);
            parameters.Add(Constants.Wickets, 100);
            parameters.Add(Constants.Stumpings, 100);

            var functionName = "\"CricketSelection\".selectedteam";
            return await connection.QueryAsync<Player>(functionName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
