using dotMemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotMemo.DataBase
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public virtual DbSet <User> Users { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
    }
}
