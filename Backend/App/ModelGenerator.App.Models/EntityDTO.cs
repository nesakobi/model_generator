using MessagePack;
using ModelGenerator.Common.Helpers;
using ProtoBuf;

namespace ModelGenerator.App.Models
{
    [MessagePackObject]
    [ProtoContract]
    public record EntityDTO(
        [property: Key(0)][property: ProtoMember(1)] Guid Id, 
        [property: Key(1)][property: ProtoMember(2)] string Name,
        [property: Key(2)][property: ProtoMember(3)] string? Comment,
        [property: Key(3)][property: ProtoMember(4)] OOPType OOPType,
        [property: Key(4)][property: ProtoMember(5)] OOPTypeMark OOPTypeMark,
        [property: Key(5)][property: ProtoMember(6)] AccessModifier AccessModifier, 
        [property: Key(6)][property: ProtoMember(7)] IEnumerable<AttributeDTO>? Attributes,
        [property: Key(7)][property: ProtoMember(8)] IEnumerable<PropertyDTO>? Properties,
        [property: Key(8)][property: ProtoMember(9)] IEnumerable<EntityDTO>? InternalDeclaredType, 
        [property: Key(9)][property: ProtoMember(10)] IEnumerable<EntityDTO>? BaseTypes,
        [property: Key(10)][property: ProtoMember(11)] bool IsGeneric);
}
