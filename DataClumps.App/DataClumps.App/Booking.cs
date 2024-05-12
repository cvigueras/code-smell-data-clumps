namespace DataClumps.App
{
    public class Booking
    {
        public Booking(string name, string dni, int age, string drivingLicence, DateTime from, DateTime to)
        {
            Name = name;
            DNI = dni;
            Age = age;
            DrivingLicence = drivingLicence;
            From = from;
            To = to;
        }

        public string Name { get; set; }
        public string DNI { get; set; }
        public int Age { get; set; }
        public string DrivingLicence { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
