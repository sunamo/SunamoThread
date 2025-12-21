namespace SunamoThread;

public class CAThread
{
    public static List<string> ToListString(IList e)
    {
        // todo přidat SunExt
        var sourceList = new List<string>( /*e.Count()*/);
        foreach (var item in e) sourceList.Add(item.ToString());
        return sourceList;
    }

    #region ToList to avoid StackOverflowException

    public static List<object> ToList(IList e)
    {
        // todo přidat SunExt
        var sourceList = new List<object>( /*e.Count()*/);

        foreach (var item in e) sourceList.Add(item);

        return sourceList;
    }

    #endregion

    #region ToList to avoid StackOverflowException

    //public static List<object> ToList(IList e)
    //{
    //    return se.CAThread.ToList(e);
    //}

    #endregion
}