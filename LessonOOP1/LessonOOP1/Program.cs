namespace LessonOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.UserGetId = Guid.NewGuid();
            user.UserName = "azamat";
            user.FirstName = "Azamat";
            user.LastName = "Rakhmonkulov";
            user.PhoneNumber = "1234567890";
            user.Email = "a@gmail.com";


            Console.WriteLine(user);
        }
    }
}
