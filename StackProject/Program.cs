using System;
using System.Collections.Generic;

namespace StackProject {
    class Program {
        static void Main(string[] args) {


            var stack = new Stack<int>();
            stack.Push(-22);
            stack.Push(2);
            var j1 = stack.Pop();
            var j2 = stack.Pop();
            var j3 = j2 / j1; //be sure to divide in the right orders
            stack.Push(j3);
            stack.Push(7);
            j1 = stack.Pop();
            j2 = stack.Pop();
            j3 = j1 * j2;
            stack.Push(j3);
            var jans = stack.Pop();
            Console.WriteLine($"Answer is {jans}");

            //
            stack.Push(1);
            stack.Push(2);
            stack.Push(2);
            var i1 = stack.Pop();
            var i2 = stack.Pop();
            var i3 = i1 * i2;
            stack.Push(i3);
            i1 = stack.Pop();
            i2 = stack.Pop();
            i3 = i1 * i2;
            stack.Push(i3);
            var ans = stack.Pop();
            Console.WriteLine($"Answer is {ans}");
        }
    }
}
