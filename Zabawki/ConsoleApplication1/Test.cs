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

        public void NewToyAddedInfo()
        {
            Console.WriteLine("New toy added!");
            Console.ReadLine();
        }

        public void LimitReachedInfo()
        {
            Console.WriteLine("Limit  reached!");
            Console.ReadLine();

        }

        public void PriceReachedInfo()
        {
            Console.WriteLine("Value changed!");
            Console.ReadLine();

        }
        public void test1()
        {
            Value toy1Value = new Value(45.5, 25);
            Value toy2Value = new Value(75, 25);
            Toy toy2 = new Car(46, 4.5, toy2Value);
            
            Toy toy1 = new Car(30, 2.5, toy1Value);
            toy2Value.priceReached += PriceReachedInfo;
            toy1Value.priceReached += PriceReachedInfo;
            toysRoom.newToyAdded += NewToyAddedInfo;
            toysRoom.limitReached += LimitReachedInfo;
            toysRoom.Limit = 50000;
            toy1Value.Price = 120;
            toy2Value.Price = 300;

            while (true)
            {


                toysRoom.add(toy1);
                toysRoom.add(toy2);
                toysRoom.showAllInfo();
                toysRoom.changeDepthToAll(3);
                toysRoom.deleteLastToy();
                
            }
        }

        public void test2()
        {
            toysRoom.newToyAdded += NewToyAddedInfo;
            toysRoom.limitReached += LimitReachedInfo;

            Value toy2Value = new Value(34.5, 50);

            Toy toy2 = new Box(2, 3, 1.5, toy2Value);
            while (true)
            {
                
                toysRoom.add(toy2);
                toysRoom.changeDepthToAll(7);
                toysRoom.deleteLastToy();
                toysRoom.deleteLastToy();
                ;
                toysRoom.showAllInfo();
               
                
            }
        }


        public void test3()
        {
            toysRoom.newToyAdded += NewToyAddedInfo;
            toysRoom.limitReached += LimitReachedInfo;
            Value toy4Value = new Value(80.5, 120);
            Toy toy4 = new Box(3, 5, 4, toy4Value);

            while (true)
            {

                toysRoom.deleteLastToy();
                toysRoom.showAllInfo();
                toysRoom.changeSpeedToAll(2);
                
            }
        }
    }
}
