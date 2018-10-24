using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api
{
    class Calculator<T>
    {
        public delegate void CallPostOp();
        public int Value { get; set; }

        CallPostOp postOp;

        //public static int operator+ (SmartInt operandA, SmartInt operandB)
        //{
        //    SmartInt newValue = new SmartInt();
        //    return operandA.Value + operandB.Value;
            
        //}

        //public static int operator +(SmartInt operandA, SmartInt operandB)
        //{
        //    SmartInt newValue = new SmartInt();
        //    return operandA.Value + operandB.Value;

        //}

        public void Description(T operandA, T operandB)
        {
            Console.WriteLine($"{operandA.ToString()}  {operandB.ToString()}");
            postOp();
        }

        public void AddRegisteredHandler(CallPostOp newPostOp)
        {
            postOp += newPostOp;
        }

        public static void CalculatorDemo()
        {
            Calculator<int> calculator = new Calculator<int>();
            calculator.AddRegisteredHandler(() => { Console.WriteLine("Hello delegates"); });
            calculator.Description(2, 3);
        }
    }
}
