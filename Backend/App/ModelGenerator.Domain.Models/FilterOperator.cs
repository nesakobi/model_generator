namespace ModelGenerator.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Id">  </param>
    /// <param name="Operator">  </param>
    /// <param name="OperatorDisplayString">  </param>
    public record FilterOperator(
        Guid Id,
        string Operator,
        string? OperatorDisplayString);
}
