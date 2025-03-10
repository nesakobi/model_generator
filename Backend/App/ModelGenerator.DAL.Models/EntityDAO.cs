using ModelGenerator.Common.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ModelGenerator.DAL.Models
{
    internal record EntityDAO(
        Guid Id,
        string Name,
        string? Comment,
        [property: BsonRepresentation(BsonType.String)] OOPType OOPType,
        [property: BsonRepresentation(BsonType.String)] OOPTypeMark OOPTypeMark,
        [property: BsonRepresentation(BsonType.String)] AccessModifier AccessModifier,
        IEnumerable<Guid>? AttributeIds,
        IEnumerable<Guid>? PropertyIds,
        IEnumerable<Guid>? InternalDeclaredTypeIds,
        IEnumerable<Guid>? BaseTypeIds, bool IsGeneric);
}
