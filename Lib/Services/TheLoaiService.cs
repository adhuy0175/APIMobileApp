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
    public class TheLoaiService
    {
        private IUnitOfWork unitOfWork;
        private TheLoaiRepository theLoaiRepository;
        public TheLoaiService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            theLoaiRepository = new TheLoaiRepository(dbContextFactory);

        }
        public void Save()
        {
            unitOfWork.Commit();
        }
        public void insertBaiHat(TheLoai theLoai)
        {
            theLoaiRepository.Add(theLoai);
            Save();
        }
        public List<TheLoai> GetTheLoai()
        {
            return theLoaiRepository.GetTheLoai();
        }
    }
}
