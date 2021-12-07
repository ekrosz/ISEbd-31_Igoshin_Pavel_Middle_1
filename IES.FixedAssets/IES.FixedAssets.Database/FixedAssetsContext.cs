using IES.FixedAssets.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace IES.FixedAssets.Database
{
	public class FixedAssetsContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FixedAssetsDatabase;Integrated Security=True;MultipleActiveResultSets=True;";

			if (optionsBuilder.IsConfigured == false)
			{
				optionsBuilder.UseSqlServer(connectionString);
			}

			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<DebitAccountChartModel> DebitAccountCharts { get; set; }

		public DbSet<CreditAccountChartModel> CreditAccountCharts { get; set; }

		public DbSet<SubdivisionModel> Subdivisions { get; set; }

		public DbSet<ResponsibleModel> Responsibles { get; set; }

		public DbSet<EntryJournalModel> EntryJournals { get; set; }

		public DbSet<FixedAssetModel> FixedAssets { get; set; }

		public DbSet<ProviderModel> Providers { get; set; }

		public DbSet<ReceiptModel> Receipts { get; set; }

		public DbSet<ReceiptTableModel> ReceiptTables { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<CreditAccountChartModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.HasIndex(p => p.AccountNumber)
				.IsUnique();

				e.Property(p => p.AccountNumber)
				.IsRequired()
				.HasMaxLength(10);

				e.HasIndex(p => p.AccountName)
				.IsUnique();

				e.Property(p => p.AccountName)
				.IsRequired()
				.HasMaxLength(100);

				e.Property(p => p.AccountType)
				.IsRequired()
				.HasMaxLength(50);

				e.Property(p => p.FirstSubconto)
				.HasMaxLength(80);

				e.Property(p => p.SecondSubconto)
				.HasMaxLength(80);

				e.Property(p => p.ThirdSubconto)
				.HasMaxLength(80);

				e.Property(p => p.Comment)
				.HasMaxLength(255);

				e.HasMany(p => p.CreditEntryJournals)
				.WithOne(p => p.CreditAccountChart)
				.HasForeignKey(p => p.CreditAccountId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<DebitAccountChartModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.HasIndex(p => p.AccountNumber)
				.IsUnique();

				e.Property(p => p.AccountNumber)
				.IsRequired()
				.HasMaxLength(10);

				e.HasIndex(p => p.AccountName)
				.IsUnique();

				e.Property(p => p.AccountName)
				.IsRequired()
				.HasMaxLength(100);

				e.Property(p => p.AccountType)
				.IsRequired()
				.HasMaxLength(50);

				e.Property(p => p.FirstSubconto)
				.HasMaxLength(80);

				e.Property(p => p.SecondSubconto)
				.HasMaxLength(80);

				e.Property(p => p.ThirdSubconto)
				.HasMaxLength(80);

				e.Property(p => p.Comment)
				.HasMaxLength(255);

				e.HasMany(p => p.DebitEntryJournals)
				.WithOne(p => p.DebitAccountChart)
				.HasForeignKey(p => p.DebitAccountId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<SubdivisionModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.HasIndex(p => p.Name)
				.IsUnique();

				e.Property(p => p.Name)
				.HasMaxLength(100)
				.IsRequired();

				e.HasMany(p => p.Receipts)
				.WithOne(p => p.Subdivision)
				.HasForeignKey(p => p.SubdivisionId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<ResponsibleModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.Property(p => p.Fio)
				.HasMaxLength(150)
				.IsRequired();

				e.HasMany(p => p.Receipts)
				.WithOne(p => p.Responsible)
				.HasForeignKey(p => p.ResponsibleId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<EntryJournalModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.HasIndex(p => p.DebitAccountId);
				
				e.HasIndex(p => p.CreditAccountId);

				e.Property(p => p.CreditFirstSubconto)
				.HasMaxLength(80);

				e.Property(p => p.CreditSecondSubconto)
				.HasMaxLength(80);

				e.Property(p => p.CreditThirdSubconto)
				.HasMaxLength(80);

				e.Property(p => p.DebitFirstSubconto)
				.HasMaxLength(80);

				e.Property(p => p.DebitSecondSubconto)
				.HasMaxLength(80);

				e.Property(p => p.DebitThirdSubconto)
				.HasMaxLength(80);

				e.Property(p => p.Count)
				.IsRequired();

				e.Property(p => p.Sum)
				.IsRequired();

				e.Property(p => p.DateEntry)
				.IsRequired();
			});

			builder.Entity<FixedAssetModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.HasIndex(p => p.Name)
				.IsUnique();

				e.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(100);

				e.Property(p => p.BalancePrice)
				.IsRequired();

				e.HasMany(p => p.ReceiptTables)
				.WithOne(p => p.FixedAsset)
				.HasForeignKey(p => p.FixedAssetId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<ProviderModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.HasIndex(p => p.Name)
				.IsUnique();

				e.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(100);

				e.HasMany(p => p.Receipts)
				.WithOne(p => p.Provider)
				.HasForeignKey(p => p.ProviderId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<ReceiptModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.Property(p => p.ProviderId)
				.IsRequired(false);

				e.Property(p => p.ResponsibleId)
				.IsRequired(false);

				e.Property(p => p.SubdivisionId)
				.IsRequired(false);

				e.Property(p => p.OperationNumber)
				.ValueGeneratedOnAdd()
				.IsRequired();

				e.Property(p => p.Sum)
				.IsRequired();

				e.Property(p => p.ReceiptDate)
				.IsRequired();

				e.Property(p => p.OperationType)
				.HasConversion<string>()
				.HasMaxLength(100)
				.IsRequired();

				e.Property(p => p.Source)
				.HasConversion<string>()
				.HasMaxLength(100);

				e.HasMany(p => p.ReceiptTables)
				.WithOne(p => p.Receipt)
				.HasForeignKey(p => p.ReceiptId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<ReceiptTableModel>(e =>
			{
				e.HasKey(p => p.Id);

				e.HasIndex(p => p.FixedAssetId);

				e.HasIndex(p => p.ReceiptId);

				e.Property(p => p.Count)
				.IsRequired();

				e.Property(p => p.Sum)
				.IsRequired();

				e.HasMany(p => p.EntryJournals)
				.WithOne(p => p.ReceiptTable)
				.HasForeignKey(p => p.ReceiptTableId)
				.OnDelete(DeleteBehavior.Cascade);
			});
		}
	}
}
