﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Province  { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid IdTournament { get; set; }
        public Tournament Tournament { get; set; } = null;
        public Guid? IdImage { get; set; }
        public ImageTeam? Image { get; set; }
        public Guid IdCoach { get; set; }
        public Coach Coach { get; set; }

        public ICollection<Player> Player { get; set; } = new List<Player>();
        public ICollection<Game> HomeGames { get; set; } = new List<Game>();
        public ICollection<Game> AwayGames { get; set; } = new List<Game>();

    }
}
