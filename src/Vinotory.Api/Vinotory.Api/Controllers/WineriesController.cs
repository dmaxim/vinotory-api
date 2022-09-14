using Microsoft.AspNetCore.Mvc;
using Vinotory.Api.Managers;

namespace Vinotory.Api.Controllers;

public class WineriesController : Controller
{
    private readonly IWineryManager _wineryManager;

    public WineriesController(IWineryManager wineryManager)
    {
        _wineryManager = wineryManager;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _wineryManager.GetAll());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var winery = await _wineryManager.Get(id);
        return Ok(winery);
    }
}