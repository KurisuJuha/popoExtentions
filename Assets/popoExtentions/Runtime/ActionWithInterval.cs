using System;
using UnityEngine;

namespace JuhaKurisu.PopoTools.Extentions
{
    public class ActionWithInterval
    {
        public event Action action;
        public double lastInvokeTime { get; private set; }
        public double interval { get; private set; }

        public ActionWithInterval(double interval, Action action)
        {
            this.action = action;
            this.interval = interval;
            lastInvokeTime = Time.timeAsDouble - interval;
        }

        public void Invoke()
        {
            TryInvoke();
        }

        public bool TryInvoke()
        {
            if (lastInvokeTime + interval > Time.timeAsDouble) return false;

            action.Invoke();
            lastInvokeTime = Time.timeAsDouble;
            return true;
        }

        public void Reset()
        {
            lastInvokeTime = Time.timeAsDouble - interval;
        }

        public void ChangeInterval(double interval)
        {
            this.interval = interval;
        }
    }
}