using Microsoft.EntityFrameworkCore;

namespace LoanManagementSystemWebApi.Models
{
  public class LoanContext : DbContext
  {
    public LoanContext(DbContextOptions<LoanContext> options)
        : base(options)
    {
    }

    public DbSet<LoanItem> LoanList { get; set; }
  }
}