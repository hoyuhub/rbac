using System.Threading.Tasks;

namespace RBAC.Domain.User
{
    public interface IUser
    {
        Task RegisterAsync(Models.User user);
    }
}
