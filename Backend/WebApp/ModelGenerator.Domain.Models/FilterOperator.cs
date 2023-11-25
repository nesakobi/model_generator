namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        public required Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public required string Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string? OperatorDisplayString { get; set; }
    }
}
