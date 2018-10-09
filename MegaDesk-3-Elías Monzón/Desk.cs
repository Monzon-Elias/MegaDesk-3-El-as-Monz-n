using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Elías_Monzón
{
    class Desk
    {
        #region variables
        public int Width
        {
            get { return Width; }
            set
            {
                if (Width >= MIN_WIDTH && Width <= MAX_WIDTH)
                    Width = value;
            }
        }
        public int Depth
        {
            get { return Depth; }
            set
            {
                if (Depth >= MIN_DEPTH && Depth <= MAX_DEPTH)
                    Depth = value;
            }
        }
        public int NoDrawers
        {
            get { return NoDrawers; }
            set
            {
                if (NoDrawers >= MIN_NO_DRAWERS && NoDrawers <= MAX_NO_DRAWERS)
                    NoDrawers = value;
            }
        }
        public enum WoodType
        {
            Laminate,
            Oak,
            Pine,
            Rosewood,
            Veneer
        }
        public int surfaceArea;
        #endregion

        #region constants
        private const int MIN_WIDTH = 24;
        private const int MAX_WIDTH = 96;
        private const int MIN_DEPTH = 12;
        private const int MAX_DEPTH = 48;
        private const int MIN_NO_DRAWERS = 0;
        private const int MAX_NO_DRAWERS = 7;
        #endregion

        public int CalculateSurfaceArea()
        {
            surfaceArea = Width * Depth;
            return surfaceArea;
        }
    }
}
