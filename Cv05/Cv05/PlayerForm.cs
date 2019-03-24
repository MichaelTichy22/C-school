using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cv05
{
    public partial class PlayerForm : Form
    {
        private Player newPlayer;

        private FootballClub selectedClub;

        internal Player NewPlayer { get => new Player(nameText.Text, selectedClub, Int32.Parse(goalsText.Text)); set => newPlayer = value; }

        public PlayerForm()
        {
            InitializeComponent();
            clubCombo.DataSource = Enum.GetValues(typeof(FootballClub));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Enum.TryParse<FootballClub>(clubCombo.SelectedValue.ToString(), out selectedClub);
        }
    }
}
