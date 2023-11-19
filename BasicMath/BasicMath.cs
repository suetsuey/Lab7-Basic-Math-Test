using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    public class BasicMath
    {
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }

        public BasicMath(double firstNum, double secondNum)
        {
            FirstNum = firstNum;
            SecondNum = secondNum;
        }

        public double GetAdd()
        {
            return FirstNum + SecondNum;
        }

        public double GetSubstract()
        {
            return FirstNum - SecondNum;
        }

        public double GetDivide()
        {
            return FirstNum / SecondNum;
        }

        public double GetMultiply()
        {
            return FirstNum * SecondNum;
        }
    }
}
