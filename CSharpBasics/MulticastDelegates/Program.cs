using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void MathDelegate(int num1, int num2);
    public delegate void WorkPerformedHandler(int hours, string workType);
    public delegate void WorkCompletedHandler(string workType);

    public class Worker
    {
        public void DoWork(int hours,string workType,WorkPerformedHandler del1, WorkCompletedHandler del2)
        {
            //del1 = null;
            //del2 = null;
            for (int i = 0;i < hours; i++)
            {
                Thread.Sleep(1000);
                del1(i + 1, workType);
            }
            del2(workType);
        }
    }

    internal class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is {x+y}");
        }

        public static void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is {x - y}");
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is {x * y}");

        }
        public void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is {x / y}");

        }
        static void Work_WorkPerformed(int hours,string workType)
        {
            Console.WriteLine($"{hours} Hours completed for {workType}");
        }
        static void Work_WorkCompleted(string workType)
        {
            Console.WriteLine($"{workType} work completed.");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            MathDelegate del1 = new MathDelegate(Add);
            MathDelegate del2= new MathDelegate(Program.Sub);
            MathDelegate del3 = new MathDelegate(p.Mul);
            MathDelegate del4 = new MathDelegate(p.Div);

            MathDelegate del5 = del1 + del2 + del3 + del4;
            Delegate[] InvocationList = del5.GetInvocationList();
            Console.WriteLine("Invocation List: ");
            foreach(var item in InvocationList)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking multicast delegates");
            del5.Invoke(20, 5);
            Console.WriteLine("After removing one delegate.");
            del5 -= del2;
            del5(22, 7);


            WorkPerformedHandler work1 = new WorkPerformedHandler(Work_WorkPerformed);
            WorkCompletedHandler work2 = new WorkCompletedHandler(Work_WorkCompleted);

            Worker worker = new Worker();
            worker.DoWork(5, "Complete delegate task", work1, work2);
        }
    }
}
