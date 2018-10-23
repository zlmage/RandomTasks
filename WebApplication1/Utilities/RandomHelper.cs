using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Utilities
{
    public class RandomHelper
    {
        Random _generator;

        public RandomHelper()
        {
            _generator = new Random();
                
        }
        public int GetRandomNumber(int min, int max)
        {
            int result;
            result = min + (int)Math.Round(_generator.NextDouble() * (max - min));
            return result;
        }

        public char GetRandomMathOperand()
        {
            var operatorSwitch = GetRandomNumber(0, 1);
            switch (operatorSwitch)
            {
                case 0:
                    return '+';
                    break;
                case 1:
                    return '-';
                    break;
                //case 2:
                //    break;
                default:
                    return '*';
            }
        }
    }
}