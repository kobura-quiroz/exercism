public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    
    public override bool Equals(Object obj)
    {
        if (obj is not FacialFeatures other)
            return false;
        return this.EyeColor == other.EyeColor
            && this.PhiltrumWidth == other.PhiltrumWidth;
    }

    public override int GetHashCode() =>
        HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    
    public override bool Equals(Object obj)
    {
        if (obj is not Identity other)
            return false;
        return this.Email == other.Email
            && this.FacialFeatures.Equals(other.FacialFeatures);
    }

    public override int GetHashCode() =>
        HashCode.Combine(Email, FacialFeatures);
}

public class Authenticator
{
    private const string AdminEmail = "admin@exerc.ism";
    private readonly FacialFeatures AdminFacialFeatures = new("green", 0.9m);
    private HashSet<Identity> Identities = new();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) =>
        faceA.Equals(faceB);
    
    public bool IsAdmin(Identity identity) =>
        identity.Email == AdminEmail &&
        identity.FacialFeatures.Equals(AdminFacialFeatures);
    
    public bool Register(Identity identity) =>
        Identities.Add(identity);
    
    public bool IsRegistered(Identity identity) =>
        Identities.TryGetValue(identity, out _);
    
    public static bool AreSameObject(Identity identityA, Identity identityB) =>
        identityA == identityB;
}
