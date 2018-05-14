using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ToysRoom
    {

        public List<Toy> list = new List<Toy>();
        public delegate void LimitToyHandler();
        public event LimitToyHandler limitReached;
        public void LimitReachedInfo()
        {
            
                Console.WriteLine("Limit  reached!");
                Console.ReadLine();
            
        }


        public void LimitReachedHandler()
        {
            this.limitReached += new LimitToyHandler(LimitReachedInfo);

            if(limitReached != null)
            {
                limitReached();
            }
        }
        
        
        private double limit;
        private double sum = 0;

        public double Limit { get => limit; set => limit = value; }

        
        public void add(Toy toy)
        {
            list.Add(toy);
            
            try
            {
                if (list.Count > 1)
                {
                    foreach (Toy atoy in list)
                    {
                        sum += atoy.GetActualValue;
                        if (limit < sum)
                        {
                            LimitReachedHandler();
                        }
                    }
                }
            }
            catch (System.InvalidOperationException ex) {
               
            }
        }

        public void deleteLastToy()
        {
            if (list.Count > 1)
            {
                list.RemoveAt(list.Count - 1);
                Console.WriteLine("Last Toy removed");
                Console.ReadLine();
            }else {
                Console.WriteLine("No toys to remove");
            }
        }

        public void changeSpeedToAll(int speed)
        {
            if (list.Count > 1)
            {
                foreach (Toy toy in list)
                {
                    if (toy is ISpeed)
                    {
                        ISpeed newToy = (ISpeed)toy;
                        newToy.Speed += speed;
                    }
                }
               
            }
        }

        public void changeDepthToAll(int depth)
        {
            if (list.Count > 1)
            {
                foreach (Toy toy in list)
                {
                    if (toy is IDepth)
                    {
                        IDepth newToy = (IDepth)toy;
                        newToy.Depth += depth;
                    }
                }
                
            }
        }


        public void changeHeightToAll(int height)
        {
            if (list.Count > 1)
            {
                foreach (Toy toy in list)
                {
                    if (toy is IHeight)
                    {
                        IHeight newToy = (IHeight)toy;
                        newToy.Height += height;
                    }
                }
               
            }
        }

        public void showAllInfo()
        {
            System.Console.WriteLine("Number of toys " + list.Count);
            System.Console.WriteLine("-----------------");
            int i =1;
            try
            {
                foreach (Toy toy in list)
                {
                    System.Console.WriteLine("Toy number: " + i);
                    System.Console.WriteLine("-----------------");

                    if (toy is ISpeed)
                    {
                        ISpeed newToy = (ISpeed)toy;
                        System.Console.WriteLine("Toy speed: " + newToy.Speed);
                    }

                    if (toy is IHeight)
                    {
                        IHeight newToy = (IHeight)toy;
                        System.Console.WriteLine("Toy height: " + newToy.Height);
                    }

                    if (toy is IDepth)
                    {
                        IDepth newToy = (IDepth)toy;
                        System.Console.WriteLine("Toy depth: " + newToy.Depth);
                    }


                    System.Console.WriteLine("Toy age: " + toy.Age);
                    System.Console.WriteLine("Actual value: " + toy.GetActualValue);
                    System.Console.WriteLine("-----------------");
                    i++;
                }
            }
            catch (InvalidOperationException e) { }


            System.Console.ReadLine();
        }



    }
}
