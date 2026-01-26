namespace Lesson_OOP;

public class User
{
    public Guid UserId { get; set; }
    public string UserFirstName { get; set; }
    public string UserLastName { get; set; }
    public string UserName { get; set; }
    private string UserPassword
    {
        get;
        set;
    }
    public string UserEmail { get; set; }
    public string UserPhone { get; set; }





    override public string ToString()
    {
        return $"UserId : {UserId}\nFN : {UserFirstName}\nLN : {UserLastName}\nEmail : {UserEmail}\nPhone : {UserPhone}";
    }
}
