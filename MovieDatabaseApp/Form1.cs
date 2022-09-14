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
        private string cmdString = "SELECT * FROM shows ORDER BY Name ASC";

        public override bool Focused => base.Focused;

        protected override bool ShowFocusCues => base.ShowFocusCues;

        public Form1()
        {
            InitializeComponent();
            connect_db();
        }

        public void connect_db()
        {
            string connetionString = null;
            connetionString = "server=localhost;database=tv_rating;uid=root;pwd=\"\";";
            MySqlConnection cnn;
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                loadTable(cnn);
                cnn.Close();
            }
            catch (Exception ex)
            {
                ConsoleText.Text = "Can not open connection ! ";
            }
        }

        private void loadTable(MySqlConnection _cnn)            //first select, simply writing it in text field
        {
            MySqlCommand cmd = _cnn.CreateCommand();
            cmd.CommandText = cmdString;
            MySqlDataReader reader = cmd.ExecuteReader();
            string header = "Name\t\t\t\tTotal Seasons\tTotal Episodes\tCompleted\tCurrent Season\tCurrent Episode\tRating";

            MovieList.Items.Clear();

            MovieList.Items.Add(header);
            while (reader.Read())
            {
                MovieList.Items.Add(getFullItem(reader));
            }
        }

        private string getFullItem(MySqlDataReader _reader)
        {
            string item = _reader.GetString(0);                     //name
            int itemLength = item.Length;
            while(itemLength <= 20)
            {
                if (itemLength == 19)
                    break;
                item += "\t";
                itemLength += 5;
            }

            if (!_reader.IsDBNull(1))
                item += "\t"+ _reader.GetInt16(1).ToString().PadLeft(12);      //season total
            item += "\t\t" + _reader.GetInt16(2).ToString().PadLeft(12);         //episodes total
            item += "\t\t" + _reader.GetBoolean(3).ToString().PadLeft(8);       //finished
            if (!_reader.IsDBNull(4) || _reader.GetInt16(4) == 0)
                item += "\t\t" + _reader.GetInt16(4).ToString().PadLeft(10);     //season current
            else
                item += "\t\t-".PadLeft(10);
            if (!_reader.IsDBNull(5) || _reader.GetInt16(5) == 0)
                item += "\t\t" + _reader.GetInt16(5).ToString().PadLeft(10);     //episode current
            else
                item += "\t\t-".PadLeft(10);
            item += "\t" + _reader.GetDecimal(6).ToString().PadLeft(6);       //rating

            return item;
        }

        private void AZradio_CheckedChanged(object sender, EventArgs e)
        {
            cmdString = "SELECT * FROM shows ORDER BY Name ASC";

            connect_db();
        }

        private void Ratingradio_CheckedChanged(object sender, EventArgs e)
        {
            cmdString = "SELECT * FROM shows ORDER BY Rating DESC";

            connect_db();
        }

        private void NewObjectBtn_Click(object sender, EventArgs e)
        {
            AddWindow newAddWindow = new AddWindow(this);
            newAddWindow.Show();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            connect_db();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }
    }
}
