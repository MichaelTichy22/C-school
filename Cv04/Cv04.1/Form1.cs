using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cv04._1
{
    public partial class Form1 : Form
    {
        Random random;
        Stats stats;

        public Form1()
        {
            InitializeComponent();

            stats = new Stats();
            random = new Random();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer1.Enabled = true;
            stats = new Stats();
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));

            if (listBox1.Items.Count >= 6)
            {
                timer1.Enabled = false;

                listBox1.Items.Clear();

                listBox1.Items.Add("Game over!");

                return;
            }
            
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);

                listBox1.Refresh();

                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 60;
                }
                else if (timer1.Interval > 250)
                {
                    timer1.Interval -= 15;
                }
                else if (timer1.Interval > 150)
                {
                    timer1.Interval -= 8;
                }

                int progressValue = 800 - timer1.Interval;

                if (progressValue > 800)
                {
                    progressValue = 800;
                }
                else if (progressValue < 0) {
                    progressValue = 0;
                }
                difficultyBar.Value = progressValue;

                stats.Update(true);

                correctLabel.Text = "Correct: " +stats.Correct;
                missedLabel.Text = "Missed: " + stats.Missed;
                accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
            }
            else
            {
                stats.Update(false);
            }
        }
    }
}
