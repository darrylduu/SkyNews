using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyNews.GUI
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            for(int i = 1; i <= 100; i++)
            {
                Thread.Sleep(5);
                circularProgressBar.Value = i;
                circularProgressBar.Update();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Load_Load(object sender, EventArgs e)
        {
            circularProgressBar.Value = 0;
            circularProgressBar.Minimum = 0;
            circularProgressBar.Maximum = 100;
            if (circularProgressBar.Value == 100)
            {
                this.Hide();
                Main form = new Main();
                form.ShowDialog();
            }
        }
    }
}
