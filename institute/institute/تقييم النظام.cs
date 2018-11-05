using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace institute
{
    public partial class تقييم_النظام : Form
    {
        public تقييم_النظام()
        {
            InitializeComponent();
            comboBox1.Items.Add("Sana'a");
            comboBox1.Items.Add("Taiz");
            comboBox1.Items.Add("Hodida");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkVGood.Checked == true && chkGood.Checked == false)
            {
                MessageBox.Show("لقد كان تقييمك لنا جيد جدا : شكرا لك " + comboBox1.Text, "message");
                this.Close();
            }
            if (chkVGood.Checked == false && chkGood.Checked == true)
            {
                MessageBox.Show("لقد كان تقييمك لنا جيد  : شكرا لك " + comboBox1.Text, "message");
                this.Close();
            }
            if (chkVGood.Checked == false && chkGood.Checked == false)
            {
                MessageBox.Show("لم تختار اي شيئ الرجاء اعاده التقييم البلد " + comboBox1.Text, "message");
              
            }
            if (chkVGood.Checked == true && chkGood.Checked == true)
            {
                MessageBox.Show("الرجاء اختيار واحد فقط ", "message");

            }
        }

        private void تقييم_النظام_Load(object sender, EventArgs e)
        {

        }
    }
}
