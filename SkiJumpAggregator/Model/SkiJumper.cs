using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiJumpAggregator.Model
{
    class SkiJumper
    {
        private int fisId { get; set; }
        private String name { get; set; }
        private String country { get; set; }
        private bool ifAdded { get; set; }
        private double rating { get; set; }
        public List<Competition> competitions = new List<Competition>();

        public SkiJumper(int fisId, String name, String country, bool ifAdded)
        {
            this.fisId = fisId;
            this.name = name;
            this.country = country;
            this.ifAdded = ifAdded;
            this.rating = 1000.0; // default rating
        }

        public void addStandings(Competition entry)
        {
            this.competitions.Add(entry);
        }

        public override string ToString()
        {
            return name + " " + country;
        }
    }
}
