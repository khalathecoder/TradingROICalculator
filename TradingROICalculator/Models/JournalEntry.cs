namespace TradingROICalculator.Models
{
    public class JournalEntry
    {
        public DateTime CreatedUtc { get; set; }
        public string Notes { get; set; } = string.Empty;
        public string? Tags { get; set; }
        public string? ScreenshotDataUrl { get; set; }
    }
}
