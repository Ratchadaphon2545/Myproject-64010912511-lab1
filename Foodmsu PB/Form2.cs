using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string Drink = "เครื่องดื่ม";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string Food = "อาหาร";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
