using ModelGenerator.DAL.Interfaces;
using ModelGenerator.Domain.Models;

namespace ModelGenerator.DAL.Implementations
{
    internal class EntityRepository : IEntityRepository
    {
        public bool CreateEntity(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntitiesById(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> GetEntitiesByIds(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntities(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
