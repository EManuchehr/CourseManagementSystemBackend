using Domain.Entities;

namespace Application.Services;

public interface IBaseService<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetAsync(Guid id, CancellationToken token = default);

    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default);

    Task<TEntity> CreateAsync(TEntity instructor, CancellationToken token = default);

    Task<bool> UpdateAsync(TEntity entity, CancellationToken token = default);

    Task<bool> DeleteAsync(TEntity submission, CancellationToken token = default);
}