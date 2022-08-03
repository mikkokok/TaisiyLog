namespace TaisiyLog.Models
{
    public class LogItem
    {
        public enum Sev
        {
            Error = 0,
            Warning = 1,
            Information = 2,
            WarningInformation = 3,
            InformationInformationInformation = 4
        }

        public DateTime LastUpdated { get; set; }
        public string LogMessage { get; set; }
        public string Origin { get; set; }
        public Sev Severity { get; set; }

    }
}
