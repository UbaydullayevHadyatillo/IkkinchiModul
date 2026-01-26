namespace _2._9_dars.Extension;

public static class StringExtension
{
    public static int GetCountOfcat(this string str)
    {
        var count = 0;
        for (var i = 0; i < str.Length - 2; i++)
        {
            if (str[i] == 'c' && str[i + 1] == 'a' && str[i + 2] == 't')
            {
                count++;
            }
        }
        return count;
    }

}
