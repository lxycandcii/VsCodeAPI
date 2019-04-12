using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VsCodeAPI.Entity;

namespace VsCodeAPI.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// 图片
        /// </summary>
        //public DbSet<Photo> Photos { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasDefaultValueSql("Newid()");
                //entity.Property(e => e.IsDelete)
                //    .HasDefaultValue(IsDeleted.No);
                //entity.Property(e => e.IsLocked)
                //    .HasDefaultValue(IsLocked.UnLocked);
                //entity.Property(e => e.Role)
                //    .HasDefaultValue(UserRole.Guest);
                //entity.Property(e => e.CreatedAt)
                //    .ValueGeneratedOnAdd()
                //    .HasDefaultValueSql("getdate()");
                //entity.Property(e => e.LastUpdatedAt)
                //    .ValueGeneratedOnAddOrUpdate()
                //    .HasDefaultValueSql("getdate()");
            });
        }
    }
}
