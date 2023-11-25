using ModelGenerator.Common.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ModelGenerator.DAL.Models
{
    internal class EntityDAO
    {
        public required Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Comment { get; set; }

        [BsonRepresentation(BsonType.String)]
        public required OOPType OOPType { get; set; }

        [BsonRepresentation(BsonType.String)]
        public OOPTypeMark OOPTypeMark { get; set; }

        [BsonRepresentation(BsonType.String)]
        public AccessModifier AccessModifier { get; set; }

        public IEnumerable<Guid>? AttributeIds { get; set; }

        public IEnumerable<Guid>? PropertyIds { get; set; }

        public IEnumerable<Guid>? InternalDeclaredTypeIds { get; set; }

        public IEnumerable<Guid>? BaseTypeIds { get; set; }

        public bool IsGeneric { get; set; }
    }
}
