using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfile
{
    internal class Match
    {
        public string Team1 { get; private set; }
        public string Team2 { get; private set; }
        public int Goals1 { get; private set; }
        public int Goals2 { get; private set; }

        public int NYellows { get; private set; }

        public List<string> YellowNames { get; private set; }

        public Match(string team1, string team2, int g1,int g2,int yellows, List<string> yellowNames)
        {
            Team1 = team1;
            Team2 = team2;
            Goals1 = g1;
            Goals2 = g2;
            NYellows= yellows;
            YellowNames = yellowNames;
            
        }
        public override string ToString() 
        { 
            string s= $" {Team1} : {Goals1}  {Team2} : {Goals2}  Yellow cards:";
            foreach(string s1 in YellowNames)
            {
              s+= s1;
            }
            return s;
        }

    }
}
