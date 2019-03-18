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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm();
            playerForm.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void bestButton_Click(object sender, EventArgs e)
        {
            BestClubForm bestClubForm = new BestClubForm();
            bestClubForm.ShowDialog();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void cancleButton_Click(object sender, EventArgs e)
        {

        }

        private void endButton_Click(object sender, EventArgs e)
        {

        }
    }
}
