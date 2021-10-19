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
    public class QuangCaoService
    {
        private IUnitOfWork unitOfWork;
        private QuangCaoRepository quangCaoRepository;
        public QuangCaoService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            quangCaoRepository = new QuangCaoRepository(dbContextFactory);

        }
        public void Save()
        {
            unitOfWork.Commit();
        }
        public void insertBaiHat(QuangCao quangCao)
        {
            quangCaoRepository.Add(quangCao);
            Save();
        }
        public List<QuangCao> GetQuangCao()
        {
            return quangCaoRepository.GetQuangCao();
        }
    }
}
