using CoffeeSlotMachine.Core.Contracts;
using CoffeeSlotMachine.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeSlotMachine.Persistence
{
    public class CoinRepository : ICoinRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CoinRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Coin[] GetCoinDepot() =>
                _dbContext.Coins
                    .OrderBy(coin => coin.CoinValue)
                    .ToArray();

       
    }
}
