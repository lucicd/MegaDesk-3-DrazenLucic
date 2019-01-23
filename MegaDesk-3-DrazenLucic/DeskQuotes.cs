using System.Collections.Generic;

namespace MegaDesk_3_DrazenLucic
{

    public class DeskQuotes
    {
        private List<DeskQuote> quotes;

        public DeskQuotes()
        {
            quotes = new List<DeskQuote>();
        }

        public List<DeskQuote> getAll()
        {
            return quotes;
        }

        public void Add(DeskQuote quote)
        {
            quotes.Add(quote);
        }
    }
}
