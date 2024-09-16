using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DatabaseBackEnd.Models.Lookups;

using Microsoft.EntityFrameworkCore;

namespace DatabaseBackEnd.Models.Data;

[PrimaryKey(nameof(Id), nameof(LanguageId))]
public class DataText(string id, string languageId, string text)
{
	// ====== Keys ====================================

	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	[Length(2, 200)]
	public string Id { get; init; } = id;

	[Length(2, 2)]
	[Column("Language")]
	public string LanguageId { get; init; } = languageId;
	public virtual Language Language { get; set; } = new Language(languageId);


	// ====== Data ====================================

	[Length(2, 3000)]
	public string Text { get; set; } = text;
}