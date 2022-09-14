namespace Vinotory.Api.Models;

public class Winery
{
    public Winery()
    {
        Name = string.Empty;
    }
    public int WineryId { get; set;  }
    public string Name { get; set;  }
}