using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.FootbalTeamGenerator
{
    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty");
                }

                this.name = value;
            }
        }

        private List<Player> players;
        public IReadOnlyList<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var player = this.players.FirstOrDefault(x => x.Name == playerName);
            if (player == null)
            {
                throw new Exception($"Player {playerName} is not in {this.name} team.");
            }
            else
            {
                this.players.Remove(player);
            }
        }

        public double Rating
        {
            get
            {
                return players.Average(x => x.OverallSkillLevel);
            }
        }
    }
}
