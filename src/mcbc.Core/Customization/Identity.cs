//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//namespace JP.Domain
//{
//    public class AppUser : IdentityUser<int>
//    {
//        public virtual ICollection<AppUserClaim> Claims { get; set; }
//        public virtual ICollection<AppUserLogin> Logins { get; set; }
//        public virtual ICollection<AppUserToken> Tokens { get; set; }
//        public virtual ICollection<AppUserRole> UserRoles { get; set; }

//        [StringLength(50)]
//        public string FirstName { get; set; }
//        [StringLength(50)]
//        public string LastName { get; set; }
        
//        public Donar Donar { get; set; }
//        public NGOUser NGOUser { get; set; }
//        public IList<UserFavoriteCause> UserFavoriteCause { get; set; }

//    }

//    public class AppRole : IdentityRole<int>
//    {
//        public virtual ICollection<AppUserRole> UserRoles { get; set; }
//        public virtual ICollection<AppRoleClaim> RoleClaims { get; set; }
//    }

//    public class AppUserRole : IdentityUserRole<int>
//    {
//        public virtual AppUser User { get; set; }
//        public virtual AppRole Role { get; set; }
//    }

//    public class AppUserClaim : IdentityUserClaim<int>
//    {
//        public virtual AppUser User { get; set; }
//    }

//    public class AppUserLogin : IdentityUserLogin<int>
//    {
//        public virtual AppUser User { get; set; }
//    }

//    public class AppRoleClaim : IdentityRoleClaim<int>
//    {
//        public virtual AppRole Role { get; set; }
//    }

//    public class AppUserToken : IdentityUserToken<int>
//    {
//        public virtual AppUser User { get; set; }
//    }
//}
