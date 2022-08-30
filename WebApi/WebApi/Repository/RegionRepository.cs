using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Model.Domain;
using WebApi.Repository.Interface;

namespace WebApi.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WebApiDbContext webApiDbContext;

        public RegionRepository(WebApiDbContext webApiDbContext)
        {
            this.webApiDbContext = webApiDbContext;
        }
        public async Task<IEnumerable<Region>> GetAll()
        {
            return await webApiDbContext.Regions.ToListAsync();
        }
    }
}
