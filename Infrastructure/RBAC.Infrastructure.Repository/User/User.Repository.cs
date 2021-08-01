using RBAC.Domain.User;
using System.Threading.Tasks;

namespace RBAC.Infrastructure.Repository.User
{
    public class User : IUser
    {
        private readonly RBACDBContext _RBACDBContext;
        public User(RBACDBContext rBACDBContext)
        {
            _RBACDBContext = rBACDBContext;
        }

        public async Task RegisterAsync(Models.User user)
        {
            _RBACDBContext.Users.Add();
        }
    }
}
