using System.Collections.Generic;
using System.IO;

namespace MegaDesk_3_DrazenLucic
{

    public class DeskQuotes
    {
        private List<DeskQuote> quotes;

        public DeskQuotes()
        {
            quotes = new List<DeskQuote>();
            LoadFromFile();
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
            string[] lines = quotes.ConvertAll(x => x.MakeFileRecord()).ToArray();
            File.WriteAllLines("quotes.txt", lines);
        }

        private void LoadFromFile()
        {
            if (File.Exists("quotes.txt"))
            {
                string[] lines = File.ReadAllLines("quotes.txt");
                foreach (string line in lines)
                {
                    quotes.Add(new DeskQuote(line));
                }
            }
        }
    }
}
