using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lib.Models
{
    public class QuangCaoModel
    {
        public int IdQC { get; set; }
        public string HinhAnhrQC { get; set; }
        public string NoiDungQC  { get; set; }
        public int IdBaiHat { get; set; }
        public string TenBaiHat { get; set; }
        public string HinhNenBaiHat { get; set; }
    }
}