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

namespace institute
{
    public partial class AddStudent : DevComponents.DotNetBar.Office2007Form
    {
        MySqlConnection cn = new MySqlConnection("Data Source=localhost;Initial Catalog=univbase;User ID=root;password=toor;");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("insert into Students(Dep_ID, Level_ID, Student_ID, Student_name, Student_Age, Student_Sex, Years) values (" + textDep.Text + "," + txtLevl.Text + "," + txtstu.Text + ",'" + txtstuname.Text + "','" + txtstu_age.Text + "','" + txtstu_sex.Text + "','" + txtyear.Text + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Some Errors was occured " + ex.Message);

            }
            finally
            {
                cn.Close();
            }

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
