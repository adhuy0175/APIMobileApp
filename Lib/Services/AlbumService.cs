using Lib.Data;
using Lib.Entities;
using Lib.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lib.Services
{
    class AlbumService
    {
        private IUnitOfWork unitOfWork;
        private AlbumRepository albumRepository;
        public AlbumService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            albumRepository = new AlbumRepository(dbContextFactory);

        }
        public void Save()
        {
            unitOfWork.Commit();
        }
        public void insertAlbum(Album album)
        {
            albumRepository.Add(album);
            Save();
        }
        public List<Album> GetAlbums()
        {
            return albumRepository.GetAlbum();
        }
    }
}
