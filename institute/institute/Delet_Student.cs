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
    public partial class Delet_Student : DevComponents.DotNetBar.Office2007Form
    {
        MySqlConnection cn = new MySqlConnection("Data Source=localhost;Initial Catalog=univbase;User ID=root;password=toor;");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Delet_Student()
        {
            InitializeComponent();
        }

        private void Delet_Student_Load(object sender, EventArgs e)
        {
            
           


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("delete from Students where Student_ID=" + txtDel_Stu.Text + "", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Some Errors was occured " + ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }
    }
}
