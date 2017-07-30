using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.FootbalTeamGenerator
{
    public class Player
    {
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;

            this.stats = new List<Stat>();
            stats.Add(new Stat("endurance", endurance));
            stats.Add(new Stat("sprint", sprint));
            stats.Add(new Stat("dribble", dribble));
            stats.Add(new Stat("passing", passing));
            stats.Add(new Stat("shooting", shooting));
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty");
                }

                name = value;
            }
        }

        private List<Stat> stats;
        public IReadOnlyList<Stat> Stats
        {
            get { return stats; }
        }

        public double OverallSkillLevel
        {
            get
            {
                return this.Stats.Average(x => x.Value);
            }
        }
    }
}
