using _2._8_dars.Services;

namespace _2._8_dars;

internal class Program
{
    static void Main(string[] args)
    {
        INotification notification = GetNotification();
        notification.SendNotification();
    }
    public static INotification GetNotification()
    {
        //INotification Notification = new EmailService();
        //INotification Notification = new AccountService();
        INotification Notification = new TeamsService();
        return Notification;
    }
}
