using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string line = Console.ReadLine();
            Data = Int32.Parse(line);
            var operatorObject = new mathInt();
            var result = operatorObject.GetAdd(Data);
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string line2 = Console.ReadLine();
            Data = Convert.ToInt32(line2);
            var operatorObject2 = new mathInt();
            var result2 = operatorObject2.GetSubtract(Data);
            Console.WriteLine(result2);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string line3 = Console.ReadLine();
            Data = Convert.ToInt32(line2);
            var operatorObject3 = new mathInt();
            var result3 = operatorObject2.GetMultiply(Data);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}