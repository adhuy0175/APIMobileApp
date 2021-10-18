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
    public class BaiHatService
    {
        private IUnitOfWork unitOfWork;
        private BaiHatRepository baiHatRepository;
        public BaiHatService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            baiHatRepository = new BaiHatRepository(dbContextFactory);

        }
        public void Save()
        {
            unitOfWork.Commit();
        }
        public void insertBaiHat(BaiHat baiHat)
        {
            baiHatRepository.Add(baiHat);
            Save();
        }
        public List<BaiHat> GetBaiHats()
        {
            return baiHatRepository.GetBaiHat();
        }
    }
}
