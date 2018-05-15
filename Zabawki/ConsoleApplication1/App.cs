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
            Test test = new Test();
            System.Threading.Thread thread1 = new System.Threading.Thread(test.test1);
            System.Threading.Thread thread2 = new System.Threading.Thread(test.test2);
            System.Threading.Thread thread3 = new System.Threading.Thread(test.test3);

            thread1.Start();
            
            thread2.Start();
            
            thread3.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            


            
            
        
        

           
            




        }
    }
}
