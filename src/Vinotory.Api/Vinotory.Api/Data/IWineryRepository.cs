using MxInfo.EntityFramework.Contracts;
using Vinotory.Api.Models;

namespace Vinotory.Api.Data;

public interface IWineryRepository : IRepository<Winery>
{
    Task<Winery> Get(int wineryId);
}