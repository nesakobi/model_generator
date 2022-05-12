using ModelGenerator.Common.Helpers;

namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Property
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public PropertyType Type { get; set; }

        public string ValueValidatorRegex { get; set; }

        public string Comment { get; set; }

        public object DefaultValue { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public IEnumerable<Attribute> AttributeList { get; set; }
    }
}