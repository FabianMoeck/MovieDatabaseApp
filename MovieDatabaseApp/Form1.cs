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

namespace MovieDatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connnect_db();
        }

        private void connnect_db()
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=tv_rating;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                loadTable(cnn);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void loadTable(MySqlConnection _cnn)            //first select, simply writing it in text field
        {
            MySqlCommand cmd = _cnn.CreateCommand();
            cmd.CommandText = "SELECT * FROM shows";
            MySqlDataReader reader = cmd.ExecuteReader();
            string result = "";
            while (reader.Read())
            {
                result += reader.GetString(0);
            }
            ConsoleText.Text = result;
        }

        

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string connetionString = null;
        //    MySqlConnection cnn;
        //    connetionString = "server=localhost;database=tv_rating;uid=root;pwd=\"\";";
        //    cnn = new MySqlConnection(connetionString);
        //    try
        //    {
        //        cnn.Open();
        //        MessageBox.Show("Connection Open ! ");
        //        cnn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Can not open connection ! ");
        //    }
        //}
    }
}
