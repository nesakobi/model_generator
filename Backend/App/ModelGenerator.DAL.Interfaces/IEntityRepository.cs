using ModelGenerator.Domain.Models;

namespace ModelGenerator.DAL.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEntityRepository
    {
        Entity CreateEntity(IEnumerable<Entity> entities);

        bool UpdateEntities(IEnumerable<Entity> entities);

        IEnumerable<Entity> GetAllEntities();

        IEnumerable<Entity> GetEntitiesByIds(IEnumerable<Guid> ids);

        bool DeleteEntitiesById(IEnumerable<Guid> ids);
    }
}
