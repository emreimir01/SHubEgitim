using System.Data.Entity.Migrations;

namespace WindowsFormsAppEntityFrameworkCRUD.Migrations
{
 internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsAppEntityFrameworkCRUD.DatabaseContext>
 {
 public Configuration()
 {
 // Enable automatic migrations. Set to false if you prefer adding explicit migrations via Add-Migration.
 AutomaticMigrationsEnabled = true;
 // WARNING: Allowing data loss for automatic destructive schema changes. Disable in production if not acceptable.
 AutomaticMigrationDataLossAllowed = true;
 }

 protected override void Seed(WindowsFormsAppEntityFrameworkCRUD.DatabaseContext context)
 {
 // This method will be called after migrating to the latest version.
 // You can use the DbSet<T>.AddOrUpdate() helper extension method to avoid creating duplicate seed data.
 }
 }
}
