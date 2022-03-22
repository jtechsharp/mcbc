using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace mcbc.EntityFrameworkCore
{
    public static class mcbcDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<mcbcDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<mcbcDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
