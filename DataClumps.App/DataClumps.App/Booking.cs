namespace DataClumps.App
{
    public class Booking
    {
        public User User { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public Booking(User user, DateTime from, DateTime to)
        {
            User = user;
            From = from;
            To = to;
        }

    }
}
