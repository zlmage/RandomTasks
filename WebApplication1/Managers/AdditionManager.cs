namespace WebApplication1.Managers
{
    public class AdditionManager : GenericTaskManager
    {
        private readonly char PLUS_CHARACTER = '+';

        public string CreateTask(int min, int max)
        {
            var firstDigit = _randomHelper.GetRandomNumber(min, max);
            var secondDigit = _randomHelper.GetRandomNumber(min, max);

            if (firstDigit < secondDigit) Swap(ref firstDigit, ref secondDigit);

            return ToString(firstDigit, secondDigit, PLUS_CHARACTER);
        }
    }
}