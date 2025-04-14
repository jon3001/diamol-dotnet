using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageGallery.Pages;

public class IndexModel : PageModel
{
    public string Caption { get; set; } = "The Snake Nebula from CFHT";
    public string ImgUrl { get; set; } = "https://apod.nasa.gov/apod/image/0204/snake_cfht.jpg";
    public string Copyright { get; set; } = "Jean-Charles Cuillandre";

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
