using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_Lecture_10_ComboAndListBoxes
{
    public class Team
    {
        string _name;
        string _city;
        List<Player> _players = new List<Player>();
        Coach _coach;

        public Team(string name, string city, Coach coach)
        {
            _name = name;
            _city = city;
            _coach = coach;
        }

        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public List<Player> Players { get => _players;  }
        public Coach Coach { get => _coach; set => _coach = value; }

    }
}
