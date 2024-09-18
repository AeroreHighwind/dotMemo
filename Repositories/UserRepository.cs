using dotMemo.DataBase;
using dotMemo.Entities;
using dotMemo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotMemo.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly DataBaseContext appDbContext;

         public UserRepository(DataBaseContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public async Task<User> GetUser(int userId)
        {
            return appDbContext.Users.FirstOrDefault<User>();
                
        }

        public async Task<User> CreateUser(User user)
        {
            var result = await appDbContext.Users.AddAsync(user);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<User> UpdateUser(User user)
        {
            var result = await appDbContext.Users
                .FirstOrDefaultAsync<User>(e => e.Id == user.Id);

            if (result != null)
            {
                result.Username = user.Username;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

    }
}
