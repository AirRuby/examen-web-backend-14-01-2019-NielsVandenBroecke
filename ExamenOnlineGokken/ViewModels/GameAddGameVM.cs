using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenOnlineGokken.ViewModels
{
    public class GameAddGameVM
    {
        [Required(ErrorMessage = "Field cannot be empty!")]
        public int league { get; set; }
        [Required(ErrorMessage = "Field cannot be empty!")]
        [MaxLength(150)]
        public string HomeTeam { get; set; }
        [Required(ErrorMessage = "Field cannot be empty!")]
        [MaxLength(150)]
        public string AwayTeam { get; set; }
    }
}
