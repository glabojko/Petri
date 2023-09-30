using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    public abstract class LifeForm
    {
        static Random random = new Random();
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }
        public char Symbol { get; set; }
        public int LifeSpan { get; set; }
        public int Nearby { get; set; }
        public LifeForm(int xcoordinate, int ycoordinate, char symbol, int lifeSpan, int nearby)
        {
            Xcoordinate = xcoordinate;
            Ycoordinate = ycoordinate;
            Symbol = symbol;
            LifeSpan = lifeSpan;
            Nearby = nearby;
        }
        public bool IsDead()
        {
            return LifeSpan <= 0;
        }

        public abstract void Interact(List<LifeForm> lifeForms);

        public List<LifeForm> Split()
        {
            List<LifeForm> newLifeForms = new List<LifeForm>();

            for (int i = 0; i < 2; i++)
            {
                int newX = Xcoordinate + random.Next(-Nearby, Nearby + 1);
                int newY = Ycoordinate - random.Next(-Nearby, Nearby + 1);
                newLifeForms.Add(CreateNewInstance(newX, newY));
            }

            return newLifeForms;
        }

        protected abstract LifeForm CreateNewInstance(int x, int y);

    }
}
