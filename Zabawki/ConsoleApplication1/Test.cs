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
                toysRoom.Limit = 1200;
                Value toy1Value = new Value(45.5, 25);
                Toy toy1 = new Car(30,2.5, toy1Value);

                Value toy2Value = new Value(75, 25);
                Toy toy2 = new Car(46,4.5, toy2Value);

                toysRoom.add(toy1);
                toysRoom.add(toy2);
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
                Toy toy2 = new Box(2,3,1.5, toy2Value);
                toysRoom.add(toy2);
                toysRoom.changeDepthToAll(7);
                toysRoom.showAllInfo();
               
                
            }
        }


        public void test3()
        {
            while (true)
            {
                Value toy3Value = new Value(70.5, 150);
                Toy toy3 = new Box(3,4, 6, toy3Value);
                toysRoom.add(toy3);
                Value toy4Value = new Value(80.5, 120);
                Toy toy4 = new Box(3,5,4, toy3Value);
                toysRoom.add(toy4);
                toysRoom.showAllInfo();
                toysRoom.changeSpeedToAll(2);
                
            }
        }
    }
}
