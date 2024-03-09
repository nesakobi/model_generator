using MessagePack;
using ProtoBuf;

namespace ModelGenerator.App.Models
{
    [MessagePackObject]
    [ProtoContract]
    public class AttributeDTO
    {
        [Key(0)]
        [ProtoMember(1)]
        public required Guid Id { get; set; }

        [Key(1)]
        [ProtoMember(2)]
        public required string Name { get; set; }
    }
}
