using ModelGenerator.DAL.Interfaces;
using ModelGenerator.Domain.Models;

namespace ModelGenerator.DAL.Implementations
{
    public class PropertyRepository : IPropertyRepository
    {
        public bool CreateTypeProperties(Guid typeId, IEnumerable<Property> properties)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTypeProperties(Guid typeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Property> GetTypePropertiesByType(Guid typeId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTypeProperties(Guid typeId, IEnumerable<Property> properties)
        {
            throw new NotImplementedException();
        }
    }
}