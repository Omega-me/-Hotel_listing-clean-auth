/// <summary>
///     This file is autogenerated by toolkit, next time you generate files again it wil be regenerated
///     If you want to do something custom with this class use partial instead
/// </summary>
using Hotel_listing.Domain.Entitites;
using Hotel_listing.Persistence.Configurations.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel_listing.Persistence;
public partial class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options):base(options)
    { }
    
    public DbSet<Country>? Country { get; set; }
    public DbSet<Hotel>? Hotel { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new HotelConfiguration());
    }
}
