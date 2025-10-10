using Common.Domain.DTOS.Base.Contracts;
using Common.Domain.Entities.Contracts;
using System.Linq.Expressions;

namespace Common.Domain.Contracts.Repositories
{
    public interface IUnitOfWork
    {
        Task AddAsync<OnDB>(OnDB entity, CancellationToken cancellationToken) 
            where OnDB : class, IEntity, IIdentifiable, IAuditable;
        Task AddAsync<OnDTO, OnDB>(OnDTO entity, CancellationToken cancellationToken) 
            where OnDTO : class, IEntityDTO, IIdentifiableDTO, IAuditableDTO 
            where OnDB : class, IEntity, IIdentifiable, IAuditable;
        Task UpdateAsync<OnDB>(OnDB entity, CancellationToken cancellationToken) 
            where OnDB : class, IEntity, IIdentifiable, IAuditable;
        Task UpdateAsync<OnDTO, OnDB>(OnDTO entity, CancellationToken cancellationToken)
            where OnDTO : class, IEntityDTO, IIdentifiableDTO, IAuditableDTO 
            where OnDB : class, IEntity, IIdentifiable, IAuditable;
        Task DeleteAsync<OnDB>(Guid id, CancellationToken cancellationToken)
            where OnDB : class, IIdentifiable, IAuditable;
        Task<bool> ExistsById<OnDB>(Guid id, CancellationToken cancellationToken)
            where OnDB : class, IIdentifiable;
        Task<OnDB?> FirstOrDefaultByIdAsync<OnDB>(Guid id, CancellationToken cancellationToken)
            where OnDB : class, IIdentifiable;
        Task<OnDTO?> FirstOrDefaultByIdAsync<OnDB, OnDTO>(Guid id, CancellationToken cancellationToken)
            where OnDB : class, IIdentifiable
            where OnDTO : class, IIdentifiableDTO, IAuditableDTO;
        Task<List<OnDB>> GetAllAsync<OnDB>(Expression<Func<OnDB, bool>> where, CancellationToken cancellationToken)
             where OnDB : class, IEntity, IIdentifiable, IAuditable;
        Task<List<OnDTO>> GetAllAsync<OnDB,OnDTO>(Expression<Func<OnDB, bool>> where, CancellationToken cancellationToken)
            where OnDB : class, IEntity, IIdentifiable, IAuditable
            where OnDTO : class, IEntityDTO, IIdentifiableDTO, IAuditableDTO;

        #region Transactions
        Task BeginTransaction(CancellationToken cancellationToken);
        Task CreateSavePoint(string name, CancellationToken cancellationToken);
        Task RollbackToSavepoint(string name, CancellationToken cancellationToken);
        Task ReleaseSavepoint(string name, CancellationToken cancellationToken);
        Task CommitTransaction(CancellationToken cancellationToken);
        Task RollbackTransaction(CancellationToken cancellationToken);
        #endregion
    }
}
