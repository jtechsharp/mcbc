using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using mcbc.Authorization.Roles;
using mcbc.Authorization.Users;
using mcbc.MultiTenancy;
using mcbc.Customization;

namespace mcbc.EntityFrameworkCore
{
    public class mcbcDbContext : AbpZeroDbContext<Tenant, Role, User, mcbcDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<NGO> NGOs { get; set; }
        public DbSet<Cause> Causes { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<UserFavoriteCause> UserFavoriteCause { get; set; }


        public DbSet<MembershipRequest> MembershipRequests { get; set; }



        public mcbcDbContext(DbContextOptions<mcbcDbContext> options)
            : base(options)
        {
            
        }
    }
}
