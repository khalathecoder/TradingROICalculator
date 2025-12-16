namespace TradingROICalculator.Models
{

    public class JournalEntry
    {
        public string UserId { get; set; } = "local";
        public DateTime CreatedUtc { get; set; }
        public string Notes { get; set; } = string.Empty;
        public string? Tags { get; set; }
        public string? ScreenshotDataUrl { get; set; }

        // optional radios
        public string? Setup { get; set; }       // e.g., "Breakout", "Reversal"
        public string? Direction { get; set; }   // "Long" / "Short"
        public string? Result { get; set; }      // "Win" / "Loss" / "BE"
    }
}
