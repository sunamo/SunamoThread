namespace SunamoThread;

public class CAThread
{
    public static List<string> ToListString(IList list)
    {
        var result = new List<string>();
        foreach (var item in list) result.Add(item?.ToString() ?? string.Empty);
        return result;
    }

    public static List<object> ToList(IList list)
    {
        var result = new List<object>();

        foreach (var item in list) result.Add(item);

        return result;
    }
}
