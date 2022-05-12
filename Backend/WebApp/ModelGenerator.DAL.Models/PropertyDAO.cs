using ModelGenerator.Common.Helpers;

namespace ModelGenerator.DAL.Models
{
    public class PropertyDAO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public PropertyType Type { get; set; }

        public string ValueValidatorRegex { get; set; }

        public object DefaultValue { get; set; }

        public IEnumerable<Guid> AttributeIds { get; set; }

        public IEnumerable<Guid> FilterOperatorIds { get; set; }
    }
}