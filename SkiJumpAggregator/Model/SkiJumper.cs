using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiJumpAggregator.Model
{
    public class SkiJumper
    {
        private int fisId { get; set; }
        private String name { get; set; }
        private String surname { get; set; }
        private String country { get; set; }
        
        private double rating { get; set; }
        public List<Competition> competitions = new List<Competition>();

        public SkiJumper(int fisId, String surname, String name, String country)
        {
            this.fisId = fisId;
            this.surname = surname;
            this.name = name;
            this.country = country;
            
            this.rating = 1000.0; // default rating
        }

        public void addStandings(Competition entry)
        {
            this.competitions.Add(entry);
        }

        public override string ToString()
        {
            return surname + " " + name + "\t" + country;
        }
    }
}
