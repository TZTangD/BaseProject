using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace tzky.saas.EntityFrameworkCore
{
    public static class saasDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<saasDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<saasDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
