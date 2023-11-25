using ModelGenerator.Common.Helpers;

namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// Describing class, struct, ...
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Unique resource identifier
        /// </summary>
        public required Guid Id { get; set; }

        /// <summary>
        /// Type name
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Comment for type
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// class/struct/interface/...
        /// </summary>
        public required OOPType OOPType { get; set; }

        /// <summary>
        /// Type mark abstract/sealed/...
        /// </summary>
        public OOPTypeMark OOPTypeMark { get; set; }

        /// <summary>
        /// Type access modifier
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Type attributes
        /// </summary>
        public IEnumerable<Attribute>? Attributes { get; set; }

        /// <summary>
        /// Type properties
        /// </summary>
        public IEnumerable<Property>? Properties { get; set; }

        /// <summary>
        /// Inner declated types
        /// </summary>
        public IEnumerable<Entity>? InternalDeclaredType { get; set; }

        /// <summary>
        /// Base type inheritance/implementation
        /// </summary>
        public IEnumerable<Entity>? BaseTypes { get; set; }

        /// <summary>
        /// Marking as generic
        /// </summary>
        public bool IsGeneric { get; set; }
    }
}
