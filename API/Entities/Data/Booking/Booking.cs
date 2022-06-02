namespace API.Entities.Data.Booking
{
    public class Booking
    {
        public IEnumerable<Destination>? Destination { get; set; }
        public Package? Package { get; set; }
    }
}
