using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Test
    {
        ToysRoom toysRoom = new ToysRoom();


        public void test1()
        {
            while (true)
            {
                toysRoom.Limit = 400;
                Value toy1Value = new Value(45.5, 25);
                Toy toy1 = new Toy(1, 2, 3, 2.5, toy1Value);
                toysRoom.add(toy1);
                toysRoom.showAllInfo();
                toysRoom.changeDepthToAll(3);
                toysRoom.deleteLastToy();
                
            }
        }

        public void test2()
        {
            while (true)
            {
                Value toy2Value = new Value(34.5, 50);
                Toy toy2 = new Toy(3, 4, 2, 1.5, toy2Value);
                toysRoom.changeDepthToAll(7);
                toysRoom.showAllInfo();
               
                
            }
        }


        public void test3()
        {
            while (true)
            {
                Value toy3Value = new Value(70.5, 150);
                Toy toy3 = new Toy(3, 1, 4, 6, toy3Value);
                Value toy4Value = new Value(80.5, 120);
                Toy toy4 = new Toy(1, 2, 3, 4, toy3Value);
                toysRoom.changeSpeedToAll(2);
                
            }
        }
    }
}
