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

        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        public const double BASE_PRICE = 200;
        public const double AREA_SURCHARGE_PER_UNIT = 1;
        public const int AREA_SURCHARGE_THRESHOLD = 1000;
        public const double DRAWER_SURCHARGE = 50;

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
                return Program.SurfaceMaterialDescr(this.SurfaceMaterial);
            }
        }
    }
}
