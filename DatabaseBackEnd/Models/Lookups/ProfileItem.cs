using System.ComponentModel.DataAnnotations.Schema;

using DatabaseBackEnd.Models.Enums;

namespace DatabaseBackEnd.Models.Lookups;

public class ProfileItem(int id, ItemDataType dataType)
{
	// ====== Keys ======================================================

	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int Id { get; init; } = id;


	// ====== Data ======================================================

	public ItemDataType DataType { get; set; } = dataType;

	public int? Precision { get; set; }



	// ====== Constructors ======================================================

	public ProfileItem(int id, ItemDataType dataType, int precision) : this(id, dataType) => Precision = precision;
}