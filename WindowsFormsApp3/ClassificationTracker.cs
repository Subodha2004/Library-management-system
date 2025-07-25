using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class ClassificationTracker
    {
        private Dictionary<string, int> classificationCounters;

        public int GetNextNumber(string classification)
        {
            if (classificationCounters == null)
            {
                classificationCounters = new Dictionary<string, int>();
            }

            if (!classificationCounters.ContainsKey(classification))
            {
                classificationCounters[classification] = 1;
            }
            else
            {
                classificationCounters[classification]++;
            }
            return classificationCounters[classification];
        }
    }
}

