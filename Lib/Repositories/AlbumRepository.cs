using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IAlbumRepository : IRepository<Album>
    {
        List<Album> GetAlbums();
    }
    public class AlbumRepository : RepositoryBase<Album>, IAlbumRepository
    {
        public AlbumRepository(DbContextFactory factory)
            : base(factory)
        {
            
        }
        public List<Album> GetAlbums()
        {
            var query = dataContext.Album.AsQueryable();
            return query.ToList();
        }
    }
}
