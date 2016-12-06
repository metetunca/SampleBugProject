//D J Mullier 2014
//represents an award such as a trophy
namespace CycleLeagueApp
{
    public class Award
    {
        private string name;
        private string description;


        public Award(string name)
        {
            this.name = name;

        }

        public Award(string name, string description)
        {
           
            this.description = description;

        }

        public string getName()
        {
            return this.name;
        }
        public Award(Competitor winner, string name)
        {
            this.name = name;


        }




    }
}
