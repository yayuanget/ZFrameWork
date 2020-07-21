using System;
using System.Collections.Generic;
using System.Linq;

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

        public static void AddListener<T1, T2>(string eventId, Action<T1,T2> handler)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            if (!handlers.Contains(handler))
            {
                handlers.Add(handler);
            }
        }

        public static void AddListener<T1,T2,T3>(string eventId, Action<T1,T2,T3> handler)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            if (!handlers.Contains(handler))
            {
                handlers.Add(handler);

            }
        }

        public static void RemoveListener(string eventId, Action handler)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            if (handlers.Contains(handler))
            {
                handlers.Remove(handler);
            }
        }

        public static void RemoveListener<T>(string eventId, Action<T> handler)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            if (handlers.Contains(handler))
            {
                handlers.Remove(handler);
            }
        }

        public static void RemoveListener<T1, T2>(string eventId, Action<T1,T2> handler)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            if (handlers.Contains(handler))
            {
                handlers.Remove(handler);
            }
        }

        public static void RemoveListener<T1, T2, T3>(string eventId, Action<T1,T2,T3> handler)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            if (handlers.Contains(handler))
            {
                handlers.Remove(handler);
            }
        }

        public static void Broadcast(string eventId)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            foreach (var handler in handlers.ToList())
            {
                if (handler is Action)
                {
                    Action act = (Action)handler;
                    act.Invoke();
                }
            }
        }

        public static void Broadcast<T>(string eventId, T  arg)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            foreach (var handler in handlers.ToList())
            {
                if (handler is Action<T>)
                {
                    Action<T> act = (Action<T>)handler;
                    act.Invoke(arg);
                }
            }
        }

        public static void Broadcast<T1, T2>(string eventId, T1 arg1, T2 arg2)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            foreach (var handler in handlers.ToList())
            {
                if (handler is Action<T1,T2>)
                {
                    Action<T1,T2> act = (Action<T1,T2>)handler;
                    act.Invoke(arg1,arg2);
                }
            }
        }

        public static void Broadcast<T1, T2, T3>(string eventId, T1 arg1, T2 arg2,T3 arg3)
        {
            List<Delegate> handlers = EventManager.GetHandlers(eventId);
            foreach (var handler in handlers.ToList())
            {
                if (handler is Action<T1, T2, T3>)
                {
                    Action<T1, T2,T3> act = (Action<T1, T2,T3>)handler;
                    act.Invoke(arg1, arg2, arg3);
                }
            }
        }

    }
}
