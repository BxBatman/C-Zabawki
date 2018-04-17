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
        public delegate void NumberToyHandler();
        public event NumberToyHandler ChangeNumber;
        private double limit;
        private double sum = 0;

        public double Limit { get => limit; set => limit = value; }

        public delegate void ValueSpeedToyHandler();
        public event ValueSpeedToyHandler ValueSpeedChange;

        public delegate void ValueHeightToyHandler();
        public event ValueHeightToyHandler ValueHeightChange;


        public delegate void ValueDepthToyHandler();
        public event ValueDepthToyHandler ValueDepthChange;


        public delegate void LimitValueToyHandler();
        public event LimitValueToyHandler LimitChange;




        public virtual void OnLimitChange()
        {
            if (LimitChange != null)
            {
                LimitChange();
            }
            else
            {
                Console.WriteLine("Limit "+ limit + " for actualValue reached!");
                Console.ReadLine();
            }
        }



        public virtual void OnValueDepthChanged()
        {
            if (ValueDepthChange != null)
            {
                ValueDepthChange();
            }
            else
            {
                Console.WriteLine("New Value for depth for Toys!!");
                Console.ReadLine();
            }
        }



        public virtual void OnValueHeightChanged()
        {
            if (ValueHeightChange != null)
            {
                ValueHeightChange();
            }
            else
            {
                Console.WriteLine("New Value for height for Toys!!");
                Console.ReadLine();
            }
        }



        public virtual void OnValueSpeedChanged()
        {
            if(ValueSpeedChange != null)
            {
                ValueSpeedChange();
            }else
            {
                Console.WriteLine("New Value for speed for Toys!!");
                Console.ReadLine();
            }
        }



        public virtual void OnNumberChanged()
        {
            if(ChangeNumber != null)
            {
                ChangeNumber();
            }else
            {
                Console.WriteLine("New Toy Added!!");
                Console.ReadLine();
            }
        }


        public void add(Toy toy)
        {
            list.Add(toy);
            OnNumberChanged();
            try
            {
                if (list.Count > 1)
                {
                    foreach (Toy atoy in list)
                    {
                        sum += atoy.GetActualValue;
                        if (limit < sum)
                        {
                            OnLimitChange();
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
                    toy.Speed += speed;
                }
                OnValueSpeedChanged();
            }
        }

        public void changeDepthToAll(int depth)
        {
            if (list.Count > 1)
            {
                foreach (Toy toy in list)
                {
                    toy.Depth += depth;
                }
                OnValueDepthChanged();
            }
        }


        public void changeHeightToAll(int height)
        {
            if (list.Count > 1)
            {
                foreach (Toy toy in list)
                {
                    toy.Height += height;
                }
                OnValueHeightChanged();
            }
        }

        public void showAllInfo()
        {
            System.Console.WriteLine("Number of toys " + list.Count);
            System.Console.WriteLine("-----------------");
            int i =1;
            foreach(Toy toy in list)
            {
                System.Console.WriteLine("Toy number: " + i);
                System.Console.WriteLine("-----------------");
                System.Console.WriteLine("Toy speed: " + toy.Speed);
                System.Console.WriteLine("Toy height: " + toy.Height);
                System.Console.WriteLine("Toy depth: " + toy.Depth);
                System.Console.WriteLine("Toy age: " + toy.Age);
                System.Console.WriteLine("Actual value: " + toy.GetActualValue);
                System.Console.WriteLine("-----------------");
                i++;
            }


            System.Console.ReadLine();
        }



    }
}
