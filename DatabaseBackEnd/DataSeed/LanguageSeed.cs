using DatabaseBackEnd.Models.Lookups;

using Microsoft.EntityFrameworkCore;

namespace DatabaseBackEnd.DataSeed;

internal static class LanguageSeed
{
	internal static Language[] SeedLanguages(this ModelBuilder modelBuilder)
	{
		Language[] languages = [new Language("de"), new Language("en")];

		modelBuilder.Entity<Language>().HasData(languages);

		return languages;
	}
}
