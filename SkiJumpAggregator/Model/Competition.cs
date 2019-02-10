using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiJumpAggregator.Model
{
    public class Competition
    {
        private string id { get; set; }
        private string standings { get; set; }

        public Competition(string id, string standings)
        {
            this.id = id;
            this.standings = standings;
        }

        public override string ToString()
        {
            return  id +" "+ standings;
        }

    }
}
