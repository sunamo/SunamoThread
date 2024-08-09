namespace SunamoThread;

public class CAThread
{
    public static List<string> ToListString(IList e)
    {
        // todo přidat SunExt
        var ls = new List<string>( /*e.Count()*/);
        foreach (var item in e) ls.Add(item.ToString());
        return ls;
    }

    #region ToList to avoid StackOverflowException

    public static List<object> ToList(IList e)
    {
        // todo přidat SunExt
        var ls = new List<object>( /*e.Count()*/);

        foreach (var item in e) ls.Add(item);

        return ls;
    }

    #endregion

    #region ToList to avoid StackOverflowException

    //public static List<object> ToList(IList e)
    //{
    //    return se.CAThread.ToList(e);
    //}

    #endregion
}