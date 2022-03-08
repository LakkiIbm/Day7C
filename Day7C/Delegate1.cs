using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------Single Cast delegate----------------------------
//namespace Day7C
//{
//    public delegate void SampleDel(int a, int b);
//    class DecDelegate
//    {
//        public void addition(int a, int b)
//        {
//            Console.WriteLine("Addition: {0} + {1} = {2}", a, b, a + b);
//        }
//        public void subtraction(int a, int b)
//        {
//            Console.WriteLine("Subtraction: {0} - {1} = {2}", a, b, a - b);
//        }
//        public void multiplication(int a, int b)
//        {
//            Console.WriteLine("Multiplication: {0} * {1} = {2}", a, b, a * b);
//        }
//    }
//    class Delegate1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter 2 nos:");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            DecDelegate d = new DecDelegate();
//            SampleDel dlgt = d.addition;
//            dlgt(a, b);
//            dlgt = d.subtraction;
//            dlgt(a, b);
//            dlgt = d.multiplication;
//            dlgt(a, b);
//            Console.ReadLine();
//        }
//    }
//}


//------------------------Multi cast delegate--------------------------------
//namespace Day7C
//{
//    public delegate void SampleDel(int a, int b);
//    class DecDelegate
//    {
//        public void addition(int a, int b)
//        {
//            Console.WriteLine("Addition: {0} + {1} = {2}", a, b, a + b);
//        }
//        public void subtraction(int a, int b)
//        {
//            Console.WriteLine("Subtraction: {0} - {1} = {2}", a, b, a - b);
//        }
//        public void multiplication(int a, int b)
//        {
//            Console.WriteLine("Multiplication: {0} * {1} = {2}", a, b, a * b);
//        }
//    }
//    class Delegate1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter 2 nos:");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            DecDelegate d = new DecDelegate();
//            SampleDel dlgt = d.addition;
//            dlgt += d.subtraction;
//            dlgt += d.multiplication;
//            dlgt(a, b);
//            dlgt -= d.multiplication;
//            dlgt(a, b);
//            Console.ReadLine();
//        }
//    }
//}


//-------------------passing delegate as parameter-------------------------------
namespace Day7C
{
    public delegate void SampleDel(int a, int b);
    class DecDelegate
    {
        public void addition(int a, int b)
        {
            Console.WriteLine("Addition: {0} + {1} = {2}", a, b, a + b);
        }
        public void subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction: {0} - {1} = {2}", a, b, a - b);
        }
        public void multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication: {0} * {1} = {2}", a, b, a * b);
        }
    }
    class Delegate1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 nos:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            DecDelegate d = new DecDelegate();
            Del(d.addition, a, b);
            Console.ReadLine();
        }
        static void Del(SampleDel s, int a, int b)
        {
            s(a, b);
        }
    }
}