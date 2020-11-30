using baps_mobiel.Droid;
using bapsMobiel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace baps_mobiel
{
    public partial class MainPage : ContentPage
    {
        private static List<Room> kamers = new List<Room>();
        public string database = "server=localhost;user id=root;password=secret;database=MyDB;";


        public MainPage()
        {
            InitializeComponent();
        }

        private void database_connection()
        {
            MySqlConnection databaseConnection = new MySqlConnection(database);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            MySqlDataReader Reader;
            commandDatabase.CommandText = "SELECT * FROM tbl_ruimtes";
            databaseConnection.Open();
            Reader = commandDatabase.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + ",";

                kamers.Add(new Room(
                    Reader.GetString("id"),
                    Reader.GetString("naam"),
                    Reader.GetString("licht"),
                    Reader.GetString("temperatuur"),
                    Reader.GetString("gordijnen"),
                    Reader.GetString("waterniveau_bad"),
                    Reader.GetString("deur")
                ));
            }
            databaseConnection.Close();
        }
    }
}
