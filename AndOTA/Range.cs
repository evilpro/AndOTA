using System;
using System.Collections;
using System.Collections.Generic;

namespace AndOTA
{
    public class Range : IEnumerable<int>
    {
        private readonly int start;
        private int stop;
        private int step;

        public Range WithStep(int step)
        {
            this.step = step;
            return this;
        }

        public Range(int start)
        {
            this.start = stop = start;
        }

        public static Range From(int startRange)
        {
            return new Range(startRange);
        }

        public Range To(int endRange)
        {
            stop = endRange;
            return this;
        }

        public void Do(Action<int> f)
        {
            foreach (int i in this) { f(i); }
        }
        public IEnumerator<int> GetEnumerator()
        {
            int max = Math.Max(start, stop);
            int min = Math.Min(start, stop);
            if (step == default(int))
            {
                step = (start == min) ? 1 : -1;
            }
            int current = start;
            while (current >= min && current < max)
            {
                yield return current;
                current += step;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
