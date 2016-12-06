//D J Mullier 2014
namespace CycleLeagueApp
{
    using System;
    using System.Collections;


    public class CycleLeague
    {
        private string leagueName;
        private int numberOfEvents;
        private ArrayList competitors = new ArrayList();

        public CycleLeague(string name, int events)
        {
            this.leagueName = name;
            this.numberOfEvents = events;
        }

        public string getLeagueName()
        {

            return leagueName;
        }

        public int getNumberOfEvents()
        {
            return numberOfEvents;
        }

        public void addCompetitor(Competitor c)
        {
            competitors.Add(c);
        }

        public Competitor getCompetitor(string name)
        {

            foreach (Competitor c in competitors)
            {
                string s = c.getName();
                s = s.ToLower();
                if (s.CompareTo(name.ToLower()) == 0)
                {
                    return c;
                }

            }
            return null;
        }

        //get the "position"th competitor (first is zero)
        public Competitor getCompetitor(int position)
        {
            return (Competitor)competitors[position];
        }

        //go through all the competitors and sort them based on total points
        public void sortResults()
        {
            competitors.Sort();
          
        }

        public void displayCompetitors()
	{
		string Awards="";
		for(int i=0; i<numberOfEvents; i++)
		{
			Competitor c;
			Awards="";
			c = (Competitor) competitors[i];
			int noAwards = c.getNumberOfAwards();
			if (noAwards>0)
			{
				ArrayList arr = c.getAwards();
				for(int j=0;j<noAwards; j++)
				{
					Award a = (Award) arr[j];
					Awards += a.getName()+" ";
				}
			}
			Console.WriteLine(c.getName()+"\t"+c.getClub()+"\t"+c.getCat()+"\t"+c.getPoints()+" "+Awards);
		}
	}
    }
}
