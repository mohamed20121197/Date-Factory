using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Date_factory.PL
{
    public partial class add_vendor : Form
    {
        BL.vendors ven = new BL.vendors();
        public add_vendor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //صوره المنتج

            MemoryStream ms = new MemoryStream();
            ven_pic.Image.Save(ms, ven_pic.Image.RawFormat);
            byte[] byteimage = ms.ToArray();

            ven.add_vendor(text_VendorName.Text, text_VendorNumber.Text, text_VendorAddress.Text, Convert.ToDouble(text_last_money.Text),
                Convert.ToDouble(text_credit_limit.Text), combo_type.Text, text_Notes.Text, byteimage);

        }
    }
}
