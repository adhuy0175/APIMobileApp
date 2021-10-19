using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
        public interface IChuDeRepository : IRepository<ChuDe>
        {
            List<ChuDe> GetChuDe();
        }
        public class ChuDeRepository : RepositoryBase<ChuDe>, IChuDeRepository
        {
            public ChuDeRepository(DbContextFactory factory)
                : base(factory)
            {

            }
            public List<ChuDe> GetChuDe()
            {
                var query = dataContext.ChuDe.AsQueryable();
                return query.ToList();
            }
        }
}
