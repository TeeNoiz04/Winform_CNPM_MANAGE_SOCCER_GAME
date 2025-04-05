using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class ImagePlayer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Url { get; set; }
        public string? AltText { get; set; }
        public required string publicId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
        
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
      
    }
}
