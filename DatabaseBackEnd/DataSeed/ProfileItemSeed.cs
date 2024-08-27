using System.Collections.Generic;
using System.Linq;

using DatabaseBackEnd.Models.Data;
using DatabaseBackEnd.Models.Enums;
using DatabaseBackEnd.Models.Lookups;

using Microsoft.EntityFrameworkCore;

namespace DatabaseBackEnd.DataSeed;

internal static class ProfileItemSeed
{
	internal static ProfileItem[] SeedProfileItems(this ModelBuilder modelBuilder, Language[] languages)
	{
		Language de = languages.Where(l => l.Id == "de").Single();
		Language en = languages.Where(l => l.Id == "en").Single();
		List<ProfileItem> profileItems = new List<ProfileItem>(200);
		List<DataText> dataTexts = new List<DataText>(400);

		string[][] itemLabels =
			[
				["Titel", "Title"]
			, ["Zuletzt aktualisiert am {0:d}", "Last modified on {0:d}"]
			, ["Zuletzt aktualisiert am {0:d}", "Last modified on {0:d}"]
			, ["Verfügbar ab  {0:d}", "Available from {0:d}"]
			, ["Verfügbar zu {0:P0}", "Available up to {0:P0}"]
			, ["Davon zu {0:P0} vor Ort verfügbar", "With on-site availability up to {0:P0}"]
			, ["Expertenwissen in den Bereichen", "Expert knowledge in these areas"]
			, ["Sprachen", "Languages"]
			, ["Wohnort", "Residence"]
			, ["Staatsbürgerschaft", "Citizenship"]
			, ["Geburtsjahr", "Year of birth"]
			, ["Stundensatz Deutschland", "Hourly rate Germany"]
			, ["Stundensatz Schweiz", "Hourly rate Switzerland"]
			, ["Zuschläge", "Surcharges"]
			, ["Einsatzländer", "Countries of deployment"]
			, ["Remotearbeit ist {0} möglich", "Working remote is {0} possible"]
			];

		for (int i = 0;++i < itemLabels.Length;)
		{
			string textId = $"ProfileItem.Label.{i}";

			profileItems.Add(new ProfileItem(i, ItemDataType.String));
			dataTexts.Add(new DataText(textId, de, itemLabels[i][0]));
			dataTexts.Add(new DataText(textId, en, itemLabels[i][1]));
		}

		modelBuilder.Entity<ProfileItem>().HasData(profileItems);
		modelBuilder.Entity<DataText>().HasData(dataTexts);

		return [.. profileItems];
	}
}
