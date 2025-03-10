using MessagePack;
using ModelGenerator.Common.Helpers;
using ProtoBuf;

namespace ModelGenerator.App.Models
{
    [MessagePackObject]
    [ProtoContract]
    public record PropertyDTO(
        [property: Key(0)][property: ProtoMember(1)] Guid Id,
        [property: Key(1)][property: ProtoMember(2)] string Name,
        [property: Key(2)][property: ProtoMember(3)] PropertyType Type,
        [property: Key(3)][property: ProtoMember(4)] EntityDTO? PropertyType,
        [property: Key(4)][property: ProtoMember(5)] string? ValueValidatorRegex,
        [property: Key(5)][property: ProtoMember(6)] string? Comment,
        [property: Key(6)][property: ProtoMember(7)] object? DefaultValue,
        [property: Key(7)][property: ProtoMember(8)] string? DisplayName,
        [property: Key(8)][property: ProtoMember(9)] string? Description,
        [property: Key(9)][property: ProtoMember(10)] IEnumerable<AttributeDTO>? AttributeList,
        [property: Key(10)][property: ProtoMember(11)] IEnumerable<FilterOperatorDTO>? FilterOperators);
}
