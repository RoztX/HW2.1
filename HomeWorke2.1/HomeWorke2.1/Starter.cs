using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorke2._1
{
    internal class Starter
    {
        public void Run()
        {
            Actions actions = new Actions();
            var typeOfLog = 0;
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                typeOfLog = random.Next(0, 3);
                switch (typeOfLog)
                {
                    case 0:
                        actions.First();
                        break;
                    case 1:
                        actions.Second();
                        break;
                    case 2:
                        actions.Third();
                        break;
                }
            }
        }
    }
}
