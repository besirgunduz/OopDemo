using OopDemo.Entities;
using System.Collections.Generic;

namespace OopDemo.DataAccess
{
    public interface ICityRepository : IAppRepository<City>
    {
        List<CityDetailDto> GetCityDetails();
    }
}
