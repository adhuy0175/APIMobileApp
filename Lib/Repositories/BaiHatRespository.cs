using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IBaiHatRepository : IRepository<BaiHat>
    {
        List<BaiHat> GetBaiHat();
    }
    public class BaiHatRepository : RepositoryBase<BaiHat>, IBaiHatRepository
    {
        public BaiHatRepository(DbContextFactory factory)
            : base(factory)
        {
            
        }
        public List<BaiHat> GetBaiHat()
        {
            var query = dataContext.BaiHat.AsQueryable();
            return query.ToList();
        }
    }
}
