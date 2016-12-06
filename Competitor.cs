//D J Mullier 2014

namespace CycleLeagueApp
{
    using System;
    using System.Collections;
public class Competitor:IComparable
{
	private string name;
	private string club;
	private string cat;
	private ArrayList awards = new ArrayList();
	private int eventsCompeted; //events competed in so far
	private int[] results;		//results achieved in the league
	
	private CycleLeague league; //league to which this competitor is attached
	
	public Competitor(CycleLeague league, string name, string club, string cat)
	{
		results = new int[league.getNumberOfEvents()];
		this.name = name;
		this.club = club;
		this.cat = cat;
		this.eventsCompeted = 0;
		this.league=league;
		league.addCompetitor(this);
		
	}

    // This function sorts the array list.   
    public int CompareTo(Object obj)
    {
        if (obj is Competitor)
           return (obj as Competitor).getPoints().CompareTo(this.getPoints());
        return 0;
    }
	
	public string getName()
	{
		return this.name;
	}
	
	public string getClub()
	{
		return this.club;
	}
	
	public string getCat()
	{
		return this.cat;
	}
	
	public int getEventsCompeted()
	{
		return eventsCompeted;
	}
	
	public int getPoints()
	{
		int points=0;
		for(int i=0 ; i<eventsCompeted; i++)
			points-=results[i];
		return points;
	}
	
	public int getPointsEvent(int evnt)
	{
		return results[evnt];
	}
	
	//assumes events are completed sequentially so points goes into the next slot
	public void setResult(int points)
	{
		results[eventsCompeted++] = points;
	
	}
	
	//set a particular result, returns false if that event does not exist
	public bool setResult(int evnt, int points)
	{
		if(evnt < league.getNumberOfEvents())
		{
			results[evnt] = points;
			return true;
		}
		return false;
	}
	
	public void addAward(Award award)
	{
		awards.Add( award);
	}
	
	public int getNumberOfAwards()
	{
		return awards.Count;
	}
	
	public ArrayList getAwards()
	{
		return awards;
	}

}
}