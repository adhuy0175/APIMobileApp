using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IQuangCaoRepository : IRepository<QuangCao>
    {
        List<QuangCao> GetQuangCao();
    }
    public class QuangCaoRepository : RepositoryBase<QuangCao>, IQuangCaoRepository
    {
        public QuangCaoRepository(DbContextFactory factory)
            : base(factory)
        {

        }
        public List<QuangCao> GetQuangCao()
        {
            var query = dataContext.QuangCao.AsQueryable();
            return query.ToList();
        }
    }
}
