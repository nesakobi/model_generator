using ModelGenerator.Common.Helpers;

namespace ModelGenerator.Domain.Models
{
    public class Entity
    {
        public string Name { get; set; }

        public string? Comment { get; set; }

        public OOPType OOPType { get; set; }

        public OOPTypeMark OOPTypeMark { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public IEnumerable<Attribute> Attributes { get; set; }

        public IEnumerable<Property> Properties { get; set; }

        public IEnumerable<Entity> InternlaDeclaredType { get; set; }

        public IEnumerable<Entity> BaseTypes { get; set; }

        public bool IsGeneric { get; set; }
    }
}
