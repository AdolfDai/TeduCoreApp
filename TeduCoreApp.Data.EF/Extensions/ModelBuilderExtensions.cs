using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.EF.Extensions
{
    //hàm config  properties cho entity
    //nằm trong class static bắc buộc
    //với tham số đầu tiên là kiểu dữ liệu ta muốn đặt extension cho nó
    public static class ModelBuilderExtensions
    {
        
        public static void AddConfiguration<TEntity>(
          this ModelBuilder modelBuilder,
          DbEntityConfiguration<TEntity> entityConfiguration) where TEntity : class
        {
            modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
        }
    }

    public abstract class DbEntityConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> entity);
    }
}
