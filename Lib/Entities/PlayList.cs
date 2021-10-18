using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{
    [Table("PLAYLIST")]
    class PlayList
    {
        
        [Key]
        public int IdPlayList { get; set; }
        public string TenPlayList { get; set; }
        public string HinhNenPlayList { get; set; }
        public int HinhIconPlayList { get; set; }
    }
}
