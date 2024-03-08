namespace SunamoThread;

public class CAThread
{
    #region ToList to avoid StackOverflowException
    //public static List<object> ToList(IList e)
    //{
    //    return se.CAThread.ToList(e);
    //}
    #endregion

    public static List<string> ToListString(IList e)
    {
        // todo přidat SunExt
        List<string> ls = new List<string>(/*e.Count()*/);
        foreach (var item in e)
        {
            ls.Add(item.ToString());
        }
        return ls;
    }

    #region ToList to avoid StackOverflowException

    public static List<object> ToList(IList e)
    {
        // todo přidat SunExt
        List<object> ls = new List<object>(/*e.Count()*/);

        foreach (object item in e)
        {
            ls.Add(item);
        }

        return ls;
    }

    #endregion
}
