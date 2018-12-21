using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PeopleApp.Shared.Entities;

namespace PeopleApp.Shared
{
  public class ApiContext : DbContext
  {
    public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

    public DbSet<Person> People { get; set; }
    public DbSet<Interest> Interests { get; set; }
    public DbSet<PersonInterest> PersonInterests { get; set; }

    public static DbContextOptions<ApiContext> InMemoryOptions => new DbContextOptionsBuilder<ApiContext>()
                                                                       .UseInMemoryDatabase("People")
                                                                       .Options;

    public static DbContextOptions<ApiContext> SqliteOptions
    {
      get
      {
        var connection = new SqliteConnection("Data Source=People.db");
        //connection.Open();

        return new DbContextOptionsBuilder<ApiContext>()
          .UseSqlite(connection)
          .Options;
      }
    }
  }
}
