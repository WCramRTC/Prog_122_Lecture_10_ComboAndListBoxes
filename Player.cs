using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_Lecture_10_ComboAndListBoxes
{
    public class Player
    {
        string _name;
        string _position;
        double _era;

        public Player(string name, string position, double era)
        {
            Name = name;
            Position = position;
            Era = era;
        }

        public string Name { get => _name; set => _name = value; }
        public string Position { get => _position; set => _position = value; }
        public double Era { get => _era; set => _era = value; }
    }
}
