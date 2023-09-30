using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    class Spirillum : LifeForm
    {
        public Spirillum(int x, int y) : base(x, y, 'S', 40, 2)
        {
        }

        protected override LifeForm CreateNewInstance(int xcoordinate, int ycoordinate)
        {
            return new Spirillum(xcoordinate, ycoordinate);
        }

        public override void Interact(List<LifeForm> lifeForms)
        {

            if (lifeForms.Any(lf => lf is Bacillus && Math.Abs(lf.Xcoordinate - Xcoordinate) <= Nearby && Math.Abs(lf.Ycoordinate - Ycoordinate) <= Nearby))
            {
                LifeSpan = 0; 
            }
        }
    }
}
