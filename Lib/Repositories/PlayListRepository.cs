using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IPlayListRepository : IRepository<PlayList>
    {
        List<PlayList> GetPlayList();
    }
    public class PlayListRepository : RepositoryBase<PlayList>, IPlayListRepository
    {
        public PlayListRepository(DbContextFactory factory)
            : base(factory)
        {

        }
        public List<PlayList> GetPlayList()
        {
            var query = dataContext.PlayList.AsQueryable();
            return query.ToList();
        }
    }
}
