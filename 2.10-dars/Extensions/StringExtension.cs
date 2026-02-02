namespace _2._10_dars.Extensions;

public static class StringExtension
{
    public static (char start, char end, int lenght, string startThersChar, string endThersChar) TapleFunc(this string str)
    {
        var start = str[0];
        var end = str[str.Length - 1];
        var lenght = str.Length;
        var startThers = str.Substring(0, 3);

    }
}
