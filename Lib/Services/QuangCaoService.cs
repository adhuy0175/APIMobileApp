using Lib.Models;
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
        private ApplicationDbContext dataContext;
        public QuangCaoService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            quangCaoRepository = new QuangCaoRepository(dbContextFactory);
            dataContext = new ApplicationDbContext();

        }
        public void Save()
        {
            unitOfWork.Commit();
        }
        public void insertQuangCao(QuangCao quangCao)
        {
            dataContext.QuangCao.Add(quangCao);
            dataContext.SaveChanges();
        }
        public IEnumerable<QuangCaoModel> GetQuangCao()
        {
            var query = from qc in dataContext.QuangCao
                        join bh in dataContext.BaiHat
                        on qc.IdBaiHat equals bh.IdBaiHat
                        select new QuangCaoModel()
                        {
                            IdQC = qc.IdQC,
                            HinhAnhrQC = qc.HinhAnhQC,
                            NoiDungQC = qc.NoiDungQC,
                            IdBaiHat = qc.IdBaiHat,
                            TenBaiHat = bh.TenBaiHat,
                            HinhNenBaiHat = bh.HinhNenBaiHat

                        };
            // dataContext.QuangCao.AsQueryable();
            return query;
        }
    }
}
