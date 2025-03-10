using ModelGenerator.Common.Helpers;

namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// Describing class, struct, ...
    /// </summary>
    /// <param name="Id"> Unique resource identifier </param>
    /// <param name="Name"> Type name </param>
    /// <param name="Comment"> Comment for type </param>
    /// <param name="OOPType"> class/struct/interface/... </param>
    /// <param name="OOPTypeMark"> Type mark abstract/sealed/... </param>
    /// <param name="AccessModifier"> Type access modifier </param>
    /// <param name="Attributes"> Type attributes </param>
    /// <param name="Properties"> Type properties </param>
    /// <param name="InternalDeclaredType"> Inner declared types </param>
    /// <param name="BaseTypes"> Base type inheritance/implementation </param>
    /// <param name="IsGeneric"> Marking as generic </param>
    public record Entity(
        Guid Id,
        string Name,
        string? Comment,
        OOPType OOPType,
        OOPTypeMark OOPTypeMark,
        AccessModifier AccessModifier,
        IEnumerable<Attribute>? Attributes,
        IEnumerable<Property>? Properties,
        IEnumerable<Entity>? InternalDeclaredType,
        IEnumerable<Entity>? BaseTypes,
        bool IsGeneric);
}
