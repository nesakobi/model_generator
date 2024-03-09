using MessagePack;
using ModelGenerator.Common.Helpers;
using ProtoBuf;

namespace ModelGenerator.App.Models
{
    [MessagePackObject]
    [ProtoContract]
    public class PropertyDTO
    {
        [Key(0)]
        [ProtoMember(1)]
        public required Guid Id { get; set; }

        [Key(1)]
        [ProtoMember(2)]
        public required string Name { get; set; }

        [Key(2)]
        [ProtoMember(3)]
        public required PropertyType Type { get; set; }

        [Key(3)]
        [ProtoMember(4)]
        public EntityDTO? PropertyType { get; set; }

        [Key(4)]
        [ProtoMember(5)]
        public string? ValueValidatorRegex { get; set; }

        [Key(5)]
        [ProtoMember(6)]
        public string? Comment { get; set; }

        [Key(6)]
        [ProtoMember(7)]
        public object? DefaultValue { get; set; }

        [Key(7)]
        [ProtoMember(8)]
        public string? DisplayName { get; set; }

        [Key(8)]
        [ProtoMember(9)]
        public string? Description { get; set; }

        [Key(9)]
        [ProtoMember(10)]
        public IEnumerable<AttributeDTO>? AttributeList { get; set; }

        [Key(10)]
        [ProtoMember(11)]
        public IEnumerable<FilterOperatorDTO>? FilterOperators { get; set; }
    }
}
