using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AndOTA
{
    public class Toolbox
    {
        public static List<Tuple<Int64, Int64>> GetRangeset(String source)
        {
            String[] src_set = source.Split(',');
            Int32[] num_set = src_set.Select(x => Int32.Parse(x)).ToArray();
            if (num_set.Length != num_set[0]+1)
            {
                Debug.WriteLine($"Parse fail: {source}");
            }

            List<Tuple<Int64, Int64>> tuples = new List<Tuple<Int64, Int64>>();

            foreach (int i in Range.From(1).To(num_set.Length).WithStep(2))
                tuples.Add(new Tuple<Int64, Int64>(num_set[i], num_set[i+1]));

            return tuples;
        }
    }
}
