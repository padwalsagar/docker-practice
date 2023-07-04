using Microsoft.AspNetCore.Mvc.RazorPages;
using myContainerizedApp.Data;

namespace myContainerizedApp.Pages;

public class IndexModel : PageModel
{
    public string StudentName { get; private set; } = "PageModel in C#";
    private readonly ILogger<IndexModel> _logger;
    private readonly SchoolContext _context;

    public IndexModel(ILogger<IndexModel> logger, SchoolContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {
        var s = _context.Students?.Where(d => d.ID == 1).FirstOrDefault();
        this.StudentName = $"{s?.FirstMidName} {s?.LastName}";
    }
}
