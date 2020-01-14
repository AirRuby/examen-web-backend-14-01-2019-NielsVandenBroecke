using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenOnlineGokken.Entities
{
    public class Game
    {
        public long Id { get; set; }
        public string Hometeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime DateOfGame { get; set; }
        public ICollection<Bet> Bets { get; set; }
        [ForeignKey("League")]
        public int LeagueIdFK { get; set; }
    }
}
