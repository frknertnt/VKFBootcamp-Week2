using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    //Base bir class yazıyoruz ve abstract olarak belirliyoruz. Yani bu class newlenemez. Buradaki implementasyonları diğer sınıflar kalıtımla devralıcak.
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class //Bu ifade referans tipli bir ifadedir struct kullanılamaz classların(referans tiplerin) kullanulmasına izin verdik
    {
        

        protected readonly RepositoryContext _context;//Metotların çalışması için RepositoryContext e ihtiyacım var

        public RepositoryBase(RepositoryContext context)//ctor injection
        {
            _context = context;
        }

        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity) => _context?.Set<T>().Remove(entity);

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            _context.Set<T>().AsNoTracking() :
            _context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
            _context.Set<T>().Where(expression).AsNoTracking() :
            _context.Set<T>().Where(expression);
        

        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
