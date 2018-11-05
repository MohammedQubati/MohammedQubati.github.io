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
    public partial class Update_Stu : DevComponents.DotNetBar.Office2007Form
    {
        MySqlConnection cn = new MySqlConnection("Data Source=localhost;Initial Catalog=univbase;User ID=root;password=toor;");
        MySqlCommand cmd;
        MySqlDataReader dr;
        
        public Update_Stu()
        {
            InitializeComponent();
        }

        private void Update_Stu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("SELECT Dep_ID,Level_ID, Student_name,  Student_Age, Student_Sex, Years FROM Students where Student_ID=" + txtStu_ID.Text + "", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                textDep.Text = dr["Dep_ID"].ToString();
                txtLevl.Text = dr["Level_ID"].ToString();
                txtstuname.Text = dr["Student_name"].ToString();
                txtstu_age.Text = dr["Student_Age"].ToString();
                txtSex.Text = dr["Student_Sex"].ToString();
                txtYear.Text = dr["Years"].ToString();
                dr.Close();
                cn.Close();
                this.Size = new Size(this.Width, 405);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No found Data" + ex.Message);

            }
            finally
            {
                cn.Close();
            }
            





        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("Update Students  set Dep_ID=" + textDep.Text + ",Level_ID=" + txtLevl.Text + ",Student_Name='" + txtstuname.Text + "',Student_Age='" + txtstu_age.Text + "',Student_Sex='" + txtSex.Text + "',Years='" + txtYear.Text + "' where Student_ID="+txtStu_ID.Text+"", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                cn.Close();
            }
            

        }
    }
}
