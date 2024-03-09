namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// Represents class or property attribute
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public required Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public required string Name { get; set; }
    }
}
