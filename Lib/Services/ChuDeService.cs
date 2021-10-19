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
    public class ChuDeService
    {
        private IUnitOfWork unitOfWork;
        private ChuDeRepository chuDeRepository;
        public ChuDeService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            chuDeRepository = new ChuDeRepository(dbContextFactory);

        }
        public void Save()
        {
            unitOfWork.Commit();
        }
        public void insertBaiHat(ChuDe chuDe)
        {
            chuDeRepository.Add(chuDe);
            Save();
        }
        public List<ChuDe> GetChuDe()
        {
            return chuDeRepository.GetChuDe();
        }
    }
}
