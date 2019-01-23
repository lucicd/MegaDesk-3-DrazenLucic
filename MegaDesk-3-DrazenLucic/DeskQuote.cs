using System;

namespace MegaDesk_3_DrazenLucic
{
    public class DeskQuote
    {
        public DeskQuote(Desk quotedDesk)
        {
            this.QuotedDesk = quotedDesk;
            this.QuoteDate = DateTime.Now;
        }

        public Desk QuotedDesk { get; }

        public double QuoteAmount
        {
            get
            {
                return this.BasePrice + this.DrawersAddon +
                    this.MaterialAddon + this.SurfaceAddon +
                    this.RushOrderAddon;
            }
        }

        public DateTime QuoteDate { get; }

        public double BasePrice
        {
            get {
                return Desk.BASE_PRICE;
            }
        }

        public double SurfaceAddon
        {
            get
            {
                int surfaceArea = this.QuotedDesk.Width * this.QuotedDesk.Depth;
                if (surfaceArea > Desk.AREA_SURCHARGE_THRESHOLD)
                {
                    return (surfaceArea - Desk.AREA_SURCHARGE_THRESHOLD) * 
                        Desk.AREA_SURCHARGE_PER_UNIT;
                }
                else
                {
                    return 0;
                }
            }
        }

        public double DrawersAddon
        {
            get
            {
                return this.QuotedDesk.NumberOfDrawers * Desk.DRAWER_SURCHARGE;
            }
        }

        public double MaterialAddon
        {
            get
            {
                double surfaceSurcharge = 0;
                switch (this.QuotedDesk.SurfaceMaterial)
                {
                    case Materials.Oak:
                        surfaceSurcharge = 200;
                        break;
                    case Materials.Laminate:
                        surfaceSurcharge = 100;
                        break;
                    case Materials.Pine:
                        surfaceSurcharge = 50;
                        break;
                    case Materials.Rosewood:
                        surfaceSurcharge = 300;
                        break;
                    case Materials.Veneer:
                        surfaceSurcharge = 125;
                        break;
                    default:
                        surfaceSurcharge = 0;
                        break;
                }
                return surfaceSurcharge;
            }
        }

        public double RushOrderAddon
        {
            get
            {
                int surfaceArea = this.QuotedDesk.Width * this.QuotedDesk.Depth;
                double rushOrderSurcharge = 0;
                if (surfaceArea < 1000)
                {
                    switch (this.QuotedDesk.ProductionTime)
                    {
                        case 3:
                            rushOrderSurcharge = 60;
                            break;
                        case 5:
                            rushOrderSurcharge = 40;
                            break;
                        case 7:
                            rushOrderSurcharge = 30;
                            break;
                        default:
                            rushOrderSurcharge = 0;
                            break;
                    }
                }
                else if (surfaceArea <= 2000)
                {
                    switch (this.QuotedDesk.ProductionTime)
                    {
                        case 3:
                            rushOrderSurcharge = 70;
                            break;
                        case 5:
                            rushOrderSurcharge = 50;
                            break;
                        case 7:
                            rushOrderSurcharge = 35;
                            break;
                        default:
                            rushOrderSurcharge = 0;
                            break;
                    }
                }
                else
                {
                    switch (this.QuotedDesk.ProductionTime)
                    {
                        case 3:
                            rushOrderSurcharge = 80;
                            break;
                        case 5:
                            rushOrderSurcharge = 60;
                            break;
                        case 7:
                            rushOrderSurcharge = 40;
                            break;
                        default:
                            rushOrderSurcharge = 0;
                            break;
                    }
                }
                return rushOrderSurcharge;
            }
        }

        public string[] GridRow
        {
            get
            {
                Desk desk = this.QuotedDesk;
                string[] row = {
                    desk.CustomerName,
                    String.Format("{0,10:dd-MMM-yy}", this.QuoteDate),
                    desk.Width.ToString(),
                    desk.Depth.ToString(),
                    desk.SurfaceArea.ToString(),
                    desk.SurfaceMaterialDescr,
                    desk.NumberOfDrawers.ToString(),
                    desk.ProductionTime.ToString() + " days",
                    String.Format("{0,10:$0.00}", this.QuoteAmount)
                };
                return row;
            }
        }
    }
}
