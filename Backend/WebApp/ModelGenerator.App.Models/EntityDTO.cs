using MessagePack;
using ModelGenerator.Common.Helpers;
using ProtoBuf;

namespace ModelGenerator.App.Models
{
    [MessagePackObject]
    [ProtoContract]
    public class EntityDTO
    {
        [Key(0)]
        [ProtoMember(1)]
        public required Guid Id { get; set; }

        [Key(1)]
        [ProtoMember(2)]
        public required string Name { get; set; }

        [Key(2)]
        [ProtoMember(3)]
        public string? Comment { get; set; }

        [Key(3)]
        [ProtoMember(4)]
        public required OOPType OOPType { get; set; }

        [Key(4)]
        [ProtoMember(5)]
        public OOPTypeMark OOPTypeMark { get; set; }

        [Key(5)]
        [ProtoMember(6)]
        public AccessModifier AccessModifier { get; set; }

        [Key(6)]
        [ProtoMember(7)]
        public IEnumerable<AttributeDTO>? Attributes { get; set; }

        [Key(7)]
        [ProtoMember(8)]
        public IEnumerable<PropertyDTO>? Properties { get; set; }

        [Key(8)]
        [ProtoMember(9)]
        public IEnumerable<EntityDTO>? InternalDeclaredType { get; set; }

        [Key(9)]
        [ProtoMember(10)]
        public IEnumerable<EntityDTO>? BaseTypes { get; set; }

        [Key(10)]
        [ProtoMember(11)]
        public bool IsGeneric { get; set; }
    }
}
