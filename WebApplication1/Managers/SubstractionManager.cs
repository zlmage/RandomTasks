namespace WebApplication1.Managers
{
    public class SubstractionManager : GenericTaskManager
    {
        private readonly char MINUS_CHARACTER = '-';

        public string CreateTask(int min, int max)
        {
            var firstDigit = _randomHelper.GetRandomNumber(min, max);
            var secondDigit = _randomHelper.GetRandomNumber(min, max);

            if (firstDigit < secondDigit) Swap(ref firstDigit, ref secondDigit);

            return ToString(firstDigit, secondDigit, MINUS_CHARACTER);
        }
    }
}