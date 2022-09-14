using Vinotory.Api.Models;

namespace Vinotory.Api.Managers;

public interface IWineryManager
{
    Task<IList<Winery>> GetAll();

    Task<Winery> Get(int wineryId);
}