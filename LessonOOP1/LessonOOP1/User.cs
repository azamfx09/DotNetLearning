namespace LessonOOP1;

public class User
{
    public Guid UserGetId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public override string ToString()
    {
        return $"UserId : {UserGetId}\nFirstName : {FirstName}\nLastName : {LastName}\nUserName: {UserName}\nEmail : {Email}\nPhoneNumber : {PhoneNumber}";


        }
}

