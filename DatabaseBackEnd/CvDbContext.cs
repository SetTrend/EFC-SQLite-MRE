using DatabaseBackEnd.DataSeed;
using DatabaseBackEnd.Models;
using DatabaseBackEnd.Models.Lookups;

using Microsoft.EntityFrameworkCore;

namespace DatabaseBackEnd;

public class CvDbContext : DbContext
{
	private readonly string _connectionString;



	public DbSet<Profile> Profile { get; set; }



	public CvDbContext(string connectionString, DbContextOptions<CvDbContext> Options) : base(Options) => _connectionString = connectionString;

	public CvDbContext(string connectionString) => _connectionString = connectionString;



	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseLazyLoadingProxies().UseSqlite(_connectionString);

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// seed initial values
		Language[] languages = modelBuilder.SeedLanguages();
		Profile profile = modelBuilder.SeedProfiles()[0];
		ProfileItem[] profileItems = modelBuilder.SeedProfileItems(languages);
	}
}
