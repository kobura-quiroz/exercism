public static class Languages
{
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages() => ["C#", "Clojure", "Elm"];

    public static List<string> AddLanguage(List<string> languages, string language) =>
        [..languages, language];

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language)
    {
        for (int i = 0; i < languages.Count; i++)
        if (languages[i] == language)
            return true;
        return false;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages) =>
        languages.Count > 0
        && (languages[0] == "C#" 
        || ((languages.Count == 2 || languages.Count == 3) 
            && languages[1] == "C#"));

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        _ = languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        var hashSet = new HashSet<string>();
        for (int i = 0; i < languages.Count; i++)
            if (!hashSet.Add(languages[i]))
                return false;
        return true;
    }
}
