using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZFrameWork.Event
{
    public static class EventManager
    {
        private static readonly Dictionary<string, List<Delegate>> Listeners = new Dictionary<string, List<Delegate>>();


        private static List<Delegate> GetHandlers(string eventId)
        {
            List<Delegate> handlers;
            if (EventManager.Listeners.ContainsKey(eventId))
            {
                handlers = EventManager.Listeners[eventId];
            }
            else
            {
                handlers = new List<Delegate>();
            }
            return handlers;
        }

        public static void AddListener(string eventId, Action handler)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            if (!handlers.Contains(handler))
            {
                handlers.Add(handler);
            }
        }

        public static void AddListener<T>(string eventId, Action<T> handler)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            if (!handlers.Contains(handler))
            {
                handlers.Add(handler);
            }
        }

    }
}
