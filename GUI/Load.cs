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
            this.BackColor = Color.Lavender;
            this.TransparencyKey = Color.Lavender;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Load_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 903)
            {
                timer1.Stop();
                this.Hide();
                WeatherForm form = new WeatherForm();
                form.ShowDialog();
            }
        }
    }
}
