﻿using MaliksCars.Application.Database;
using MaliksCars.Application.Models;
using MaliksCars.Application.Startup;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MaliksCars.Application.Services.Auth
{
    public class UsersService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _factory;

        public UsersService(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }

        public async Task<User> FindUserAsync(int userId)
        {
            using var context = _factory.CreateDbContext();
            return await context.Users
                .Include(u => u.UserFavoriteCars)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<User?> FindUserAsync(string username, string password)
        {
            using var context = _factory.CreateDbContext();
            return await context.Users.FirstOrDefaultAsync(x => x.Email == username && x.Password == password);
        }

        public async Task<User?> FindUserByEmailAsync(string email)
        {
            using var context = _factory.CreateDbContext();
            return await context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User> CreateUserAsync(User user)
        {
            using var context = _factory.CreateDbContext();
            var addedUser = await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            await context.UserRoles.AddAsync(new UserRole { RoleId = 1, User = user });
            await context.SaveChangesAsync();
            return addedUser.Entity;
        }
        // Eager loading is a technique that allows you to load related data along with the main entity when querying the database. This is done by using the Include method 
        // in your query to specify the navigation properties that you want to eagerly load. You can also use the ThenInclude method to eagerly load nested navigation properties.
        public async Task<List<User>> GetAllUsersAsync()
        {
            using var context = _factory.CreateDbContext();
            return await context.Users
                    //.Include(ufc => ufc.UserFavoriteCars)
                    .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                    .ToListAsync();
        }

        //asign user roles 
        public async Task AssignAdminRoleAsync(int userId)
        {
            using var context = _factory.CreateDbContext();
            var user = await context.Users.FindAsync(userId);

            if (user != null)
            {
                // Get the Admin role
                var adminRole = await context.Roles.FirstOrDefaultAsync(r => r.Name == CustomRoles.Admin);

                // Check if the user is already assigned to the Admin role
                var userRole = await context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == adminRole.Id);

                // Add the user to the Admin role if they are not already assigned
                if (adminRole != null && userRole == null)
                {
                    await context.UserRoles.AddAsync(new UserRole { RoleId = adminRole.Id, User = user });
                    await context.SaveChangesAsync();
                }
            }


        }



        public async Task AssignRoleAsync(int userId, string roleName)
        {
            using var context = _factory.CreateDbContext();
            var user = await context.Users.FindAsync(userId);

            if (user != null)
            {
                // Get the role
                var role = await context.Roles.FirstOrDefaultAsync(r => r.Name == roleName);

                // Check if the user is already assigned to the role
                var userRole = await context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == role.Id);

                // Add the user to the role if they are not already assigned
                if (role != null && userRole == null)
                {
                    await context.UserRoles.AddAsync(new UserRole { RoleId = role.Id, User = user });
                    await context.SaveChangesAsync();
                }
            }
        }


        //remove role
        public async Task RemoveRoleAsync(int userId, string roleName)
        {
            using var context = _factory.CreateDbContext();
            var user = await context.Users
                .Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user != null)
            {
                // Find the UserRole object that represents the association between the user and the role
                var userRole = user.UserRoles.FirstOrDefault(ur => ur.Role.Name == roleName);

                // Remove the UserRole object if it exists
                if (userRole != null)
                {
                    context.UserRoles.Remove(userRole);
                    await context.SaveChangesAsync();
                }
            }
        }


        public async Task<bool> GetUserRolesAsync(int userId)
        {

            using var context = _factory.CreateDbContext();

            var user = await context.Users.Include(u => u.UserRoles)
                        .ThenInclude(ur => ur.Role)
                        .FirstOrDefaultAsync(u => u.Id == userId);

            if (user != null)
            {
                return user.UserRoles.Any(ur => ur.Role.Name == CustomRoles.Admin);
            }
            return false;
        }

        public string GetSha256Hash(string input)
        {
            using (var hashAlgorithm = SHA256.Create())
            {
                var byteValue = Encoding.UTF8.GetBytes(input);
                var byteHash = hashAlgorithm.ComputeHash(byteValue);
                return Convert.ToBase64String(byteHash);
            }
        }
    }
}
