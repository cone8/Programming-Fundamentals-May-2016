using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InstructionSet
{
    static void Main(string[] args)
    {
        string opCode = Console.ReadLine();

        // 1st error: "end" is lowercase and this makes the loop infinite
        while (opCode != "END")
        {
            string[] codeArgs = opCode.Split(' ');

            long result = 0;
            switch (codeArgs[0])
            {
                // 2nd error: int is not suitable for the operandOne / operandTwo
                // as the result of the operations may overflow the int type
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        // 3rd error: operandOne is assigned to result and then incremented
                        // OperandOne is not necessary. This two lines may be replaced by:
                        // result = long.Parse(codeArgs[1]) + 1;
                        result = ++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        // 4th error: operandOne is assigned to result and then decremented
                        // OperandOne is not necessary. This two lines may be replaced by:
                        // result = long.Parse(codeArgs[1]) - 1;
                        result = --operandOne;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);
            // 5th error: input is never read inside the while loop
            // and this makes the loop infinite
            opCode = Console.ReadLine();
        }
    }
}