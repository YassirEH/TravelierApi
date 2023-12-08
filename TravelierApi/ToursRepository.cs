namespace TravelierApi
{
    public class ToursRepository : IToursRepository
    {
        private readonly DataContext _context;

        public ToursRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateTours(Tours tours)
        {
            _context.Tours.Add(tours);
            return Save();
        }

        public bool DeleteTours(int id)
        {
            var tourToDelete = GetToursById(id);
            if (tourToDelete != null)
            {
                _context.Tours.Remove(tourToDelete);
                return Save();
            }
            return false;
        }

        public ICollection<Tours> GetAllTours()
        {
            return _context.Tours.ToList();
        }

        public Tours GetToursById(int id)
        {
            return _context.Tours.FirstOrDefault(t => t.Id == id);
        }

        public bool ToursExists(int id)
        {
            return _context.Tours.Any(t => t.Id == id);
        }

        public bool UpdateTours(Tours tours)
        {
            _context.Tours.Update(tours);
            return Save();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
