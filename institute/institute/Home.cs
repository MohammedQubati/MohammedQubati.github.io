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

namespace institute
{
    public partial class Home : DevComponents.DotNetBar.Office2007Form
    {
        Note_Bad n = new Note_Bad();
        public Home()
        {
            InitializeComponent();
            Strip.Text = "Today is :" + DateTime.Now + "   ||                                                                                                                                                                                                                                                                                                                       Computer name is :" + Environment.MachineName;
           
            this.notifyIcon1.Icon = this.Icon;
            this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "الرجاء تحديث البرنانج";
            this.notifyIcon1.BalloonTipTitle = "تحذير التحديث";
            this.notifyIcon1.ShowBalloonTip(12);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
           // st.MdiParent=this;
            st.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void sideBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
           
            Student st = new Student();
           
            st.Show();
        }

        private void navigationPane1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ribbonPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contuct_me contuct = new contuct_me();
            contuct.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            تقييم_النظام قيم = new تقييم_النظام();
            قيم.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progresBar prog = new progresBar();
            prog.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Show();

        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            ListBox Lis = new ListBox();
            Lis.Show();
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            ListView LsV = new ListView();
            LsV.Show();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            Date date = new Date();
            date.Show();
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void حولالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("مرحبا بك في برنامج ام كيو لاداره المعهد");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            Note_Bad Not = new Note_Bad();
            Not.Show();
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
