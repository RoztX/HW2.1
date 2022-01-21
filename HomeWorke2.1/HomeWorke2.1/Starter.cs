using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorke2._1
{
    internal class Starter
    {
        public void Start(int logQuantity)
        {
            Actions actions = new Actions();
            var typeOfLog = 0;
            for (int i = 0; i < logQuantity; i++)
            {
                Random random = new Random();
                typeOfLog = random.Next(0, 3);
                if (typeOfLog == 0)
                {
                    actions.First();
                }
                else if (typeOfLog == 1)
                {
                    actions.Second();
                }
                else
                {
                    actions.Third();
                }
            }

        }
    }
}
