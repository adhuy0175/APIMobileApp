using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{   
    [Table("QUANGCAO")]
    class QuangCao
    {  
        [Key]
        public int IdQC { get; set; }
        public string HinhAnhQC { get; set; }
        public string NoiDungQC { get; set; }
        public int IdBaiHat { get; set; }
    }
}
