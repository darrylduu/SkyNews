using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyNews.BLL
{
    class WeatherInfo
    {
        public class activities
        {
            public string title { get; set; }
            public string description { get; set; }
            public string link { get; set; }

            // GetAllActivities() method that returns a List<WeatherInfo.activities>
            // This method receives an integer weather in Celcius
            // If < 0, certain activities will be shown for this type of weather
            // If > 0, certain activities will be shown for this type of weather
            // Etc...

            public List<WeatherInfo.activities> GetActivities(int temperature, string location)
            {
                List<activities> listA = new List<activities>();

                // switch statement goes here
                if (temperature < 0)
                {
                    // get all Winter activites from the DB
                    // add to the listA
                }
                if (temperature > 0 && temperature <= 10)
                {
                    // get all AlmostWinter activites from the DB
                    // add to the listA
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
        public class coordinates
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string desc { get; set; }
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
        public class system
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }

        public class root
        {
            public coordinates coord { get; set; }
            public List <weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public system system { get; set; }
        }
    }
}
