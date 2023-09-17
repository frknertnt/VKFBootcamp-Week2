using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>//Herhangi bir somut sınıf bu kontratı kabul ederse aşağıda yazılan metotları kullanmak zorunda kalıcak
    {
        //CRUD
        IQueryable<T> FindAll(bool trackChanges);//EF Core Değişiklikleri izler ve SaveChanges kullanıldığına değişikliği yansıtır. Bazen izlememek performans kazandırabilir o yüzden parametreye bağladık.
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
