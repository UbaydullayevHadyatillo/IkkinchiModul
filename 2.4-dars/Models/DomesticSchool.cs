namespace _2._4_dars.Models;

public class DomesticSchool : School
{
    public string NickName { get; set; }

    public DomesticSchool(string nickName)
    {
        NickName = nickName;
        Console.WriteLine("Domestik school ctor ishladi");
    }
}
