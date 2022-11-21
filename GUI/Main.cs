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
        double lon;
        double lat;

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBoxCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root outPut = Info;

                pictureIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelCondition.Text = Info.weather[0].main;
                labelDetails.Text = Info.weather[0].description;
                labelTemp.Text = string.Format("{0}\u00B0"+"C", outPut.main.temp);
                labelCountry.Text = Info.sys.country.ToString();
                labelWindspeed.Text = Info.wind.speed.ToString();
                labelPressure.Text = Info.main.pressure.ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }

        }

        DateTime convertDateTine(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();

            return day;
        }

        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo= JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                ForecastUC FUC;
                for (int i = 0; i < 8; i++)
                {
                    FUC = new ForecastUC();
                    FUC.pictureBoxWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[i]
                        .weather[0].icon + ".png";
                    FUC.labelMainWeather.Text = ForecastInfo.daily[i].weather[0].main;
                    FUC.labelWeatherDescription.Text = ForecastInfo.daily[i].weather[0].description;
                    FUC.labeldt.Text = convertDateTine(ForecastInfo.daily[i].dt).DayOfWeek.ToString();

                    flowLayoutPanel.Controls.Add(FUC);
                }
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
            //getForecast();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
