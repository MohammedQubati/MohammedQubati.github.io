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
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
            treeView1.Nodes.Add("Users");
            
            treeView1.Nodes[0].Nodes.Add("Mohammed");
            treeView1.Nodes[0].Nodes.Add("Ali");
            treeView1.Nodes[0].Nodes.Add("Fatma");

            treeView1.Nodes.Add("programs");
            treeView1.Nodes[1].Nodes.Add("C#");
            treeView1.Nodes[1].Nodes.Add("php");
            treeView1.Nodes[1].Nodes.Add("c++");
            


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
