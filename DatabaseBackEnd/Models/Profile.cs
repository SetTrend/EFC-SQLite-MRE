using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseBackEnd.Models;

public class Profile(int id)
{
	// ====== Keys ======================================================

	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int Id { get; init; } = id;
}