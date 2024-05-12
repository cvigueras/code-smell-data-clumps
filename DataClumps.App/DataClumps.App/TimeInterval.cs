namespace DataClumps.App
{
    public class TimeInterval
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public TimeInterval(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }
    }
}
