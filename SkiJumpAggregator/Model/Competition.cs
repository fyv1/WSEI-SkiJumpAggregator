using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiJumpAggregator.Model
{
    class Competition
    {
        private int id { get; set; }
        private int standings { get; set; }

        public Competition(int id, int standings)
        {
            this.id = id;
            this.standings = standings;
        }


    }
}
