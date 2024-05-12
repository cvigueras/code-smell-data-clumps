using DataClumps.App;

var booking = new Booking(new User("Carlos", "12345678Z", 22, "0987654567"), 
    new TimeInterval(DateTime.Now, DateTime.Now.AddDays(5)));
Console.ReadLine();
