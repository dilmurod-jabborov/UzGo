using UzGo.Domain.Enums;
using UzGo.Domain.Models;

namespace UzGo.Data.IRepository;

public interface IDriverService
{
    void RegisterDriver(Driver driver);
    int Login(string phoneNumber, string password);
    void Logout(int driverId);
    void UpdateDriverAccount(int driverId, string fullName, string phoneNumber, int age, Gender gender);
    void UpdateDriverForAdmin(int driverId, Car car);
    void IsActiveDriver(bool isActive);
    void DeleteDriverForAdmin(int driverId);
}
