public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operation is null)
            throw new ArgumentNullException(nameof(operation));
        
        if (string.IsNullOrWhiteSpace(operation))
            throw new ArgumentException("Operation cannot be empty.", nameof(operation));
        
        return operation switch
        {
            "+" => $"{operand1} + {operand2} = {operand1 + operand2}",
            "*" => $"{operand1} * {operand2} = {operand1 * operand2}",
            "/" => operand2 == 0 
                ? "Division by zero is not allowed." 
                : $"{operand1} / {operand2} = {operand1 / operand2}",
            _ => throw new ArgumentOutOfRangeException(nameof(operation), $"Operation '{operation}' not supported.")
        };
    }
}
