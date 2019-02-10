using SkiJumpAggregator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SkiJumpAggregator.Model
{
    public class _FISretrieverModel : INotifyPropertyChanged
    {
        private int id { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private string nationality { get; set; }
        private int fisId { get; set; }
        private List<Competition> standings = new List<Competition>();
        private List<SkiJumper> jumpers = new List<SkiJumper>();

        private HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();

        public event PropertyChangedEventHandler PropertyChanged;

        public _FISretrieverModel()
        {

        }

        public List<SkiJumper> getSkiJumpers()
        {

            HtmlAgilityPack.HtmlDocument StandingsDoc = web.Load("https://www.fis-ski.com/DB/ski-jumping/cup-standings.html");

            var JumperId = StandingsDoc.DocumentNode.SelectNodes("//a[contains(@class, 'table-row reset-padding')]").ToList();
            var HeaderNames = StandingsDoc.DocumentNode.SelectNodes("//div[contains(@class, 'g-xs-10 g-sm-9 g-md-4 g-lg-4 justify-left bold align-xs-top')]").ToList();
            var Nationality = StandingsDoc.DocumentNode.SelectNodes("//span[contains(@class, 'country__name-short')]").ToList();
            //var  = doc.DocumentNode.SelectNodes("//span[contains(@class, 'country__name-short')]").ToList();

            Regex fisIdRegex = new Regex(@"[0-9]{3,6}");
            for (int i = 0; i < HeaderNames.Count; i++)
            {
                string jumperLink = JumperId[i].Attributes["href"].Value;
                string fisIdString = fisIdRegex.Match(jumperLink).Value.ToString();
                fisId = int.Parse(fisIdString);
                SkiJumper jumper = new SkiJumper(fisId, parseName(HeaderNames[i].InnerText), parseSurname(HeaderNames[i].InnerText), Nationality[i].InnerText);
                jumpers.Add(jumper);

            }

            return jumpers;
 
        }

 /*     public List<Competition> getCompetitionStanding()
        {
            
            HtmlAgilityPack.HtmlDocument JumperDoc = web.Load("https://www.fis-ski.com/DB/general/athlete-biography.html?sectorcode=JP&competitorid=" + fisId + "&type=result");

            var cupNames = JumperDoc.DocumentNode.SelectNodes("//div[contains(@class, 'g-md g-lg justify-left hidden-sm-down')]").ToList();
            var cupStanding = JumperDoc.DocumentNode.SelectNodes("//div[contains(@class, 'g-xs-24 g-sm g-md g-lg justify-right')]").ToList();

            for (int i = 0; i < 3; i++)
            {
                Competition competition = new Competition(cupNames[i].InnerText, cupStanding[i].InnerText);
                standings.Add(competition);
            }
            return standings;

        }
*/
        private string parseSurname(string dirty)
        {
            Regex regex = new Regex(@"[A-z]\w+");
            return regex.Match(dirty).NextMatch().Value;
        }

        private string parseName(string dirty)
        {
            Regex regex = new Regex(@"[A-z]\w+");
            return regex.Match(dirty).Value;
        }
    }
    
}