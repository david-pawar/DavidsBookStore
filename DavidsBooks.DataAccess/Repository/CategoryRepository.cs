using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavidsBooks.DataAccess.Repository.IRepository;
using DavidsBooks.Models;
using DavidsBookStore.DataAccess.Data;

namespace DavidsBooks.DataAccess.Repository
{
   public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
