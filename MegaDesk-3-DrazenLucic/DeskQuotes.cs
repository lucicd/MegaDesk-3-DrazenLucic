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

        public List<DeskQuote> GetAll()
        {
            return quotes;
        }

        public List<DeskQuote> GetFiltered(string materialDescr)
        {
            if (materialDescr.Equals("All"))
            {
                return quotes;
            }
            else
            {
                Materials material = Program.SurfaceMaterialId(materialDescr); 
                return quotes.FindAll
                (
                    delegate (DeskQuote quote)
                    {
                        return quote.QuotedDesk.SurfaceMaterial == material;
                    }
                );
            }
        }

        public void Add(DeskQuote quote)
        {
            quotes.Add(quote);
        }
    }
}
