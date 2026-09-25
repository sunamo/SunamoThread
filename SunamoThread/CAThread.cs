namespace SunamoThread;

/// <summary>
/// Provides thread-safe collection conversion utilities.
/// </summary>
public class CAThread
{
    /// <summary>
    /// Converts an <see cref="IList"/> to a <see cref="List{T}"/> of strings by calling ToString on each element.
    /// </summary>
    /// <param name="list">The source list to convert.</param>
    /// <returns>A new list of string representations of each element.</returns>
    public static List<string> ToListString(IList list)
    {
        var result = new List<string>();
        foreach (var item in list) result.Add(item?.ToString() ?? string.Empty);
        return result;
    }

    /// <summary>
    /// Converts an <see cref="IList"/> to a <see cref="List{T}"/> of objects.
    /// </summary>
    /// <param name="list">The source list to convert.</param>
    /// <returns>A new list containing all elements as objects.</returns>
    public static List<object> ToList(IList list)
    {
        var result = new List<object>();

        foreach (var item in list) result.Add(item);

        return result;
    }
}
