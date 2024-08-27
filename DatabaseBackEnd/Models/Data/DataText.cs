using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DatabaseBackEnd.Models.Lookups;

using Microsoft.EntityFrameworkCore;

namespace DatabaseBackEnd.Models.Data;

[PrimaryKey(nameof(Id), nameof(Language))]
public class DataText(string id, Language language, string text)
{
	// ====== Keys ====================================

	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	[Length(2, 200)]
	public string Id { get; init; } = id;

	public virtual Language Language { get; set; } = language;


	// ====== Data ====================================

	[Length(2, 3000)]
	public string Text { get; set; } = text;
}