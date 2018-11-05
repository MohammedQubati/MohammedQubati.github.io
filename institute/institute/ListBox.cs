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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void LstBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAddListBox_Click(object sender, EventArgs e)
        {
            LstBox1.Items.Add(textBox1.Text);
        }

        private void RmoveListBox_Click(object sender, EventArgs e)
        {
            LstBox1.Items.RemoveAt(LstBox1.SelectedIndex);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LstBox1.Items.Clear();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
