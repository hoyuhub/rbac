namespace RBAC.Models
{
    public class User : BaseModel
    {
        // 登录名
        public string LoginName { get; set; }
        // 昵称
        public string UserName { get; set; }
        // 密码 
        public string Password { get; set; }
    }
}
