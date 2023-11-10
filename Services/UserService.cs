using CRM.Models;

namespace CRM.Services;

public static class UserService
{
    static List<User> Users { get; }
    static int nextId = 3;
    static UserService()
    {
        Users = new List<User>
        {
            new User { Id = 1, UserName = "khadeja", Password = "12345" },
            new User { Id = 2, UserName = "moha", Password = "2222" }
        };
    }
    public static User? Get(string userName, string password) => Users.FirstOrDefault(p => p.UserName == userName && p.Password == password);
}
