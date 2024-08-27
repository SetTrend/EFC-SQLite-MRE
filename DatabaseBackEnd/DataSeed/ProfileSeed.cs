using DatabaseBackEnd.Models;

using Microsoft.EntityFrameworkCore;

namespace DatabaseBackEnd.DataSeed;

internal static class ProfileSeed
{
	internal static Profile[] SeedProfiles(this ModelBuilder modelBuilder)
	{
		Profile[] profiles = [new Profile(1)];

		modelBuilder.Entity<Profile>().HasData(profiles);

		return profiles;
	}
}
