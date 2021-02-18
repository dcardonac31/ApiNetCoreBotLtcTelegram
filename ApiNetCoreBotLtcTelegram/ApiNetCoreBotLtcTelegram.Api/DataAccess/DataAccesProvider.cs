using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetCoreBotLtcTelegram.Api.Models;

namespace ApiNetCoreBotLtcTelegram.Api.DataAccess
{
    public class DataAccesProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccesProvider(PostgreSqlContext context)
        {
            _context = context;
        }
        public void AddBot(Bots bot)
        {
            _context.bots.Add(bot);
            _context.SaveChanges();
        }

        public void UpdateBot(Bots bot)
        {
            _context.bots.Update(bot);
            _context.SaveChanges();
        }

        public void DeleteBot(int idBot)
        {
            var entity = _context.bots.FirstOrDefault(t => t.idbot == idBot);
            _context.bots.Remove(entity);
            _context.SaveChanges();
        }

        public Bots GetBot(int idBot)
        {
            return _context.bots.FirstOrDefault(t => t.idbot == idBot);
        }

        public List<Bots> GetBots()
        {
            return _context.bots.OrderBy(x => x.idbot).ToList();
        }


    }
}
