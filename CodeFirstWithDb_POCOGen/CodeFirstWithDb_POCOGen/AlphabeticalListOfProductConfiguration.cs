// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CodeFirstWithDb_POCOGen
{

    // Alphabetical list of products
    public class AlphabeticalListOfProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AlphabeticalListOfProduct>
    {
        public AlphabeticalListOfProductConfiguration()
            : this("dbo")
        {
        }

        public AlphabeticalListOfProductConfiguration(string schema)
        {
            ToTable("Alphabetical list of products", schema);
            HasKey(x => new { x.ProductId, x.ProductName, x.Discontinued, x.CategoryName });

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasColumnName(@"ProductName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SupplierId).HasColumnName(@"SupplierID").HasColumnType("int").IsOptional();
            Property(x => x.CategoryId).HasColumnName(@"CategoryID").HasColumnType("int").IsOptional();
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock").HasColumnType("smallint").IsOptional();
            Property(x => x.UnitsOnOrder).HasColumnName(@"UnitsOnOrder").HasColumnType("smallint").IsOptional();
            Property(x => x.ReorderLevel).HasColumnName(@"ReorderLevel").HasColumnType("smallint").IsOptional();
            Property(x => x.Discontinued).HasColumnName(@"Discontinued").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CategoryName).HasColumnName(@"CategoryName").HasColumnType("nvarchar").IsRequired().HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>