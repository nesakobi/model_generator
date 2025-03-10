namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// Represents class or property attribute
    /// </summary>
    /// <param name="Id">  </param>
    /// <param name="Name">  </param>
    public record Attribute(
        Guid Id,
        string Name);
}
