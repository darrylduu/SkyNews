using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyNews.DAL;
using System.Data.SqlClient;

namespace SkyNews.BLL
{
    class WeatherInfo
    {
        public class activities
        {

            public int activityId { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string link { get; set; }

            // GetAllActivities() method that returns a List<WeatherInfo.activities>
            // This method receives an integer weather in Celcius
            // If < 0, certain activities will be shown for this type of weather
            // If > 0, certain activities will be shown for this type of weather
            // Etc...

            public List<WeatherInfo.activities> GetActivities(string temp)
            {
                List<activities> listA = new List<activities>();
                activities a;
                int temperature = 0;

                MessageBox.Show(temp);
                //MessageBox.Show(temperature.ToString());

                if (temperature <= 0)
                {
                    SqlConnection connDB = UtilityDB.ConnectDB();
                    SqlCommand cmdGetId = new SqlCommand("SELECT activityId FROM Combinations WHERE temperatureId = 1", connDB);

                    SqlDataReader reader = cmdGetId.ExecuteReader();
                    

                    while (reader.Read())
                    {
                        a = new activities();
                        SqlCommand cmdGetTitle = new SqlCommand("SELECT title FROM Activities WHERE activityId = @activityId", connDB); // added
                        a.activityId = Convert.ToInt32(reader["activityId"]);
                        cmdGetTitle.Parameters.AddWithValue("@activityId", a.activityId); //added
                        //cmdGetTitle.ExecuteNonQuery();
                        //MessageBox.Show(reader["title"].ToString());
                        a.title = reader["title"].ToString(); // added 
                        listA.Add(a);
                    }


                    connDB.Close();
                }
                if (temperature > 0 && temperature <= 10)
                {
                    SqlConnection connDB = UtilityDB.ConnectDB();
                    SqlCommand cmdGetId = new SqlCommand();
                    cmdGetId.Connection = connDB;
                    cmdGetId.CommandText = "SELECT activityId FROM Combinations WHERE temperatureId = 1";
                    SqlDataReader reader = cmdGetId.ExecuteReader();
                    a = new activities();

                    while (reader.Read())
                    {
                        a.activityId = Convert.ToInt32(reader["activityId"]);
                        listA.Add(a);
                    }

                    connDB.Close();
                }
                if (temperature > 10 && temperature <= 16)
                {
                    // get all Fall activites from the DB
                    // add to the listA
                }
                if (temperature > 16)
                {
                    // get all Summer activites from the DB
                    // add to the listA
                    // if location is near a beach, get beach activities from DB
                    // add to the listA
                }



                return listA;
            }


            public void DisplayActivities(ListView lv, List<activities> listA)
            {
                lv.Items.Clear();

                if (listA.Count != 0) // if list has data...
                {
                    // fill listview
                    foreach (activities a in listA)
                    {
                        ListViewItem items = new ListViewItem();
                        items.SubItems.Add(a.title);
                        items.SubItems.Add(a.description);
                        items.SubItems.Add(a.link);
                        lv.Items.Add(items);
                    }
                }
                else
                {
                    lv.Items.Add("There are no activities for this location.");
                }
            }
        }
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }
        public class wind
        {
            public double speed { get; set; }
        }
        public class sys
        {
            public string country { get; set; }
        }

        public class root
        {
            public coord coord { get; set; }
            public List <weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
        }
    }
}
