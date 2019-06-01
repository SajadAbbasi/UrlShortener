using Model;
using System;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public partial class UnitOfWork : IUnitOfWork,IDisposable
    {
        private IRepository<Url> _urlRepository;
        private EFFirstContext _context;
        public IRepository<Url> UrlRepository
        {
            get
            {

                if (_urlRepository == null)
                    _urlRepository = new GenericRepository<Url>(_context);
                return _urlRepository;
            }
        }


        public UnitOfWork()
        {
            _context = new EFFirstContext();
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

    }
}
