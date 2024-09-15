using dotMemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotMemo.DataBase
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet <User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}
