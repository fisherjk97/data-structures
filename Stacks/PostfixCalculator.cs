using Stack.List;
using System;

namespace Calculator
{
    public static class PostfixCalculator
    {
        /*Algorithm
        
        foreach token
            if token is integer
                push token
            else if token is operator
                pop right-side value
                pop left-side value
                evaluate operator
                push result
        next
         */

         //the stack of integers not yet operated on

        public static int Calculate(string[] args){
            
            Stack<int> values = new Stack<int>();

            foreach (string token in args){
                //if the value is an integer

                int value;
                if(int.TryParse(token, out value)){
                    //push it to the stack
                    values.Push(value);
                }else{
                    //otherwise evaluate the expression

                    int rhs = values.Pop();
                    int lhs = values.Pop();

                    //and pop the result back to the stack

                    switch(token){
                        case "+":
                            values.Push(lhs + rhs);
                            break;
                        case "-":
                            values.Push(lhs - rhs);
                            break;
                          case "*":
                            values.Push(lhs * rhs);
                            break;
                          case "/":
                            values.Push(lhs / rhs);
                            break;
                        case "%":
                            values.Push(lhs % rhs);
                            break;
                        default: 
                            throw new ArgumentException(string.Format("Unrecognized Token: {0}", token));
                    }
                }
            }

        return values.Pop();

        }

        public static void Print(string[] args){
            Console.WriteLine("Expression: ");
            foreach(var a in args){
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}