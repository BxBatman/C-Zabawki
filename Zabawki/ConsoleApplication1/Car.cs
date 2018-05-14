using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car : Toy, ISpeed
    {
        public Car(int speed,double age, Value basicValue) : base(age, basicValue)
        {
            this.speed = speed;
        }
        private int speed;
        public int Speed {
            get {
                return speed;
            }
            set {
                speed = value;
            }
        }
    }
}
