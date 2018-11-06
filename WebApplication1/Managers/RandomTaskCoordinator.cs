using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Utilities;

namespace WebApplication1.Managers
{
    public class RandomTaskCoordinator
    {
        RandomHelper _randomHelper;
        AdditionManager _additionManager;
        SubstractionManager _substractionManager;

        public RandomTaskCoordinator()
        {
            _randomHelper = new RandomHelper();
            _additionManager = new AdditionManager();
            _substractionManager = new SubstractionManager();
        }

        public string GetFormattedTasksList(int min, int max, int count)
        {
            var tasksList = "";

            for (int i = 1; i <= count; i++)
            {
                tasksList += GetRandomTask(min, max);
                //Add tab between Tasks on each row. Add new row on each 4 Tasks.
                if (i % 4 == 0) tasksList += "<br/>"; else tasksList += "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;";
            }

            return tasksList;
        }

        public string GetRandomTask(int min, int max)
        {
            var randomTask = "";

            switch (_randomHelper.GetRandomMathOperand())
            {
                case '-':
                    {
                        randomTask += _substractionManager.CreateTask(min, max);
                        break;
                    }
                case '+':
                    {
                        randomTask += _additionManager.CreateTask(min, max);
                        break;
                    }
            }

            return randomTask;
        }//new change
    }
}