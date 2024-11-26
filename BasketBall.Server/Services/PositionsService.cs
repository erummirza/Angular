using BasketBall.Server.Data;
using BasketBall.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BasketBall.Server.Services
{
    public class PositionsService : IPositionsService
    {
        private readonly BasketballDbContext _context;
        public PositionsService(BasketballDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Position>> GetPositionsList()
        {
            return await _context.Positions
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();
        }
    }
}
