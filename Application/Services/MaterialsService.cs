using System;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services

public class MaterialsService : IBaseService<Materials>
{
    private readonly IBaseRepository<Materials> _MaterialsRepository;

    public MaterialsService(IBaseRepository<Materials> MaterialsRepository)
    {
        _MaterialsRepository = MaterialsRepository;
    }

    public async Task<Materials> CreateAsync(Materials Materials, CancellationToken token = default)
    {
        return await _MaterialsRepository.CreateAsync(Materials, token);
    }

    public async Task<bool> DeleteAsync(Materials Materials, CancellationToken token = default)
    {
        return await _MaterialsRepository.DeleteAsync(Materials, token);
    }

    public async Task<IEnumerable<Materials>> GetAllAsync(CancellationToken token = default)
    {
        return await _MaterialsRepository.GetAllAsync(token);
    }

    public async Task<Materials> GetAsync(Guid id, CancellationToken token = default)
    {
        return await _MaterialsRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Materials Materials, CancellationToken token = default)
    {
        var existingMaterials = await GetAsync(Materials.Id);

        if (existingMaterials is null)
        {
            return false;
        }


        existingMaterials.title = Materials.title;
        existingMaterials.description = Materials.description;
        existingMaterials.description = Materials.description;
        existingMaterials.file_url = Materials.file_url;


        return await _MaterialsRepository.UpdateAsync(existingMaterials, token);
    }
}
}