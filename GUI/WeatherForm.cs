using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SkyNews.BLL;
using SkyNews.DAL;
using System.Text.RegularExpressions;

namespace SkyNews.GUI
{
    public partial class WeatherForm : Form
    {
        string APIKey = "10272f136f947a75efb69dcc09e674ac";
        double lon;
        double lat;
        
        

        public WeatherForm()
        {
            InitializeComponent();
            labelDateTime.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            textBoxCity.Focus();

            flowLayoutPanelDailyWeather.Visible = false;

            labelSearchForCity.Parent = pictureBoxBackground;
            labelSearchForCity.BackColor = Color.Transparent;

            labelCountry.Parent = pictureBoxBackground;
            labelCountry.BackColor = Color.Transparent;

            labelCondition.Parent = pictureBoxBackground;
            labelCondition.BackColor = Color.Transparent;

            labelDateTime.Parent = pictureBoxBackground;
            labelDateTime.BackColor = Color.Transparent;

            labelDetails.Parent = pictureBoxBackground;
            labelDetails.BackColor = Color.Transparent;

            labelTemp.Parent = pictureBoxBackground;
            labelTemp.BackColor = Color.Transparent;

            labelWind.Parent = pictureBoxBackground;
            labelWind.BackColor = Color.Transparent;

            labelPressure2.Parent = pictureBoxBackground;
            labelPressure2.BackColor = Color.Transparent;

            labelActivities.Parent = pictureBoxBackground;
            labelActivities.BackColor = Color.Transparent;

            labelWindspeed.Parent = pictureBoxBackground;
            labelWindspeed.BackColor = Color.Transparent;

            labelPressure.Parent = pictureBoxBackground;
            labelPressure.BackColor = Color.Transparent;

            WeatherInfo.user u = new WeatherInfo.user();
            u.DisplayFavorites(listBoxFavorites, u.getAllLocations(1));


        }



        DateTime convertDateTine(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();

            return day;
        }



        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", textBoxCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pictureBoxIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelCondition.Text = Info.weather[0].main;
                labelDetails.Text = Info.weather[0].description;
                labelTemp.Text = Info.main.temp.ToString() + "°C";
                labelCountry.Text = Info.sys.country.ToString();
                labelWindspeed.Text = Info.wind.speed.ToString() + " Km/h";
                labelPressure.Text = Info.main.pressure.ToString() + " hPa";

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }

        }



        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/3.0/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&units=metric&appid={2}", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                ForecastUC FUC;
                for (int i = 0; i < 8; i++)
                {
                    FUC = new ForecastUC();
                    FUC.pictureBoxWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[i]
                        .weather[0].icon + ".png";
                    FUC.labelMainWeather.Text = ForecastInfo.daily[i].weather[0].main;
                    FUC.labelWeatherDescription.Text = ForecastInfo.daily[i].weather[0].description;
                    FUC.labeldt.Text = convertDateTine(ForecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FUC.labelMin.Text = ForecastInfo.daily[i].temp.min.ToString() + "°C";
                    FUC.labelMax.Text = ForecastInfo.daily[i].temp.max.ToString() + "°C";

                    flowLayoutPanelDailyWeather.Controls.Add(FUC);
                }
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
            
            string temp = labelTemp.Text;
            string cleaned = temp.Replace("°C", "");
            int temperature = Convert.ToInt32(Math.Floor(Convert.ToDouble(cleaned)).ToString());

            WeatherInfo.activities a = new WeatherInfo.activities();
            List<WeatherInfo.activities> listA = a.GetActivities(temperature);
            a.DisplayActivities(listViewActivities, listA);

            flowLayoutPanelDailyWeather.Visible = true;
        }

        private void buttonConnectDB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UtilityDB.ConnectDB().State.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherInfo.user u = new WeatherInfo.user();
            WeatherInfo.location l = new WeatherInfo.location();

            if (textBoxCity.Text != "")
            {
                string city = validateCity(textBoxCity.Text);

                if (u.AlreadyExits(1, city))
                {
                    MessageBox.Show("This location is already in your favorites! Go take a look :)");
                }
                else
                {
                    u.SaveToFavorites(1, city);
                    u.DisplayFavorites(listBoxFavorites, u.getAllLocations(1));
                }
            }
            else
            {
                MessageBox.Show("Please enter a city or country to save to favorites.");
                textBoxCity.Focus();
            }
        }

        private string validateCity(string strCity)
        {
            string textboxCityValidation = char.ToUpper(strCity[0]) + strCity.Substring(1);
            return textboxCityValidation;
        }

        private void listBoxFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFavorites_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxFavorites.SelectedItem != null)
            {
                tabControl1.SelectedIndex = 0;
                textBoxCity.Text = listBoxFavorites.SelectedItem.ToString();
                buttonSearch_Click(sender, e);
            }
        }
    }
}
