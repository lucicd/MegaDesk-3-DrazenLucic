namespace MegaDesk_3_DrazenLucic
{
    public enum Materials
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }

    public class Desk
    {
        public Desk()
        {
            this.Quote = new DeskQuote(this);
        }

        public string CustomerName { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public int SurfaceArea
        {
            get
            {
                return this.Width * this.Depth;
            }
        }

        public int NumberOfDrawers { get; set; }
        public Materials SurfaceMaterial { get; set; }
        public int ProductionTime { get; set; }
        public DeskQuote Quote { get; set; }

        public string SurfaceMaterialDescr
        {
            get
            {
                string material = "";
                switch (this.SurfaceMaterial)
                {
                    case Materials.Oak:
                        material = "Oak";
                        break;
                    case Materials.Laminate:
                        material = "Laminate";
                        break;
                    case Materials.Pine:
                        material = "Pine";
                        break;
                    case Materials.Rosewood:
                        material = "Rosewood";
                        break;
                    case Materials.Veneer:
                        material = "Veneer";
                        break;
                    default:
                        break;
                }
                return material;
            }
        }
    }
}
