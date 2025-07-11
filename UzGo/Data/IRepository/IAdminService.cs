using UzGo.Domain.Models;

namespace UzGo.Data.IRepository;

public interface IAdminService
{
    void RegisterAdmin(Admin admin);
    int LoginAdmin(string phoneNumber,  string password);
    int UpdateAdmin(string fullName, string phoneNumber);
    void Longout(int id);
}
