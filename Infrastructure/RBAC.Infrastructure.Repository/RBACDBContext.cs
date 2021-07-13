using Microsoft.EntityFrameworkCore;
using RBAC.Entitys;

namespace RBAC.Infrastructure.Repository
{
    public class RBACDBContext : DbContext
    {
        public RBACDBContext() { }
        public RBACDBContext(DbContextOptions<RBACDBContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
        }

        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<MutuallyExclusive> MutuallyExclusives { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<RelGroupRole> RelGroupRoles { get; set; }
        public DbSet<RelIdentityRole> RelIdentityRoles { get; set; }
        public DbSet<RelOrgRole> RelOrgRoles { get; set; }
        public DbSet<RelRoleAut> RelRoleAuts { get; set; }
        public DbSet<RelUserGroup> RelUserGroups { get; set; }
        public DbSet<RelUserIdentity> RelUserIdentities { get; set; }
        public DbSet<RelUserOrg> RelUserOrgs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}