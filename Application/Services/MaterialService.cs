using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services;

public class MaterialService(IBaseRepository<Material> materialRepository) : IBaseService<Material>
{
    public async Task<Material> CreateAsync(Material material, CancellationToken token = default)
    {
        return await materialRepository.CreateAsync(material, token);
    }

    public async Task<bool> DeleteAsync(Material submission, CancellationToken token = default)
    {
        return await materialRepository.DeleteAsync(submission, token);
    }

    public async Task<IEnumerable<Material>> GetAllAsync(CancellationToken token = default)
    {
        return await materialRepository.GetAllAsync(token);
    }

    public async Task<Material> GetAsync(Guid id, CancellationToken token = default)
    {
        return await materialRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Material material, CancellationToken token = default)
    {
        return await materialRepository.UpdateAsync(material, token);
    }
}