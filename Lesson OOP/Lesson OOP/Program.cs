using System.Xml;

namespace Lesson_OOP;

internal class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();
        user1.UserId = Guid.NewGuid();
        user1.UserName = "azamatchik";
        user1.UserFirstName = "Azamat";
        user1.UserLastName = "Rahmonqulov";
        user1.UserPhone = "1234567890";
        user1.UserEmail = "azamat@gmail.com";

        User user2 = new User()
        {
            UserId = Guid.NewGuid(),
            UserName = "azamat09",
            UserFirstName = "Azamat",
            UserLastName = "Rakhmonkulov",
            UserPhone = "931545509",
            UserEmail = "azamat1@gmail.com",
        };

        Console.WriteLine(user1);
        Console.WriteLine(user2);
       


        //int num1 = 30;
        //int num2 = 12;


        //var res = GetSummNumber(num1, num2);

        //Console.WriteLine(res);


        // DTO => Data Transfer Object
    }




    static int GetSummNumber(int a, int b)
    {
        return a + b;
    }



    static int GetSummNumber(int a, int b, int c)
    {
        return a + b + c;
    }
}
