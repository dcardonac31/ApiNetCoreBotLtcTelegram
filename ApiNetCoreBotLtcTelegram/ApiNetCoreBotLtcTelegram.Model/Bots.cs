using System;
using System.Collections.Generic;
using System.Text;

namespace ApiNetCoreBotLtcTelegram.Model
{
    public class Bots
    {
        public int IdBot { get; set; }
        public string PhoneNumber { get; set; }
        public int ApiId { get; set; }
        public string ApiHash { get; set; }
    }
}
