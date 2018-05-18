using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1

{
    
    

    struct Value
    {

        public delegate void PriceToyHandler();
        public event PriceToyHandler priceReached;


        private double price;
        private double sentimentalValue;


        public Value(double price, double sentimentalValue)
        {
            this.price = price;
            this.sentimentalValue = sentimentalValue;
            priceReached = null;
        }

        public double Price {
            get {
                return this.price;
                }
            set {
                if(value > 0)
                {
                    priceReached();
                    this.price = value;
                }else
                {
                    Console.WriteLine("Price must be greater than 0");
                    Console.ReadLine();
                }
            }
        }
        public double SentimentalValue {
            get
            {
                return this.sentimentalValue;
            }
            set
            {
                if (value > 0)
                {
                    this.sentimentalValue = value;
                }
                else
                {
                    Console.WriteLine("SentimentalValue must be greater than 0");
                    Console.ReadLine();
                }
            }

        }
    }



    class Toy
    {
        
        private double age;
       


        Value basicValue;

        
        public double Age { get => age; set => age = value; }


        public Toy(double age,Value basicValue)
        {
            
            this.age = age;
            this.basicValue = basicValue;
        }



        public double GetActualValue
        {
            get
            {
             return basicValue.Price * this.age + basicValue.SentimentalValue;
            }
        }

    }
}
