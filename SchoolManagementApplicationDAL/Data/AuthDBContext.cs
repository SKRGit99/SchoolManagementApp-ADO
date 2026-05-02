using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SchoolManagementApplicationDAL.Data
{
    public class AuthDBContext : IdentityDbContext
    {
        public AuthDBContext(DbContextOptions<AuthDBContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=LAPTOP-K1PVP9J6;Database=DevAppDb;Trusted_Connection=True;TrustServerCertificate=Yes;");
        //    }
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed Roles (Student, Educator, Admin)
            var studentRoleId = "31371bcb-ae05-4d27-967b-b27047aecbf7";
            var employeeRoleId = "568a834c-3049-492e-ae5d-09b7dc39db19";
            var educatorRoleId = "f473d18b-b0ff-4606-9e80-8dda261019c9";
            var adminRoleId = "ac9ff895-6c6a-4653-a52d-f42947a30810";
            var superAdminRoleId = "d2436ebc-8ff2-4a4a-931b-0f311f58f4da";
            var directorRoleId = "ddb9168c-704f-44af-8403-8def10a67eb1";
            var principalRoleId = "adb1abf0-c8dd-45a6-b760-bc61c30c4fef";
            var guestRoleId = "fe342b15-5975-41d8-83cb-d7b1b8b8b152";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Guest",
                    NormalizedName = "Guest",
                    Id = guestRoleId,
                    ConcurrencyStamp = guestRoleId
                },
                new IdentityRole
                {
                    Name = "Student",
                    NormalizedName = "Student",
                    Id = studentRoleId,
                    ConcurrencyStamp = studentRoleId
                },
                new IdentityRole
                {
                    Name = "Employee",
                    NormalizedName = "Employee",
                    Id = employeeRoleId,
                    ConcurrencyStamp = employeeRoleId
                },
                new IdentityRole
                {
                    Name= "Educator",
                    NormalizedName = "Educator",
                    Id = educatorRoleId,
                    ConcurrencyStamp = educatorRoleId
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Name = "Principal",
                    NormalizedName = "Principal",
                    Id = principalRoleId,
                    ConcurrencyStamp = principalRoleId
                },
                new IdentityRole
                {
                    Name = "Director",
                    NormalizedName = "Director",
                    Id = directorRoleId,
                    ConcurrencyStamp = directorRoleId
                },
                new IdentityRole
                {
                    Name = "SuperAdmin",
                    NormalizedName = "SuperAdmin",
                    Id = superAdminRoleId,
                    ConcurrencyStamp = superAdminRoleId
                }

            };
            builder.Entity<IdentityRole>().HasData(roles);

            // Seed SuperAdminUser
            var superAdminId = "4a1f05ea-ca6d-45e7-b558-82150290af0b";
            var superAdminUser = new IdentityUser
            {
                UserName = "superadmin@skr91.com",
                Email = "superadmin@skr91.com",
                NormalizedEmail = "superadmin@skr91.com".ToUpper(),
                NormalizedUserName = "superadmin@skr91.com".ToUpper(),
                Id = superAdminId
            };
            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(superAdminUser, "superadmin@123");

            builder.Entity<IdentityUser>().HasData(superAdminUser);

            // Add All roles to SuperAdminUser
            var superAdminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = educatorRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = employeeRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = studentRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = principalRoleId,
                    UserId = superAdminId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);

            //Seed Principal Role
            var principalUserId = "25973b30-2677-46d7-9b72-584ede7a5c6e";
            var principalUser = new IdentityUser
            {
                UserName = "principal@skr91.com",
                Email = "principal@skr91.com",
                NormalizedEmail = "principal@skr91.com".ToUpper(),
                NormalizedUserName = "principal@skr91.com".ToUpper(),
                Id = principalUserId
            };
            principalUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(principalUser, "principal@123");

            builder.Entity<IdentityUser>().HasData(principalUser);

            // Add All roles to Principal
            var principalRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = principalUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = educatorRoleId,
                    UserId = principalUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = employeeRoleId,
                    UserId = principalUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = studentRoleId,
                    UserId = principalUserId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(principalRoles);


            // Seed EmployeeUser
            var employeeUserId = "7c604289-9d4d-4051-90b2-5e7b8982d6ae";
            var employeeUser = new IdentityUser
            {
                UserName = "employee@skr91.com",
                Email = "employee@skr91.com",
                NormalizedEmail = "employee@skr91.com".ToUpper(),
                NormalizedUserName = "employee@skr91.com".ToUpper(),
                Id = employeeUserId
            };
            employeeUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(employeeUser, "employee@123");

            builder.Entity<IdentityUser>().HasData(employeeUser);

            // Add roles to Employee
            var employeeRoles = new List<IdentityUserRole<string>>
            {

                new IdentityUserRole<string>
                {
                    RoleId = employeeRoleId,
                    UserId = employeeUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = educatorRoleId,
                    UserId = employeeUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = studentRoleId,
                    UserId = employeeUserId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(employeeRoles);


            // Seed EducatorUser
            var educatorUserId = "6cffae1f-2c3a-4588-b176-7e6691a5c1b2";
            var educatorUser = new IdentityUser
            {
                UserName = "faculty@skr91.com",
                Email = "faculty@skr91.com",
                NormalizedEmail = "faculty@skr91.com".ToUpper(),
                NormalizedUserName = "faculty@skr91.com".ToUpper(),
                Id = educatorUserId
            };
            educatorUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(educatorUser, "faculty@123");

            builder.Entity<IdentityUser>().HasData(educatorUser);

            // Add roles to EducatorUser
            var educatorRoles = new List<IdentityUserRole<string>>
            {

                new IdentityUserRole<string>
                {
                    RoleId = educatorRoleId,
                    UserId = educatorUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = studentRoleId,
                    UserId = educatorUserId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(educatorRoles);


            // Seed StudentUser
            var studentUserId = "63da928e-9896-4f73-8c1b-0ea5a9500b80";
            var studentUser = new IdentityUser
            {
                UserName = "students@skr91.com",
                Email = "students@skr91.com",
                NormalizedEmail = "students@skr91.com".ToUpper(),
                NormalizedUserName = "students@skr91.com".ToUpper(),
                Id = studentUserId
            };
            studentUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(studentUser, "student@123");

            builder.Entity<IdentityUser>().HasData(studentUser);

            // Add roles to EducatorUser
            var studentRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = studentRoleId,
                    UserId = studentUserId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(studentRoles);
        }



    }
}
