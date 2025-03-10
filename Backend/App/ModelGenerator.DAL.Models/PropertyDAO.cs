using ModelGenerator.Common.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ModelGenerator.DAL.Models
{
    public record PropertyDAO(
        Guid Id,
        string Name,
        [property: BsonRepresentation(BsonType.String)] PropertyType Type,
        Guid? PropertyTypeId,
        string? ValueValidatorRegex,
        string? Comment,
        object? DefaultValue,
        string? DisplayName,
        string? Description,
        IEnumerable<Guid>? AttributeIds,
        IEnumerable<Guid>? FilterOperatorIds);
}