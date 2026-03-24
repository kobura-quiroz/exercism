using System.Collections.ObjectModel;

public class Authenticator
{
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public Authenticator(Identity admin)
    {
        this.admin = admin;
    }

    private readonly Identity admin;

    private readonly IDictionary<string, Identity> developers
        = new Dictionary<string, Identity>
        {
            ["Bertrand"] = new Identity
            {
                Email = "bert@ex.ism",
                EyeColor = "blue"
            },

            ["Anders"] = new Identity
            {
                Email = "anders@ex.ism",
                EyeColor = "brown"
            }
        };

    public Identity Admin
    {
        get { return admin; }
    }

    public IDictionary<string, Identity> GetDevelopers()
    {
        var copy = new Dictionary<string, Identity>();

        foreach (var kvp in developers)
        {
            copy[kvp.Key] = new Identity
            {
                Email = kvp.Value.Email,
                EyeColor = kvp.Value.EyeColor
            };
        }

        return new ReadOnlyDictionary<string, Identity>(copy);
    }
}

public struct Identity
{
    public string Email { get; set; }

    public string EyeColor { get; set; }
}
