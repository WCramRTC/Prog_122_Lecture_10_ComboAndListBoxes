using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Prog_122_Lecture_10_ComboAndListBoxes
{
    public partial class Form1 : Form
    {
        List<string> _places = new List<string>();
        List<string> _populations = new List<string>();
        List<Team> _teams = new List<Team>();

        public Form1()
        {
            InitializeComponent();
            TeamPreload();
            //DisplayTeamNames(_teams);
            // To access a list in a combo box or list box
            // use the objects .Items list
            DisplayTeamNames(_teams, cbPlaces);

            //Preload();
        }

        public void DisplayTeamNames(List<Team> teams, ComboBox combobox)
        {
            // Clears information from combobox
            combobox.Items.Clear();
         
            foreach (Team team in teams)
            {
                combobox.Items.Add($"{team.City} {team.Name}");
            }

            combobox.SelectedIndex = 0;
        } // DisplayTeamNames()

        public void DisplayTeamNames(List<Team> teams, ListBox listbox)
        {
            // Clears information from combobox
            listbox.Items.Clear();

            foreach (Team team in teams)
            {
                listbox.Items.Add($"{team.City} {team.Name}");
            }

            listbox.SelectedIndex = 0;
        }

        public void DisplayPlayerNames(List<Player> players, ListBox lb)
        {
            lb.Items.Clear();
            foreach (Player player in players)
            {
                lb.Items.Add(player.Name);
            }
        }

        public void TeamPreload()
        {
      
            Coach laker = new Coach("Tim Laker");
            Team mariners = new Team("Mariners", "Seattle", laker);
            Player player = new Player("Jarred Kelenic", "Outfielder", 5.34);
            mariners.Players.Add(player);
            player = new Player("Julio Rodrigez", "Centerfield", 1.44);
            mariners.Players.Add(player);
            _teams.Add(mariners);
            //----------------------------------------
            Coach baker = new Coach("Dusty Baker");
            Team astros = new Team("Astros", "Houston", baker);
            player = new Player("José Altuve", "Second Basemen", 5.34);
            astros.Players.Add(player);
            player = new Player("Yordan Álvarez", "Left Fielder", 1.44);
            astros.Players.Add(player);
            _teams.Add(astros);

            //----------------------------------------

            Coach cram = new Coach("William Cram");
            Team procrammers = new Team("Procrammers", "Seattle", cram);
            player = new Player("Zach", "Second Basemen", 5.34);
            procrammers.Players.Add(player);
            player = new Player("Wong", "Left Fielder", 1.44);
            procrammers.Players.Add(player);
            _teams.Add(procrammers);


            string display = $"" +
                $"Team: {astros.City} {astros.Name}\n" +
                $"Coach: {astros.Coach.Name}\n" +
                $"Player: {astros.Players[0].Name}";

  
            

        }

        //public void AddToComboBox(List<string> list)
        //{
        //    foreach (string item in list)
        //    {
        //        cbPlaces.Items.Add(item);
        //    }
        //}

        //public void Preload()
        //{
        //    _places.Add("San Francisco");
        //    _places.Add("Milwaukee");
        //    _places.Add("Canton");
        //    _places.Add("Everett");

        //    _populations.Add("10000000");
        //    _populations.Add("20000000");
        //    _populations.Add("30000000");
        //    _populations.Add("40000000");

        //    AddToComboBox(_places);
        //}

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //int index = cbPlaces.SelectedIndex;
            int index = cbPlaces.SelectedIndex;

            Team team = _teams[index];

            DisplayPlayerNames(team.Players, lbNames);
        }

  


    } // class
} // Main
