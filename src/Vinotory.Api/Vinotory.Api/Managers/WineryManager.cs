using Microsoft.EntityFrameworkCore;
using Vinotory.Api.Data;
using Vinotory.Api.Models;

namespace Vinotory.Api.Managers;

public class WineryManager : IWineryManager
{
    private readonly IWineryRepository _wineryRepository;
    public WineryManager(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }
    public async Task<IList<Winery>> GetAll()
    {
        return await _wineryRepository.GetAll().ToListAsync();
    }

    public async Task<Winery> Get(int wineryId)
    {
        return await _wineryRepository.Get(wineryId);
    }
}