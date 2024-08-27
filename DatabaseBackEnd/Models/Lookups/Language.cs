using System.ComponentModel.DataAnnotations;

namespace DatabaseBackEnd.Models.Lookups;

public class Language(string id)
{
	// ====== Keys ====================================

	[Length(2, 2)]
	public string Id { get; init; } = id;
}