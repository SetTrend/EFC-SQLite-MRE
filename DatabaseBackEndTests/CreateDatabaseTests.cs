using System.Threading.Tasks;

using DatabaseBackEnd;

namespace DatabaseBackEndTests;

[TestClass]
public class CreateDatabaseTests
{
	[TestMethod]
	public async Task SuccessfullyCreateDatabaseAndDelete()
	{
		using CvDbContext ctx = new CvDbContext(@"Data Source=.\Test.sqlite");

		await ctx.Database.EnsureDeletedAsync();
		await ctx.Database.EnsureCreatedAsync();
	}
}
