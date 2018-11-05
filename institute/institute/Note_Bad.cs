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
    public partial class Note_Bad : Form
    {
        public Note_Bad()
        {
            InitializeComponent();
        }

        private void حفظالملفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files | *.TXT";
            saveFileDialog1.InitialDirectory = "C:\\";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,richTextBox1.Text);
                MessageBox.Show("تم الحفظ بنجاح", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
