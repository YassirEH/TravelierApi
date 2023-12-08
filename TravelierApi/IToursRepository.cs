namespace TravelierApi
{
    public interface IToursRepository
    {
        public IEnumerable<Tours> GetAllTours();
        public Tours GetToursById(int id);
        public bool AddTours(Tours tours);
        public bool UpdateTours(Tours tours);
        public bool DeleteTours(int id);
        public bool Save();
    }
}
