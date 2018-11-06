using WebApplication1.Managers;

namespace WebApplication1.Services
{
    public class RandomExamService
    {
        readonly RandomTaskCoordinator _taskCoordinator;

        public RandomExamService()
        {
            _taskCoordinator = new RandomTaskCoordinator();
        }

        public string GetRandomTasksList(int min, int max, int count)
        {
            return _taskCoordinator.GetFormattedTasksList(min, max, count);
        }
    }
}