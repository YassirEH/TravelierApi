namespace TravelierApi
{
    public class Tours
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Departure { get; set; } // Added this line
        public DateTime Return { get; set; }
        public double Price { get; set; }
        public string Country { get; set; }

        public string DepartureFormatted
        {
            get
            {
                return Departure.ToString("dd/MM/yyyy");
            }
        }

        public string ReturnFormatted
        {
            get
            {
                return Return.ToString("dd/MM/yyyy");
            }
        }
    }
}
