using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        //Context üzerinde iş yapacağız o yüzden DI yapısı kuralım
        private readonly RepositoryContext _context;
        private readonly Lazy<IBookRepository> _bookRepository;//Lazy loading kullanarak nesneye ihtiyaç duyulduğu anda erişim sağlanacak
        private readonly Lazy<IUserRepository> _userRepository;
        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(_context));
        }

        public IBookRepository Book => _bookRepository.Value;//Nesne ancak kullanıldığı anda new lenicek 

        public IUserRepository User => _userRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
