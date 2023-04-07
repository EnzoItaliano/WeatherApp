using CityLocation.Models;

namespace CityLocation.Contracts
{
    public interface ICityLocationService
    {
        Task<List<CityData>> GetCityDataAsync(string city);
    }
}
