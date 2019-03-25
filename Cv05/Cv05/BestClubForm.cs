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
    public partial class BestClubForm : Form
    {
        public List<FootballClub> BestClubs { get; set; }
        public int NumberOfGoals { get; set; }
        public BestClubForm()
        {
            InitializeComponent();
        }

        public void SetForm()
        {
            goalsText.Text = NumberOfGoals.ToString();

            clubsList.DataSource = BestClubs;
        }
    }
}
