using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenOnlineGokken.Entities
{
    public class League
    {
        public long Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
