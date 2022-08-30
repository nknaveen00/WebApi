using WebApi.Model.Domain;

namespace WebApi.Repository.Interface
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAll();
    }
}
