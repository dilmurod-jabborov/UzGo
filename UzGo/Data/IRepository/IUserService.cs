using UzGo.Domain.Enums;

namespace UzGo.Data.IRepository;

public interface IUserService
{
    void RegisterUser(string phoneNumber, string password, string fullName, int age, Gender gender);
    int Login(string phoneNumber, string password);
    void Longout(int id);
    void UpdateUserAccount(string fullName,  string phoneNumber, int age, Gender gender);
    void DeleteUserAccount(int id);
    void GetAccount(int id);
    void OrderHistory(int id);
}
