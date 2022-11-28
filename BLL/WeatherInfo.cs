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
        public class Favorites


        public class user
        {
            public int id { get; set; }
            public string name { get; set; }

            

            public bool AlreadyExits(int userId, string location)
            {
                bool exists = false;

                SqlConnection conn = new SqlConnection();

                try
                {
                    conn = UtilityDB.ConnectDB();
                    SqlCommand cmdFindEmployee = new SqlCommand("SELECT l.locationId, l.locationName " +
                                                                "FROM Locations l " +
                                                                "JOIN Favorites f ON f.locationId = l.locationId " +
                                                                "WHERE l.locationName = @locationName" +
                                                                "AND f.userId = @userId", conn);
                    cmdFindEmployee.Parameters.AddWithValue("@locationName", location);
                    cmdFindEmployee.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader reader = cmdFindEmployee.ExecuteReader();

                    if (reader.Read())
                    {
                        exists = reader["locationName"].Equals(location); // checks if location already saved
                    }

                }
                catch (Exception x)
                {
                    throw x;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                return exists;
            }

            public void SaveToFavorites(int userId, string location)
            {
                SqlConnection conn = UtilityDB.ConnectDB();
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Favorites (locationId, userId) VALUES (@locationId, @userId)", conn);
                cmdInsert.Parameters.AddWithValue("@locationId", location);
                cmdInsert.Parameters.AddWithValue("@userId", userId);
                cmdInsert.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();

                MessageBox.Show("Location has been added to favorites.");
            }

        }
        public class activities
        {

            public int activityId { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string link { get; set; }

            public List<WeatherInfo.activities> GetActivities(int temperature)
            {
                List<activities> listA = new List<activities>();
                activities a;

                if (temperature <= 0)
                {
                    SqlConnection connDB = UtilityDB.ConnectDB();
                    SqlCommand cmdGetId = new SqlCommand("SELECT a.title, a.activityId " +
                                                         "FROM Activities a " +
                                                         "JOIN Combos c on c.activityId = a.activityId " +
                                                         "WHERE temperatureId = 0 " +
                                                         "AND weatherId = 12;", connDB);

                    SqlDataReader reader = cmdGetId.ExecuteReader();
                    

                    while (reader.Read())
                    {
                        a = new activities();
                        a.activityId = Convert.ToInt32(reader["activityId"]);
                        a.title = reader["title"].ToString();
                        listA.Add(a);
                    }

                    connDB.Close();
                }
                if (temperature > 0 && temperature <= 10)
                {
                    SqlConnection connDB = UtilityDB.ConnectDB();
                    SqlCommand cmdGetId = new SqlCommand("SELECT a.title, a.activityId " +
                                                         "FROM Activities a " +
                                                         "JOIN Combinations c on c.activityId = a.activityId " +
                                                         "WHERE temperatureId = 1 " +
                                                         "AND weatherId = 12;", connDB);

                    SqlDataReader reader = cmdGetId.ExecuteReader();


                    while (reader.Read())
                    {
                        a = new activities();
                        a.activityId = Convert.ToInt32(reader["activityId"]);
                        a.title = reader["title"].ToString();
                        listA.Add(a);
                    }

                    connDB.Close();
                }
                if (temperature > 10 && temperature <= 16)
                {
                    SqlConnection connDB = UtilityDB.ConnectDB();
                    SqlCommand cmdGetId = new SqlCommand("SELECT a.title, a.activityId " +
                                                         "FROM Activities a " +
                                                         "JOIN Combinations c on c.activityId = a.activityId " +
                                                         "WHERE temperatureId = 2 " +
                                                         "AND weatherId = 12;", connDB);

                    SqlDataReader reader = cmdGetId.ExecuteReader();


                    while (reader.Read())
                    {
                        a = new activities();
                        a.activityId = Convert.ToInt32(reader["activityId"]);
                        a.title = reader["title"].ToString();
                        listA.Add(a);
                    }

                    connDB.Close();
                }
                if (temperature > 16)
                {
                    SqlConnection connDB = UtilityDB.ConnectDB();
                    SqlCommand cmdGetId = new SqlCommand("SELECT a.title, a.activityId " +
                                                         "FROM Activities a " +
                                                         "JOIN Combinations c on c.activityId = a.activityId " +
                                                         "WHERE temperatureId = 3" +
                                                         "AND weatherId = 12;", connDB);

                    SqlDataReader reader = cmdGetId.ExecuteReader();


                    while (reader.Read())
                    {
                        a = new activities();
                        a.activityId = Convert.ToInt32(reader["activityId"]);
                        a.title = reader["title"].ToString();
                        listA.Add(a);
                    }

                    connDB.Close();
                }

                return listA;
            }


            public void DisplayActivities(ListView lv, List<activities> listA)
            {
                lv.Items.Clear();

                if (listA.Count != 0) // if list has data...
                {
                    // fill listview
                    foreach (WeatherInfo.activities item in listA)
                    {
                        ListViewItem lvItem = new ListViewItem(item.title.ToString());
                        lv.Items.Add(lvItem);
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
