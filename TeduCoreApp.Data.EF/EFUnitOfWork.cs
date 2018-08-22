using System;
using System.Collections.Generic;
using System.Text;
using TeduCoreApp.Infrastructure.Interfaces;

namespace TeduCoreApp.Data.EF
{
    //triển khai từ Interface IUnitOfWork
    public class EFUnitOfWork : IUnitOfWork
    {
        public readonly AppDbContext _context;
        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
