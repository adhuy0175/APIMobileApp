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
    public class PlayListService
    {
        private IUnitOfWork unitOfWork;
        private PlayListRepository playListRepository;
        public PlayListService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            playListRepository = new PlayListRepository(dbContextFactory);

        }
        public void Save()
        {
            unitOfWork.Commit();
        }
        public void insertBaiHat(PlayList playList)
        {
            playListRepository.Add(playList);
            Save();
        }
        public List<PlayList> GetPlayList()
        {
            return playListRepository.GetPlayList();
        }
    }
}
