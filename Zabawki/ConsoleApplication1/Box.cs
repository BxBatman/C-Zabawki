using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Box : Toy, IDepth, IHeight
    {
        public Box(int depth,int height,double age, Value basicValue) : base(age, basicValue)
        {
            this.depth = depth;
            this.height = height;
        }
        private int depth;
        private int height;

        public int Depth {
        get {
                return depth;
       
            }
        set
            {
                depth = value;
            }
        }
        public int Height {
        get {
                return height;
            }
        set {
                height = value;
            }
        }
    }

}
