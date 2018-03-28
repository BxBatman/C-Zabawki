using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class App
    {
        static void Main(string[] args)
        {

            Value toy1Value = new Value(45.5, 25);
            Value toy2Value = new Value(34.5, 50);


            Toy toy1 = new Toy(1, 2, 3,2.5,toy1Value);
            Toy toy2 = new Toy(1, 3, 5,2.5,toy2Value);
            ToysRoom toysRoom = new ToysRoom();
            //ustaiwam limit wartosci
            toysRoom.Limit = 400;
            //ppierwsza zabawaka dodanie
            toysRoom.add(toy1);
            toysRoom.showAllInfo();
            //zmiana dla wszystkich 
            toysRoom.changeDepthToAll(3);
            toysRoom.changeSpeedToAll(2);
            toysRoom.showAllInfo();
            //dodanie 2 zabawki
            toysRoom.add(toy2);
            toysRoom.showAllInfo();





        }
    }
}
