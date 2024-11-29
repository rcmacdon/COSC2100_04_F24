using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Demo_w12a_DatabaseCompletion.Properties;
using System.Configuration;

namespace Demo_w12a_DatabaseCompletion
{
    public class Country
    {

        public static List<Country> countries = new List<Country>();

        public String CountryID { get; set; }
        public String CountryName { get; set; }
        public int RegionID { get; set; }

        public Country()
        {
        }

        public Country(String countryID, String countryName, int regionID)
        {
            CountryID = countryID;
            CountryName = countryName;
            RegionID = regionID;
        }


        public static void LoadCountries()
        {
            SqlConnection connection = new SqlConnection(Settings.Default.dbConn);

            try { 
                connection.Open();
                SqlCommand command;
               
                //command = new SqlCommand("SELECT * FROM countries", connection);
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM countries";
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Country country = new Country();
                    country.CountryID = reader.GetString(0);
                    country.CountryName = reader.GetString(1);
                    country.RegionID = reader.GetInt32(2);
                    countries.Add(country);
                }
            } catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
            finally { 
                connection.Close();
            }
        }

        public bool UpdateCountry()
        {
            String sql = "UPDATE countries SET countryName = @countryName, regionID = @regionID WHERE countryID = @countryID";


            SqlConnection connection = new SqlConnection(Settings.Default.dbConn);
            try
            {
                connection.Open();
                SqlCommand command;

                //command = new SqlCommand("SELECT * FROM countries", connection);
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@countryName", this.CountryName);
                command.Parameters.AddWithValue("@regionID", this.RegionID);
                command.Parameters.AddWithValue("@countryID", this.CountryID);

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        }
}
