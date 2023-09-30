using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    class Coccus : LifeForm
    {
        public Coccus(int x, int y) : base(x, y, 'C', 100, 1)
        {
        }

        protected override LifeForm CreateNewInstance(int xcoordinate, int ycoordinate)
        {
            return new Coccus(xcoordinate, ycoordinate);
        }

        public override void Interact(List<LifeForm> lifeForms)
        {

            if (lifeForms.Count(lf => lf is Bacillus || lf is Spirillum && Math.Abs(lf.Xcoordinate - Xcoordinate) <= Nearby && Math.Abs(lf.Ycoordinate - Ycoordinate) <= Nearby) < 2)
            {
                LifeSpan = 0;
            }
        }
    }
}