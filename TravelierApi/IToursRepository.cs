namespace TravelierApi
{
    public interface IToursRepository
    {
        public bool ToursExists(int id);
        public ICollection<Tours> GetAllTours();
        public Tours GetToursById(int id);
        public bool CreateTours(Tours tours);
        public bool UpdateTours(int tourId, Tours tours);
        public bool DeleteTours(int id);
        public bool Save();
    }
}
