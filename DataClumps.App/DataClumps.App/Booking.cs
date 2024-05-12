namespace DataClumps.App
{
    public class Booking
    {
        public User User { get; set; }
        public TimeInterval TimeInterval { get; set; }


        public Booking(User user, TimeInterval timeInterval)
        {
            User = user;
            TimeInterval = timeInterval;
        }
    }
}
