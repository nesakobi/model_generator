using ModelGenerator.Domain.Models;

namespace ModelGenerator.DAL.Interfaces
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetTypePropertiesByType(Guid typeId);

        bool CreateTypeProperties(Guid typeId, IEnumerable<Property> properties);

        bool DeleteTypeProperties(Guid typeId);

        bool UpdateTypeProperties(Guid typeId, IEnumerable<Property> properties);
    }
}