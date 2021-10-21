
using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IQuangCaoRepository 
    {
        IEnumerable<QuangCao> GetQuangCao();
    }
    public class QuangCaoRepository : RepositoryBase<QuangCao>
    {
        public QuangCaoRepository(DbContextFactory factory)
            : base(factory)
        {



        }
    }
}
