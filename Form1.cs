using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bảng_cửu_chuog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbskq_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbskq.Items.Clear();
            int cc=Convert.ToInt32(txt1.Text);
            for (int i = 1; i <= 10; i++) ;
                //lbskq.Items.Add(txt1.Text+"x" + i.ToString() + "=" + (cc * i));
        lbskq.Items.Add(String.Format("{0}*{1}={2}"));
        }
    }
}
