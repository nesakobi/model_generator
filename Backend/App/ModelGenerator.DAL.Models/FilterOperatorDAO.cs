namespace ModelGenerator.DAL.Models
{
    public record FilterOperatorDAO(
        Guid Id,
        string Operator,
        string? OperatorDisplayString);
}
