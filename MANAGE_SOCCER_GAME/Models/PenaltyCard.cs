using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class PenaltyCard
    {
        public Guid Id { get; set; }
        public string TypeCard { get; set; }
        public string Description { get; set; }
        public TimeSpan Time { get; set; }

        [Timestamp] // This attribute marks the property for concurrency tracking
        public byte[] RowVersion { get; set; }
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }


    }
}
