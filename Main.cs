using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using SkyNews.BLL;

namespace SkyNews
{
    public partial class Main : Form
    {
        string APIKey = "10272f136f947a75efb69dcc09e674ac";
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBoxCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pictureIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelCondition.Text = Info.weather[0].main;
                labelDetails.Text = Info.weather[0].desc;

                labelSunrise.Text = Info.system.sunrise.ToString();
                labelSunrise.Text = Info.system.sunset.ToString();

                labelWindspeed.Text = Info.wind.speed.ToString();
                labelPressure.Text = Info.main.pressure.ToString();
            }
        }

        public Main()
        {
            InitializeComponent();
            labelDateTime.Text = DateTime.Now.ToString("dddd , MMM dd yyyy, hh:mm:ss");
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
