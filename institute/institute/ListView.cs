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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
            //create 2 Groups
            listView1.Groups.Add("", "Social Media");

            listView1.Items.Add("Facebook", 0);
            listView1.Items.Add("Twitter", 2);
            listView1.Items.Add(" Google +", 1);

            listView1.Items[0].Group = listView1.Groups[0];
            listView1.Items[1].Group = listView1.Groups[0];
            listView1.Items[2].Group = listView1.Groups[0];


            listView1.Groups.Add("", "buy");
            
            //Add 2 Items to the first group
           

           

            listView1.Items.Add("master card", 3);
            listView1.Items.Add("pay pal",4);


           listView1.Items[3].Group = listView1.Groups[1];
            listView1.Items[4].Group = listView1.Groups[1];

            //Add 2 Items to the secound group
           






           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
