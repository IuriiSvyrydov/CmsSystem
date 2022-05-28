using CmsSystem.Domain.Entities;
using CmsSystem.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CmsSystem.Persistence.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        public DbSet<Product>Products { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                var result = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow,
                    _=>DateTime.UtcNow

                };
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
