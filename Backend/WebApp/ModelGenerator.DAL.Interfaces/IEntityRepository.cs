using ModelGenerator.Domain.Models;

namespace ModelGenerator.DAL.Interfaces
{
    public interface IEntityRepository
    {
        bool CreateEntity(IEnumerable<Entity> entities);

        bool UpdateEntities(IEnumerable<Entity> entities);

        IEnumerable<Entity> GetAllEntities();

        IEnumerable<Entity> GetEntitiesByIds(IEnumerable<Guid> ids);

        bool DeleteEntitiesById(IEnumerable<Guid> ids);
    }
}
