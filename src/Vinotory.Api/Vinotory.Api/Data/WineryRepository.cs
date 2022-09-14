using MxInfo.EntityFramework.Contracts;
using MxInfo.EntityFramework.Repositories;
using Vinotory.Api.Models;

namespace Vinotory.Api.Data;

public class WineryRepository : Repository<Winery>, IWineryRepository
{
    public WineryRepository(IEntityContext entityContext) : base(entityContext)
    {
    }

    public async Task<Winery> Get(int wineryId)
    {
        return (await FindSingleAsync(winery => winery.WineryId.Equals(wineryId)))!;
    }
}