using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZFrameWork.Event
{
    public class EventManager
    {
        private readonly static Dictionary<string, List<Action>> evenDic = new Dictionary<string, List<Action>>();

    }
}
