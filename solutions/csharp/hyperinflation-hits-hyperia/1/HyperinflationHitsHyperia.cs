using System.Numerics;

public static class CentralBank
{
    private const string DefaultErrorMessage = "*** Too Big ***";

    public static string DisplayDenomination(long @base, long multiplier) =>
        MultiplyBigNumbers(@base, multiplier);

    public static string DisplayGDP(float @base, float multiplier) =>
        MultiplyBigNumbers(@base, multiplier);

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier) =>
        MultiplyBigNumbers(salaryBase, multiplier, errorMessage: "*** Much Too Big ***");

    private static string MultiplyBigNumbers<T>(T @base, T multiplier, string errorMessage = DefaultErrorMessage) where T : INumber<T>
    {
        try
        {
            var result = checked(@base * multiplier);

            if (result is float f && float.IsInfinity(f))
                return errorMessage;

            return result.ToString();
        }
        catch (OverflowException)
        {
            return errorMessage;
        }
    }
}
