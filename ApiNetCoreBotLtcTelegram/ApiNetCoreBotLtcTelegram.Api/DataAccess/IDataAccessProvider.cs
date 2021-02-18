using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetCoreBotLtcTelegram.Api.Models;


namespace ApiNetCoreBotLtcTelegram.Api.DataAccess
{
    public interface IDataAccessProvider
    {
        void AddBot(Bots bot);
        void UpdateBot(Bots bot);
        void DeleteBot(int idBot);

        Bots GetBot(int idBot);
        List<Bots> GetBots();
    }
}
