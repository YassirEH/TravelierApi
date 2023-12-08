namespace TravelierApi
{
    public interface IToursRepository
    {
        IEnumerable<Tours> GetAllTours();
        Tours GetToursById(int id);
        void AddTours(Tours tours);
        void UpdateTours(Tours tours);
        void DeleteTours(int id);
        void Save();
    }
}
