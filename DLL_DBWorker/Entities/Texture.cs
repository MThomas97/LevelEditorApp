using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DBWorker.Entities
{
    //[Serializable]
    public class Texture
    {
        [Key]
        public int TextureId { get; set; }
        [Required]
        public byte[] TextureImage { get; set; }
        [Required]
        public string HashSum { get; set; }
    }
}
