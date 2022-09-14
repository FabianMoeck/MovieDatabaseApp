using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseApp
{
    public partial class AddWindow : Form
    {
        private string _name;
        private int _seasons;
        private int _episodes;
        private int _completed;
        private int _curS;
        private int _curE;
        private decimal _rating;

        private Form prevForm;

        public AddWindow(Form _prevForm)
        {
            InitializeComponent();
            prevForm = _prevForm;
        }

        private void num_Seasons_ValueChanged(object sender, EventArgs e)
        {
            _seasons = (int)num_Seasons.Value;
        }

        private void num_Episodes_ValueChanged(object sender, EventArgs e)
        {
            _episodes = (int)num_Episodes.Value;
        }

        private void ck_Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Completed.Checked)
                _completed = 1;
            else
                _completed = 0;
        }

        private void num_CurrentS_ValueChanged(object sender, EventArgs e)
        {
            _curS = (int)num_CurrentS.Value;
        }

        private void num_CurrentEp_ValueChanged(object sender, EventArgs e)
        {
            _curE = (int)num_CurrentEp.Value;
        }

        private void num_Rating_ValueChanged(object sender, EventArgs e)
        {
            _rating = num_Rating.Value;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            getInputs();

            string connetionString = null;
            connetionString = "server=localhost;database=tv_rating;uid=root;pwd=\"\";";
            MySqlConnection cnn;
            cnn = new MySqlConnection(connetionString);
            try
            {
                MySqlCommand query = cnn.CreateCommand();
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO shows (Name,Seasons,Episodes,Finished,CurSeason,CurEpisode,Rating) VALUES('"+_name+"','"+_seasons+"','"+_episodes+"','"+_completed+"','"+_curS+"','"+_curE+"','"+_rating+"')";

                cnn.Open();
                query.ExecuteNonQuery();
                cnn.Close();

                prevForm.Focus();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void getInputs()
        {
            _seasons = (int)num_Seasons.Value;
            _episodes = (int)num_Episodes.Value;
            if (ck_Completed.Checked)
                _completed = 1;
            else
                _completed = 0;
            _curS = (int)num_CurrentS.Value;
            _curE = (int)num_CurrentEp.Value;
            _rating = num_Rating.Value;

            if (txt_Name.Text != "")
            {
                _name = txt_Name.Text;
            }
            else
            {
                MessageBox.Show("No Name given!");
                return;
            }
        }
    }
}
