using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    interface ITheLoaiRepossitory:IRepository<TheLoai>
    {
        List<TheLoai> GetTheLoai();
    }
    public class TheLoaiRepository : RepositoryBase<TheLoai>, ITheLoaiRepossitory
    {
        public TheLoaiRepository(DbContextFactory factory)
            : base(factory)
        {

        }
        public List<TheLoai> GetTheLoai()
        {
            var query = dataContext.TheLoai.AsQueryable();
            return query.ToList();
        }
    }
}