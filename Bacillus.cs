using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    class Bacillus : LifeForm
    {
        public Bacillus(int x, int y) : base(x, y, 'B', 10, 3)
        {
        }

        protected override LifeForm CreateNewInstance(int xcoordinate, int ycoordinate)
        {
            return new Bacillus(xcoordinate, ycoordinate);
        }

        public override void Interact(List<LifeForm> lifeForms)
        {
            
            if (!lifeForms.Any(lf => lf is Coccus && Math.Abs(lf.Xcoordinate - Xcoordinate) <= Nearby && Math.Abs(lf.Ycoordinate - Ycoordinate) <= Nearby))
            {
                LifeSpan = 0; 
            }
        }
    }


}
