using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Elías_Monzón
{
    class Quote
    {
        #region member variables
        //A desk quote description
        private string customerName;
        private DateTime quoteDate;
        private Desk desk = new Desk();
        public int drawersCost;
        public int saCost;
        public int rushCost;
        public int woodCost;
        public int finalQuote;
        #endregion

        #region constants
        private const int DESK_PRICE_BASE = 200;
        private const int DRAWER_BASE_COST = 50;
        private const int ORDER_OPTION_3DAYS = 60;
        private const int ORDER_OPTION_5DAYS = 40;
        private const int ORDER_OPTION_7DAYS = 30;
        #endregion

        public Quote(int width, int depth, int noDrawers, Desk.WoodType Wood, int rushDays)
        {
            desk.Width = width;
            desk.Depth = depth;
            desk.NoDrawers = noDrawers;

            //=======NoDRAWERS ADDITIONAL COST===========
            drawersCost = DRAWER_BASE_COST * noDrawers;
            
            //========Surface Area Additional Cost=======
            saCost = (desk.surfaceArea - 1000);

            //=================TOTAL PRICE===============
            finalQuote = saCost + rushCost + woodCost + drawersCost;

            switch (rushDays)
            {
                case ORDER_OPTION_3DAYS:
                    rushDays = ORDER_OPTION_3DAYS;
                    //=============surfArea < 1000 related Cost=============
                    if (desk.surfaceArea < 1000)
                        rushCost = 60;
                    //===surfArea > 1000 AND surfArea < 2000 related Cost===
                    else if (desk.surfaceArea > 1000 && desk.surfaceArea < 2000)
                        rushCost = 70;
                    //=============surfArea > 2000 related Cost=============
                    else if (desk.surfaceArea > 2000)
                        rushCost = 80;
                    break;
                case ORDER_OPTION_5DAYS:
                    rushDays = ORDER_OPTION_5DAYS;
                    //=============surfArea < 1000 related Cost=============
                    if (desk.surfaceArea < 1000)
                        rushCost = 40;
                    //===surfArea > 1000 AND surfArea < 2000 related Cost===
                    else if (desk.surfaceArea > 1000 && desk.surfaceArea < 2000)
                        rushCost = 50;
                    //=============surfArea > 2000 related Cost=============
                    else if (desk.surfaceArea > 2000)
                        rushCost = 60;
                    break;
                case ORDER_OPTION_7DAYS:
                    rushDays = ORDER_OPTION_7DAYS;
                    //=============surfArea < 1000 related Cost=============
                    if (desk.surfaceArea < 1000)
                        rushCost = 30;
                    //===surfArea > 1000 AND surfArea < 2000 related Cost===
                    else if (desk.surfaceArea > 1000 && desk.surfaceArea < 2000)
                        rushCost = 35;
                    //=============surfArea > 2000 related Cost=============
                    else if (desk.surfaceArea > 2000)
                        rushCost = 40;
                    break;
                default:
                    Console.WriteLine("The options are: 3, 5 or 7 rushdays");
                    break;
            }

            switch (Wood)
            {
                case Desk.WoodType.Laminate:
                    Wood = Desk.WoodType.Laminate;
                    woodCost = 100;
                    break;
                case Desk.WoodType.Oak:
                    Wood = Desk.WoodType.Oak;
                    woodCost = 200;
                    break;
                case Desk.WoodType.Pine:
                    Wood = Desk.WoodType.Pine;
                    woodCost = 50;
                    break;
                case Desk.WoodType.Rosewood:
                    Wood = Desk.WoodType.Rosewood;
                    woodCost = 300;
                    break;
                case Desk.WoodType.Veneer:
                    Wood = Desk.WoodType.Veneer;
                    woodCost = 125;
                    break;
                default:
                    Console.WriteLine("The options are: Oak, Pine, Rosewood, and Veneer");
                    break;
            }
        }
    }
}