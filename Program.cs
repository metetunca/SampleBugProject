using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleLeagueApp
{
    //D J Mullier 2014
    using System;
    namespace cycleLeague
    {
        public class League
        {


            public static void Main()
            {
                //some ad-hoc code to do some testing
                Random rnd = new Random();
                Competitor c;
                int events = 18;
                CycleLeague league = new CycleLeague("Time Trial League", events);
                for (int i = 0; i < 20; i++) //loop for competitors
                {
                    c = new Competitor(league, "Person " + i, "Nova", "Senior");
                    for (int j = 0; j < events; j++) //loop for events, generating random points for each event for each competitor ****************BUG HERE put int j = 0; i < events; i++
                    {

                        
                        int ran = rnd.Next(50); 
                        c.setResult(ran); //random set of results
                    }
                    c.getPointsEvent(1); //debug
                }




                league.sortResults();
                Competitor c2 = league.getCompetitor(0);
                Award award = new Award("League Champion");
                c2.addAward(award);
                award = new Award("Hilly 19 Trophy");
                c2.addAward(award);
                award = new Award("Triangle Trophy");
                c2.addAward(award);
                league.displayCompetitors();
               
                Console.Read();// press a key to exit at the end
            }

        }
    }

}
