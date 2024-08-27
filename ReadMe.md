# Minimum Reproducible Example

## Foreign Key Issue in Entity Framework Core with SQLite

For details, see this question issue in the Entity Framework Core repository: [/dotnet/efcore/issues/34543](https://github.com/dotnet/efcore/issues/34543).

### Observation

Using the **SQLite** provider, I referenced the `Language` entity from the `DataText` entity using a foreign key. This doesn't seem possible.

In `OnModelCreating()` I'm getting the following error message:

```
System.InvalidOperationException: The 'Language' property 'DataText.Language' could not be
mapped because the database provider does not support this type. Consider converting the
property value to a type supported by the database using a value converter. See
https://aka.ms/efcore-docs-value-converters for more information. Alternately, exclude the
property from the model using the '[NotMapped]' attribute or by using 'EntityTypeBuilder.Ignore'
in 'OnModelCreating'.
```

### Run The MRE

In order to reproduce this MRE's issue, run this solution's sole MSTest unit test @ [`DatabaseBackEndTests.CreateDatabaseTests.SuccessfullyCreateDatabaseAndDelete()`](./DatabaseBackEndTests/CreateDatabaseTests.cs#l11).

### Remarks

I want to avoid FluentAPI configuration as it would scatter my code. Convention by itself should run smoothly here.