namespace SunamoThread;

/// <summary>
/// Represents the CA thread type.
/// </summary>
public class CAThread
{
    /// <summary>
    /// To list string.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>The to list string result.</returns>
    public static List<string> ToListString(IList list)
    {
        var result = new List<string>();
        foreach (var item in list) result.Add(item?.ToString() ?? string.Empty);
        return result;
    }

    /// <summary>
    /// To list.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>The to list result.</returns>
    public static List<object> ToList(IList list)
    {
        var result = new List<object>();

        foreach (var item in list) result.Add(item);

        return result;
    }
}
