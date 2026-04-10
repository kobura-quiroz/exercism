public struct CurrencyAmount
{
    private readonly decimal amount;
    private readonly string currency;

    private static readonly ArgumentException _differentCurrenciesException = new("Different currencies are not comparable");

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public static bool operator ==(CurrencyAmount left, CurrencyAmount right) =>
        CurrenciesAreEqual(left, right)
        ? left.amount == right.amount
        : throw _differentCurrenciesException;

    public static bool operator !=(CurrencyAmount left, CurrencyAmount right) =>
        CurrenciesAreEqual(left, right)
        ? left.amount != right.amount
        : throw _differentCurrenciesException;

    public static bool operator >(CurrencyAmount left, CurrencyAmount right) =>
        CurrenciesAreEqual(left, right)
        ? left.amount > right.amount
        : throw _differentCurrenciesException;

    public static bool operator <(CurrencyAmount left, CurrencyAmount right) =>
        CurrenciesAreEqual(left, right)
        ? left.amount < right.amount
        : throw _differentCurrenciesException;

    public static decimal operator +(CurrencyAmount left, CurrencyAmount right) =>
        CurrenciesAreEqual(left, right)
        ? left.amount + right.amount
        : throw _differentCurrenciesException;

    public static decimal operator -(CurrencyAmount left, CurrencyAmount right) =>
        CurrenciesAreEqual(left, right)
        ? left.amount - right.amount
        : throw _differentCurrenciesException;

    public static decimal operator *(CurrencyAmount left, CurrencyAmount right) =>
        CurrenciesAreEqual(left, right)
        ? left.amount * right.amount
        : throw _differentCurrenciesException;

    public static decimal operator /(CurrencyAmount left, CurrencyAmount right) =>
        CurrenciesAreEqual(left, right)
        ? left.amount / right.amount
        : throw _differentCurrenciesException;

    public static explicit operator double(CurrencyAmount ca) => (double)ca.amount;

    public static implicit operator decimal(CurrencyAmount ca) => ca.amount;

    private static bool CurrenciesAreEqual(CurrencyAmount left, CurrencyAmount right) =>
        string.Equals(left.currency, right.currency, StringComparison.OrdinalIgnoreCase);
}
