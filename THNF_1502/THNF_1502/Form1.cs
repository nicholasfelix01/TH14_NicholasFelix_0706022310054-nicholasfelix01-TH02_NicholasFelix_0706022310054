using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace THNF_1502
{
    public partial class Form1 : Form
    {

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;

        string query;
        DataTable dt = new DataTable();

        bool cb1 = false;
        bool cb2 = false;
        List<string> teamname = new List<string>();
        string prevth;
        string prevta;

        bool dgvkeisi = false;

        string gituteam;
        string gituplayer;
        string gitugo;
        string gitumenit;

        string strnglagiAway;
        string strnglagiHome;
        public Form1()
        {
            InitializeComponent();
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dddd, MMMM dd, yyyy";
            dtp.Value = dtp.MinDate;
            tb_matchid.ReadOnly = true;
            connection = new MySqlConnection("server=localhost;uid=root;password=Uc805911255;database=premier_league");
            dgv.ReadOnly = true;
            DataTable dt2 = new DataTable();
            query = "select team_name from team";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                teamname.Add(dt2.Rows[i][0].ToString());
            }
            foreach (string str in teamname)
            {
                cb_teamhome.Items.Add(str);
                cb_teamaway.Items.Add(str);
            }
        }

        public void updatedgv()
        {
            try
            {
                dgvkeisi = true;
                string kodeteamhome;
                string kodeteamaway;
                DataTable dtmen1 = new DataTable();
                DataTable dtmen2 = new DataTable();
                query = $"select * from team where team_name = '{cb_teamhome.Text}'";
                command = new MySqlCommand(query, connection); adapter = new MySqlDataAdapter(command); adapter.Fill(dtmen1);
                query = $"select * from team where team_name = '{cb_teamaway.Text}'";
                command = new MySqlCommand(query, connection); adapter = new MySqlDataAdapter(command); adapter.Fill(dtmen2);
                kodeteamhome = dtmen1.Rows[0][0].ToString();
                kodeteamaway = dtmen2.Rows[0][0].ToString();
                strnglagiAway = kodeteamaway;
                strnglagiHome = kodeteamhome;
                DataTable whatamidoing = new DataTable();
                query = $"select * from `match` where team_home = '{kodeteamhome}' and team_away = '{kodeteamaway}'";
                command = new MySqlCommand(query, connection); adapter = new MySqlDataAdapter(command); adapter.Fill(whatamidoing);
                string akhirnyaketemuidmatchnya = whatamidoing.Rows[0][0].ToString();
                tb_matchid.Text = akhirnyaketemuidmatchnya;
                try
                {
                    DateTime date = (DateTime)whatamidoing.Rows[0][1];
                    dtp.Value = date;
                    string dada = whatamidoing.Rows[0][1].ToString();
                    string year = dada.Substring(6, 4);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
                DataTable whatamidoingagain = new DataTable();
                query = $"select minute, team.team_name as 'team', player.player_name as 'player', `type` from dmatch join team on team.team_id = dmatch.team_id join player on player.player_id = dmatch.player_id where match_id = '{akhirnyaketemuidmatchnya}' order by minute asc;";
                command = new MySqlCommand(query, connection); adapter = new MySqlDataAdapter(command); adapter.Fill(whatamidoingagain); dgv.DataSource = whatamidoingagain;
                cb_player.Items.Clear();
                cb_team.Items.Clear();
                cb_type.Text = "";
                cb_team.Text = "";
                tb_minute.Text = "";
                cb_team.Items.Add(cb_teamhome.Text);
                cb_team.Items.Add(cb_teamaway.Text);

                gitumenit = null;
                gitugo = null;
                gituplayer = null;
                gituteam = null;
            }
            catch (Exception e)
            {
                MessageBox.Show("No Match Found");
                dgv.DataSource = null;
                dgv.Rows.Clear();
                dgvkeisi = false;
                dtp.Value = DateTime.Now;
                tb_matchid.Text = "";
            }
        }

        private void cb_teamhome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb1 = true;
            if (prevth != null)
            {
                cb_teamaway.Items.Add(prevth);
            }
            cb_teamaway.Items.Remove(cb_teamhome.SelectedItem.ToString());
            prevth = cb_teamhome.SelectedItem.ToString();
            if (cb1 == true && cb2 == true)
            {
                updatedgv();
            }
        }

        private void cb_teamaway_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb2 = true;
            if (prevta != null)
            {
                cb_teamhome.Items.Add(prevta);
            }
            cb_teamhome.Items.Remove(cb_teamaway.SelectedItem.ToString());
            prevta = cb_teamaway.SelectedItem.ToString();
            if (cb1 == true && cb2 == true)
            {
                updatedgv();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgvkeisi)
            {
                try
                {
                    dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select Row Yang Bener");
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (dgvkeisi)
            {
                try
                {
                    if (gitugo != null && gituplayer != null && gituteam != null && gitumenit != null)
                    {
                        connection.Open();
                        query = $"insert into `dmatch` (`match_id`, `minute`, `team_id`, `player_id`, `type`, `delete`) VALUES('{Convert.ToInt32(tb_matchid.Text)}', '{Convert.ToInt32(tb_minute.Text)}', '{gituteam}', '{gituplayer}', '{gitugo}', 0);";
                        command = new MySqlCommand(query, connection);
                        reader = command.ExecuteReader();
                        connection.Close();
                        MessageBox.Show("Item has been added to database");
                        updatedgv();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("isi yang benar");
                }
            }
        }

        private void cb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_player.Items.Clear();
            DataTable whatamidoingagain = new DataTable();
            query = $"select team_id from team where team_name = '{cb_team.Text}';";
            command = new MySqlCommand(query, connection); adapter = new MySqlDataAdapter(command); adapter.Fill(whatamidoingagain);
            string wehstressetapibukankarenaappdevtapikarenahallaine = whatamidoingagain.Rows[0][0].ToString();
            gituteam = wehstressetapibukankarenaappdevtapikarenahallaine;
            DataTable whatamidoing = new DataTable();
            query = $"select player_name from player where team_id = '{wehstressetapibukankarenaappdevtapikarenahallaine}';";
            command = new MySqlCommand(query, connection); adapter = new MySqlDataAdapter(command); adapter.Fill(whatamidoing);
            for (int i = 0; i < whatamidoing.Rows.Count; i++)
            {
                cb_player.Items.Add(whatamidoing.Rows[i][0].ToString());
            }
        }

        private void cb_team_TextChanged(object sender, EventArgs e)
        {
            cb_player.Items.Clear();
            cb_player.Text = "";
        }

        private void tb_minute_TextChanged(object sender, EventArgs e)
        {
            gitumenit = tb_minute.Text;
        }

        private void tb_minute_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tb_minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tb_minute.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_player_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable whatamidoing = new DataTable();
                query = $"select player_id from player where player_name = '{cb_player.Text}';";
                command = new MySqlCommand(query, connection); adapter = new MySqlDataAdapter(command); adapter.Fill(whatamidoing);
                gituplayer = whatamidoing.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gitugo = cb_type.Text;
            }
            catch (Exception ex) { }

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (strnglagiAway != null & strnglagiHome != null)
            {
                if (!dgvkeisi)
                {
                    try
                    {
                        string yes = dtp.Value.ToString("yyyy");
                        int tahaha = 1;
                        DataTable whatamidoing = new DataTable();
                        query = $"select match_date from `match` where year(match_date) = {Convert.ToInt32(yes)}";
                        command = new MySqlCommand(query, connection); adapter = new MySqlDataAdapter(command); adapter.Fill(whatamidoing);
                        tahaha = tahaha + whatamidoing.Rows.Count;
                        if (tahaha < 10)
                        {
                            yes = yes + "00" + tahaha.ToString();
                        }
                        if (tahaha < 100 && tahaha > 9)
                        {
                            yes = yes + "0" + tahaha.ToString();
                        }
                        if (tahaha > 99 && tahaha < 1000)
                        {
                            yes = yes + tahaha.ToString();
                        }
                        string matchid = yes;
                        tb_matchid.Text = matchid;
                        connection.Open();
                        query = $"insert into `match` (`match_id`, `match_date`, `team_home`, `team_away`, `goal_home`, `goal_away`, `referee_id`, `delete`) VALUES('{Convert.ToInt32(matchid)}', '{dtp.Value:yyyy-MM-dd}', '{strnglagiAway}', '{strnglagiHome}', 0, 0, 'M001', 0);";
                        command = new MySqlCommand(query, connection);
                        reader = command.ExecuteReader();
                        connection.Close();
                        MessageBox.Show("Item has been added to database");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }               
            }           
        }
    }
}
