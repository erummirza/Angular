using BasketBall.Server.Models;

namespace BasketBall.Server.Services
{
    public interface IPositionsService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
