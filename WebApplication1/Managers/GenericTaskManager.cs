using System.Text;
using WebApplication1.Utilities;

namespace WebApplication1.Managers
{
    public class GenericTaskManager
    {
        internal RandomHelper _randomHelper;

        public GenericTaskManager()
        {
            _randomHelper = new RandomHelper();
        }

        internal void Swap(ref int a, ref int b)
        {
            var tempSwap = a;
            a = b;
            b = tempSwap;
        }

        public string ToString(int firstDigit, int secondDigit, char operand)
        {
            StringBuilder result = new StringBuilder();

            result = result.Append(firstDigit.ToString());
            result = result.Append(" ");
            result = result.Append(operand);
            result = result.Append(" ");
            result = result.Append(secondDigit.ToString());
            result = result.Append(" = ");
            return result.ToString();
        }
    }
}//change 2