using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{   [Table("ALBUM")]
    class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        public string TenAlbum { get; set; }
        public string TenCaSiAlbum { get; set; }
        public string HinhAlbum { get; set; }
    }
}
