using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{   
    [Table("THELOAI")]
    class TheLoai
    {
        [Key]
        public int IdTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public string HinhTheLoai { get; set; }
        public int IdChuDe { get; set; }
    }
}
