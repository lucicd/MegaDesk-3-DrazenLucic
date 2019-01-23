using System;
using System.Windows.Forms;

namespace MegaDesk_3_DrazenLucic
{
    public static class Program
    {
        public static readonly DeskQuotes Quotes = new DeskQuotes();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

        public static string SurfaceMaterialDescr(Materials material)
        {
            string materialDesc = "";
            switch (material)
            {
                case Materials.Oak:
                    materialDesc = "Oak";
                    break;
                case Materials.Laminate:
                    materialDesc = "Laminate";
                    break;
                case Materials.Pine:
                    materialDesc = "Pine";
                    break;
                case Materials.Rosewood:
                    materialDesc = "Rosewood";
                    break;
                case Materials.Veneer:
                    materialDesc = "Veneer";
                    break;
                default:
                    break;
            }
            return materialDesc;
        }

        public static Materials SurfaceMaterialId(string materialDesc)
        {
            Materials materialId = Materials.Oak;
            switch (materialDesc)
            {
                case "Oak":
                    materialId = Materials.Oak;
                    break;
                case "Laminate":
                    materialId = Materials.Laminate;
                    break;
                case "Pine":
                    materialId = Materials.Pine;
                    break;
                case "Rosewood":
                    materialId = Materials.Rosewood;
                    break;
                case "Veneer":
                    materialId = Materials.Veneer;
                    break;
                default:
                    break;
            }
            return materialId;
        }
    }
}
