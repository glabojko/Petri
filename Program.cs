namespace Petri
{
    internal class Program
    {
        static List<LifeForm> lifeForms = new List<LifeForm>();
        static void Main(string[] args)
        {
            {
                
                lifeForms.Add(new Bacillus(3, 5));
                // lifeForms.Add(new Bacillus(4, 5));
                lifeForms.Add(new Coccus(3, 4));
                // lifeForms.Add(new Coccus(3, 4));
                lifeForms.Add(new Spirillum(2, 3));

                int time = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Time: {time}");
                    DisplayDish();

                    
                    for (int i = 0; i < lifeForms.Count; i++)
                    {
                        if (lifeForms[i].IsDead())
                        {
                            List<LifeForm> newLifeForms = lifeForms[i].Split();
                            lifeForms.AddRange(newLifeForms);
                            lifeForms.RemoveAt(i);
                            i--;
                        }
                    }

                    
                    //for (int i = 0; i < lifeForms.Count; i++)
                    //{
                    //    lifeForms[i].Interact(lifeForms);
                    //    if (lifeForms[i].IsDead())
                    //    {
                    //        lifeForms.RemoveAt(i);
                    //        i--;
                    //    }
                    //}

                    
                    System.Threading.Thread.Sleep(1000);
                    time++;
                }
            }

            static void DisplayDish()
            {
                char[,] dish = new char[10, 10];

                for (int i = 0; i < dish.GetLength(0); i++)
                {
                    for (int j = 0; j < dish.GetLength(1); j++)
                    {
                        dish[i, j] = '.';
                    }
                }

                foreach (var lifeForm in lifeForms)
                {
                    dish[lifeForm.Ycoordinate, lifeForm.Xcoordinate] = lifeForm.Symbol;
                }

                for (int i = 0; i < dish.GetLength(0); i++)
                {
                    for (int j = 0; j < dish.GetLength(1); j++)
                    {
                        Console.Write(dish[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
