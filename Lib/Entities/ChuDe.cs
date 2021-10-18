using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{
    [Table("CHUDE")]
    class ChuDe
    {
        [Key]
        public int IdChuDe { get; set; }
        public string TenChuDe { get; set; }
        public string HinhChuDe { get; set; }

    }
}
