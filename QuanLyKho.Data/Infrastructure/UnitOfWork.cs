using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private QuanLyKhoDbContext _dbcontext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public QuanLyKhoDbContext DbContext
        {
            get { return _dbcontext ?? (_dbcontext = _dbFactory.Init()); }
        }
        public void Commit()
        {
            _dbcontext.SaveChanges();
        }
    }
}
