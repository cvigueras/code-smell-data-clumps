namespace DataClumps.App
{
    public class User
    {
        public string Name { get; set; }
        public string DNI { get; set; }
        public int Age { get; set; }
        public string DrivingLicence { get; set; }

        public User(string name, string dni, int age, string drivingLicence)
        {
            Name = name;
            DNI = dni;
            Age = age;
            DrivingLicence = drivingLicence;
        }
    }
}
