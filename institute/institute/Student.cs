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
    public partial class Student : DevComponents.DotNetBar.Office2007Form
    {
        MySqlConnection cn = new MySqlConnection("Data Source=localhost;Initial Catalog=univbase;User ID=root;password=toor;");
      //  MySqlCommand cmd;
       // MySqlDataReader dr;
        MySqlDataAdapter Da;
        DataSet Ds=new DataSet();
        public Student()
        {
            InitializeComponent();
            Da = new MySqlDataAdapter("Select * from Students", cn);
            Da.Fill(Ds,"Students");
            dataGridViewX1.DataSource = Ds.Tables["Students"];
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            AddStudent AddSt = new AddStudent();
            AddSt.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Delet_Student del_Stu = new Delet_Student();
            del_Stu.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Update_Stu Update_Stu = new Update_Stu();
            Update_Stu.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
