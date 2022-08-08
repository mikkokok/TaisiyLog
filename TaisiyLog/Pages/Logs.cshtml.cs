using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaisiyLog.Models;

namespace TaisiyLog.Pages
{
    public class LogsModel : TaisiyLogBase
    {
        public void OnGet()
        {
        }

        public void OnPost(LogItem logItem)
        {
            logItems.Add(logItem);
        }
    }
}
