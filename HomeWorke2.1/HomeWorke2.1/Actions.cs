using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorke2._1
{
    public class Actions
    {
        public Result First()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Info, $"{nameof(First)}");
            return new Result { status = true };
        }
        public Result Second()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Warning, $"{nameof(Second)}");
            return new Result { status = true };
        }
        public Result Third()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Error, $"Broke");
            return new Result { status = false };
        }
    }
}
