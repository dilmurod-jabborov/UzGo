using UzGo.Domain.Enums;

namespace UzGo.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public Gender Gender { get; set; }
    public int Age { get; set; }
}
