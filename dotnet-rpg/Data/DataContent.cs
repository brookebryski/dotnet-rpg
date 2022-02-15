using System;
using dotnet_rpg.Models;

namespace dotnet_rpg.Data
{
    public class DataContent : DbContext
    {
        public DataContent(DbContextOptions<DataContext> options) :base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
    }
}
