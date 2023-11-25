using MessagePack;
using ProtoBuf;

namespace ModelGenerator.App.Models
{
    [MessagePackObject]
    [ProtoContract]
    public class FilterOperatorDTO
    {
        [Key(0)]
        [ProtoMember(1)]
        public required Guid Id { get; set; }

        [Key(1)]
        [ProtoMember(2)]
        public required string Operator { get; set; }

        [Key(2)]
        [ProtoMember(3)]
        public string? OperatorDisplayString { get; set; }
    }
}
