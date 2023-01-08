namespace ConsExcursion;

public static class temps
{
    public static string conversion_hhmm(int nmMn)
    {
        var mn = nmMn % 60;
        var hh = (nmMn - mn) / 60;
        return mn + "h:" + hh + "m";
    }
}