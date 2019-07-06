using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_factory.PL
{
    public partial class server_config : Form
    {

        BL.log_in log_in = new BL.log_in();

        public server_config()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txt_server_name.Text;
            Properties.Settings.Default.DataBase = txt_db.Text;
            Properties.Settings.Default.User_Name = txt_uer_name.Text;
            Properties.Settings.Default.Password = txt_password.Text;
            Properties.Settings.Default.Mode = rb_sql.Checked == true ? "sql" : "windows";
            Properties.Settings.Default.Save();





            dataGridView1.DataSource = log_in.check_con();
            if (Convert.ToInt32(dataGridView1.Rows.Count - 1) == 0)
            {
                MessageBox.Show("Connection Failed", "Error", MessageBoxButtons.OK);
            }

            else
                MessageBox.Show("Connection Done", "Correct", MessageBoxButtons.OK);

        }

        private void rb_sql_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
