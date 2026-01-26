namespace _2._9_dars.Extension;

public static class IntExtension
{
    public static int GetSumOfFromOne(this int num)
    {
        var sum = 0;
        for(var i = 1; i <= num; i++)
        {
            sum += i;
        }
        return sum;
    }
}
