using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv04._1
{
    class Stats
    {
        public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);

        public int Correct { get; set; }
        public int Missed { get; set; }
        public int Accuracy { get; set; }

        public event UpdatedStatsEventHandler UpdatedStats;

        private void OnUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        public void Update(bool correctKey)
        {
            if (correctKey)
            {
                Correct++;
            }
            else
            {
                Missed++;
            }

            Accuracy = (Correct + Missed) * (Correct / 100);

            OnUpdatedStats();
        }
    }
}
