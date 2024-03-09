using ModelGenerator.Common.Helpers;

namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// Describing class property
    /// </summary>
    public class Property
    {
        /// <summary>
        /// 
        /// </summary>
        public required Guid Id { get; set; }

        /// <summary>
        /// Property name
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Property type
        /// </summary>
        public required PropertyType Type { get; set; }

        /// <summary>
        /// Custom type for property
        /// 
        /// not null when Type == <see cref="PropertyType.Custom"/>
        /// </summary>
        public Entity? PropertyType { get; set; }

        /// <summary>
        /// Property value validation regex
        /// </summary>
        public string? ValueValidatorRegex { get; set; }

        /// <summary>
        /// Comment for property
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// Default value for property
        /// </summary>
        public object? DefaultValue { get; set; }

        /// <summary>
        /// Display name - UI purpose
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Description about use cases - UI purpose
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Attributes connected to the property
        /// </summary>
        public IEnumerable<Attribute>? AttributeList { get; set; }

        /// <summary>
        /// Filter operators allowed for property - UI purpose
        /// </summary>
        public IEnumerable<FilterOperator>? FilterOperators { get; set; }
    }
}