using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tichy_SemestralniPrace
{
    public partial class Form1 : Form
    {
        private List<Planet> planets;
        private List<Spaceship> spaceships;

        public Form1()
        {
            InitializeComponent();

            planets = new List<Planet>();
            spaceships = new List<Spaceship>();        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Planet planet in planets)
            {
                planet.Refresh(timer1.Interval);
            }
        }
    }
}
