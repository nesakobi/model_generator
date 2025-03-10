using ModelGenerator.Common.Helpers;

namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// Describing class property
    /// </summary>
    /// <param name="Id">  </param>
    /// <param name="Name"> Property name </param>
    /// <param name="Type"> Property type </param>
    /// <param name="PropertyType"> Custom type for property
    /// 
    /// not null when Type == <see cref="PropertyType.Custom"/> </param>
    /// <param name="ValueValidatorRegex"> Property value validation regex </param>
    /// <param name="Comment"> Comment for property </param>
    /// <param name="DefaultValue"> Default value for property </param>
    /// <param name="DisplayName"> Display name - UI purpose </param>
    /// <param name="Description"> Description about use cases - UI purpose </param>
    /// <param name="AttributeList"> Attributes connected to the property </param>
    /// <param name="FilterOperators"> Filter operators allowed for property - UI purpose </param>
    public record Property(
        Guid Id,
        string Name,
        PropertyType Type,
        Entity? PropertyType,
        string? ValueValidatorRegex,
        string? Comment,
        object? DefaultValue,
        string? DisplayName,
        string? Description,
        IEnumerable<Attribute>? AttributeList,
        IEnumerable<FilterOperator>? FilterOperators);
}