using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaisiyLog.Models;

namespace TaisiyLog.Pages
{
    public class IndexModel : TaisiyLogBase
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet = true)]
        public List<LogItem> LogItems
        {
            get
            {
                return logItems;
            }
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnDelete()
        {
            logItems.Clear();
        }
    }
}