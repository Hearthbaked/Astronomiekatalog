using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Astronomiekatalog
{
    public partial class FormKatalog : Form
    {
        MySqlConnection conn;
        
        public FormKatalog()
        {
            InitializeComponent();
            
            conn = new MySqlConnection("server=localhost;uid=root;password=root;database=astronomiekatalog");
            conn.Open();

             MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from galaxie";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Galaxie g = new Galaxie(reader.GetInt64(0), reader.GetInt32(1),
                reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetFloat(5), reader.GetFloat(6),
                reader.GetFloat(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10));
                listBoxGalaxie.Items.Add(g);
            }
            reader.Close();

        }
        //Übergabe an die Galaxie-Listebox, bitte für Sternsystem und Planet ebenso anlegen
        private void listBoxGalaxie_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from galaxie";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Galaxie g = new Galaxie(reader.GetInt64(0), reader.GetInt32(1),
                reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetFloat(5), reader.GetFloat(6),
                reader.GetFloat(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10));
                listBoxGalaxie.Items.Add(g);
            }
            reader.Close();
        }

        //Hier Sternsystem Übergabe

        //Hier Planet Übergabe

        //SyndicationFeed und Feedreader hier einfügen

        private void buttonWechselDich_Click(object sender, EventArgs e)
        {

        }
    }
}
