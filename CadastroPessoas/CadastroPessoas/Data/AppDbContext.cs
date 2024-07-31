using CadastroPessoas.Models;
using Microsoft.EntityFrameworkCore;
    namespace CadastroPessoas.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    DbSet<Pessoas> Pessoas { get; set; } = null!;
}
