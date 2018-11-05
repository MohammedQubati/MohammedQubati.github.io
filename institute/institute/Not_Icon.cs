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
    public partial class Not_Icon : Form
    {
        public Not_Icon()
        {
            InitializeComponent();
            this.notifyIcon1.Icon = this.Icon;
            this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "الرجاء تحديث البرنانج";
            this.notifyIcon1.BalloonTipTitle = "تحذير التحديث";
            this.notifyIcon1.ShowBalloonTip(12);


        }

        private void Not_Icon_Load(object sender, EventArgs e)
        {

        }
    }
}
