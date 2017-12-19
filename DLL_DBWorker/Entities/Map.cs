using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DBWorker.Entities
{
    [Serializable]
    public class Map
    {
        [Key]
        public int MapId { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

        // texture id by ';' — 1;0;3;24;5;41;...
        // read and fill from 0;0 to max;max — 0;0, 1;0, 2;0...
        public string FloorTextures { get; set; }
        public string ItemsTextures { get; set; }
    }
}
