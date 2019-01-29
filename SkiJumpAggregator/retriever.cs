using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SkiJumpAggregator
{
    class retriever
    {
        public void getFisData()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.fis-ski.com/DB/ski-jumping/cup-standings.html");

            var JumperId = doc.DocumentNode.SelectNodes("//a[contains(@class, 'table-row reset-padding')]").ToList();
            var HeaderNames = doc.DocumentNode.SelectNodes("//div[contains(@class, 'g-xs-10 g-sm-9 g-md-4 g-lg-4 justify-left bold align-xs-top')]").ToList();
            var Nationality = doc.DocumentNode.SelectNodes("//span[contains(@class, 'country__name-short')]").ToList();
            //var  = doc.DocumentNode.SelectNodes("//span[contains(@class, 'country__name-short')]").ToList();


            for (int i = 0; i < HeaderNames.Count; i++)
            {
                string jumperLink = JumperId[i].Attributes["href"].Value;
                string fisId = new Regex(@"[0-9][0-9][0-9][0-9][0-9][0-9]").Match(jumperLink).Value;
                Console.WriteLine("{0} -> {1}, {2}", fisId, HeaderNames[i].InnerText.ToString(), Nationality[i].InnerText.ToString());
            }
            Console.ReadKey();
        }
    }
}
