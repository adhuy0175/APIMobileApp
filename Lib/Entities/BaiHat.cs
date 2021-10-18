using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{
    [Table("BAIHAT")]
    public class BaiHat
    {
        [Key]
        public int IdBaiHat { get; set; }
        public string TenBaiHat { get; set; }

        public  string LoiBaiHat { get; set; }
        public string TenCaSi { get; set; }
        public string HinhNenBaiHat { get; set; }
        public string LinkBaiHat { get; set; }
        public int IdAlbum { get; set; }
        public int IdTheLoai { get; set; }
        public int IdPlayList { get; set; }
    }
}
