using ModelGenerator.Common.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ModelGenerator.DAL.Models
{
    public class PropertyDAO
    {
        public required Guid Id { get; set; }

        public required string Name { get; set; }

        [BsonRepresentation(BsonType.String)]
        public required PropertyType Type { get; set; }

        public Guid? PropertyTypeId { get; set; }

        public string? ValueValidatorRegex { get; set; }

        public string? Comment { get; set; }

        public object? DefaultValue { get; set; }

        public string? DisplayName { get; set; }

        public string? Description { get; set; }

        public IEnumerable<Guid>? AttributeIds { get; set; }

        public IEnumerable<Guid>? FilterOperatorIds { get; set; }
    }
}