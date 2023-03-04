namespace TransfloAssesment.Services
{
    public class DriversService : IDriversService
    {
        private readonly ApplicationDbContext _context;

        public DriversService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Driver> Add(Driver driver)
        {
            await _context.AddAsync(driver);
            _context.SaveChanges();

            return driver;
        }
        public Driver Delete(Driver driver)
        {

            _context.Remove(driver);
            _context.SaveChanges();

            return driver;
        }
        public async Task<IEnumerable<Driver>> GetAll()
        {
            return await _context.Drivers.AsNoTracking().Where(x=>x.isDeleted==false).OrderBy(g => g.firstName).ToListAsync();
        }
        public async Task<Driver> GetById(int id)
        {
            return await _context.Drivers.SingleOrDefaultAsync(g => g.Id == id &&g.isDeleted==false);
        }
        public Task<bool> IsvalidDriver(int id)
        {
            return _context.Drivers.AnyAsync(g => g.Id == id);
        }

        public Driver Update(Driver driver)
        {
            _context.Update(driver);
            _context.SaveChanges();

            return driver;
        }

        
    }
}
