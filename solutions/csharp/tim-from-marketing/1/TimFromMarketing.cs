using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department) =>
        $"{(id is not null ? $"[{id}] - " : "")}" +
        $"{name} - {department?.ToUpper() ?? "OWNER"}";
}
