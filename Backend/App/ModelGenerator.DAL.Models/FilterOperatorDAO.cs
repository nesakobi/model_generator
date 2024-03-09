namespace ModelGenerator.DAL.Models
{
    public class FilterOperatorDAO
    {
        public Guid Id { get; set; }

        public required string Operator { get; set; }

        public string? OperatorDisplayString { get; set; }
    }
}
