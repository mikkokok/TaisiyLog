using Microsoft.AspNetCore.Mvc.RazorPages;
using TaisiyLog.Models;

namespace TaisiyLog.Pages
{
    public class TaisiyLogBase : PageModel
    {
        public static List<LogItem> logItems = new();

    }
}
