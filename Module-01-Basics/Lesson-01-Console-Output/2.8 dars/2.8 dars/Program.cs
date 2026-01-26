using _2._8_dars.Services;

namespace _2._8_dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static INotificationService GetNotificationService()
        {
            INotificationService notificationService = new TeamService();
            return notificationService;
        }

    }
}
