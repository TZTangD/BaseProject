using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using tz.saas.Authorization.Roles;
using tz.saas.Authorization.Users;
using tz.saas.MultiTenancy;

namespace tz.saas.EntityFrameworkCore
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
