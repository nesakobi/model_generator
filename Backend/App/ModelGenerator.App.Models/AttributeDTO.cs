using MessagePack;
using ProtoBuf;

namespace ModelGenerator.App.Models
{
    [MessagePackObject]
    [ProtoContract]
    public record AttributeDTO(
        [property: Key(0)][property: ProtoMember(1)] Guid Id,
        [property: Key(1)][property: ProtoMember(2)] string Name);
}
