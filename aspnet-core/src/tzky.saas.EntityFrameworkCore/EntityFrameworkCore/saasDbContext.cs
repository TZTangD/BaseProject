using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using tzky.saas.Authorization.Roles;
using tzky.saas.Authorization.Users;
using tzky.saas.MultiTenancy;

namespace tzky.saas.EntityFrameworkCore
{
    public class saasDbContext : AbpZeroDbContext<Tenant, Role, User, saasDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public saasDbContext(DbContextOptions<saasDbContext> options)
            : base(options)
        {
        }
    }
}
