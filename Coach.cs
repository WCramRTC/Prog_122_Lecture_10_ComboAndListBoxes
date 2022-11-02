using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_Lecture_10_ComboAndListBoxes
{
    public class Coach
    {

        string _name;

        public Coach(string name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
