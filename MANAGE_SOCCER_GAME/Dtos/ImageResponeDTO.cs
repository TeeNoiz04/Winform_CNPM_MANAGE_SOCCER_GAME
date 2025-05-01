using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Dtos
{
    public class ImageResponeDTO
    {
        public string Url { get; set; }
        public string PublicId { get; set; } // Thêm publicId vào DTO
        public Guid? ForeignKeyId { get; set; }
        public string AltText { get; set; }
    }
}
