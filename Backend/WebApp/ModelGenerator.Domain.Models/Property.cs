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
        /// Proeprty type
        /// </summary>
        public required PropertyType Type { get; set; }

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
        /// Describtion about use cases - UI purpose
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