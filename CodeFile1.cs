using System;

namespace PropertyApp
{
    class Fraction
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        private int sum;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public static void Main(string[] args)
        {
            Fraction f = new Fraction();
            f.Number = 10;
            Console.WriteLine(f.Number);
            f.Sum = 20;
            Console.WriteLine(f.Sum);
        }
    }
}