namespace TransfloAssesment.Services
{
    public interface IDriversService
    {
        Task<IEnumerable<Driver>> GetAll();
        Task<Driver> GetById(int id);
        Task<Driver> Add(Driver driver);
        Driver Update(Driver driver);
        Driver Delete(Driver driver);
        Task<bool> IsvalidDriver(int id);

    }
}
