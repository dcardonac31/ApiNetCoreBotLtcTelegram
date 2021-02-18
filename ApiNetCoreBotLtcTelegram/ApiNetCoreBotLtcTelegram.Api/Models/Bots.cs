using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetCoreBotLtcTelegram.Api.Models
{
    public class Bots
    {
        [Key]
        public int idbot { get; set; }
        public string phonenumber { get; set; }
        public int apiid { get; set; }
        public string apihash { get; set; }
    }
}
