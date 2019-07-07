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
    public partial class getting_start : Form
    {
        BL.vendors ven = new BL.vendors();
        public getting_start()
        {
            InitializeComponent();
        }

        private void السيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.server_config frm = new server_config();
            frm.txt_server_name.Text = Properties.Settings.Default.Server;
            frm.txt_db.Text = Properties.Settings.Default.DataBase;
            frm.ShowDialog();
        }

        private void عملاءتوريدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.vendors_managment frm = new vendors_managment();
            frm.dataGridView1.DataSource = ven.get_all_vendors();
               
            frm.ShowDialog();
        }
    }
}
